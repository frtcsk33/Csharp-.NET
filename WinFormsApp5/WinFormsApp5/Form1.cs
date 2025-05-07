using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] cities = new string[] { "İstanbul", "Ankara", "Trabzon"," Kayseri", "Antalya", "Konya"};
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(cities[0]);
            comboBox1.Items.Add(cities[1]);
            MessageBox.Show(cities.Length + " farklı şehir bulunmaktadır");
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            if(comboBox1.SelectedItem.ToString() == cities[0])
            {
                comboBox2.Items.Add(cities[2]);
                comboBox2.Items.Add(cities[3]);
            }
            else
            {
                comboBox2.Items.Add(cities[4]);
                comboBox2.Items.Add(cities[5]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from = comboBox1.SelectedItem.ToString();
            string to = comboBox2.SelectedItem.ToString();
            MessageBox.Show("Kalkış noktanız: "+ from + " Varış noktanız: "+to  +" İyi uçuşlar dileriz.");
        }
    }
}
