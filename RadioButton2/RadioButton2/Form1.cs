using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi1 = 10;
        int sayi2 = 2;
        int topla, fark, carp, bol;

        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            carp = sayi1 * sayi2;
            label1.Text = carp.ToString();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            bol = sayi1 / sayi2;

            label1.Text = bol.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            topla = sayi1 + sayi2;

            label1.Text = topla.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            fark = sayi1 - sayi2;
            label1.Text = fark.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
