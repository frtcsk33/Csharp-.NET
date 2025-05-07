using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //int[] numbers = { 1, 2, 3 };
            Add(1,2,3);
             
        }

        public void Add( params int[] numbers)
        {
            int result = 0;

            foreach (int number in numbers)
            {
                result += number;
            
            }
            MessageBox.Show(result.ToString());
        }
    }
}
