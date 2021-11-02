using PaymentMethod.Models.Payment.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod.Models.Payment.Models
{
    public class DebitPayment:PaymentBase
    {
        public decimal Commission { get; set; }
        public Card CardInfo { get; set; }
    }
}
