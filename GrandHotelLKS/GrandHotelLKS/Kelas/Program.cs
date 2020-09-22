using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GrandHotelLKS.Kelas
{
    class Program : Query 
    {
        SqlConnection con;
        Koneksi kon = new Koneksi();

        public String GetHash(String str) 
        {
            var crpt = new SHA256Managed();
            String hash = String.Empty;
            byte[] bit = crpt.ComputeHash(Encoding.ASCII.GetBytes(str));
            foreach(byte bt in bit)
            {
                hash += bt.ToString();
            }
            return hash;
        }

        public String GetCod(String query, String fild) 
        {
            con = kon.GetCon();
            String kode;
            try
            {
                kode = GetData(query,fild);
                if(kode.Equals(""))
                {
                    return "001";
                }
                else
                {
                    int kod = int.Parse(kode)+1;
                    return "00"+kod.ToString();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean ValidString(TextBox a)
        {
            if (a.Text.Equals(""))
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        public void buttonAct(Button ins, Button del, Button upd, Button sve, Button can)
        {
            ins.Enabled = true;
            del.Enabled = true;
            upd.Enabled = true;
            sve.Enabled = false;
            can.Enabled = false;
        }

        public void InsertOn(Button ins,Button del,Button upd,Button sve,Button can) 
        {
            ins.Enabled = false;
            del.Enabled = false;
            upd.Enabled = false;
            sve.Enabled = true;
            can.Enabled = true;
        }
        public void EditOn(Button ins, Button del, Button upd, Button sve, Button can)
        {
            ins.Enabled = false;
            del.Enabled = true;
            upd.Enabled = true;
            sve.Enabled = false;
            can.Enabled = true;
        }

    }
}
