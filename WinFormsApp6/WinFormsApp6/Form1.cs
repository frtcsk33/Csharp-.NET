using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] stages = { "1. tencerede suyu kaynatın", "2.Kaynar suya makarnaları atın", "3.Tuz atın", "4.Makarnalar pişince süzgece alın", "5.Tencereye biraz yağ koyduktan sonra makarnaları içine dökün", "6. Afiyet olsun" };
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (index <= stages.Length - 1)
            {
                listBox1.Items.Add(stages[index]);
                index++;
            }
            else
            {
                MessageBox.Show("Tarif tamamlanmıştır.");
            }
            
        }
    }
}
