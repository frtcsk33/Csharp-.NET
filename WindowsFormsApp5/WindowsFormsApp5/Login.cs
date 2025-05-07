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
    public partial class Login : Form
    {
        public Login(User _user) //Login formuna User sınıfından bir nesne yolladık
        {
            InitializeComponent();
            user = _user; //nesneyi User sınıfından oluşan user nesnesine aktardık
        }
         
        User user; //user'ı türettik
        private void Login_Load(object sender, EventArgs e)
        {
            label1.Text = $"Hoş geldiniz {user.userName}"; //türettiğimiz nesnenin ismini ekranda gösterdik
        }
    }
}
