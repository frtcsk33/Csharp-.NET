using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama36_windows_form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("selam!");
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void btnSuccess_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Beni Buldun");
        }

        private void btnFail1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Kaybettiniz");
        }

        private void btnFail2_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Kaybettiniz");
        }

        private void btnFail3_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Kaybettiniz");
        }

        private void btnClick_MouseHover(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Red;
        }

        private void btnClick_MouseLeave(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.White;
          
        }
    }
}
