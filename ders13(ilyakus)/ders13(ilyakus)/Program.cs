using System;
using System.Collections;

namespace ders13_ilyakus_
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList teksayilar = new ArrayList();
            ArrayList ciftsayilar = new ArrayList();

            Console.Write("bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= sayi ; i++)
            
                if(i % 2 == 0)
                    ciftsayilar.Add(i);

                
                else
                    teksayilar.Add(i);

            Console.WriteLine("Tek sayılar dizisi: ");
            for (int i = 0; i < teksayilar.Count; i++)
            
                Console.WriteLine(teksayilar[i]);
            Console.WriteLine(" ");


            Console.WriteLine("Çift sayılar dizisi: ");
            for (int i = 0; i < ciftsayilar.Count; i++)

                Console.WriteLine(ciftsayilar[i]);
            Console.ReadKey();
        }
    }
}
