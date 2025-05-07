using Polymorphism2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tm.Start();
        }

        Human human = new Human();
        Ork ork = new Ork();
        Elf elf = new Elf();
        private void tm_Tick(object sender, EventArgs e)
        {
            label1.Left += human.GetSpeed();
            label2.Left += ork.GetSpeed();
            label3.Left += elf.GetSpeed();
            if (label1.Right >= label4.Left)
            {
                tm.Stop();
                MessageBox.Show("İnsan kazandı.");
                
            }
            else if (label2.Right >= label4.Left) 
            {
                tm.Stop();
                MessageBox.Show("Ork kazandı");
              
            }
            else if(label3.Right >= label4.Left)
            {
                tm.Stop();
                MessageBox.Show("Elf kazandı.");
                
            }
        }
    }
}
