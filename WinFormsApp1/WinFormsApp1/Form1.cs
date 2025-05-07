using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int age;
        public Form1()
        {
            InitializeComponent();
        }
        int number;
        
        private void btnClick_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show((++number).ToString());
        }

        

    }
}
