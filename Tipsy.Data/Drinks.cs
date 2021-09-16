using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsy.Data
{
    public class Drinks
    {
        [Key]
        public int DrinkId { get; set; }
        [Required]
        public string DrinkName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public List<string> Ingredients { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }

        //Foreign key
        [Display(Name = "Order")]
        public virtual int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
    }
}