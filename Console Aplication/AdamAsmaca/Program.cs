using System;
using System.Collections.Generic;

namespace AdamAsmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int hak = 5, bilinen = 0;
                string[] sorular = { "zeytinburnu", "kahramanmaraş", "çanakkale", "hayrabolu" };
                string seciliSoru = sorular[new Random().Next(sorular.Length)];
                double puan = seciliSoru.Length * 100;
                char[] ekran = new char[seciliSoru.Length];
                Console.Clear();
                for (int i = 0; i < seciliSoru.Length; i++)
                {
                    ekran[i] = '-';
                }
                List<char> oncekiTahminler = new List<char>();

                do
                {
                    //ekranı yazdır
                    foreach (char harf in ekran)
                    {
                        Console.Write(harf + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"{puan:#.00} puan. {hak} hakkınız kaldı");
                    Console.WriteLine("Tahmin: ");
                    string tahmin = Console.ReadLine();
                    bool dogruMu = false;
                    if (!string.IsNullOrEmpty(tahmin) && tahmin.Length == 1) //harf tahmini
                    {
                        char harf = tahmin.ToLower()[0];
                        if (!(oncekiTahminler.Contains(harf)))
                        {
                            for (int i = 0; i < seciliSoru.Length; i++)
                            {
                                //if (seciliSoru[i] == harf&& ekran[i] !=harf) * Girilen *
                                if (seciliSoru[i] == harf)
                                {
                                    dogruMu = true;
                                    ekran[i] = harf;
                                    bilinen++;
                                }
                            }
                        }
                    }
                    else if (!string.IsNullOrEmpty(tahmin))
                    {
                        if (seciliSoru == tahmin.ToLower())
                        {
                            dogruMu = true;
                            break;
                        }
                    }

                    if (!dogruMu)
                    {
                        hak--;
                        puan *= 0.85;
                        if (hak == 0)
                        {
                            break;
                        }
                    }
                    if (seciliSoru.Length == bilinen)
                    {
                        break;
                    }
                } while (true);

                if (hak == 0)
                {
                    Console.WriteLine("Kaybettiniz! Puan: 0");
                }
                else
                {
                    Console.WriteLine(seciliSoru);
                    Console.WriteLine($"Tebrikler kazandınız! Puanınız: {puan:#.00} Kalan hak: {hak}");
                }

                Console.WriteLine("Tekrar oynamak için E tuşuna basınız");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key != ConsoleKey.E)
                    break;
            } while (true);

            /*
             * string ifadelerden Contains ve Indexof ile kelime içerisinde harf bulma yöntemi
             * 
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
             */


        }
    }
}
