﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygualama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1=0, sayi2=0;


            

            sayi1= Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            if (radioButton1.Checked)
            {
                listBox1.Items.Add(sayi1 + sayi2); 

            }
            else
            {
                listBox1.Items.Add(sayi1 - sayi2);
            }

        }
    }
}
