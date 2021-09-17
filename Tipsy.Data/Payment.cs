using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsy.Data
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
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

    public enum PayType { Cash, Credit, Debit }
}
