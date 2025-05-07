using System;

namespace ders15_ilyakus_
{
    class Program
    {

        private static void toplama(int n, int a)
        {
            Console.WriteLine(a + n+ "\n");
        }

        private static void cikarma(int n, int a)
        {
            Console.WriteLine(a - n + "\n");
        }

        private static void bolme(int n, int a)
        {
            Console.WriteLine(a / n + "\n");
        }

        private static void carpma(int n, int a)
        {
            Console.WriteLine(a * n+ "\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("İki tane sayı giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            toplama(a, n);
            cikarma(a, n);
            bolme(a, n);
            carpma(a, n);
        }
    }
}
