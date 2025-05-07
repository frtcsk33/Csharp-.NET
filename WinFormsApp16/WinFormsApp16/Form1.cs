using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int number = 20;



        public void SendCopy(int copyNumber)
        {
            copyNumber = 40;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendCopy(number);
            MessageBox.Show(number.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refCopy(ref number);
            MessageBox.Show(number.ToString());
        }


        public void refCopy(ref int refCopy)
        {
            refCopy = 50;
        }
    }
}
