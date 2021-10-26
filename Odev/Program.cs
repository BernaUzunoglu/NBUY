using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------Oyun 1 ---------------
            Random rnd = new Random();

            do
            {
                int rasgeleSayi = rnd.Next(100);
                while (true)
                {
                    Console.WriteLine("Lütfen 1 - 100 arasındaki tahmini değerinizi giriniz");
                    try
                    {
                        int tahminDeger = Convert.ToInt32(Console.ReadLine());
                        if (tahminDeger < 1 || tahminDeger > 100)
                            throw new Exception("1 - 100 arası bir sayı girmediniz");
                        //break;

                        if (tahminDeger < rasgeleSayi)
                            Console.WriteLine("Yukarı");
                        else if (tahminDeger > rasgeleSayi)
                            Console.WriteLine("Aşağı");
                        else
                        {
                            Console.WriteLine("Dogru Tahmin");
                            break;
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Lütfen sayısal bir değer giriniz");
                    }
                }
                Console.WriteLine("Tekrar oynamak içi E tuşuna basınız");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key != ConsoleKey.E)
                    break;

            } while (true);

            // ----------- Oyun 2 -------

            Console.WriteLine("Lütfen 1 - 6 arasındaki zar değerinizi giriniz");
            try
            {
                int zarDegeri = Convert.ToInt32(Console.ReadLine());
                if (zarDegeri < 1 || zarDegeri > 6)
                    //throw new Exception("1 - 6 arası bir sayı girmediniz");
                    Console.WriteLine("1 - 6 arası bir sayı girmediniz");
                //break;

                int sayac = 1;
                while (true)
                {
                    int a = rnd.Next(1, 7);
                    int b = rnd.Next(1, 7);
                    if (zarDegeri == a && zarDegeri == b)
                    {
                        Console.WriteLine("Girilen Zar değeri {0} :{0} gelme iterasyon saysı {1} ", zarDegeri, sayac);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Gelen zar değerleri {0}:{1} ve iterasyon sayısı : {2}", a, b, sayac);
                        sayac++;
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Lütfen sayısal bir değer giriniz");
            }




            ///----------- Oyun 3 ----------
            ///
            string[] kelimeListesi = { "ELMA", "BERNA", "KANEPE", "TABAK", "KULAKLIK", "BİLGİSAYAR", "YAZILIM", "MÜHENDİS", "HAFIZA" };
            //string[] kelimeListesi = { "ELMA", "ELMA", "ELMA", "ELMA", "ELMA", "ELMA", "ELMA", "ELMA", "ELMA", "ELMA", "ELMA", "ELMA", "ELMA", "ELMA", "ELMA", };


            do
            {
                string oyunKelimesi = kelimeListesi[rnd.Next(1, 9)];
                int maxPuan = oyunKelimesi.Length * 10;

                char[] karekterDizisi = oyunKelimesi.ToCharArray();
                string[] bosDizi = new string[oyunKelimesi.Length];

                Console.WriteLine();

                for (int i = 0; i < oyunKelimesi.Length; i++)
                {
                    bosDizi[i] = " - ";
                    Console.Write(" - ");// Kelimenin harf değeri
                }
                for (int i = 5; i >= 0; i--)
                {
                    Console.WriteLine("\n Harf tahmin etmek için H'ye Kelime tahmin etmek için K'ya basınız");
                    ConsoleKeyInfo info = Console.ReadKey();

                    if (info.Key == ConsoleKey.H)//Harf tahmini
                    {
                        for (int k = 0; k < bosDizi.Length; k++)
                        {
                            Console.WriteLine("\n Tahmin ettiğiniz harf i girin  :  ");
                            string tahminKarekteri = Console.ReadLine();
                            bool tahminDurumu = oyunKelimesi.Contains(tahminKarekteri.ToUpper());
                            if (tahminDurumu == true)
                            {
                                int index = oyunKelimesi.IndexOf(tahminKarekteri.ToUpper());
                                bosDizi[index] = tahminKarekteri;
                                foreach (var item in bosDizi)
                                {
                                    Console.Write(item);
                                }

                            }
                            else
                            {
                                Console.WriteLine("\n Yanlış tahmin ettiniz");
                                maxPuan = maxPuan - (maxPuan * 15 / 100);
                                //break;
                            }


                        }
                        //Console.WriteLine("Kelimeyi doğru tahmin ettiniz");
                        //Console.WriteLine("Kazanılan toplam puan : {0} ", maxPuan);
                        break;
                        



                    }
                    else if (info.Key == ConsoleKey.K)
                    {
                        Console.WriteLine("Tahmin ettiğiniz kelimeyi girin");
                        string tahminKelime = Console.ReadLine();
                        if (tahminKelime.ToUpper() == oyunKelimesi)
                        {
                            Console.WriteLine("Doğru Tahmin Ettiniz");
                        }
                        else
                        {
                            Console.WriteLine("Hatalı tahmin");
                            maxPuan = maxPuan - (maxPuan * 15 / 100);
                        }

                    }
                    else
                        Console.WriteLine("Lütfen düzgün giriş yapınız");

                }
                
                Console.WriteLine("Adam Asıldı");
                Console.WriteLine("Kazanılan toplam puan : {0} ", maxPuan);

            } while (true);


        }
    }
}
