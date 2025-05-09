﻿using Sinema_Otomasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otomasyonu
{
    public partial class Form2 : Form
    {
        public Form2(List<Movie> _movies, Form1 _form1)
        {

            InitializeComponent();
            movies = _movies;
            form1 = _form1;
        }
        List<Movie> movies;
        Form1 form1;
        Movie selectedMovie;
        Session selectedSession;


        public void ListDetail(int movieIndex, string _time, string _date)
        {
            selectedMovie = movies[movieIndex];
            selectedSession = selectedMovie.sessions.Find(s => s.Date == _date && s.time == _time);

            lblTime.Text = $"{_date} - {_time} ";
            lblMinute.Text = selectedMovie.minute;
            lblPrice.Text = selectedMovie.price.ToString()+ " tl";
            pbSelectedPicture.Image = Image.FromFile(selectedMovie.picturePath);
            lblCategory.Text = selectedMovie.category.ToString();
            CheckChairsStatus();

        }

        private void CheckChairsStatus()
        {
            foreach (Control item in grbChairs.Controls)
            {
                if(item is Button)
                {

                    string row = item.Tag.ToString();
                    string number = item.Text;

                    item.Enabled = true;
                    foreach (Chairs chair in selectedSession.chairs)
                    {
                        if(chair.row == row && chair.number == number)
                        {
                            if (chair.status )
                            {
                                item.BackColor = Color.DarkRed;
                                item.Enabled = false;
                            }
                            else
                            {
                                item.BackColor = Color.LightGreen;
                            }
                            break;
                        }
                    }
                }
            }
        }

        List<Chairs> chairs = new List<Chairs>();

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string row = button.Tag.ToString();
            string number = button.Text;
            Chairs chair = selectedSession.chairs.Find(c => c.row == row && c.number == number );
            if (button.BackColor.Name != "Blue")
            {
                chairs.Add(chair);
                button.BackColor = Color.Blue;
            }
            else
            {

                chairs.Remove(chair);
                button.BackColor = Color.LightGreen;

            }

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
           if(chairs.Count == 0)
            {
                MessageBox.Show("Lütfen en az 1 koltuk seçiniz.");
                return;
            }
            Sales sales = new Sales();
            sales.count = chairs.Count;
            sales.movieName = selectedMovie.movieName;
            sales.sessionTime = $"{selectedSession.Date} - {selectedSession.time}";
            sales.totalPrice = CalculatePrice();

            foreach (Chairs chair in chairs)
            {
                chair.status = true;
            }


            MessageBox.Show(sales.ToString());

            ChangePage();

        }

        private void ChangePage()
        {
            rbSmall.Checked = rbMedium.Checked = rbLarge.Checked = false;
            chairs.Clear();
            this.Hide();
            form1.Show();
        }


        private decimal CalculatePrice()
        {
            decimal price = selectedMovie.price * chairs.Count;
            if (rbSmall.Checked)
            {
                price += 3;
            }
            else if (rbMedium.Checked)
            {
                price += 6;
            }
            else if (rbLarge.Checked)
            {
                price += 9;
            }
            return price;
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangePage();
            chairs.Clear();
        }
    }
}
