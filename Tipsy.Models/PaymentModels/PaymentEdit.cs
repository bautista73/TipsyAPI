using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipsy.Data;

namespace Tipsy.Models.PaymentModels
{
    public class PaymentEdit
    {
        [Required]
        public int PaymentId { get; set; }
        [Required]
        public float Amount { get; set; }
        [Required]
        public PayType PaymentType { get; set; }
    }
}
