using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsy.Models
{
    public class OrderEdit
    {
        public int Quantity { get; set; }
        public int DrinkId { get; set; }
        public int OrderId { get; set; }
    }
}
