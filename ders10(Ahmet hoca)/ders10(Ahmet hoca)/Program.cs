using System;

namespace ders10_Ahmet_hoca_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int toplam = 0;
            
            for (i=2; i<=100; i++)
            {
                if(i == 2 || i == 3 || i== 5 || i == 7)
                {
                    Console.Write(i);
                    toplam = toplam + i;
                }
                if (i % 2 != 0 && i  % 3 != 0 && i%5!=0 && i % 7 != 0)
                {

                    Console.WriteLine(i);
                    toplam = toplam + i;

                }
                

          
            }
            Console.Write("asal sayilarin Toplami: " + toplam);
        }
    }
}
