using System;

namespace uygulama16
{
    class Program
    {
        static int hesapla(int x1)
        {
            x1 = x1 * x1 + x1 + 10;
            return (x1);
        }



        static void Main(string[] args)
        {

            int toplam = 0;

            for (int i = 0; i < 3; i++)
            {
                toplam += hesapla(Convert.ToInt32(Console.ReadLine()));
             
            }
            Console.WriteLine("toplam: " + toplam);






        
        }
    }
}
