using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilyakus_ders21_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void reset_time()
        {
            string[] a = new string[4];
            a[0] = "00";
            a[1] = "00";
            a[2] = "00";
            a[3] = "00";

            label6.Text = string.Join(":", a);
            
        }

        public void set_time()
        {
            string[] a = new string[3];
            a[0] = DateTime.Now.Hour.ToString("");
            a[1] = DateTime.Now.Hour.ToString("");
            a[2] = DateTime.Now.Hour.ToString("");

            if (TabControl.SelectedTap == tabPage1)
                label2.Text = string.Join(":", a);
            else if (TabControl.SelectedTap == tabPage2)
            {
                label7.Text = string.Join(":", a);
            }

            string gun = DateTime.Now.DayOfWeek.ToString();
            string tr_gun = "Pazar";

            switch (gun)
            {
                case "Monday":
                    tr_gun = "Pazartesi";
                    break;

                case "Tuesday":
                    tr_gun = "Salı";
                    break;

                case "Wednesday":
                    tr_gun = "Çarşamba";
                    break;

                case "Thursday":
                    tr_gun = "Perşembe";
                    break;

                case "Friday":
                    tr_gun = "Cuma";
                    break;

                case "Saturday":
                    tr_gun = "Cumartesi";
                    break;

                case "Sunday":
                    tr_gun = "Pazar";
                    break;

                    if (TabControl.SelectedTap == tabPage1)
                        label3.Text = tr_gun;
                    else if (TabControl.SelectedTap== tabPage4)
                        label8.Text = tr_gun;


                    a[0] = DateTime.Now.Day.ToString("D2");
                    a[1] = DateTime.Now.Day.ToString("D3");
                    a[2] = DateTime.Now.Day.ToString("D4");
                    
            }


        

      




        }

       
    }
}
