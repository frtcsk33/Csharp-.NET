using System;

namespace ders8_ahmet_hoca__tekrar_
{
    class Program
    {
        static void Main(string[] args)
        {
            int vize, final, proje, devamsizlik;
            string dersAdi;
            double ortalama;
            Console.WriteLine("ders adini giriniz: ");
            dersAdi = Console.ReadLine();
            Console.WriteLine("vize notunu giriniz: ");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("final notunu giriniz: ");
            final = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("proje notunu giriniz: ");
            proje = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("devamsızlığı giriniz: ");
            devamsizlik = Convert.ToInt32(Console.ReadLine());

            ortalama = (vize*0.4+final*0.6+proje*0.35);

            if (devamsizlik < 10)
            {
                if (dersAdi == "Görsel programlama")
                {
                    proje = proje + 20;

                }
                if (proje >= 80 && dersAdi == "Görsel Programlama")
                {
                    proje = 99;

                }
            }
            else
            {
                Console.WriteLine("Devamsızlığınız 10 ve üstü olduğu için Dersten kaldınız");
            }
            Console.WriteLine("dersAdi: {0}/nvize: {1}/n final:  {2}/nproje:  {3}/n devamsızlık:   {4}\nOrtalama: {5}", dersAdi, vize, final, proje, devamsizlik, ortalama);

        }

    }
}