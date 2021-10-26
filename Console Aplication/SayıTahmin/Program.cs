using System;

namespace SayıTahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Random rnd = new Random();
                int tahminSayısı = 0, rasgeleSayi = rnd.Next(1, 101), giris = 0;

                do
                {
                    Console.WriteLine("Rasgele Sayıyı tahmin ediniz");
                    try
                    {
                        giris = int.Parse(Console.ReadLine());
                    }
                    catch
                    {

                        Console.WriteLine("Yanlış bir değer girdiniz");
                        continue;
                    }
                    finally
                    {
                        tahminSayısı++;
                    }
                    
                    if (giris == rasgeleSayi)
                    {
                        Console.WriteLine("Tebrikler" + tahminSayısı + ". denemede bildiniz");
                        break;
                    }
                    else if (giris > rasgeleSayi)
                    {
                        Console.WriteLine("Tahmininizi düşürün");
                    }
                    else
                        Console.WriteLine("Tahmininizi artırın");
                } while (true);

                Console.WriteLine("Tekrar oynamak içi E tuşuna basınız");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key != ConsoleKey.E)
                    break;

            } while (true);
        }
    }
}
