using System;

namespace uygulama29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("matrisin satır sayısını giriniz: ");
            int satir = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("matrisin sütun sayısını giriniz: ");
            int sutun = Convert.ToInt32(Console.ReadLine());


            int[,] matris = new int[satir, sutun];


            Console.WriteLine("Matris elemanlarını giriniz: ");
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.WriteLine($"[{i},{j}]: ");
                    matris[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int caprazToplam = 0;
            int caprazCarpim1 = 1;
            int caprazCarpim2 = 1;

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    if (i == j)
                    {
                        caprazCarpim1 *= matris[i, j];
                    }
                    if (i + j == satir - 1)
                    {
                        caprazCarpim2 *= matris[i, j];
                    }
                }
            }

            caprazToplam = caprazCarpim1 + caprazCarpim2;

            Console.WriteLine($"köşegen kenarların çarpımı: {caprazToplam}");

            Console.ReadLine();
        }
    }
}
