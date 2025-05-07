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

namespace DisconnectedMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=FIRATC\\SQLEXPRESS;Database=Northwind;Integrated Security=true");
        private void Form1_Load(object sender, EventArgs e)
        {
            UrunListesi();

        }

        private void UrunListesi()
        {
            //disconnected mimari ile veri listeleme işlemi
            SqlDataAdapter adp = new SqlDataAdapter("select * from Products", baglanti);

            DataTable dt = new DataTable();
            //DataSet ds = new DataSet();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;


            dataGridView1.Columns["ProductID"].Visible = false;

            dataGridView1.Columns["CategoryID"].Visible = false;
            dataGridView1.Columns["SupplierID"].Visible = false;
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adi = txtUrunAdi.Text;
            decimal fiyat = nudFiyat.Value;
            decimal stok = nudStok.Value;

            if (adi == "" || fiyat == null || stok == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
                return;
            }

            SqlCommand komut = new SqlCommand();

            komut.CommandText = string.Format("insert products (ProductName,UnitPrice,UnitsInStock) values('{0}',{1},{2})", adi, fiyat, stok);

            komut.Connection = baglanti;

            baglanti.Open();
            int etkilenen = komut.ExecuteNonQuery();
            //etkilenen 0 dan büyükse sorguda hata yoktur ve başarılı bir şekilde kayıt eklenmitir.
            if (etkilenen > 0)
            {

                MessageBox.Show("Kayıt Başarılı bir şekilde eklenmiştir.");
                UrunListesi();

            }
            else
            {
                MessageBox.Show("Kayıt ekleme sırasında hata meydana geldi.");
            }
            baglanti.Close();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            KategoriForm kf = new KategoriForm();
            kf.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview'da seçili satırı alma işlemi

            txtUrunAdi.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();


            txtUrunAdi.Tag = dataGridView1.CurrentRow.Cells["ProductID"].Value;

            nudFiyat.Value = (decimal)dataGridView1.CurrentRow.Cells["UnitPrice"].Value;

            nudStok.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["UnitsInStock"].Value);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("Update Products Set ProductName ='{0}' , UnitPrice ={1} , UnitsInStock={2} where ProductID={3}", txtUrunAdi.Text, nudFiyat.Value, nudStok.Value, txtUrunAdi.Tag);

            komut.Connection = baglanti;
            baglanti.Open();


            try
            {
                int etk = komut.ExecuteNonQuery(); baglanti.Close();

                if (etk > 0)
                {
                    MessageBox.Show("Kayıt güncellendi");
                    UrunListesi();
                }
                else
                {
                    MessageBox.Show("kayıt güncellenirken hata     oldu");
                }
            }
            catch (Exception ex)
            {
                baglanti.Close();

                MessageBox.Show("kayıt güncellenirken hata     oldu" + ex.Message);

            }





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);

                SqlCommand cmd = new SqlCommand(string.Format("Delete products Where ProductID={0}",id),baglanti);

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
