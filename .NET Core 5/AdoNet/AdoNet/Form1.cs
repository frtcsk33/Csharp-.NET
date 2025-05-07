using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Server=FIRATC\\SQLEXPRESS;Database=Northwind;user=sa;pwd=123"; //sql authentication ile bağlanma 
            //baglanti.ConnectionString = "Server=.;Database=Northwind;Integrated Security=true;"; //windows authentication ile bağlanma

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select * from products";
            komut.Connection = baglanti;


            baglanti.Open();
            SqlDataReader rdr = komut.ExecuteReader();

            while (rdr.Read())
            {
                string adi = rdr["ProductName"].ToString();

                string fiyat = rdr["UnitPrice"].ToString();

                string stok = rdr["UnitsInStock"].ToString();

                ListUrunler.Items.Add(string.Format("{0},{1},{2}", adi, fiyat, stok));
            }
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KategoryForm kf = new KategoryForm();

            kf.ShowDialog();

        }

     
    }
}
