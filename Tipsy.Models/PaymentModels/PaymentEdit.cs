using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipsy.Data;

namespace Tipsy.Models.PaymentModels
{
    public class PaymentEdit
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public PayType PaymentType { get; set; }
    }
}
