using System;

namespace uygulama18
{
    class Program
    {
       





        private static int enBuyukSayi(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }

        private static int enBuyukSayi2(int a, int b, int c)
        {
            return enBuyukSayi(a, enBuyukSayi(b, c));
        }

     
        static void Main(string[] args)
        {
            int sayi1, sayi2, sayi3;

            Console.WriteLine("üç tane sayi giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            sayi2 = Convert.ToInt32(Console.ReadLine());
            sayi3 = Convert.ToInt32(Console.ReadLine());
            int Max = enBuyukSayi2(sayi1, sayi2, sayi3);

            Console.WriteLine("En buyuk sayı:    {0}", Max);


        }
    }
}
