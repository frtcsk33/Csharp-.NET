using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac=0;

            for (int i = 1; i < 5; i += 2)
                for (int j = i; j > 0; j -= 5)
                    sayac = sayac + j + i;
                   
                Console.WriteLine(sayac);
            
        }
    }
}
