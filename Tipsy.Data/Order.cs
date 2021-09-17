using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsy.Data
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int Quantity { get; set; }
        
        [Required]
        public DateTimeOffset OrderUtc { get; set; }

        [Display(Name = "Drinks")]
        public virtual int DrinkId { get; set; }
    }
}