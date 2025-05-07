using System;

namespace ders9_ilyakus_
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ad, soyad;
            //int vize, final;
            //double sonuc;
            //Console.Write("Adınız: ");
            //ad = Console.ReadLine();
            //Console.Write("soyadınız: ");
            //soyad = Console.ReadLine();
            //Console.Write("vize: ");
            //vize = Convert.ToInt32(Console.ReadLine());
            //Console.Write("final: ");
            //final = Convert.ToInt32(Console.ReadLine());
            //sonuc = vize * 0.4 + final * 0.6;


            //Console.Write("adı: {0}\nsoyadı:   {1}\nvize:   {2}\nfinal: {3}\nnotunuz: {4}",ad,soyad,vize,final,sonuc);
            //Console.ReadLine();


            //Console.Write("kelime giriniz: ");
            //string kelime= Console.ReadLine();
            //int uzunluk = kelime.Length;
            //Console.WriteLine("girdiğiniz kelimenin uzunluğu: " + uzunluk);


            string metin;
            Console.WriteLine("metni giriniz: ");
            metin = Console.ReadLine();
            string[] kelimeler = metin.Split(' ');
            Console.WriteLine("Kelime sayısı: " + kelimeler.Length);

            foreach( string kelime in kelimeler){
                Console.WriteLine(kelime);

            }
            
            string phrase = "The quick brown fox jumps over the lazy dog.";
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
            Console.WriteLine(word);
            }

        }
            

}
}
