using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_V1
{
    public class Dikdörtgen:Sekil
    {

        public Dikdörtgen(double x,double y):base(x)// burdaki x temel sınıfa gönderiliyor.
        {
           // this.X = x;
            this.Y = y;
        }
        //public Dikdörtgen()
        //{

        //}
        public double Y { get; set; }

        //override ile temel sınıftaki metotların kalıtımı alınarak kendi sistemimize uygun kendi değişken ve işlemlerimizi tanımlayabileceğimiz yapıyı sunar. AlanHesapla metodunu aldık dikdörtgene uygun olarak tekrar yazabildik.
        public override double AlanHesapla()
        {
            //return base.AlanHesapla();// base diyince kalıtım aldığı sınıftaki değişkenler
            return X * Y;

        }

        public override double CevreHesapla()
        {
            return 2 * (X + Y);
        }

        public override double KosegenHesapla()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }

    }
}
