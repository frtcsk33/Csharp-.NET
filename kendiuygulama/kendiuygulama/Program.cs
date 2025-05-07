using System;

namespace kendiuygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //while (sayi != 0 )
            //{
            //    sum += sayi % 10; //123 --> 3 + 2 + 1
            //    sayi = sayi / 10; 
            //}

            //Console.WriteLine(sum);

            //int faktoriyel = 1;
            //for (int i = sayi; i >= 1; i--)
            //{
            //    faktoriyel *= i;
            //}
            //Console.WriteLine(faktoriyel);


            int[] array1 = { 1, 3, -5, 4 };
            int[] array2 = { 1, 4, -5, -2 };
            int[] multiply = new int[4];
            for (int i = 0; i < array1.Length; i++)
            {
                multiply[i] = array1[i] * array2[i];
                
            }
            foreach(int array in multiply)
            {

                Console.Write(array+ " ");
            }


        }
    }
}
