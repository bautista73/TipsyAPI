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
                    IsComplete = model.IsComplete,
                    OrderNotes = model.OrderNotes,
                    OrderUtc = DateTimeOffset.Now
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
                                    OrderUtc = e.OrderUtc
                                }
                                );
                return query.ToArray();
            }
        }
    }
}
