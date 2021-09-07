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
    class PaymentService
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
                    OrderId = _userId,
                    PaymentDate = model.PaymentDate,
                    Amount = model.Amount,
                    PaymentType = model.PaymentType
                };
        }
    }
}
