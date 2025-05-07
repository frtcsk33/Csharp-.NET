using System;

namespace uygulama7_diziler3_foreach_
{
    class Program
    {

        static void Main(string[] args)
        {
            //string[] sehirler = { "Mersin", "İzmir", "Kocaeli", "Artvin", "Ankara", "Erzurum", "Şanlıurfa" };

            //foreach(string i in sehirler)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] sayilar = { 1, 4, 8, 52, 41, 75, 126, 85, 24 };
            //foreach(int i in sayilar)
            //{
            //    Console.WriteLine(i);
            //}


            //int[] sayilar = { 7,45,25,41 };
            //int toplam = 0;
            //foreach(int i in sayilar)
            //{
            //    toplam = toplam + i;
            //}
            //Console.WriteLine("Toplam: " + toplam);


            //int[] sayilar = { 7, 2, 4, 6, 7 };
            //int toplam = 0;
            //foreach(int i in sayilar)
            //{
            //    toplam = toplam + i;

            //}
            //Console.WriteLine("toplam: " + toplam);


            //int[] rakamlar = { 1, 2, 7, 5, 4, 8, 6, 9, 3 };

            //foreach(int sayi in rakamlar)
            //{
            //    if(sayi % 2 == 0)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //}

            //int[] degerler = { 1, 2, 3, 4, 5, 6 };

            //int sonuc=1;

            //foreach (int i in degerler )
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine("6 sayısının faktöriyeli "+ sonuc);


            //int[] sayilar = { 4, 1, 7, -8, 23, 14, 51, 84, -75, 26, -8, 9 };
            //foreach(int i in sayilar)
            //{
            //    if(i>10 && i<30 && i % 2 == 0 )
            //    {
            //        Console.WriteLine(i);
            //    }

            //}


            int[] sayilar = new int[5];

            for(int i=0; i<5; i++)
            {
                Console.Write("Sayıyı girin: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

            }

            //Array.Reverse(sayilar);
            Array.Sort(sayilar);
            //foreach(int i in sayilar)
            //{
            //    Console.WriteLine(i);

            //}
            Console.WriteLine("En küçük eleman: " + sayilar[0]);
            Console.WriteLine("En büyük eleman: " + sayilar[4]);
            Console.WriteLine("dizinin boyutu: " + sayilar.Length);
            //Console.Write(sayilar[0]);
        }
    }
}
