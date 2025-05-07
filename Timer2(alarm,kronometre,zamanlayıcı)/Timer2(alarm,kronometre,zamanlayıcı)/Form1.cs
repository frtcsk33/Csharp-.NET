using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer2_alarm_kronometre_zamanlayıcı_
{
    public partial class Form1 : Form
    {
        Timer myTimer;

        public Form1()
        {
            InitializeComponent();
            myTimer = new Timer();
            myTimer.Interval = 1000; // Set the interval to 1 second (1000 milliseconds)
            myTimer.Tick += MyTimer_Tick;
            myTimer.Start(); // Start the timer when the form loads
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Second.ToString("D2"); // Display seconds with leading zero
            label2.Text = DateTime.Now.Minute.ToString("D2"); // Display minutes with leading zero
            label3.Text = DateTime.Now.Hour.ToString("D2");   // Display hours with leading zero
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // You can perform any additional actions when the button is clicked
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // You can add any initialization code here if needed
        }
    }

}
