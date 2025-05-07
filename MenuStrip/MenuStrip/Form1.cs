using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void johnWickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Köpeğe bulaşmayacaktınız şimdi ananızı bellemeye gelecek kaçın";


            listBox1.Items.Add("John Wick");

            listBox2.Items.Add(toolStripComboBox1.Text);

        }

        
        private void aBoutDeSouffleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Bir çiftin Günlük yaşamı";

            listBox1.Items.Add("A bout de souffle");
            listBox2.Items.Add(toolStripComboBox1.Text);

        }
    }
}
