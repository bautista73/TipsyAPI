using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipsy.Data;

namespace Tipsy.Models.PaymentModels
{
    public class PaymentCreate
    {
        [Required]
        public int OrderId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        
        public DateTimeOffset PaymentDate { get; set; }

        
        public float Amount { get; set; }

        [Required]
        [Range(1, 3)]
        public PayType PaymentType { get; set; }
    }
}
