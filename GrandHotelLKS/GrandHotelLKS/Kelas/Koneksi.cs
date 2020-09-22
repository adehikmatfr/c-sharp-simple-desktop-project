using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GrandHotelLKS.Kelas
{
    class Koneksi
    {
        SqlConnection con;
        public SqlConnection GetCon() 
        {
            con = new SqlConnection();
            con.ConnectionString = "SERVER=LAPTOP-8VEI6K7E; Initial Catalog=lks2; Integrated Security=true;";
            return con;
        }
        public void debug() 
        {
            con = GetCon();
            try 
            {
                con.Open();
                MessageBox.Show("Connection Succes");
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
