using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsy.Data
{
    public enum UserStatus
    {
        Working,
        Off,
        Break
    }
    class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastaName { get; set; }
        [Required]
        public string Password { get; set; }
        public UserStatus Status { get; set; }
    }
}
