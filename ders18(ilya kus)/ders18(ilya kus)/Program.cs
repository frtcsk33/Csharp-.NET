using System;
using System.Collections.Generic;

namespace ders18_ilya_kus_
{
    class Program
    {
        class urun
        {
            public string ad;
            public int fiyat;


        }
        static void urunler()
        {
            List<urun> urunler = new List<urun>();
            urun urun1 = new urun();

            urun1.ad = "pantolon";
            urun1.fiyat = 250;
            urunler.Add(urun1);

            urun urun2 = new urun();

            urun2.ad = "tişört";
            urun2.fiyat = 50;
            urunler.Add(urun2);

            urun urun3 = new urun();

            urun3.ad = "ayakkabı";
            urun3.fiyat = 270;
            urunler.Add(urun3);

            foreach (var item in urunler)
            {
                if (item.fiyat >= 200)
                {
                    Console.WriteLine(item.ad + " " + item.fiyat);
                }
            }
        }
        static void Main(string[] args)
        {

            urunler();




        }
    }
}
