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
        public Guid UserId { get; set; }

        [Required]
        public string DrinkName { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}