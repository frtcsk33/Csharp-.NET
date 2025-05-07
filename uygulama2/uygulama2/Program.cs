using System;

namespace uygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 54;

            bool isTrue = (x > 50 && x < 60) && (x % 5 == 0 || x % 3 == 0);
            Console.Write(isTrue);
        }
    }
}
