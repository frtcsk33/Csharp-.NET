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
    internal class Products
    {
        //select metodu
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("UrunListele",Tools.Baglanti);

            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;

        }

        //insert metodu

        public static bool Insert(Product u)
        {
            SqlCommand cmd = new SqlCommand("UrunEkle", Tools.Baglanti);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ProductName",u.ProductName);

            cmd.Parameters.AddWithValue("@UnitPrice", u.UnitPrice);

            cmd.Parameters.AddWithValue("@UnitsInStock", u.Stock);

         return Tools.ExecuteNonQuery(cmd);



          

        }

    }
}
