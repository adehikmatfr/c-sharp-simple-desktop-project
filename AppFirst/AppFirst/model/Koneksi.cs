using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//panggil modul driver mysql
using MySql.Data;
using MySql.Data.MySqlClient;


namespace AppFirst.model
{
    class Koneksi
    {
        //buat method open db untuk membuka database
        public MySqlConnection getKoneksi() 
        {
            String host, user, password, db,con;
            host = "localhost";
            user = "root";
            password = "";
            db = "sepatu";
            con="server="+host+";user="+user+";password="+password+";database="+db+";";
            Console.WriteLine(con);
            //syntax
            MySqlConnection conn = new MySqlConnection(con);
            return conn;  
        }

    }
}
