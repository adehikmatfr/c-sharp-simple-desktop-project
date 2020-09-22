using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//gunakan module sql client untuk mnggunakan sql
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Kelas
{
    class Koneksi
    {
        //buat method yang mereturn koneksi
        public SqlConnection GetCon() 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "SERVER=LAPTOP-8VEI6K7E;Initial Catalog=latihan; Integrated Security=true;";
            return con;
        }
        //buat method debug koneksi
        public void DebugCon() 
        {
            SqlConnection con = GetCon();
            try
            {
                con.Open();
                MessageBox.Show("Koneksi Berhasil");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
