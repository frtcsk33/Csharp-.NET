using System;

namespace uygulama19
{
    class Program
    {
        private static int y1_hesapla(int x)
        {
            int y1 = x * x + x + 10;
                return y1;
        }

        private static int y2_hesapla(int x)
        {
            int y2 = x * x * x - 2 * x;
            return y2;

        }

        static void Main(string[] args)
        {

            for (int i = 0; i < 2; i++)
            {
                int deger = Convert.ToInt32(Console.ReadLine());

                if(deger > 8)
                {
                    Console.WriteLine("y2 fonksiyonunun hesabı: " + y2_hesapla(deger));
                }
                else
                {
                    Console.WriteLine("y1 fonksiyonunun hesabı: " + y1_hesapla(deger));
                }

            }



        }
    }
}
