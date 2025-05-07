using System;

namespace ders12_ilyakus_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = { { 3,0,1 }, { -1, 2,4}};
            int[,] B = { { 2,3 }, { 2,1 }, { -1,2 } };

            Console.WriteLine(A.GetLength(0));
            Console.WriteLine(B.GetLength(1));
            int[,] C = new int[A.GetLength(0), B.GetLength(1)];

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    int toplam = 0;
                    for (int k = 0; k < A.GetLength(1); k++)
                    {
                        toplam += A[i, k] * B[k, j];


                    }
                    C[i, j] = toplam;
                    Console.WriteLine(toplam);

                }
            }
            Console.ReadKey();

        }
    }
}
