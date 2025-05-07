using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asdds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;
            vize = Convert.ToDouble(textBox2.Text);

            final = Convert.ToDouble(textBox3.Text);

            ortalama = vize * 0.4 + final * 0.6;

            textBox1.Text = ortalama.ToString();


        }
    }
}
