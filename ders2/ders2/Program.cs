using System;

namespace ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ad: ");
            string ad  = Console.ReadLine();
            Console.Write("soyad: ");
            string soyad = Console.ReadLine();
            Console.Write("telefon no: ");
            string tlf = Console.ReadLine();
            Console.Write("tc: ");
            string tc = Console.ReadLine();

            Console.WriteLine("\n\n\nad:  "+ ad + "\nsoyad:  " + soyad + "\ntlf: " + tlf + "\ntc: " + tc);

            Console.WriteLine("\nAdı:    {0}\nSoyadı:  {1}\ntlf:  {2}\ntc:   {3}", ad, soyad, tlf, tc);





        }
    }
}
