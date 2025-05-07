using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numbers = new int[3];
        string[] cities = new string[3] { "İstanbul", "Mersin ","Ankara"};
        int[] ages = { 10, 20, 30 };
        private void button1_Click(object sender, EventArgs e)
        {
            //cities[0] = "Şırnak";
            //cities[1] = "Mersin";
            cities[2] = "İstanbul";
            MessageBox.Show(cities[2]);
            MessageBox.Show(ages[1].ToString());
        }
    }
}
