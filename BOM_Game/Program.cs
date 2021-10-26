using System;

namespace BOM_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("BOM Oyunu için kural sayısnı belirleyiniz");
                    int kuralSayisi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kural Değeri:   " + kuralSayisi+ "\n");
                    bool oyunBitti = false;
                    //Console.Clear();
                    for (int i = 1; i < 100; i++)
                    {
                        if (i % 2 == 1 && oyunBitti==false)
                        {
                            if (i % 2 == 1 && i % kuralSayisi == 0)
                                Console.WriteLine("BOM");
                            else if(i==100)
                                Console.WriteLine("BERABERE");
                            else
                                Console.WriteLine("Bilgisayar Oynadı: " + i+ "\n");
                        }
                        else
                        {
                            bool dogruMu = false;
                            while (dogruMu == false && oyunBitti==false )//Kullanıcı Bom yazarken ihtimallerin kontrolü iç
                            {
                                Console.WriteLine("Sıra sizde: ");
                                string deger = Console.ReadLine();
                                if (i % kuralSayisi == 0 && deger.ToUpper() == "BOM")
                                {
                                    Console.WriteLine("BOM");
                                    dogruMu = true;
                                }
                                
                                else if(i % kuralSayisi == 0 &&(i == Convert.ToInt32(deger) || i != Convert.ToInt32(deger))&&i != Convert.ToInt32(deger))
                                { Console.WriteLine("KAYBETTİNİZ"); oyunBitti = true; }

                                else if (i % kuralSayisi == 0 && deger.ToUpper() != "BOM")
                                    Console.WriteLine("ifadeyi düzgün giriniz");
                                else if (i == Convert.ToInt32(deger))
                                {
                                    Console.WriteLine("=====================================================");
                                    dogruMu = true;
                                }
                                else if (i == Convert.ToInt32(deger) && i == 100)
                                {
                                    Console.WriteLine("BERABERE");
                                    oyunBitti = true;
                                }   
                                else
                                {
                                    Console.WriteLine("KAYBETTİNİZ.");
                                    dogruMu = true;
                                    oyunBitti = true;
                                }
                            }
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Yanlış lütfen sayısal bir değer giriniz");
                }
            } while (true);
        }
    }
}
