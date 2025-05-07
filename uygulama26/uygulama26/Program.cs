using System;

namespace uygulama26
{
    class Program
    {
        static void Main(string[] args)
        {
            bitki bitki1 = new bitki();

            bitki1.ad = "çam";
            bitki1.tur = "ağaç";

            hayvan hayvan1 = new hayvan();

            hayvan1.ad = "inek";
            hayvan1.tur = "memeli";

            Console.WriteLine(bitki1.ad + " "+ bitki1.tur+ "\n" + hayvan1.ad + " " + hayvan1.tur );

        }
    }
}
