using System;
using System.Collections.Generic;

namespace uygulama27
{
    class Program
    {
        static void Main(string[] args)
        {

            List<personel> Calisanlar = new List<personel>();



            personel personel1 = new personel();

            personel1.isim = "Ersin cem";
            personel1.maas = 26.500;
           
            Calisanlar.Add(personel1);


            personel personel2 = new personel();

            personel2.isim = "Fırat";
            personel2.maas = 50.000;
            
            Calisanlar.Add(personel2);


            personel personel3 = new personel();

            personel3.isim = "alperen";
            personel3.maas = 50.000;
            
            Calisanlar.Add(personel3);

            foreach(var item in Calisanlar)
            {
                if(item.maas > 40.000)
                {
                    item.unvan = "Müdür";
                    Console.WriteLine(item.isim +" " + Convert.ToDouble(item.maas )+ "  " + item.unvan);

                }
                if(item.maas < 40.000 && item.maas > 20.000)
                {
                    item.unvan = "işçi";
                    Console.WriteLine(item.isim + " " + Convert.ToDouble(item.maas)+ "  " + item.unvan);
                }
            }

        }
    }
}
