using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_V1
{
    public class Kare : Sekil
    {
        //public double X { get; set; } Kalıtım ile berbaber geliyor

        //public Kare()
        //{

        //}


        //KAlıtım aldığımız için temel sınıftaki kurucu metodun x değerine base ile ulaşabildik.
        public Kare(double x):base(x)
        {
            //this.X = x;
        }

        public override double AlanHesapla()
        {
            return X * X;
        }
    }
}
