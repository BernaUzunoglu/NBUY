using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_V1
{
    public class DikUcgen:Dikdörtgen
    {

        public DikUcgen(double x, double y):base(x,y)
        {

        }

        public override double AlanHesapla()
        {
            return base.AlanHesapla()/2;
        }
        public override double CevreHesapla()
        {
            //return X + Y + base.KosegenHesapla();
            return base.CevreHesapla() / 2 + base.KosegenHesapla();
        }
        public override string ToString()
        {
            return "Dİk Üçgenin : " + AlanHesapla() + "br²";
        }
    }
}
