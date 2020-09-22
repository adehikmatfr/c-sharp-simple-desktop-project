using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanLks2
{
    public partial class Form1 : Form
    {
        Kelas.Koneksi con = new Kelas.Koneksi();
        Kelas.Query qr = new Kelas.Query();

        public void tampildata()
        {
            qr.ShowAll("SELECT * FROM tbl_barang", "tbl_barang", dg);
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.AllowUserToAddRows = false;
            dg.Refresh();
        }
        public void CoBox() 
        {
            String q, f;
            q = "SELECT * FROM tbl_barang";
            f = "NamaBarang";
            qr.ShowBox(q,f,cb);
        }

        public Form1()
        {
            InitializeComponent();
            UserControl ui = new UserControl();
            ui.Show();
        }
    }
}
