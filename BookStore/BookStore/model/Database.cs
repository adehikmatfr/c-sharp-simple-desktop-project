using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//import modul sql driver and client
using MySql.Data;
using MySql.Data.MySqlClient; //for client connection
using MySql.Data.Common; //for comman or query
using System.Data;  //for datatable

namespace BookStore.model
{
    class Database
    {
        //create method koneksi
        public MySqlConnection koneksi() 
        {
                String host, user, psw, db, server;
                host = "localhost";
                user = "root";
                psw = "";
                db = "buku";
                server = "server=" + host + ";user=" + user + ";password=" + psw + ";database=" + db + ";";
                MySqlConnection con = new MySqlConnection(server);
                return con;
        }
        //create method query Inser Update Delete
        public int InUpDel(String query) 
        {
            int nilai;
            try
            {
                MySqlConnection con;
                con = koneksi();
                MySqlCommand comman = con.CreateCommand(); //buat intansiasi command
                comman.CommandText = query; //tangka variable query 
                con.Open(); //buka koneksi
                comman.ExecuteNonQuery(); //masukan
                con.Close();
                nilai = 1; //jika query berhasil 
            }
            catch 
            {
                nilai = 0; //jika query gagal
            }
            return nilai;
        }
       //create method select/read

        public DataTable selectad(String query) 
        {
            DataTable data;
            MySqlConnection con;
            con = koneksi();
            con.Open();
            MySqlDataAdapter dataAdabter = new MySqlDataAdapter();
            dataAdabter.SelectCommand = new MySqlCommand(query, con);
            data = new DataTable();
            dataAdabter.Fill(data);
            return data;
        }


    }
}
