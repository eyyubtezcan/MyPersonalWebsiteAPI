using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using MyPersonalWebsite.Data;
using MyPersonalWebsite.Data.Entities;
using MyPersonalWebsite.Models.RequestModels;
using MyPersonalWebsite.Models.ResponseModels;
using MyPersonalWebsite.Service.Abstract;
using MyPersonalWebsite.Service.Concreate;

namespace MyPersonalWebsite.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        //Sipariş Oluşturma
        [HttpPost("CreateOrder")]
        public ActionResult<List<OrderCreateResponseModel>> CreateOrder(List<CustomerOrderRequestModel> orders)
        {
            var res= _orderService.CreateOrder(orders);
            if(res.isOk)
                return Ok(res.Result);
            else return BadRequest(res);
        }
        [HttpPost("ListOrders")]
        public ActionResult<OrderListResponseModel> ListOrders(OrderFilterModel filterModel)
        {
                var orders = _orderService.ListOrders(filterModel).Result;
            if (orders == null)
            {
                return NotFound();
            }
            var response = orders.ToList();
            return Ok(response);
        }
        [HttpGet("ListOrderStatuses")]
        public ActionResult<OrderStatusResponseModel> ListOrderStatuses()
        {
            var orders = _orderService.ListOrderStatuses().Result;
            if (orders == null)
            {
                return NotFound();
            }
            var response = orders.ToList();
            return Ok(response);
        }
        [HttpPut("UpdateOrderStatus")]
        public  ActionResult UpdateOrderStatus(OrderStatusUpdateRequestModel orderStatusUpdateRequestModel)
        {

            var res = _orderService.UpdateOrderStatus(orderStatusUpdateRequestModel).Result;
            if (res)
            {
                return Ok();                
            }
            else
            {
                return NotFound();
            }
           
        }


        [HttpPut("UpdateOrder/{orderNumber}")]
        public ActionResult UpdateOrder(int orderNumber, Order order)
        {
            //var existingOrder = _context.Orders.FirstOrDefault(o => o.OrderNumber == orderNumber);
            //if (existingOrder == null)
            //{
            //    return NotFound();
            //}
            //existingOrder.Status = order.Status;
            //_context.SaveChanges();
            //return Ok(existingOrder);
            return Ok();
        }

        [HttpDelete("DeleteOrder/{orderNumber}")]
        public IActionResult DeleteOrder(int orderNumber)
        {
            //var existingOrder = _context.Orders.FirstOrDefault(o => o.OrderNumber == orderNumber);
            //if (existingOrder == null)
            //{
            //    return NotFound();
            //}
            //_context.Orders.Remove(existingOrder);
            //_context.SaveChanges();
            //return Ok(existingOrder);
            return Ok();
        }
    }
}

