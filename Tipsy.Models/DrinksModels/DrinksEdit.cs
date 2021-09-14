using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsy.Models.DrinkModels
{
    public class DrinksEdit
    {
        public int DrinkId { get; set; }
        public string DrinkName { get; set; }
        public decimal Price { get; set; }
        public List<string> Ingredients { get; set; }
    }
}
