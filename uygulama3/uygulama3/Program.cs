using System;

namespace uygulama3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kAdi = "Firatcsk";
            //string email = "frtcsk2@gmail.com";
            //string sifre = "bequiet";

            //Console.WriteLine("İsminizi giriniz. email veya kullancı adı da girebilirsiniz");
            //string isim  = Console.ReadLine();
            //Console.WriteLine("Şifrenizi giriniz");
            //string kullaniciSifre = Console.ReadLine();

            //Console.WriteLine((kAdi == isim || email == isim) && (sifre == kullaniciSifre));


            //Tip dönüşümleri


            int numberInt = 10;

            string numberString = numberInt.ToString();


            //int numberInt2 = int.Parse(numberString);

            int numberInt2 = Convert.ToInt32(numberString);
            // ToInt16 = short
            // ToInt32 = int
            // ToInt64 = float

            double numberDouble = Convert.ToDouble("17");
            decimal numberDecimal = Convert.ToDecimal("20");
            Console.WriteLine(numberInt2 * 2);

            short numberShort = 15;
            int numberInt3 = numberShort;


            //konsol üzerinden küçük kenarı ve büyük kenarı girilen bir dikdörtgenin çevresini hesaplayan uygulamayı yazınız. 

            Console.WriteLine("Küçük kenarı giriniz");
            int kucukKenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("büyük kenarı giriniz");
            int buyukKenar = Convert.ToInt32(Console.ReadLine());

            int cevre = (buyukKenar + kucukKenar) * 2;

            //Console.WriteLine((kucukKenar + buyukKenar) * 2);
            Console.WriteLine("Dikdörtgenin çevresi = " + cevre);






            





        }
    }
}
