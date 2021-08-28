using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsy.Models
{
    public class OrderCreate
    {
        [Required]
        public bool IsComplete { get; set; }
        [MaxLength(250)]
        public string OrderNotes { get; set; }
    }
}
