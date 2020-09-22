using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace GUI.Class
{
    class Model
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        Class.Koneksi kon= new Class.Koneksi();
        //untuk query insert update delete
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
                return 0;
            }
            finally
            {
             con.Close();
            }
        }
        //untuk mengecek data dalam database
        public int Cek(String query) 
        {
            con = kon.GetCon();
            try 
            {
                con.Open();
                cmd = new SqlCommand(query,con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return 1;
                }
                else 
                {
                return 0;
                }
            }
            catch(Exception e)
            {
              return 0; 
            }finally
            {
            con.Close();
            }
        }
        //menampilkan data pada data grid view
        public void TampilAll(String query,String table,DataGrid dg)
        {
            con = kon.GetCon();
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds,table);
                dg.DataSource = ds;
                dg.DataMember = table;
                dg.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

     /*   public String GetData(String query,String row) 
        {
            con = kon.GetCon();
            try
            {
                cmd = new SqlCommand(query,con);
                dr = cmd.ExecuteReader();
                if(dr.HasRows){
                    while(dr.Read())
                    {
                        dr[row];
                    }
            }
            catch(Exception e)
            {
                return "Source Gagal " + e.Message;
            } finally
            {
            con.Close();
            }
        }
        */
    }
}
