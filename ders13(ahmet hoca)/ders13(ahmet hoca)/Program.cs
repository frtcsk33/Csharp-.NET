using System;

namespace ders13_ahmet_hoca_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //iki boyutlu diziler
            int[,] iki_boyutlu_int = new int { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            int[,] iki_boyutlu_int1 = new int[4,2] { { 4, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };


            string[,] iki_boyutlu_string_1 = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };

            //int[,,] uc_boyutlu_int = 

            int[,,] uc_boyutlu_int_1 = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 }  } }  };

            Console.WriteLine(uc_boyutlu_int_1[1,1,1]);
        }
    }
}
