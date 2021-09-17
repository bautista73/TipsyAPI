using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsy.Models
{
    public class OrderEdit
    {
        public Guid OrderId { get; set; }
        public int Quantity { get; set; }
        public int DrinkId { get; set; }
    }
}
