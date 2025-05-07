using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Text = count.ToString();
        }
        int count;
        public void Selamla()
        {
           
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            count++;
            assign();
        }

        public void assign()
        {
            label1.Text = count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count--;
            assign();
            
        }
    }
}
