using System;
using System.Collections.Generic;

namespace uygulama25
{
    class Program
    {

        static void urunler()
        {
            List<urun> urunler = new List<urun>();

            urun urun1 = new urun();

            urun1.isim = "Kalem";
            urun1.fiyat = 100;
            urunler.Add(urun1);


            urun urun2 = new urun();

            urun2.isim = "silgi";
            urun2.fiyat = 25;
            urunler.Add(urun2);

            urun urun3 = new urun();
            urun3.isim = "defter";
            urun3.fiyat = 75;
            urunler.Add(urun3);


            foreach (var items in urunler)
            {
                if(items.fiyat > 70)
                    Console.WriteLine(items.isim + " " + items.fiyat);

            }

        }

        static void Main(string[] args)
        {
            urunler();
            



        }
    }
}
