using System;

namespace MetotKullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref ve out
            /*
             Ref kullanırken varsayılan değer ataması zorunludur, Out için bu zorunluluk yoktur.
             Metot’a out anahtar sözcüğü ile geçilen değişkenin aynı metot içinde değer ataması yapılması zorunlu iken, 
            Ref için böyle bir zorunluluk yoktur.

            /// Değer türleri 
             */

            int a = 5;
            RefMetod(ref a);// ref ile a nın adresini gönderdi
            Console.WriteLine(a);

            if(DonusturmeyiDene("123",out int cevap))
            {
                Console.WriteLine(cevap);
            }
            Tuple<bool, int> tuple = DonusturmeyiDene("32423");
            if (tuple.Item1)
            {
                Console.WriteLine(tuple.Item2);
            }


        }
        static Tuple<bool,int> DonusturmeyiDene(string ifade)
        {
            try
            {
                int sonuc = int.Parse(ifade);
                return new Tuple<bool, int>(true,sonuc);

            }
            catch
            {
                return new Tuple<bool, int>(false, 0);
            }
            
        }

        static bool DonusturmeyiDene(string ifade, out int sonuc)
        {
            try
            {
                sonuc = int.Parse(ifade);
                return true;

            }
            catch
            {
                sonuc = 0;
                return false;
            }
        }

        static void RefMetod(ref int a)
        {
            int b = 10;
            a = b;//a nın adresine b deki değeri atadı
            b = 20;
        }
    }
}
