using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipsy.Data;

namespace Tipsy.Models.PaymentModels
{
    class PaymentDetail
    {
        [Key]
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public PayType PaymentType { get; set; }
    }
}
