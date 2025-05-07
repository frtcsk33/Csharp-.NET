using System;
using System.Collections.Generic;

namespace uygulama31
{
    class Program
    {
        class Ders
        {
            public string Kod { get; private set; }
            public string Ad { get; private set; }
            public string Aciklama { get; private set; }

            public Ders(string kod, string ad, string aciklama)
            {
                Kod = kod;
                Ad = ad;
                Aciklama = aciklama;
            }

            public void BilgiYazdir()
            {
                Console.WriteLine($"Ders Adi: {Ad}");
                Console.WriteLine($"Aciklama: {Aciklama}");

            }

            public bool KodEslesiyor(string aranankod)
            {
                return Kod == aranankod;
            }

        }

        static void Main(string[] args)
        {
            List<Ders> dersler = new List<Ders> {

                new Ders ders1 = {"Mat 101", "Matematik 1", "Temel Matematik Dersi", "Amfi 4", "PRF.AHMET YULMAZ"},
                new Ders ders2{"FIZ101", "Fizik 1", "Temel Fizik Dersi", "AMFİ1", "AYŞE eldem"},
                new Ders ders3{"CSE101", "Fizik 1", "Temel Fizik Dersi", "AMFİ1", "uğur erkan"},
            };

            Console.WriteLine("Ders kodu: ");
            string arananKod = Console.ReadLine();

            Ders arananDers = GetDersBilgisi(dersler, arananKod);

            if(arananDers != null)
            {
                arananDers.BilgiYazdir();
            }
            else
            {
                Console.WriteLine("Ders bulunamadı.");
            }
        }

        static Ders GetDersBilgisi(List<Ders> dersler, string arananKod)
        {
            return dersler.Find(d => d.KodEslesiyor(arananKod));
        }


    }
}
