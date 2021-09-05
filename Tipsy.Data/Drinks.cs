using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsy.Data
{
    class Drinks
    {
        [Key]
        public int DrinkId { get; set; }
        public string DrinkName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public List<T> Ingredients { get; set; }
    }
}
