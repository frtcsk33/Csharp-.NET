using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string sample = "burası 1. satır \n2. satır";
            //string sample = "Yunus Emre der ki \"Sevelim, sevilelim, bu dünya kimseye kalmaz.\" ";
            //string sample = @"burası 1.satır
            //burası 2. satır";
            string name = "abdullah";
            string surname = "yeşil";
            string sample = $"Merha benim adım {name}. Soyadım {surname}";
            MessageBox.Show(sample);
        }
    }
}
