using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public Guid OwnerId { get; set; }
        [Required]
        public string DrinkName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public List<string> Ingredients { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
