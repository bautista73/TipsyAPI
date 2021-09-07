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
        public string UserFullName { get; set; }
        public int DrinkId { get; set; }
        public string DrinkName { get; set; }
        public decimal OrderSubTotal { get; set; }
        public decimal OrderTax { get; set; }
        public decimal OrderTotal { get; set; }
        public bool IsComplete { get; set; }
        public string OrderNotes { get; set; }
        [Display(Name="CreatedOnDate")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
