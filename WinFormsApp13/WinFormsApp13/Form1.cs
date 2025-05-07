using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string name;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            name = button1.Text;
            damage(name, 220);
        }
        public void damage(string dmg, int hasar = 200)
        {
            MessageBox.Show($"{dmg} Tarafından {hasar} hasar verildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            damage(dmg:"büyücü",hasar:250);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            name = button3.Text;
            damage(name,300);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            damage("bıçak");
        }

        /// <summary>
        /// sadece npcler kullanabilir.
        /// </summary>
        public void damage()
        {
            MessageBox.Show(" düşmana 100 hasar verildi");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            damage();
        }
    }
}
