using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string GetName()
        {
            Random random = new Random();
            int number= random.Next(0, 3);

            return "Abdullah";
        }

        private void button1_Click(object sender, EventArgs e)
        {
          string name =  GetName();
            MessageBox.Show(name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(calculate(4,5).ToString());
        }

        public int calculate(int number1, int number2)
        {
            return number1 * number2;
        }
    }

}
