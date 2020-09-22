using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GrandHotel._1._1.Kelas
{
    class Koneksi
    {
        SqlConnection con;
        public SqlConnection GetCon() 
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=; Initial Catalog=lks: Integrated Security=true;";
            return con;
        }

        public void debug()
        {
            con = GetCon();
            try
            {
                con.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message,"INpormasi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
