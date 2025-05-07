using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string secretKey;
        Random random = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            string guess = textBox1.Text;
            if(guess == secretKey)
            {
                MessageBox.Show("Kazandınız");
            }
            else
            {
              char[] letters =  guess.ToCharArray();
                string matchedLetters = "";

                foreach (char letter in letters)
                {
                    if (secretKey.Contains(letter) && !matchedLetters.Contains(letter))
                    {
                        matchedLetters += $"{letter},";
                    }
                }
                if(matchedLetters != "")
                {
                    matchedLetters = matchedLetters.TrimEnd(',');
                    listBox1.Items.Add(matchedLetters);
                }
            }
        }



        
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] secretKeys = {"dolap", "bilgisayar","fare", "kalem"};
            secretKey = secretKeys[random.Next(0, 4)];
            button2.Visible = true;
            textBox1.Visible = true;
            textBox1.Text = "";

        }
    }
}
