using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;  // driver mysql
using MySql.Data.MySqlClient; // mysql client
using MySql.Data.Common; // mysql command , query
using System.Windows.Forms;
using System.Data;

namespace LatihanLKS.Model
{
    class Database
    {
        //fungsi koneksi
        public MySqlConnection koneksi() 
        {
            String host, user, psw, db, server;
            host = "localhost";
            user = "root";
            psw = "";
            db = "grandhotel";
            server = "server=" + host + ";user=" + user + ";password=" + psw + ";database=" + db + ";";
            MySqlConnection con = new MySqlConnection(server);
            return con;
        }

      //  public buat fungsi crud

       public int InUpDel(String query)
        {
            MySqlConnection con;
            MySqlCommand command;

            int msg; 

            try
            {
                con = koneksi();
                command = con.CreateCommand(); //create statment /command
                command.CommandText = query; //string query
                con.Open();
                command.ExecuteNonQuery(); // untuk memasukan ke dalam database
                con.Close();
                msg = 1;
            }catch(Exception e)
                 {
                     msg = 0;
                 }
            return msg;
        }

        //Data Grid View
       public DataSet DataGrid(string query, string tabel)
       {
           MySqlConnection con;
           MySqlDataAdapter sdaUser;
           DataSet dsGrid;
           con = koneksi();
           sdaUser = new MySqlDataAdapter(query, con);
           dsGrid = new DataSet();

           try
           {
               con.Open();
               sdaUser.Fill(dsGrid, tabel);
               return dsGrid;
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
               return null;
           }
           finally
           {
               con.Close();
           }
       }

        //mengecek data di dtabase 

       public DataSet tampil() 
       {
           MySqlConnection con;
           con = koneksi();
           MySqlDataAdapter data;
           data = new MySqlDataAdapter("SELECT namaJob from job",con);
           DataSet set = new DataSet();
           data.Fill(set,"job");
           return set;
       }

       public bool NumCek(String query)
       {
           MySqlConnection con;
           MySqlCommand command;
           con = koneksi();
           try
           {
               command = con.CreateCommand(); //create statment /command
               command.CommandText = query; //string query
               con.Open();
               MySqlDataReader reader = command.ExecuteReader(); // untuk memasukan ke dalam database
               return reader.HasRows; //mengembalikan nilai true or false
           }
           finally
           {
               con.Close(); //tutup koneksi
           }
       }


        //fungsi debuging connection

        public void debugConnection() 
        {
            try
            {
                MySqlConnection con;
                con = koneksi();
                con.Open();
                MessageBox.Show("Connection Sucess!");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


    }
}
