using System;

namespace uygulama5__diziler_
{
    class Program
    {
        static void Main(string[] args)
        {
            //string city = "İstanbul";

            //string[] cities = new string[3];

            //cities[0] = "istanbul";
            //cities[1] = "ankara";
            //cities[2] = "Mersin";
            //Console.WriteLine(cities[2]);

            //int number1;
            //int number2;
            //int number3;


            //int[] sayilar = { 10, 45, 21, 35, 64, 75, 84, 26 };
            //Console.WriteLine(sayilar[6]);


            //string[] isimler = { "Ali", "Ahmet", "Ayşe", "emel", "mehmet" ,"baran"};

            //Console.WriteLine(isimler[5]);

            string[] sehirler = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Şehir: ");
                sehirler[i] = Console.ReadLine();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sehirler[i]);
            }

            Console.Read();
        }
    }
}
