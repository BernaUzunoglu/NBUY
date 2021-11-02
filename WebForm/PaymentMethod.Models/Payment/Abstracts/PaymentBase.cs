using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod.Models.Payment.Abstracts
{
    public abstract class PaymentBase
    {
        public string CustomerId { get; set; }
        public decimal Total { get; set; }
        public decimal TaxAmount { get; set; }
        public DateTime PaymentDate { get;} = DateTime.Now;// Oto property 

    }
}
