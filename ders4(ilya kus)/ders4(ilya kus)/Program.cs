using System;

namespace ders4_ilya_kus_
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("bir sayı giriniz: ");
            // double c = Convert.ToDouble(Console.ReadLine());
            // double sonuc = (c * 18)/100;
            // Console.WriteLine("sayının %18 i:  " + sonuc);


            Console.Write("sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if(sayi % 2 == 0)
            {
                Console.Write("Sayı çifttir.");

            }
            else
            {
                Console.Write("Sayı tektir.");
            }
        }
    }
}
