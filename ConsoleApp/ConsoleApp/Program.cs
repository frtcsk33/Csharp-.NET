using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("En sevdiğinz meyve hangisi?");
            //string meyve = Console.ReadLine();
            //Console.WriteLine("En sevdiğiniz tatlı hangisi?");
            //string tatli = Console.ReadLine();

            //Console.WriteLine("Dur tahmin ediyorum. En sevdiğin tatlı: "+ tatli);
            //Console.Write("En sevdiğin meyve: " + meyve);
            //Console.ReadKey();


            #region degiskenler
            //byte yas = 254;
            //short para = 123;
            //char karakter = 'a';
            //float fiyat = 11.4F;
            //double fiyat2 = 11.4;
            //bool cinsiyet = true;
            //decimal des = 15.8M; 
            #endregion


            #region genel şeyler
            //double kısa, uzun;
            //kısa = 4;
            //uzun = 5; ;

            //Console.WriteLine("Dikdörtgenin alanı: " + kısa * uzun);

            //string name = "firat";
            //string surname = "Coskun";
            //string fullName = name + " " + surname;
            //Console.WriteLine(fullName);

            #endregion


            //Console.Write("5 ile 7 eşit mi?");
            //Console.WriteLine(5 == 7);
            //Console.Write("4 büyük mü 8'den?");
            //Console.WriteLine(4 > 8);
            //Console.Write("9 <= 9?");
            //Console.WriteLine(9 <= 9);

            string secretNumber = "18";
            string number = Console.ReadLine();
            Console.WriteLine(number == secretNumber);

        }
    }
}
