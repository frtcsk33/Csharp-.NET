using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Models;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Account account = new Account();
            account.userName = textBox1.Text;
            account.password = textBox2.Text;
            MessageBox.Show($"Kullanıcı başarıyla oluşturulmuştur. Kullanıcı adı= {account.userName}");
        }
    }
}
