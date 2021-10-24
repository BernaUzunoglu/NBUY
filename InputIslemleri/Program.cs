using System;

namespace InputIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Adınızı Giriniz:  ");

            //string ad = Console.ReadLine(); 
            //Console.WriteLine();
            /*
             *Kullamıcı Giriişleri
             *Veri tabanı istekleri
             *Dosya İşlemleri
             *sunucu istekleri
             *Tür Dönüşümleri
             *
             *Try-Catch | Error Handling
             */

            Console.Write("Lütfen 1 ile 100 arasında bir sayı giriniz: ");
            int girilenSayi = 0;
            //int girilenSayi = Convert.ToInt32(Console.ReadLine());

            try
            {
                girilenSayi = Convert.ToInt32(Console.ReadLine());

                if (girilenSayi < 1 || girilenSayi > 100)
                {
                    //throw new OverflowException();
                    throw new Exception(message: "Girilen sayı 1-100 arasınd değildir.");
                }
                Console.WriteLine(girilenSayi * girilenSayi);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("girilen sayı çok büyük yada çok küçük");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Lütfen bir sayı giriniz");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                //Finally her zaman çalışır.
                Console.WriteLine("Finally Çalıştı");
            }

            Console.WriteLine("1-6 arasındsa bir sayı giriniz");
            int sayi2 = 0;
            string girilen = Console.ReadLine();
            if(int.TryParse(girilen,out sayi2))
            {
                Console.WriteLine(sayi2*sayi2*sayi2);
            }
            else
            {
                Console.WriteLine("Sayi giremediniz");
            }
            
        }
    }
}
