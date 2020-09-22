using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace LatihanLks2.Kelas
{
    class Query
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;

        Koneksi kon=new Koneksi();

        public int InUpDel(String query)
        {
            con = kon.GetCon();
            try 
            {
                con.Open();
                cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                return 1;
            } 
            catch(Exception e)
            {
                MessageBox.Show("gagal");
                return 0;
            } 
            finally
            {
                con.Close();
            }
        }

        public void ShowAll(String query, String table, DataGridView dgv) 
        {
            con = kon.GetCon();
            try 
            {
                con.Open();
                cmd = new SqlCommand(query,con);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds,table);
                dgv.DataSource = ds;
                dgv.DataMember = table;
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

        public void ShowBox(String query,String fild,ComboBox cb) 
        {
            con = kon.GetCon();
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
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
