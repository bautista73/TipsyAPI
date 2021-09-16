using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipsy.Data;

namespace Tipsy.Models
{
    public class OrderCreate
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int DrinkId { get; set; }
    }
}
