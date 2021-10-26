using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            ///----------- Oyun 3 ----------
            ///
            string[] kelimeListesi = { "ELMA", "BERNA", "KANEPE", "TABAK", "KULAKLIK", "BİLGİSAYAR", "YAZILIM", "MÜHENDİS", "HAFIZA" };

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
