using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsy.Models
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        [Display(Name = "Created")]
        public DateTimeOffset OrderUtc { get; set; }
        public Guid UserId { get; set; }
        public int Quantity { get; set; }
        public List<string> Drinks { get; set; }
        public int PaymentId { get; set; }
    }
}
