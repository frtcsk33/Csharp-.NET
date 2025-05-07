using System;
using System.Collections.Generic;

namespace ders20_ilya_kus_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<personel> list = new List<personel>();

            personel personel1 = new personel();
            personel1.ad = "Fırat";
            personel1.maas = 1200;
            list.Add(personel1);

            personel personel2 = new personel();
            personel2.ad = "Veli";
            personel2.maas = 2000;
            list.Add(personel2);

            personel personel3 = new personel();
            personel3.ad = "Alperen";
            personel3.maas = 5000;
            list.Add(personel3);

            foreach (var item in list)
            {
                if (item.maas <=1300)
                {
                    item.unvan = "işçi";
                    Console.WriteLine(item.ad + " " + item.unvan + " " + item.maas);
                }
                if (item.maas > 1300 && item.maas <=2000)
                {
                    item.unvan = "Personel";
                    Console.WriteLine(item.ad + " " + item.unvan + " " + item.maas);
                }
                if (item.maas > 2000)
                {
                    item.unvan = "Müdür";
                    Console.WriteLine(item.ad + " " + item.unvan + " " + item.maas);
                }
            }
        }
    }
}
