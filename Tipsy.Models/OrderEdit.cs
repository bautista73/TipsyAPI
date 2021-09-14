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
        public List<string> Drinks { get; set; }
    }
}
