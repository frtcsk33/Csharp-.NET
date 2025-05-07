using System;

namespace ders12_ahmet_hoca_
{
    class Program
    {
        static void Main(string[] args)
        {
            int rakam = 0;
            Console.WriteLine("Bir sayı griiniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //while(sayi > 0)
            //{
            //    rakam = sayi % 10;
            //    Console.Write(rakam);
            //    sayi = sayi / 10;

            //}
            string sayi = Console.ReadLine();
            for (int i = sayi.Length - 1; i >= 0; i--)
            {
                Console.Write(sayi[i]);
            }

        }
    }
}
