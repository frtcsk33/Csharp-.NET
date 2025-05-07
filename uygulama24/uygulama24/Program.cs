using System;

namespace uygulama24
{
    class ogrenciBilgileri
    {
        public string ad;
        public int no;
        public string bolum;
    }


    class Program
    {
        static void Main(string[] args)
        {
            ogrenciBilgileri ogr = new ogrenciBilgileri();
            ogr.ad = "firat";
            ogr.bolum = " Bilgisayar müh";
            ogr.no = 10213124;

            Console.WriteLine(ogr.ad +" " + ogr.bolum + "  " + ogr.no );

        }
    }
}
