using System;

namespace uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            for ( a = 2; a >= 0; a--)
            {
                for ( b = 0; b <= 2; b++)
                {
                    if(a == b)
                    {
                        Console.WriteLine("1");

                    }
                    else
                    {
                        Console.WriteLine("0");
                    }

                }
                Console.WriteLine("\n");
            }
        }
    }
}
