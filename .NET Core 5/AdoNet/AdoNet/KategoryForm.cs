using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class KategoryForm : Form
    {
        public KategoryForm()
        {
            InitializeComponent();
        }



        private void KategoryForm_Load(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection("Server=.;Database=Northwind;Integrated Security=true");

            SqlCommand komut = new SqlCommand("select * from Categories", baglanti);

            baglanti.Open();

            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                string adi = rdr["CategoryName"].ToString();
                string tanimi = rdr["Description"].ToString();
                listBox1.Items.Add(string.Format("{0}-{1}", adi, tanimi));
            }
            baglanti.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
