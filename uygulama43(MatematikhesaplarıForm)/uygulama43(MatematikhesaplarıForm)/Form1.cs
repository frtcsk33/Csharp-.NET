using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama43_MatematikhesaplarıForm_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int birkenar, alan, cevre;
            birkenar = Convert.ToInt32(textBox1.Text);
            alan = birkenar * birkenar;
            cevre = birkenar * 4;

            label4.Text = alan.ToString();
            label5.Text = cevre.ToString();

            buton

            //int birkenar;
            //int alan, cevre;
            //int dikalan, dikcevre;
            //int uzun;
                



            //birkenar = Convert.ToInt32(textBox1.Text);

            //alan = birkenar * birkenar;
            //cevre = 4 * birkenar;

            //uzun = Convert.ToInt32(textBox2.Text);

            //dikalan = birkenar * uzun;
            //dikcevre = 2 * (birkenar + uzun);

            //label4.Text = alan.ToString();
            //label5.Text = cevre.ToString();

            //label4.Text = dikalan.ToString();
            //label5.Text = cevre.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            textBox2.Visible = false;

            label1.Text = "KARE";
            panel1.Visible = true;
            button3.visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label1.Text = "DİKDÖRTGEN";
            label2.Text = "Kısa KEnar";
            panel1.Visible = true;

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kısa, uzun, cevre, alan;

            kısa = Convert.ToInt32(textBox1.Text);
            uzun = Convert.ToInt32(textBox2.Text);

            alan = kısa * uzun;
            cevre = 2 * (kısa + uzun);

            label4.Text = alan.ToString();
            label5.Text = cevre.ToString();
        }
    }
}
