using System;

namespace uygulama4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Aklından bir sayı tut ve söyleme sonra enter tuşuna bas");
            //Console.ReadLine();
            //Console.WriteLine("Tuttuğun sayıyı iki ile çarp ve enter tuşuna bas");
            //Console.ReadLine();
            //Console.WriteLine("Bulduğun sonucu belirlediğin bir ikinci bir sayı ile topla ve bu ikinci sayıyı ekrana yazdıktan sonra enter tuşuna bas");
            //double number = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Bulduğun sonucu ikiye böl");
            //Console.ReadLine();

            //Console.WriteLine("Bulduğun sonuçtan ilk tuttuğun sayıyı çıkar");
            //Console.ReadLine();
            //string tahmin = (number / 2).ToString();
            //Console.WriteLine("Galiba tahmin ediyorum... Bulduğum sayı = " + tahmin + " mi/mu?");
            //Console.ReadLine();


            //Switch case 

            Console.WriteLine("Hangi meyveyi almak istiyorsunuz? ");
            string fruit = Console.ReadLine();

            switch (fruit)
            {
                case "elma":
                case "armut":
                    Console.WriteLine("1 Lira");
                    break;
                case "çilek":
                    Console.WriteLine("2 Lira");
                    break;

                case "muz":
                    Console.WriteLine("3 Lira");
                    break;

                default:
                    Console.WriteLine("4 Lira");
                    break;



            }





        }
    }
}
