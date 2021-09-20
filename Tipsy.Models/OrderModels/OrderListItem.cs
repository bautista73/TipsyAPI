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
        public int Quantity { get; set; }
        public int DrinkId { get; set; }
        public DateTimeOffset OrderUtc { get; set; }
    }
}
