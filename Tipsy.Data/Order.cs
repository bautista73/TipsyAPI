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
        [Required]
        public string UserFullName { get; set; }
        [Required]
        public int DrinkId { get; set; }
        [Required]
        public string DrinkName { get; set; }
        [Required]
        public decimal OrderSubTotal { get; set; }
        [Required]
        public decimal OrderTotal { get; set; }
        [Required]
        public bool IsComplete { get; set; }
        [Required]
        public string OrderNotes { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
