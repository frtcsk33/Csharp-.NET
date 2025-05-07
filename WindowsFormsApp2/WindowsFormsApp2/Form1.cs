using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Account account = new Account();
        private void button1_Click(object sender, EventArgs e)
        {
            account.userName = textBox1.Text;
            account.race = comboBox1.SelectedItem.ToString();
            account.branch = comboBox2.SelectedItem.ToString();
            account.weapon = textBox2.Text;
            ChangeState(false);
            ChangeVisible(true);
        }

        public void ChangeState(bool state)
        {
            textBox1.Enabled = state;
            textBox2.Enabled = state;
            comboBox1.Enabled = state;
            comboBox2.Enabled = state;
            button1.Enabled = state;
            
        }

        public void ChangeVisible(bool isVisible)
        {
            lblHealt.Visible = lblFirat.Visible=  pictureBox2.Visible = pictureBox1.Visible= button2.Visible=isVisible;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            do
            {
                account.Attack();
                lblHealt.Width -= account.damage;
                MessageBox.Show($"Düşmana {account.damage} kadar hasar verdiniz.");
                if(lblHealt.Width <= 0)
                {
                    MessageBox.Show("Düşmanı yendiniz. ");
                    pictureBox1.Visible = false;
                    break;

                }

            
                lblFirat.Width -= account.damage2;
                MessageBox.Show($"düşman size {account.damage2} kadar hasar verdi");
                if(lblFirat.Width <= 0)
                {
                    MessageBox.Show("Kurt Adam Kazandı.");
                    pictureBox2.Visible = false;
                    break;
                   
                }
            } while (true);
               
          
            
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeVisible(false);
            ChangeState(true);
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            lblFirat.Size = new Size(200, 23);
            lblHealt.Size = new Size(200, 23);
        }
    }
}
