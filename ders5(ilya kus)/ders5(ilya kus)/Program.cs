using System;

namespace ders5_ilya_kus_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sayı giriniz: ");
            int sonuc = Convert.ToInt32(Console.ReadLine());

            if(sonuc > 0)
            {
                Console.WriteLine("sayı pozitiftir");
            }
            else if (sonuc < 0)
            {
                Console.WriteLine("sayı negatiftir");
            }
            else
            {
                Console.WriteLine("sayı 0'a eşittir");
            }
            
         }
    }
}
