using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //string kullaniciAdi = "frtcsk";
            //string email = "frtcsk2@gmail.com";
            //string sifre = "raskolnikov7";

            //Console.WriteLine("İsminizi giriniz: ");
            //string adOrEmail = Console.ReadLine();

            //Console.WriteLine("Sifre giriniz: ");
            //string sifre2 = Console.ReadLine();

            //bool isTrue = (kullaniciAdi == adOrEmail || adOrEmail == email) && (sifre == sifre2);

            //Console.WriteLine(isTrue); 
            #endregion


            #region MyRegion
            //int kucukKenar = Convert.ToInt32(Console.ReadLine());

            //int buyukKenar = Convert.ToInt32(Console.ReadLine());

            //int cevre = 2*(kucukKenar + buyukKenar);
            //Console.WriteLine(cevre); 
            #endregion

            try
            {
                Console.WriteLine("1. sayıyı giriniz");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2. sayıyı giriniz");
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.Write(number1 * number2);
            }
            //catch (FormatException)
            //{
            //    Console.WriteLine("hatalı giriş yaptınız. Lütfen sayı formatını kullanınız");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("0'a bölünemez");
            //}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            finally
            {
                Console.WriteLine("Burası son durak");
            }



        }
    }
}
