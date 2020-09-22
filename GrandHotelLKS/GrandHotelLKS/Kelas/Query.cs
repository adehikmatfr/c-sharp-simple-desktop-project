using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace GrandHotelLKS.Kelas
{
    class Query:Koneksi
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;

        public int InUpDel(String query, String Option)
        {
            con = GetCon();
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(Option, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

        public void ShowAll(String query, String table, DataGridView dgv)
        {
            con = GetCon();
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, table);
                dgv.DataSource = ds;
                dgv.DataMember = table;
                dgv.Refresh();
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

        public void ShowBox(String query, String fild, ComboBox cb)
        {
            con = GetCon();
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cb.Items.Add(dr[fild]);
                    }
                }
                else
                {
                    cb.Items.Add(null);
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

        public String GetData(String query, String fild)
        {
            con = GetCon();
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    return dr[fild].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
