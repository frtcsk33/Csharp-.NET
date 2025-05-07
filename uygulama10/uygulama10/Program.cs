using System;

namespace uygulama10
{
    class Program
    {
        static void Main(string[] args)
        {


            int max = 0, min = 100, toplam = 0;
            int adet = 10;

            int Not;

            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine("10 adet sayı giriniz ");
                Not = Convert.ToInt32(Console.ReadLine());

                if(Not < 0 || Not > 100)
                {
                    Console.WriteLine("Yanlış not.");

                }
                else
                {
                    if(Not > max)
                    {
                        max = Not;
                    }
                    else if(Not < min)
                    {
                        min = Not;
                    }
                    toplam += Not;
                    
                }

            }

            Console.WriteLine("En yüksek not: {0}", max);
            Console.WriteLine("En düşük not: {0}", min);

            float ortalama = (float)toplam / (float)adet;
            Console.WriteLine("ortalama:  {0}", ortalama);






        }
    }
}
