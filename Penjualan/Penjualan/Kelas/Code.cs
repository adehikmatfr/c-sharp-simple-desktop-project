using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//gunakan modul sql
using System.Data.SqlClient;

namespace Penjualan.Kelas
{
    class Code : Koneksi
    {
        public String BuatKode(String awal ,String query) 
        {
             SqlConnection con;
             SqlCommand cmd;
             SqlDataReader red;
            String urut;
             long hitung;
             con=GetCon();
             con.Open();
             cmd=new SqlCommand(query,con);
             red=cmd.ExecuteReader();
             red.Read();
            if (red.HasRows)
            {
                hitung = Convert.ToInt64(red[0].ToString().Substring(red["KodeBuku"].ToString().Length - 3, 3)) + 1;
                string joinstr = "00" + hitung;
               return urut = awal + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                return urut = awal+"001";
            }
            return urut;
        }
    }
}
