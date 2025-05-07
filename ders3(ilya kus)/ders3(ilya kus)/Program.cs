using System;

namespace ders3_ilya_kus_
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            Console.Write("bir tane sayı giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("bir tane sayı giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\n");
            c = a + b;
            Console.WriteLine("iki sayınının toplamı: " + c);
            c = a - b;
            Console.WriteLine("iki sayınının farkı: " + c);
            c = a * b;
            Console.WriteLine("iki sayınının çarpımı: " + c);
            c = a / b;
            Console.WriteLine("iki sayınının bolumu: " + c);
            c = a % b;
            Console.WriteLine("Mod işlemi: " + c);
            

        }
    }
}
