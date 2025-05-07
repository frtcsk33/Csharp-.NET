using System;

namespace uygulama6_diziler_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write((i + 1).ToString() + " .sayıyı giriniz: ");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());



            //}

            //int enbuyuk;
            //enbuyuk = sayilar[0];

            //for (int i = 1; i < 5; i++)
            //{
            //    if(enbuyuk < sayilar[i])
            //    {
            //        enbuyuk = sayilar[i];
            //    }

            //}
            //Console.Write(enbuyuk)

            string[] isim = new string[3];

            int[] s1 = new int[3];
            int[] s2 = new int[3];
            int[] ort = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.Write(i + 1 + "  öğrencinin adı: ");
                isim[i] = Console.ReadLine();

                Console.Write(i + 1 + " Sınav1: ");
                s1[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write(i + 1 + " Sınav2: ");
                s2[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write(i + 1 + " ort: ");
                ort[i] = (s1[i]+s2[i])/2;

            }
            Console.Write("öğrenci  Sınav1    Sınav2    Ortalama");
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" " + isim[i] + "  " + s1[i] + "     " + s2[i] + "    " + ort[i]);
                
            }
            Console.Read();




        }
    }
}
