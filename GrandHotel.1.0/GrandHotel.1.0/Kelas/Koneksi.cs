using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GrandHotel._1._0.Kelas
{
    class Koneksi
    {
        SqlConnection con;
        public SqlConnection GetCon() 
        {
            con = new SqlConnection();
            con.ConnectionString = "SERVER=;Initial Catalog=lks; Integrated Security=true;";
            return con;
        }

        public void debug() 
        {
            con = GetCon();
            try 
            {
             con.Open();
             MessageBox.Show("Succes");
            }
            catch(Exception e)
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
