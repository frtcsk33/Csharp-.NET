using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Models;

namespace WindowsFormsApp4
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

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = textBox1.Text;
            MessageBox.Show($"{product.ProductName} ürünü {product.CreatedDate} tarihinde girilmiştir");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product(textBox1.Text);
            MessageBox.Show($"{product.ProductName} ürünü {product.CreatedDate} tarihinde girilmiştir");

        }
    }
}
