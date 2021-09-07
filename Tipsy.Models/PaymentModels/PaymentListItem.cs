using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsy.Models.PaymentModels
{
    class PaymentListItem
    {
        public int PaymentId { get; set; }
        public int  OrderId { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
