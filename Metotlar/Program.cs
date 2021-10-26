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
    }
}
