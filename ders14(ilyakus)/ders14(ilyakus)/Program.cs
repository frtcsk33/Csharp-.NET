using System;
using System.Linq;

namespace ders14_ilyakus_
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] isimler = { "Hüseyin", "Hasan", "Mete", "Veli", "Alperen", "Ömer", "Ayşe", "hadolu", "ahmet", "Yasin"};
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma" };



            Random rand = new Random();
            foreach(string gun in gunler)
            {
                int n = rand.Next(isimler.Length);
                string isim = isimler[n];
                Console.WriteLine(gun + " "+  isim);

                isimler = isimler.Where(x => x != isimler[n]).ToArray();



                n = rand.Next(isimler.Length);
                Console.WriteLine(gun + "\t" + isimler[n] + "\t==========================");

                isimler = isimler.Where(x => x != isimler[n]).ToArray();
                


            }








        }
    }
}
