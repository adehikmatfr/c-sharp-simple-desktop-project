﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace GrandHotel.Kelas
{
    class Koneksi
    {
        public SqlConnection GetCon() 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "SERVER=LAPTOP-8VEI6K7E; Initial Catalog=lks; Integrated Security=true;";
            return con;
        }
        public void debug() 
        {
            SqlConnection con = GetCon();
            try
            {
                con.Open();
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
