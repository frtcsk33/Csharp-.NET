using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] books = { "Simyacı", "Bülbülü öldürmek", "ölüm sessiz geldi", "sefiller", "Minyeli Abdullah", "Semerkant", "İskambil kağıtlarının esrarı", "Beyaz Diş" };

            foreach (string book in books)
            {
                listBox1.Items.Add(book);
            }

        }
    }
}
