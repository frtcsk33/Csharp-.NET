using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        Timer myTimer;
        int dakika = 0;
        int saniye = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {

            /* label1.Text = DateTime.Now.Second.ToString("D2");*/ // Display seconds with leading zero
                                                                   //int sayi = Convert.ToInt32(label1.Text);
                                                                   //sayi++;

            //label1.Text = sayi.ToString();

            //if(sayi == 60)
            //{
            //    sayi = 0;
            //    label1.Text = sayi.ToString();

            //    dakika++;
            //    label2.Text = dakika.ToString();



            //}
           
            int salise = Convert.ToInt32(label6.Text);
            salise++;

            label6.Text = salise.ToString();
             myTimer.Interval = 100;

            if(salise == 9)
            {
                
                salise = 0;
                label6.Text = salise.ToString();

                saniye++;
                label1.Text = saniye.ToString();
                myTimer.Interval = 1000;
            }


            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            myTimer = new Timer();
            myTimer.Interval = 100; // Set the interval to 1 second (1000 milliseconds)
            myTimer.Tick += MyTimer_Tick;
            myTimer.Start();

        }

    }
}
