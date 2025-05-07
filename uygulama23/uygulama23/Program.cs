using System;

namespace uygulama23
{
    class Program
    {

        static void Main(string[] args)
        {
            ogrbilgileri ogr = new ogrbilgileri();

            ogr.ad = "Fırat";
            ogr.bolum = "bilgisayar müh";
            ogr.no = 201312054;

            Console.WriteLine(ogr.ad + " " + ogr.bolum + "   " + ogr.no);
        }
    }
}
