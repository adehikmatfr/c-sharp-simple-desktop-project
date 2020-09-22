using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//panggil modul sql cient
using System.Data.SqlClient;

namespace Penjualan.Kelas
{
    class Koneksi
    {
        //buat method koneksi
        public SqlConnection GetCon() 
        {
            SqlConnection con = new SqlConnection();
            //dari sql server jika ns ade/sql -> ade\\sql
            con.ConnectionString = "Data Source= LAPTOP-8VEI6K7E; Initial Catalog=db_buku; Integrated Security=True"; 
            return con;
        }

    }
}
