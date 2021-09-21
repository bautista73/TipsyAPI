using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsy.Models.DrinkModels
{
    public class DrinksEdit
    {
        [Required]
        public int DrinkId { get; set; }
        [Required]
        public string DrinkName { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
