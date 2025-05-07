using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PROJE
{
    public partial class Form1 : Form
    {
        DateTime biletTarihValue = DateTime.Now;
        string connectionString = "Data Source=FiratC\\SQLEXPRESS;Initial Catalog=CINEMA;Integrated Security=True";
        
        public Form1()
        {
            //this.BackgroundImage = Properties.Resources.two;
            //this.BackgroundImageLayout = ImageLayout.Stretch;
            //this.BackColor = Color.Transparent;
            InitializeComponent();
            FillComboBox();
          
        }

        private void FillComboBox()
        {
            comboBox2.Items.Clear();
            string sqlQuery = "SELECT filmAdi FROM Filmler";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            comboBox2.Items.Add(row["filmAdi"].ToString());
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Veri çekme hatası");
                }
            }
        }

        private void biletData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string selectedFilmAdi = comboBox2.SelectedItem.ToString();
                    int selectedSeat = Convert.ToInt32(comboBoxKoltukNo.SelectedItem);

                  
                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Musteriler.musteriAdi, Musteriler.musteriSoyadi, Filmler.filmAdi, Filmler.filmTuru, Filmler.filmSure, Bilet.koltukNo,  Bilet.biletTarih, Bilet.biletFiyat FROM Bilet LEFT JOIN Musteriler ON Bilet.musteriID = Musteriler.musteriID INNER JOIN Filmler ON Bilet.filmID = Filmler.filmID ", con))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@FilmAdi", selectedFilmAdi);
                        adapter.SelectCommand.Parameters.AddWithValue("@KoltukNo", selectedSeat);

                        DataTable biletTable = new DataTable();
                        adapter.Fill(biletTable);

                        dataGridView1.DataSource = biletTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri çekme hatası: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int biletFiyatValue = 100;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    int selectedSeat = Convert.ToInt32(comboBoxKoltukNo.SelectedItem);
                    string selectedFilmAdi = comboBox2.SelectedItem.ToString();

                    // Müşteri ekliyorum
                    string sqlMusteri = "INSERT INTO Musteriler (musteriAdi, musteriSoyadi) VALUES(@Param1, @Param2)";
                    using (SqlCommand cmdMusteri = new SqlCommand(sqlMusteri, con))
                    {
                        cmdMusteri.Parameters.AddWithValue("@Param1", textBox1.Text);
                        cmdMusteri.Parameters.AddWithValue("@Param2", textBox2.Text);

                        cmdMusteri.ExecuteNonQuery();
                    }

                    // Eklenen müşterinin musteriID'sini alıyorum
                    string musteriIdQuery = "SELECT musteriID FROM Musteriler WHERE musteriAdi = @MusteriAdi AND musteriSoyadi = @MusteriSoyadi";
                    using (SqlCommand cmdMusteriId = new SqlCommand(musteriIdQuery, con))
                    {
                        cmdMusteriId.Parameters.AddWithValue("@MusteriAdi", textBox1.Text);
                        cmdMusteriId.Parameters.AddWithValue("@MusteriSoyadi", textBox2.Text);
                        int musteriID = (int)cmdMusteriId.ExecuteScalar();

                        // Bilet ekliyorum
                        string sqlBilet = "INSERT INTO Bilet(filmID, koltukNo, biletTarih, biletFiyat, musteriID) VALUES(@FilmID, @KoltukNo, @BiletTarih, @BiletFiyat, @MusteriID)";
                        using (SqlCommand cmdBilet = new SqlCommand(sqlBilet, con))
                        {
                            cmdBilet.Parameters.AddWithValue("@FilmID", GetFilmID(selectedFilmAdi, con));
                            cmdBilet.Parameters.AddWithValue("@KoltukNo", selectedSeat);
                            cmdBilet.Parameters.AddWithValue("@BiletFiyat", biletFiyatValue);
                            cmdBilet.Parameters.AddWithValue("@BiletTarih", biletTarihValue);
                            cmdBilet.Parameters.AddWithValue("@MusteriID", musteriID);

                            cmdBilet.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri ekleme hatası: {ex.Message}");
            }

            label7.Text = 100.ToString() + " TL";
            biletData();
        }

        //FilmID'sini alıyorum
        private int GetFilmID(string filmAdi, SqlConnection con)
        {
            string filmIdQuery = "SELECT filmID FROM Filmler WHERE filmAdi = @FilmAdi";
            using (SqlCommand filmIdCmd = new SqlCommand(filmIdQuery, con))
            {
                filmIdCmd.Parameters.AddWithValue("@FilmAdi", filmAdi);
                return (int)filmIdCmd.ExecuteScalar();
            }
        }


    }
}
