using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phoneNumber = textBox1.Text;
            string phoneLast = Checkphone(phoneNumber);
            if (phoneLast.Contains("Hata"))
            {
                MessageBox.Show(phoneLast);
            }
            else
            {
                MessageBox.Show($"{phoneLast} telefona mesaj gönderilmiştir");
             }
        }

        public string Checkphone(string phone)
        {
            try
            {
                if (phone == "")
                {
                    return "Hata mesajı => lütfen telefon alanını doldurunuz";
                }

                phone = phone.Replace(" ", "");
                phone = phone.Replace("+", "");

                string firstCharacter = phone.Substring(0,1);
                if (firstCharacter == "9")
                {
                    phone = phone.Substring(1,phone.Length-1);

                }
                else if(firstCharacter != "0")
                {
                    phone= "0" + phone;
                }


                if (phone.Length == 11)
                {
                    Convert.ToDouble(phone);
                     return phone;
                }
                return "Hata mesajı => Lütfen girdiğiniz telefon formatını kontrol ediniz (11 hane kabul edilir)";
            }
            catch (FormatException)
            {

                return "Hata mesajı => Lütfen uygun format ile telefon numarası giriniz. ";
            
             }
            catch (Exception)
            {
                return "hata mesajı => Bilinmeyen hata lütfen telefon numarasını tekrar giriniz.";
            }
           
        }


        // 05535552222

        // 
        // 0554 445 32 23
        //+90 555 234 24 43
        //90343252353254
        //55564324323
        //assadad
    }
}
