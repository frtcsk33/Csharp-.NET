using System;

namespace ders11_ilyakus_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Karaman", "Konya", "İstanbul", "İzmir", };
            string[] plakalar = new string[sehirler.Length];

            for(int i=0; i<sehirler.Length-1; i++)
            {
                Console.Write(sehirler[i] + " ilinin plaka kodunu giriniz");
                plakalar[i] = Console.ReadLine();

            }
            Console.ReadLine();
        }
    }
}
