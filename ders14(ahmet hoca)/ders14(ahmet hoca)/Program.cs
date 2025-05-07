using System;

namespace ders14_ahmet_hoca_
{
    class Program
    {
        static void Main(string[] args)
        {
            //matris çarpımı
            int[,] A = { { 4, 0, 1 }, { -1, 2, -1 } };
            int[,] B = { { 2, 3 }, { 1, 2 }, { 2, -1 } };

            int[,] C = new int[A.GetLength(0), B.GetLength(1)];
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    C[i,j] = A[i, j] * B[i ,j];
                    Console.WriteLine(C[i,j]);
                }
            }
        }

    }
}
