using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GUI.Class
{
    class Koneksi
    {
        public SqlConnection GetCon() 
        {
            SqlConnection con;
            con = new SqlConnection();
            con.ConnectionString = "SERVER=LAPTOP-8VEI6K7E; Initial Catalog=lks; Integrated Security=true";
            return con;
        }

        public String debug()
        {
            SqlConnection con;
            con = GetCon();
            try 
            {
                con.Open();
                return "Koneksi Berhasil";
            }catch(Exception e)
            {
                return "Koneksi Gagal "+e.ToString();
            }
        }
    }
}
