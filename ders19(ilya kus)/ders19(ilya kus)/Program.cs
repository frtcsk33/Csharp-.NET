using System;

namespace ders19_ilya_kus_
{
    class Program
    {
        static void Main(string[] args)
        {
            bitki bitki1 = new bitki();

            bitki1.ad = "çam";
            bitki1.tur = "ağaç";

            hayvan hayvan1 = new hayvan();

            hayvan1.ad = "kurt";
            hayvan1.tur = "memeli";

            Console.WriteLine(bitki1.ad + " " + bitki1.tur + "\n" + hayvan1.ad + " " + hayvan1.tur);

        }
    }
}
