using System;

namespace uygulama22
{
    class hesaplamalar
    {
        int hesapla1(int x1)
        {
            return (x1 * x1 * x1 - 10 * x1);
        }

        static void Main(string[] args)
        {
            hesaplamalar hsp = new hesaplamalar();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("değerleri giriniz ");
                int y = Convert.ToInt32(Console.ReadLine());

                int hesaplanan_deger = hsp.hesapla1(y);

                Console.WriteLine("y= "+ hesaplanan_deger);
            }

        }
    }
}
