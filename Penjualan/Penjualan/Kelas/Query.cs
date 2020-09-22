using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Penjualan.Kelas
{
    class Query : Koneksi //buat class menjadi extends
    {
        public int InUpDel(String query) 
        {
            int a;
            SqlCommand cmd;
            SqlConnection con;
            con=GetCon();
            try
            {
                con.Open();
                cmd=new SqlCommand(query,con);
                cmd.ExecuteNonQuery(); //masukan ke dalam database
                return a=1; //succes
            }
            catch (Exception e)
            {
                return a=0; //gagal
            }
            finally 
            {
                con.Close();
            }
            return a;
        }

    }
}
