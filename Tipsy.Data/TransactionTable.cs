using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsy.Data
{
   public class TransactionTable
    {
        public int TransactionId { get; set; }

        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }

        [ForeignKey(nameof(Payment))]
        public int PaymentId { get; set; }
    }
}
