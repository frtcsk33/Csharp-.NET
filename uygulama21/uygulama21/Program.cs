using System;
using System.Collections;
namespace uygulama21
{
    class Program
    {
        static void Main(string[] args)
        {
            //        ArrayList dinamikDizi = new ArrayList();

            //        var cem = new ArrayList();

            //        dinamikDizi.Add(1);
            //        dinamikDizi.Add(50);
            //        dinamikDizi.Add("Fırat");
            //        dinamikDizi.Add(4.5);
            //        dinamikDizi.Add(null);
            //        dinamikDizi.Add(true);
            //        dinamikDizi.Add(" ");

            //        cem.Add("ersin");
            //        ArrayList list2 = new ArrayList() { 2, "Deli", " ", true, 4.5, null };

            ArrayList tekSayilar = new ArrayList();
            ArrayList ciftSayilar = new ArrayList();
            //int[] sayi;

            int sayi;
            Console.WriteLine("10 tane sayi giriniz ");
            sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < 10; i++)
            //{
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //}


            for (int i = 0; i <= sayi; i++)
            {
                if(i % 2 == 0)
                {
                    ciftSayilar.Add(i);
                }
                else
                {
                    tekSayilar.Add(i);
                }
            
            }
            
                

            foreach(int sayilar in tekSayilar)
            {
                Console.WriteLine(sayilar);
            }

            foreach (var ciftler in ciftSayilar)
            {
                Console.WriteLine(ciftler);
            }
            Console.WriteLine("\n\nTek sayilar dizisi: ");

            for (int i = 0; i < tekSayilar.Count; i++)
            {
                Console.WriteLine(tekSayilar[i]);
            }

            Console.WriteLine("\n\nçift sayilar dizisi: ");

            for (int i = 0; i < ciftSayilar.Count; i++)
            {
                Console.WriteLine(ciftSayilar[i]);
            }


        }
    }
}
