using System;

namespace ders1__
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.Write("Hello world!");
        //    Console.WriteLine("Hello World!");
        //    Console.Read();


        //    string adı = "ali";
        //    string soyadı = "Yılmaz";
        //    Console.WriteLine("ahmet " + soyadı);
        //    Console.Read();
        //}
        static void Main(string[] args) 
        {
            //string adı, soyadı, doğum_yeri, mesleği, telefon_numarasi

            //Console.Write("adı: ");
            //string adi = Console.ReadLine();
            //Console.Write("soyadı: ");
            //string soyadi = Console.ReadLine();
            //Console.Write("doğum yeri: ");
            //string doğum_yeri = Console.ReadLine();
            //Console.Write("mesleği: ");
            //string meslek = Console.ReadLine();
            //Console.Write("telefon numarası: ");
            //string telefon_numarasi = Console.ReadLine();


            //Console.WriteLine("\n\n\n adı: " + adi);
            //Console.WriteLine(" soyadı: " + soyadi);
            //Console.WriteLine("Doğum Yeri: " + doğum_yeri);
            //Console.WriteLine(" telefon: " + telefon_numarasi);
            //Console.WriteLine(" meslek: " + meslek);


            Console.Write("adi: ");
            string adi2 = Console.ReadLine();
            Console.Write("soyadi: ");
            string soyadi2 = Console.ReadLine();
            Console.Write("yaş: ");
            string yas = Console.ReadLine();
            Console.Write("bolum: ");
            string bolum = Console.ReadLine();
            Console.Write("numara: ");
            string no = Console.ReadLine();

            Console.Write("\n\n\n\n ============== \n\n\n");
            //Console.Write("adi: "+ adi2 +"\nsoyadi: " + soyadi2 + "\nyas: " + yas +  "\nbolum: " +bolum+ "\n" +"numara " + no);
            //Console.ReadLine();

            //Console.Write($"adi: {adi2}\nsoyadi: {soyadi2}\nyas: {yas}\nbolum: {bolum}\nnumara: {no}");
            Console.WriteLine("\nAdı:   {0}\nSoyadi: {1}\nYas:    {2}\nBolum:  {3}\nNumara: {4}", adi2, soyadi2, yas, bolum, no);

            Console.ReadLine();
        }
    }
}
