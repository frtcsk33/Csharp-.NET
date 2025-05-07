using System;

namespace uygulama34
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("a: "  +a +" \nb: "+ b  + "\nc: "+ c +"\n\n\n");
            Console.WriteLine(Math.Min(a, b));
            Console.WriteLine(Math.Max(b, c));
            Console.WriteLine(Math.Abs(a - b));
            Console.WriteLine(Math.Sqrt(b));
            Console.WriteLine(Math.Round(a));
            Console.WriteLine(Math.Floor(c));

                
        }
    }
}
