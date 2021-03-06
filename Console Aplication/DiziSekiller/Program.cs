using System;


namespace DiziSekiller
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------Boş Kare ----------------------
            bool[,] matrisKare = null;
            try
            {
                Console.Write("Lütfen Kare İçin Boyutu Girin: ");
                int girilenBoyutKare = int.Parse(Console.ReadLine());
                matrisKare = new bool[girilenBoyutKare, girilenBoyutKare];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for (int satir = 0; satir < matrisKare.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < matrisKare.GetLength(1); sutun++)
                {
                    if (satir == 0 || sutun == 0 | satir == matrisKare.GetLength(0) - 1 ||
                        sutun == matrisKare.GetLength(1) - 1)
                    {
                        matrisKare[satir, sutun] = true;
                    }
                }
            }

            //ekrana yazdır

            for (int satir = 0; satir < matrisKare.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < matrisKare.GetLength(1); sutun++)
                {
                    if (matrisKare[satir, sutun])
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            //-------------------Üçgen---------------------

            bool[,] matrisUcgen = null;
            try
            {
                Console.Write("Lütfen Üçgen İçin Boyutu Girin: ");
                int girilenBoyutUcgen = int.Parse(Console.ReadLine());
                matrisUcgen = new bool[girilenBoyutUcgen, 2 * girilenBoyutUcgen - 1];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            int x = matrisUcgen.GetLength(0);
            int y = matrisUcgen.GetLength(1);
            for (int satir = x - 1; satir >= 0; satir--)
            {
                for (int sutun = 0; sutun < y; sutun++)
                {
                    matrisUcgen[satir, sutun] = true;
                    int boslukSayisi = (x - 1 - satir) * 2;

                    int bosluk2 = boslukSayisi / 2;
                    if (bosluk2 == 0) continue;
                    for (int i = 0; i < bosluk2; i++)
                    {
                        matrisUcgen[satir, i] = false;
                    }

                    for (int i = y - 1; i > y - 1 - bosluk2; i--)
                    {
                        matrisUcgen[satir, i] = false;
                    }
                }
            }

            //ekrana yazdır

            for (int satir = 0; satir < matrisUcgen.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < matrisUcgen.GetLength(1); sutun++)
                {
                    Console.Write(matrisUcgen[satir, sutun] ? "X" : " ");
                }
                Console.WriteLine();
            }

            //-------------------TersÜçgen---------------------

            //bool[,] matrisTersUcgen = null;
            //try
            //{
            //    Console.Write("Lütfen Ters Üçgen İçin Boyutu Girin: ");
            //    int girilenBoyutUcgenTers = int.Parse(Console.ReadLine());
            //    matrisTersUcgen = new bool[girilenBoyutUcgenTers, 2 * girilenBoyutUcgenTers - 1];
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //int x1 = matrisTersUcgen.GetLength(0);
            //int y1 = matrisTersUcgen.GetLength(1);
            //for (int sutun = x1 - 1; sutun >= 0; sutun--)
            //{
            //    for (int satir = 0; satir < x1; satir++)
            //    {
            //        matrisTersUcgen[satir, sutun] = true;
            //        int boslukSayisi = (y1 - 1 - sutun) * 2;

            //        int bosluk2 = boslukSayisi / 2;
            //        if (bosluk2 == 0) continue;
            //        for (int i = 0; i < bosluk2; i++)
            //        {
            //            matrisTersUcgen[satir, i] = false;
            //        }

            //        for (int i = x1 - 1; i > y1 - 1 - bosluk2; i--)
            //        {
            //            matrisTersUcgen[satir, i] = false;
            //        }
            //    }
            //}

            ////ekrana yazdır

            //for (int satir = 0; satir < matrisTersUcgen.GetLength(0); satir++)
            //{
            //    for (int sutun = 0; sutun < matrisTersUcgen.GetLength(1); sutun++)
            //    {
            //        Console.Write(matrisTersUcgen[satir, sutun] ? "X" : " ");
            //    }
            //    Console.WriteLine();
            //}


            bool[,] matris = null;
            try
            {
                Console.Write("Lütfen Boyutu Girin: ");
                int girilenBoyut = int.Parse(Console.ReadLine());
                matris = new bool[girilenBoyut, 2 * girilenBoyut - 1];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            for (int satir = 0; satir < matris.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < matris.GetLength(1); sutun++)
                {
                    if ((satir + sutun >= matris.GetLength(0) - 1 && sutun - satir <= matris.GetLength(0) - 1))
                    {
                        matris[satir, sutun] = true;
                    }
                }

            }

            //ekrana yazdır

            for (int satir = 0; satir < matris.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < matris.GetLength(1); sutun++)
                {
                    Console.Write(matris[satir, sutun] ? "X" : " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
