using System;
using System.Collections;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new[] { 3, 5, 6, 69, 45, 41, 1 };
            sayilar = new int[10];

            Random rnd = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(maxValue: 100);
            }
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }

            double[,] matris = new double[5, 3];

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = rnd.NextDouble() * rnd.Next(maxValue: 100);
                }
            }
            Array.Resize(ref sayilar, newSize: 20);

            ArrayList liste1 = new ArrayList();
            liste1.Add(123);
            liste1.Add("Berna");
            liste1.Add(true);
            liste1.Add(null);
            liste1.Add(DateTime.Now);

            //Generic List
            List<int> liste2 = new List<int>();
            liste2.Add(2);
            liste2.Add(5);
            liste2.Add(55);


        }

    }
        
}

