using System;

namespace ders9_ahmet_hoca_
{
    class Program
    {
        static void Main(string[] args)
        {

            int ceket_b, pantolon_b, ayakkabi_b, canta_b, kemer_b, gomlek_b, toplam_fiyat;
            ceket_b = 0;
            pantolon_b = 0;
            gomlek_b = 0;
            ayakkabi_b= 0;
            canta_b = 0;
            kemer_b = 0;
            string cevap;
            Console.WriteLine("ceket aldınız mı? E/H");
            cevap = Console.ReadLine();
            if(cevap == "E") 
            {ceket_b = 1; toplam_fiyat += 100; }

            Console.WriteLine("gomlek aldınız mı? E/H");
            cevap = Console.ReadLine();
            if (cevap == "E")
            { gomlek_b = 1; toplam_fiyat += 100; }

            Console.WriteLine("ayakkabı aldınız mı? E/H");
            cevap = Console.ReadLine();
            if (cevap == "E")
            { ayakkabi_b= 1; toplam_fiyat += 200; }


            Console.WriteLine("çanta aldınız mı? E/H");
            cevap = Console.ReadLine();
            if (cevap == "E")
            { canta_b= 1; toplam_fiyat += 225; }

            Console.WriteLine("kemer aldınız mı? E/H");
            cevap = Console.ReadLine();
            if (cevap == "E")
            { ceket_b = 1; toplam_fiyat += 100; }

            int urun










        }
    }
}
