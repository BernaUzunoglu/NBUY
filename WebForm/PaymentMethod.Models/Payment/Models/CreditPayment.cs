using PaymentMethod.Models.Payment.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod.Models.Payment.Models
{
    public class CreditPayment:PaymentBase
    {
        public int  Inatallement { get; set; }
        public decimal Comission { get; set; }
        public Card CardInfo { get; set; }

    }
}
