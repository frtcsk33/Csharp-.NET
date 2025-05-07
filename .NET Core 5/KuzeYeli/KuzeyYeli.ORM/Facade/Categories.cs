using KuzeyYeli.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.ORM.Facade
{
    internal class Categories
    {


        //Select Metodu
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_KategoriListele",Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();

            adp.Fill(dt);
            return dt;
        }


        //Insert Metodu
        public static bool Insert(Category k)
        {
         SqlCommand cmd = new SqlCommand("prc_KategoriEkle",Tools.Baglanti);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@adi", k.CategoryName);
            cmd.Parameters.AddWithValue("@tanim", k.Description);

            //cmd.Connection = Tools.Baglanti;
            //Tools.Baglanti.Open();


            return Tools.ExecuteNonQuery(cmd);      





        }

        private void Form2_Load()
        {

        }        //Update Metodu
        //Delete Metodu


    }
}
