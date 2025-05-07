using System;

namespace uygulama20
{
    class Program
    {
        static void Main(string[] args)
        {

            //int rakam = 0;
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //while(sayi> 0)
            //{
            //    rakam = sayi % 10;
            //    sayi = sayi / 10;
            //    Console.Write(rakam);
            //}

            int[,] dizi = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            int[,] dizi2 = { { 2, 4 }, { 4, 6 }, { 5, 7 }, { 7, 8 } };

            string[,] iki_boyutlu = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };

            int[,,] array3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, {{ 7, 8, 9 }, { 10, 11, 12 } } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.WriteLine("a[{0},{1},{2}] = {3}", i, j, k, array3D[i, j, k]);
                    }
                }
            }

        }
    }
}
