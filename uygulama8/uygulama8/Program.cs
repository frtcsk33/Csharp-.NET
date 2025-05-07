using System;

namespace uygulama8
{
    class Program
    {
        static void Main(string[] args)
        {

            int vize, final, proje, devamsizlik;

            string dersAdi;
            double ortalama;

            Console.WriteLine("Ders adını giriniz: ");
            dersAdi = Console.ReadLine();

            Console.WriteLine("vize notunu giriniz: ");
            vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("final notunu giriniz: ");
            final = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("proje notunu giriniz: ");
            proje = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("devamsızlık giriniz: ");
            devamsizlik = Convert.ToInt32(Console.ReadLine());

            ortalama = (vize * 0.4 + final * 0.6 + proje * 0.35);

            if(devamsizlik < 10)
            {
                if(dersAdi == "Görsel programlama")
                {
                    proje = proje + 20;

                }
                if(proje>80 && dersAdi == "Görsel programlama")
                {
                    proje = 99;
                }

            }
            else
            {
                Console.WriteLine("Devamsızlıktan kaldınız");
            }

            Console.WriteLine("dersAdi:    {0}/nVize:     {1}/nFinal:      {2}/nProje:    {3}/nDevamsızlık:    {4}/nOrtalama:   {5}", dersAdi, vize, final, proje, devamsizlik, ortalama);








        }
    }
}
