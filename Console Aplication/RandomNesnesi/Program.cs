using System;

namespace RandomNesnesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random rnd = new Random(); // instance(bir örneğinin oluşturmak)
            int sayi1 = rnd.Next(0,101);//100 e kadar


            //-10 ile 20 arasında rastgale sayı
            int sayi2 = rnd.Next(-10,20);

            //rastgele bir sayı
            int sayi3 = rnd.Next();
        }
    }
}
