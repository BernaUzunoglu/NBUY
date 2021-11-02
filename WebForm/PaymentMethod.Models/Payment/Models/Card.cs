using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod.Models.Payment.Models
{
    public class Card
    {
        public string Number { get; set; }
        public string NameSurname { get; set; }
        public int Mount { get; set; }
        public int Year { get; set; }
        public string CVC { get; set; }

    }
}
