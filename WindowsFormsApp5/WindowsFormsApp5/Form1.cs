using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.Models;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1() //form1'in constructor'ı
        {
            InitializeComponent();
        }

        User user; //User sınıfından nesne oluşturuldu
        private void Form1_Load(object sender, EventArgs e)
        {
            user = new User("abdullah", "123"); //nesnenin constructor'ına parametre yollayıp başlattık. İlk değerler atandı.
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            string userName = textBox1.Text; //textboxlara yazılan değerleri username'in içerisine aktardık.
            string password = textBox2.Text; //textboxlara yazılan değerleri username'in içerisine aktardık.

            if (userName == user.userName && password == user.password) //textboxlardan gelen değerlerin Constructor'a gelen değerlere eşit mi değil mi diye baktık
            {
                Login login = new Login(user); //yeni bir form ekranı oluşturduk ve içerisine sınıftan türetilen nesneyi yolladık
                login.Show(); //2.formu gösterdik
                this.Hide();//1.Formu gizledik
            }
            else
            {
                MessageBox.Show("Hatalı giriş"); //hatalı giriş 
            }
        }
    }
}
