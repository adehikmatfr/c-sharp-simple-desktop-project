using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//gunakan modul buku 


namespace Penjualan.GUI
{
    public partial class FormPelanggan : Form
    {
        FormBuku bk;
        //baut method bersih data
        public void clear() 
        {
            tx_pelanggan.Text = "";
            tx_penaggan.Text = "";
            tx_nama.Text = "";
            rc_alamat.Text = "";
        }
        //methd button

        public FormPelanggan()
        {
            InitializeComponent();
            clear();
          
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (!tx_pelanggan.Text.Equals(""))
            {
                if (MessageBox.Show("Apakah Anda Yakin ingin membuat Baru?", "INFORMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    clear();
                    Kelas.Code kod = new Kelas.Code();
                    String kode = kod.BuatKode("P", "SELECT IdPelanggan FROM tbl_pelanggan ORDER by IdPelanggan DESC");
                    tx_pelanggan.Text = kode;
                    bk.EditOFF(false);
                    bk.EditON(true);
                }
            }
            else
            {
                clear();
                Kelas.Code kod = new Kelas.Code();
                String kode = kod.BuatKode("P", "SELECT IdPelanggan FROM tbl_pelanggan ORDER by IdPelanggan DESC");
                tx_pelanggan.Text = kode;
                bk.EditOFF(false);
                bk.EditON(true);
            }
        }

    }
}
