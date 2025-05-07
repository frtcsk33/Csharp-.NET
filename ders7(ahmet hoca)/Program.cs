using System;

namespace ders7_ahmet_hoca_
{
    class Program
    {
        static void Main(string[] args)
        {
            int vize, final, proje, devamsizlik;
            string dersAdi;
            Console.WriteLine("ders adini giriniz: ");
            dersAdi = Console.ReadLine();
            Console.WriteLine("vize notunu giriniz: ");
            vize = Convert.ToInt32(Console.ReadLine()) * 0.25;
            Console.WriteLine("final notunu giriniz: ");
            final = Convert.ToInt32(Console.ReadLine()) * 0.45;
            Console.WriteLine("proje notunu giriniz: ");
            proje = Convert.ToInt32(Console.ReadLine()) * 0.30;
            Console.WriteLine("devamsızlığı giriniz: ");
            devamsizlik = Convert.ToInt32(Console.ReadLine());





            if (devamsizlik < 10)
            {
                if (dersAdi == "Görsel programlama")
                {
                    proje = proje + 20;

                }
                if (proje >= 80 && dersAdi == "Görsel Programlama")
                {

                }
            }
            else
            {
                Console.WriteLine("Devamsızlığınız 10 ve üstü olduğu için Dersten kaldınız");
            }



        }

    }
}
}
