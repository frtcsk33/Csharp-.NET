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

namespace ProdecureUygulama
{
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();

        }

        SqlConnection baglanti = new SqlConnection("Server=FiratC\\SQLEXPRESS;Database=Northwind;Integrated Security=true");

        private void KategoriListesi()
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_KategoriListele", baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;



        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            KategoriListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("prc_KategoriEkle", baglanti);

            
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@adi", txtAdi.Text);
            cmd.Parameters.AddWithValue("@tanim", txtTanim.Text);

            baglanti.Open();


            int etk = cmd.ExecuteNonQuery();

            baglanti.Close();

            if (etk > 0)
            {
                MessageBox.Show("Ürün başarılı bir şekilde eklenmiştir");
                KategoriListesi();
            }
            else
            {
                MessageBox.Show("Ürün eklenemedi!");
            }


        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                SqlCommand komut = new SqlCommand("prc_KategoriSil", baglanti);

                komut.CommandType = CommandType.StoredProcedure;
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CategoryID"].Value);

                komut.Parameters.AddWithValue("@kID", id);

                baglanti.Open();

                int etk = komut.ExecuteNonQuery();

                baglanti.Close();

                if (etk > 0)
                {

                    MessageBox.Show("Kayıt silindi");
                    KategoriListesi();
                }
                else
                {
                    MessageBox.Show("Kayıt silinemedi");
                }

            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand komut = new SqlCommand("prc_KategoriGuncelle", baglanti);

            komut.CommandType = CommandType.StoredProcedure;


            DataGridViewRow row = dataGridView1.CurrentRow; 
           
            komut.Parameters.AddWithValue("@id", row.Cells["CategoryID"].Value);
            komut.Parameters.AddWithValue("@adi", row.Cells["CategoryName"].Value);
            komut.Parameters.AddWithValue("@tanim", row.Cells["Description"].Value);

            baglanti.Open();

            int etk = komut.ExecuteNonQuery();
            baglanti.Close();

            if (etk > 0)
            {
                MessageBox.Show("Kayıt başarıyla güncellenmiştir");

                KategoriListesi();
            }
            else
            {
                MessageBox.Show("Kayıt güncellenirken bir hata oluştu");
            }

        }
    }
}
