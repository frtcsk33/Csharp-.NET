using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "abdullah";
            object sample = name;
            int number = 5;
            object sample2 = number;

            name = sample.ToString();
            number = Convert.ToInt32(sample2);

            name = sample as string;
            name = (string)sample;

            object sampleListBox = listBox1;
            ListBox a = sampleListBox as ListBox;

            listBox1.Items.Add(50.3);
        }
    }
}
