using System;

namespace uygulama13
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int[,] X;

            X = new int[2, 3];

            Console.WriteLine("sayıları giriniz: \n");

            for (i = 0; i < X.GetLength(0); i++)
            {
                for (j = 0; j < X.GetLength(1); j++)
                {
                    Console.WriteLine("\telemanlar [" + i + "," + j + "]: ");

                    X[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nElemanlar:  \n");
            //for ( i = 0; i < X.GetLength(0); i++)
            //{
            //    for (j = 0; j < X.GetLength(1); j++)
            //    {
            //        Console.WriteLine(X[i,j] + " ");
            //    }
            //}

            foreach (var elements in X)
            {
                Console.WriteLine(elements);
            }
          
        }
    }
}
