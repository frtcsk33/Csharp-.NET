using System;

namespace uygulama17
{
    class Program
    {


        private static int enBuyukSayi(int a , int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static void Main(string[] args)
        {
            int sayi1, sayi2;

            Console.WriteLine("iki tane sayi giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            sayi2 = Convert.ToInt32(Console.ReadLine());

            int Max = enBuyukSayi(sayi1, sayi2);

            Console.WriteLine("En buyuk sayı:    {0}", Max);









        }
    }
}
