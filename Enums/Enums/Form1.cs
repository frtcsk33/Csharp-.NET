using Enums.Enums;
using Enums.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(Difficulty.Easy);
            comboBox1.Items.Add(Difficulty.Medium);
            comboBox1.Items.Add(Difficulty.Hard);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.userName = textBox1.Text;
            game.difficulty = (Difficulty)comboBox1.SelectedItem;
            game.gender = radioButton1.Checked ? Gender.Male : Gender.Female;

        }
    }
}
