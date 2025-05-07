using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama41_form_6_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("İstanbul");
            listBox1.Items.Add("Bursa");
            //comboBox1.Items.Add("İstanbul");
            //comboBox1.Items.Add("Ankara");
        }
    }
}
