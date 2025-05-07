using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form1 : Form
    {
        Timer myTimer;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            myTimer = new Timer();
            myTimer.Interval = 1000; // Set the interval to 1 second (1000 milliseconds)
            myTimer.Tick += MyTimer_Tick;
            myTimer.Start(); // Start the timer when the form loads
           


         
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        { 
            label1.Text = DateTime.Now.Hour.ToString();
            label2.Text = DateTime.Now.Minute.ToString();
            if (label2.Text == comboBox2.Text && label1.Text == comboBox1.Text)
            {
                myTimer.Enabled = false;
                MessageBox.Show("uyuma zamanı!!");
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 24; i++)
            {

                comboBox1.Items.Add(i);
            }

            for(int j= 0; j<60; j++)
            {
                comboBox2.Items.Add(j);
            }
        }
    }
}
