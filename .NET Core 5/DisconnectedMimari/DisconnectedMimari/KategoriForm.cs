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
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=FIRATC\\SQLEXPRESS;Database=Northwind;Integrated Security=true");
            //Integrated security : Windows authentication ile server'a bağlanmayı sağlar.


        /*SqlConnection baglanti = new SqlConnection("Server=FIRATC\\SQLEXPRESS;Database=Northwind;user=sa;pwd=123")*/
       


        private void KategoriForm_Load(object sender, EventArgs e)
        {
            KategoriListesi();
        }

        private void KategoriListesi()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Categories", baglanti);

            DataTable dt = new DataTable();

            adp.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Columns["CategoryID"].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = String.Format("Insert Categories (CategoryName, Description) values('{0}','{1}')", txtKategoriAdi.Text, txtTanimi.Text);
            cmd.Connection = baglanti;

            baglanti.Open();
            int etk = cmd.ExecuteNonQuery();

            baglanti.Close();


            if (etk > 0)
            {
                MessageBox.Show("Kayıt eklenmiştir.");
                KategoriListesi();
            }
            else
            {
                MessageBox.Show("Kayıt eklenemedi. Hata oluştu.");
            }
        }
    }

}
