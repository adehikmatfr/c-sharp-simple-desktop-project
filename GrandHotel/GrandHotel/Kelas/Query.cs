using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace GrandHotel.Kelas
{
    class Query:Koneksi
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;

        public Boolean InUpDel(String query) 
        {
            con = GetCon();
            try
            {
             con.Open();
             cmd=new SqlCommand(query,con);
             cmd.ExecuteNonQuery();
             return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public void ShowAll(String query,String table, DataGridView dgv)
        {
            con = GetCon();
            try 
            {
                con.Open();
                cmd = new SqlCommand(query,con);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds,table);
                dgv.DataSource = ds;
                dgv.DataMember=table;
                dgv.Refresh();
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

        public void ShowBox(String query, String fild, ComboBox cb) 
        {
            con = GetCon();
            try
            {
                con.Open();
                cmd = new SqlCommand(query,con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                        cb.Items.Add(dr[fild]);
                    }
                }
                else 
                {
                    cb.Items.Add("Null");
                }
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
