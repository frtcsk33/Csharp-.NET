using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.userName = "abdullah";
            user.password = "123";
            user.age = 27;
            user.job = "developer";
            MessageBox.Show($"Kullanıcı adı: {user.userName} - Şifre: {user.password}");

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tree tree = new Tree();
            tree.type = "elma";
            tree.age = 12;
            tree.color = "Green";
            tree.height = 127;
            MessageBox.Show($"Ağacın tipi: {tree.type}\n Yaşı: {tree.age} \n Rengi: {tree.color}\n Uzunluğu: {tree.height}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.userName = textBox1.Text;
            user.password = textBox2.Text;

            string loginDate = DateTime.Now.ToString();
            user.Login(loginDate);

            User user2 = new User();
            user2.userName = "test";
            user2.password = "123";

            string loginDate2 = DateTime.Now.ToString();

            user2.Login(loginDate2);
        }

        //user details


    }
}
