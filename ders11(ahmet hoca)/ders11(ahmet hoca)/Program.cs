using System;

namespace ders11_ahmet_hoca_
{
    class Program
    {
        static void Main(string[] args)
        {
            //girilen sayı kadar fibonacci sayısı yazacak örnk: 5 girdiyse ilk 5 fibonacci sayısını gösterir.
            int sayi;

            long c = 1;
            long a = 0;
            long b = 1;
            while(true)
            {
                Console.WriteLine("bir sayı giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 0)
                {
                    
                    for (int i = 0; i < sayi; i++)
                    {
                        Console.WriteLine(c);
                        c = a + b;
                        a = b;
                        b = c;   
                    }

                }
                else
                {
                    break;
                }
            }
            
               
            
        }
    }
}
