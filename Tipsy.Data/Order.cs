using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsy.Data
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        // Add a list of drinks
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int PaymentId { get; set; }
        [Required]
        public bool IsComplete { get; set; }
        [Required]
        public string OrderNotes { get; set; }
        [Required]
        public DateTimeOffset OrderUtc { get; set; }
    }
}
