using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama36_windows_form_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {

            try
            {
               if(txtName.Text == "")
                {
                    MessageBox.Show("Lütfen boş bırakmayınız");

                }
                else
                {
                   int number = Convert.ToInt32(txtName.Text);

                    if (number > 100)
                    {
                    MessageBox.Show("100'den büyük bir sayı girdiniz");
                    txtName.Clear();
                    }

                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen tam sayı giriniz... ");
                txtName.Clear();
            }
           


            //string digit = txtName.Text;



            //string name = txtName.Text;
            //this.Text = name;

            //textBox1.Text = name
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
