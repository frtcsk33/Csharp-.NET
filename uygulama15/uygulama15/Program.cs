using System;
using System.Linq;

namespace uygulama15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Hüseyin", "Hasan", "Ahmet", "Veli", "Cem", "Alperen", "Ömer", "Ayşe", "Hadaolu", "Yasin" };
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma" };

            Random rand = new Random();

            foreach(string gun in isimler)
            {
                int n = rand.Next(isimler.Length);
                string isim = isimler[n];

                Console.WriteLine(gun + " " + isim);

                isimler = isimler.Where(x => x != isimler[n]).ToArray();



                n = rand.Next(isimler.Length);

                Console.WriteLine(gun + " " + isimler[n]+ "\t===========");

                isimler = isimler.Where(x => x != isimler[n]).ToArray();


            }




           
        }
    }
}
