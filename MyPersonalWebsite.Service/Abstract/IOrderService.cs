using MyPersonalWebsite.Data.Entities;
using MyPersonalWebsite.Models.FilterModels;
using MyPersonalWebsite.Models.RequestModels;
using MyPersonalWebsite.Models.ResponseModels;
using MyPersonalWebsite.Models.ViewModels;
using MyPersonalWebsite.Service.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Service.Abstract
{
    public interface IOrderService
    {
        ServiceResult<List<OrderCreateResponseModel>> CreateOrder(List<CustomerOrderRequestModel> requestOrders);
        ServiceResult<bool> UpdateOrderStatus(OrderStatusUpdateRequestModel orderStatusUpdateRequestModel);
        ServiceResult<OrderCreateResponseModel> UpdateOrder(CustomerOrderRequestModel order);
        ServiceResult<bool> DeleteOrder(int id);
        ServiceResult<List<OrderListResponseModel>> ListOrders(OrderFilterModel filterModel);
        ServiceResult<List<OrderStatusResponseModel>> ListOrderStatuses();

    }
}
