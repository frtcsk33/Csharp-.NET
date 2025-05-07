using System;

namespace uygulama9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc;
            Console.WriteLine("ilk sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("------------MENU-----------?\nYapmak istediginiz islemi seçiniz\n1-Toplama için (S)\nÇıkarma için (C)\nÇarpma için (M)\nBolme için (D) basınız");
            char character = Convert.ToChar(Console.ReadLine());

            switch (character)
            {
                case 's': sonuc = sayi1 + sayi2;
                    Console.WriteLine("Toplama işlemi : "+sonuc);
                    break;

                case 'c': sonuc = sayi1 - sayi2;
                    Console.WriteLine("Çıkarma işlemi: "+ sonuc);
                    break;

                case 'm': sonuc = sayi1 * sayi2;
                    Console.WriteLine("Çarpma işlemi: "+sonuc);
                    break;
                case 'd': sonuc = sayi1 / sayi2;
                    Console.WriteLine("Bölme işlemi: " + sonuc);
                    break;

                default: Console.WriteLine("Bir işlem seçmediniz. Lütfen geçerli bir işlem seçiniz");
                    break;



            }

        }
    }
}
