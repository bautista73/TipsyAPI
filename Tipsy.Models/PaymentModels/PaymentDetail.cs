using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipsy.Data;

namespace Tipsy.Models.PaymentModels
{
    public class PaymentDetail
    {
        [Required]
        public int PaymentId { get; set; }
        [Required]
        public Guid OrderId { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; }
        [Required]
        public float Amount { get; set; }
        [Required]
        public PayType PaymentType { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
