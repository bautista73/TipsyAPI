using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipsy.Models;
using Tipsy.Models.PaymentModels;
using Tipsy.Data;

namespace Tipsy.Services
{
    public class PaymentService
    {
        private readonly Guid _userId;

        public PaymentService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreatePayment(PaymentCreate model)
        {
            var entity =
                new Payment()
                {
                    UserId = _userId,
                    PaymentDate = model.PaymentDate,
                    Amount = model.Amount,
                    PaymentType = model.PaymentType,
                    CreatedUtc = DateTimeOffset.Now
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Payments.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<PaymentListItem> GetPayments()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Payments
                        .Where(e => e.UserId == _userId)
                        .Select(
                            e =>
                                new PaymentListItem
                                {
                                    PaymentId = e.PaymentId,
                                    OrderId = e.OrderId,
                                    CreatedUtc = e.CreatedUtc,
                                    Amount = e.Amount,
                                    PaymentDate = e.PaymentDate,
                                    UserId = e.UserId
                                }
                        );
                return query.ToArray();
            }
        }

        public PaymentDetail GetPaymentById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Payments
                        .Single(e => e.PaymentId == id);
                return
                    new PaymentDetail
                    {
                        PaymentId = entity.PaymentId,
                        OrderId = entity.OrderId,
                        PaymentDate = entity.PaymentDate,
                        Amount = entity.Amount,
                        PaymentType = entity.PaymentType,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }

        public bool UpdatePayment(PaymentEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Payments
                        .Single(e => e.PaymentId == model.PaymentId);

                            entity.PaymentId = model.PaymentId;
                            entity.Amount = model.Amount;
                            entity.PaymentType = model.PaymentType;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeletePayment(int paymentId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Payments
                        .Single(e => e.PaymentId == paymentId);
                ctx.Payments.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
