using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsy.Models
{
    public class OrderListItem
    {
        public int OrderId { get; set; }
        public Guid UserId { get; set; }
        // Add a list of drinks
        public int Quantity { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
        public bool IsComplete { get; set; }
        public string OrderNotes { get; set; }
        [Display(Name="CreatedOnDate")]
        public DateTimeOffset OrderUtc { get; set; }
    }
}
