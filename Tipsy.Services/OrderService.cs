using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipsy.Data;
using Tipsy.Models;

namespace Tipsy.Services
{
    public class OrderService
    {
        private readonly Guid _userId;

        public OrderService(Guid userId)
        {
            _userId = userId;
        }

        //Create Method
        public bool CreateOrder(OrderCreate model)
        {
            var entity =
                new Order()
                {
                    UserId = _userId,
                    Quantity = model.Quantity,
                    Drinks = model.Drinks,
                    OrderUtc = DateTimeOffset.Now,
                    PaymentId = model.PaymentId
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Orders.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //Read Method
        public IEnumerable<OrderListItem> GetOrders()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Orders
                        .Where(e => e.UserId == _userId)
                        .Select(
                            e =>
                                new OrderListItem
                                {
                                    OrderId = e.OrderId,
                                    UserId = e.UserId,
                                    OrderUtc = e.OrderUtc,
                                    Quantity = e.Quantity,
                                    Drinks = e.Drinks,
                                    PaymentId = e.PaymentId
                                }
                                );
                return query.ToArray();
            }
        }

        public OrderDetail GetOrderById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Orders
                        .Single(e => e.OrderId == id && e.UserId == _userId);
                return
                    new OrderDetail
                    {
                        OrderId = entity.OrderId,
                        UserId = entity.UserId,
                        OrderUtc = entity.OrderUtc,
                        Quantity = entity.Quantity,
                        PaymentId = entity.PaymentId,
                        Drinks = entity.Drinks
                    };
            }
        }

        public bool UpdateOrder(OrderEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Orders
                        .Single(e => e.OrderId == model.OrderId && e.UserId == _userId);

                entity.Quantity = model.Quantity;
                entity.Drinks = model.Drinks;
                entity.OrderId = model.OrderId;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteOrder(int orderId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Orders
                        .Single(e => e.OrderId == orderId && e.UserId == _userId);

                ctx.Orders.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
