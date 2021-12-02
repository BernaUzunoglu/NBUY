using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using North_DbSet.Models;

namespace North_DbSet.Models
{
    public partial class Product// aynı isim ve namespace sahip class tanımladık. Partiial class olması bize bu olanağı sağlamaktadır.
    {
        public override string ToString()
        {
            //return ProductName;
            return $"{ProductName}- {UnitPrice:c2}";
        }
    }
}
