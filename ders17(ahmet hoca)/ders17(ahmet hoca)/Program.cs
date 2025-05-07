using System;

namespace ders17_ahmet_hoca_
{
    class hesaplamalar
    {
        int hesapla1(int x)
        {
            return (x * x * x - 10 * x);
        }



        static void Main(string[] args)
        {
            hesaplamalar hsp = new hesaplamalar();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("y degeri giriniz ");

                int y = Convert.ToInt32(Console.ReadLine());
                int hesaplanan_deger = hsp.hesapla1(y);

                Console.WriteLine("y= " + hesaplanan_deger);


            }



        }
    }
}
