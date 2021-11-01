using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methodlar
            //Geriye değer döndürülüyor mu? hayır ise void evet ise geri dönüş tipi
            // Eğer geriye dönüş tipi yazılmış ise return keyword ile dönüştürülecek
            //bu metoda isim vermeliyiz. PascalCase yazım şekli
            //metod çalışırken parametreye ihtiyacı varmı hayır ise boş bırakılacak evet ise parametre tanımlamas yapılacak
            //metodların imzaları benzersizdir


            Console.WriteLine();
            double alan = AlanHesapla(5);
            alan = AlanHesapla(3,4);
            alan = AlanHesapla(3d);
            alan = AlanHesapla(3d,3.14);
            int sonuc = Topla(3,5);
            //int sonuc1 = Topla((Topla(3,5), 5),Topla(9,7));

            int[] sayilar = { 3, 5, 6, 4, 6, 5, 8, 9 };
            sonuc = Topla(new[] { 3, 5, 6, 4, 6, 5, 8, 9 },1);
            Console.WriteLine(sonuc);
            sonuc = Topla(sayilar,1);
            Console.WriteLine(sonuc);
            sonuc = Topla(3, 5, 6, 4, 6, 5, 8, 9);
            Console.WriteLine(sonuc);
        }
        
         
        /// <summary>
        /// Karenin alanını hesaplayan metot
        /// </summary>
        /// <param name="kenar">Karenin bir kenarının uzunluğu</param>
        /// <returns> Karenin alanı</returns>
        static double AlanHesapla(int kenar)
        {
            double sonuc = kenar * kenar;
            return sonuc;
        }

        /// <summary>
        /// Dİkdörtgenin alanının hesaplanmasında kullanılır
        /// </summary>
        /// <param name="kenar1"> kenar1</param>
        /// <param name="kenar2">kenar2</param>
        /// <returns>Dikdört Alanı</returns>
         static double AlanHesapla (int kenar1, int kenar2)
        {
            return kenar1 * kenar2;
        }

        /// <summary>
        /// Çemberin alanını hesaplayan  metod
        /// </summary>
        /// <param name="r"> r yarıçap değeri</param>
        /// <returns></returns>
        static double AlanHesapla(double r,double pi=Math.PI)//Opsiyonel parametre ve bu parameterler hep sonda yazılır
        {
            return r * r * pi;
        }

        static int Topla(int a,int b)
        {
            return a + b;
        }

        static int Topla(int[] sayilar , int yuvarlama )
        {
            int sonuc = 0;
            foreach (int sayi in sayilar)
            {
                sonuc += sayi;
            }
            return sonuc;
        }

        // params olarak kullanıldığı zaman new[] {} şeklinde , dizi ismi ile ve sonsuz parametre olarak kullanımını sağlıyor.Topla(params int[] sayilari int yuvarlama ) şeklinde tanımlanınca , , , şeklinde girdi alabildiği için diğer parametrenin ayrımını yapamıyor.
        static int Topla(double yuvarlama ,params int[] sayilar)
        {
            int sonuc = 0;
            foreach (int sayi in sayilar)
            {
                sonuc += sayi;
            }
            return sonuc;
        }
    }
}
