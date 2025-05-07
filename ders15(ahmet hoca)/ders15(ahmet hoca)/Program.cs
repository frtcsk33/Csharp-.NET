using System;

namespace ders15_ahmet_hoca_
{
    class Program
    {
        private static int hesapla(int x1) {

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
            Console.WriteLine("toplam " + toplam);






        }
    }
}
