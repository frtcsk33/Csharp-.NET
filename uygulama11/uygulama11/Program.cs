using System;

namespace uygulama11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int rastgeleSayi1 = rnd.Next(10, 20);
            int rastgeleSayi2 = rnd.Next(50);
            int rastgeleSayi3 = rnd.Next();
            double rastgeleSayi = rnd.NextDouble();

            Console.WriteLine(rastgeleSayi1+ "\n");
            Console.WriteLine(rastgeleSayi2+ "\n");
            Console.WriteLine(rastgeleSayi3+ "\n");
            Console.WriteLine(rastgeleSayi);







        }
    }
}
