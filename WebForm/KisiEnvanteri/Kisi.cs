using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiEnvanteri
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public DateTime DogumTarihi { get; set; }
        public byte[] Fotograf { get; set; }

        public override string ToString() => $"{Ad} {Soyad}";
        
    }
}
