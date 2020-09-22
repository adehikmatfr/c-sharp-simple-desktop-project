using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using sql Client;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace WindowsFormsApplication2.Kelas
{
    //buat query extends koneksi
    class Query : Koneksi
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;

        //buat pungsi query
        public int InUpDel(String query) 
        {
            con = GetCon();
            try
            {
                con.Open();
                cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
        //buat fungsi tampil data semua
        public void ShowAll(String query,String table,DataGridView dg) 
        {
            con = GetCon();
            try
            {
                con.Open();
                cmd = new SqlCommand(query,con);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds,table);
                dg.DataSource = ds;
                dg.DataMember = table;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                dg.DataMember = null;
                dg.DataMember = null;
            }
            finally
            {
                con.Close();
            }
        }
        //buat fungsi tampil ke chackbox
        public void ShowBox(String query,String fild,ComboBox cb) 
        {
            con = GetCon();
            try
            {
                con.Open();
                cmd = new SqlCommand(query,con);
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                  while(dr.Read())
                  {
                      cb.Items.Add(dr[fild]);
                  }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
