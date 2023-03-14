using Microsoft.EntityFrameworkCore;
using MyPersonalWebsite.Data;
using MyPersonalWebsite.Data.Entities;
using MyPersonalWebsite.Models.FilterModels;
using MyPersonalWebsite.Models.RequestModels;
using MyPersonalWebsite.Models.ResponseModels;
using MyPersonalWebsite.Models.ViewModels;
using MyPersonalWebsite.Repository.Abstract;
using MyPersonalWebsite.Repository.Concreate;
using MyPersonalWebsite.Service.Abstract;
using MyPersonalWebsite.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using MyPersonalWebsite.Models.Enums;

namespace MyPersonalWebsite.Service.Concreate
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;
        private readonly IRepository<MaterialInformation> _materialRepository;
        private readonly IRepository<OrderStatus> _orderstatusRepository;

        public OrderService(IOrderRepository repository,
                            IRepository<MaterialInformation> materialRepository,
                            IRepository<OrderStatus> orderstatusRepository)
        {
            _repository = repository;
            _materialRepository = materialRepository;
            _orderstatusRepository = orderstatusRepository;
        }

        public ServiceResult<List<OrderCreateResponseModel>> CreateOrder(List<CustomerOrderRequestModel> requestOrders)
        {
            ServiceResult<List<OrderCreateResponseModel>> res = new ServiceResult<List<OrderCreateResponseModel>>();

            List<OrderCreateResponseModel> resList = new List<OrderCreateResponseModel>();

            requestOrders.ForEach(o =>
            {
                OrderCreateResponseModel requestData = new OrderCreateResponseModel();

                var isExists = _repository.GetAllQueryableAsync().FirstOrDefaultAsync(a => a.CustomerOrderNo == o.CustomerOrderNo).Result;
                if (isExists is null)
                {
                    var hasMaterialData = _materialRepository.GetAllQueryableAsync().FirstOrDefaultAsync(x => x.Code == o.MaterialCode && x.Name == o.MaterialName).Result;
                    var materialId = hasMaterialData?.Id??0;
                    if (hasMaterialData is null)
                    {
                        var material = new MaterialInformation() { Code = o.MaterialCode, Name = o.MaterialName, Description="" };
                        _materialRepository.AddAsync(material);
                       _materialRepository.SaveChanges();
                        materialId = material.Id;
                    }
                    

                       
                        var orderData = new Order()
                        {
                            CustomerOrderNo = o.CustomerOrderNo,
                            FromAddress = o.FromAddress,
                            ToAddress = o.FromAddress,
                            Quantity = o.Quantity,
                            QuantityUnit = o.QuantityUnit,
                            Weight = o.Weight,
                            WeightUnit = o.WeightUnit,
                            Note = o.Note,
                            StatusId = (int)OrderStatusEnums.OrderReceived,
                            MaterialId = materialId,
                            //MaterialCode = o.MaterialCode,
                            //MaterialName = o.MaterialName
                        };

                        if (_repository.AddAsync(orderData).IsCompleted)
                        {
                            requestData.CustomerOrderNumber = o.CustomerOrderNo;
                            requestData.Status = false;
                            requestData.ErrorDescription = "";
                        }
                        else
                        {
                            requestData.CustomerOrderNumber = o.CustomerOrderNo;
                            requestData.Status = true;
                            requestData.ErrorDescription = "Siparişin sisteme kayıt edilmesinde bilinmeyen bir sorun ile karşılaşıldı.";
                        }
                    
                }
                else
                {
                    requestData.CustomerOrderNumber = o.CustomerOrderNo;
                    requestData.SystemOrderNumber = isExists.Id;
                    requestData.Status = true;
                    requestData.ErrorDescription = "Bu sipariş daha önceden sisteme gönderildiğinden, tekrar göndermeniz mümkün değil!";
                }
                resList.Add(requestData);

            });
            _repository.SaveChanges();
            res.Ok();
            res.Result = resList;
            return res;
        }

        public ServiceResult<bool> DeleteOrder(int id)
        {
            ServiceResult<bool> res = new ServiceResult<bool>();

            var order = _repository.GetByIdAsync(id).Result;
            _repository.Remove(order);
            res.Result = true;
            res.Ok();

            return res;
        }

        public ServiceResult<List<OrderListResponseModel>> ListOrders(OrderFilterModel filterModel)
        {
            ServiceResult<List<OrderListResponseModel>> res = new ServiceResult<List<OrderListResponseModel>>();

            List<OrderListResponseModel> orderList = new List<OrderListResponseModel>();

            var orderquery = _repository.GetAllQueryableAsync();

            if (filterModel.CustomerOrderNo != null)
            {
                orderquery.Where(x => x.CustomerOrderNo == filterModel.CustomerOrderNo);
            }
            if (filterModel.StartDate != null)
            {
                orderquery = orderquery.Where(o => o.CreatedDate >= filterModel.StartDate);
            }
            if (filterModel.EndDate != null)
            {
                orderquery = orderquery.Where(o => o.CreatedDate <= filterModel.EndDate);
            }
            

            var query = from order in orderquery
                        join status in _orderstatusRepository.GetAllQueryableAsync() on order.StatusId equals status.Id
                        join material in _materialRepository.GetAllQueryableAsync() on order.MaterialId equals material.Id
                       
                        select new OrderListResponseModel()
                        {
                            CustomerOrderNo = order.CustomerOrderNo,
                            FromAddress = order.FromAddress,
                            ToAddress = order.FromAddress,
                            Quantity = order.Quantity,
                            QuantityUnit = order.QuantityUnit,
                            Weight = order.Weight,
                            WeightUnit = order.WeightUnit,
                            Note = order.Note,
                            StatusId = order.StatusId,
                            StatusDesc = status.Description,
                            MaterialId = order.MaterialId,
                            MaterialCode = material.Code,
                            MaterialName = material.Name

                        };

            orderList = query.ToListAsync().Result;
            
            res.Result = orderList;
            res.Ok();

            return res;
        }
        public ServiceResult<bool> UpdateOrderStatus(OrderStatusUpdateRequestModel orderStatusUpdateRequestModel)
        {
            ServiceResult<bool> res = new ServiceResult<bool>();

            OrderCreateResponseModel orderList = new OrderCreateResponseModel();



            var existingOrder = _repository.GetAllQueryableAsync().FirstOrDefaultAsync(o => o.CustomerOrderNo == orderStatusUpdateRequestModel.CustomerOrderNo).Result;

            if (existingOrder != null)
            {
                existingOrder.StatusId = orderStatusUpdateRequestModel.StatusId;
                existingOrder.UpdatedDate = DateTime.Now;

                _repository.Update(existingOrder);
                _repository.SaveChanges();
                res.Ok();
                res.Result = true;
            }
            else{
                res.Fail();
                res.Result = false;
            }

            
            return res;
        }
        public ServiceResult<OrderCreateResponseModel> UpdateOrder(CustomerOrderRequestModel order)
        {
            ServiceResult<OrderCreateResponseModel> res = new ServiceResult<OrderCreateResponseModel>();

            OrderCreateResponseModel orderList = new OrderCreateResponseModel();


            //var existingOrder = _repository.GetAllQueryableAsync().FirstOrDefault(o => o.OrderNumber == order.OrderNumber);
            //if (existingOrder == null)
            //{
            //    existingOrder.OrderNumber = order.OrderNumber;
            //    existingOrder.FromAddress = order.FromAddress;
            //    existingOrder.MaterialId = order.MaterialId;
            //    existingOrder.Quantity = order.Quantity;
            //    existingOrder.QuantityUnit = order.QuantityUnit;
            //    existingOrder.StatusId = order.StatusId;
            //    existingOrder.ToAddress = order.ToAddress;
            //    existingOrder.Weight = order.Weight;
            //    existingOrder.WeightUnit = order.WeightUnit;
            //    existingOrder.Note = order.Note;
            //    existingOrder.Status = order.Status;

            //}

            //_repository.Update(existingOrder);
            res.Ok();
            res.Result = orderList;
            return res;
        }

        public ServiceResult<List<OrderStatusResponseModel>> ListOrderStatuses()
        {
            ServiceResult<List<OrderStatusResponseModel>> res = new ServiceResult<List<OrderStatusResponseModel>>();
            List<OrderStatusResponseModel> statusList = new List<OrderStatusResponseModel>();

            var query = from order in _orderstatusRepository.GetAllQueryableAsync()
                        select new OrderStatusResponseModel()
                        {
                            Code = order.Code,
                            Description = order.Description,
                            Id = order.Id,
                            Name = order.Name
                        };

            statusList = query.ToListAsync().Result;
           
            res.Result = statusList;
            res.Ok();
            return res;

        }
    }
}
