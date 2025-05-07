using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiDouble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;

            double toplam, fark, carpim, bolum;


            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            toplam = sayi1 + sayi2;
            label7.Text = toplam.ToString();


            fark = sayi1 - sayi2;
            label8.Text = fark.ToString();

            carpim = sayi1 * sayi2;
            label9.Text = carpim.ToString();

            bolum = sayi1 / sayi2;
            label10.Text = bolum.ToString();






        }

        
    }
}
