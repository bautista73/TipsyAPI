using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsy.Models.PaymentModels
{
    public class PaymentListItem
    {
        [Required]
        public int PaymentId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public float Amount { get; set; }

        
        public DateTimeOffset PaymentDate { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}

