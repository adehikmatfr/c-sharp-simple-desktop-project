using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using System.Data;
using System.Windows.Forms; //for query

namespace AppFirst.model
{
    class Crud : Koneksi //extends class
    {
        public void read()
        {
            try
            {
                //buat variable coneksi
                MySqlConnection koneksi;
                // intansiasi class
                Koneksi con = new Koneksi();
                koneksi = con.getKoneksi();
                //perintah command/query
                MySqlCommand command = koneksi.CreateCommand();
                command.CommandText = "insert into jenis values('','New ERa')";
                koneksi.Open();
                command.ExecuteNonQuery(); //memasukan query
                koneksi.Close();//tutup koneksi
                MessageBox.Show("data Berhasil disimpan");
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
