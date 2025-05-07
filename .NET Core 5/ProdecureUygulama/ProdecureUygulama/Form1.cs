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
using System.Windows.Forms;

namespace ProdecureUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UrunListesi();
        }

        SqlConnection baglanti = new SqlConnection("Server=FiratC\\SQLEXPRESS;Database=Northwind;Integrated Security=true");



        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UrunEkle", baglanti);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = baglanti;
            cmd.Parameters.AddWithValue("@ProductName", txtUrunadi.Text);
            cmd.Parameters.AddWithValue("@UnitPrice", nudFiyat.Value);
            cmd.Parameters.AddWithValue("@UnitsInStock", nudStok.Value);

            baglanti.Open();

            int etk = cmd.ExecuteNonQuery();

            baglanti.Close();


            if (etk > 0)
            {
                MessageBox.Show("Kayıt eklendi");
                UrunListesi();
            }
            else
            {
                MessageBox.Show("Kayıt eklenirlen hata oluştu");
            }

        }

        private void UrunListesi()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Products ", baglanti);


            DataTable dt = new DataTable();

            adp.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                SqlCommand cmd = new SqlCommand("UrunSil",baglanti);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection = baglanti;

                cmd.Parameters.AddWithValue("@ProductId", dataGridView1.CurrentRow.Cells["ProductID"].Value);

                baglanti.Open();
                int etk = cmd.ExecuteNonQuery();

                baglanti.Close();   

                if(etk > 0)
                {
                    MessageBox.Show("Kayıt silinmiştir");
                    UrunListesi();
                }
                else
                {
                    MessageBox.Show("Kayıt silinirken hata oluştu");
                }

            }
        }
    }
}
