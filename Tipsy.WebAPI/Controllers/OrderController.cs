using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tipsy.Models;
using Tipsy.Services;

namespace Tipsy.WebAPI.Controllers
{
    [Authorize]
    public class OrderController : ApiController
    {
        private OrderService CreateOrderService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var orderService = new OrderService(userId);
            return orderService;
        }

        public IHttpActionResult Post(OrderCreate order)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateOrderService();

            if (!service.CreateOrder(order))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Get()
        {
            OrderService orderService = CreateOrderService();
            var orders = orderService.GetOrders();
            return Ok(orders);
        }

        public IHttpActionResult Get(int id)
        {
            OrderService orderService = CreateOrderService();
            var order = orderService.GetOrderById(id);
            return Ok(order);
        }

        public IHttpActionResult Put(OrderEdit order)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateOrderService();
            if (!service.UpdateOrder(order))
                return InternalServerError();
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateOrderService();

            if (!service.DeleteOrder(id))
                return InternalServerError();

            return Ok();
        }
    }
}
