using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_V1
{
    //Sınıfları absrtact yaparak kalıtıma izin veriyoruz.Fakat new ile nesne üretilmesine engel oluyoruz.
    public abstract class Sekil// Base class- Ana  class-Temel class
    {
        public Sekil(double x)
        {
            this.X = x;
        }

        private double _x;
        
        public double X // Bu property i farklı bir yerde farklı bir şekilde kullanmak istiyorsak virtual tanımlayabiliriz.
        {
            get { return _x; }
            set 
            {
                if (value <= 0)
                    throw new Exception("X 0'dan büyük olmalıdır.");
                _x = value;
            }
        }

        // Virtual tanımladık ki kullanıcılar override ile sistemelerine uygun şekilde kullanabilsinler
        //public virtual double AlanHesapla()
        //{
        //    return X * X;
        //}

        public abstract double AlanHesapla();
        //Yukardaki metodu abstract tanımladığımız için kalıtım alınan bütün sınıflarda bu metod kesinlikle yazılmalıdır.

        public virtual double CevreHesapla()
        {
            return 4 * X;
        }

        public virtual double KosegenHesapla()
        {
            return Math.Sqrt(2) * X;
        }
    }
}
