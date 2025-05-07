using System;

namespace ders17_ilya_kus_
{
    class ogrbilg
    {
        public string ad { get; set; }
        public int no { get; set; }
        public string bolum { get; set; }

        public void Bilgi()
        {
            Console.WriteLine("Öğrencinin adi:  {0}", ad);
            Console.WriteLine("Öğrencinin numarasi:  {0}", no);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ogrbilg ogr = new ogrbilg();

            ogr.ad = "Wally";
            ogr.no = 21412;
            ogr.bolum = "Bilgisayar Müh.";
            ogr.Bilgi();


            ogrbilg ogr1 = new ogrbilg();

            ogr1.ad = "Veli";
            ogr1.no = 1234;
            ogr1.bolum = "Elektrik elektronik";
            ogr1.Bilgi();

            //Console.WriteLine(ogr.ad + " " + ogr.no);
        }
    }
}
