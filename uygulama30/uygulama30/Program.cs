using System;

namespace uygulama30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tekSayilar = new int[100];
            int[] ciftSayilar = new int[100];

            int tekIndex = 0;
            int ciftIndex = 0;

            Console.WriteLine("bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());


            while(sayi > -1)
            {
                if(sayi % 2 == 0)
                {
                    ciftSayilar[ciftIndex] = sayi;
                    ciftIndex++;
                }
                else
                {
                    tekSayilar[tekIndex] = sayi;
                    tekIndex++;
                }
                Console.WriteLine("bir sayı giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("tek sayılar: ");
            for (int i = 0; i < tekIndex; i++)
            {
                Console.WriteLine(tekSayilar[i] + " ");
            }

            Console.WriteLine("\ncift sayılar: ");
            for (int i = 0; i < ciftIndex; i++)
            {
                Console.WriteLine(ciftSayilar[i] + " ");
            }


        }
    }
}
