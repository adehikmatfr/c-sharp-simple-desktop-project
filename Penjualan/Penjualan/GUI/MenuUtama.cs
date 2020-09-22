using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Penjualan.Kelas;

namespace Penjualan.GUI
{
    public partial class MenuUtama : Form
    {
        //buat form menjadi objek
        //1.form barang
        FormBuku buku;
        FormPelanggan pelanggan;

        //buat fungsi ketika form di close
        public void FormBukuClose(Object sender,FormClosedEventArgs e) 
        {
            buku = null;
        }
        //buat fungsi ketika form di close
        public void FormPelangganClose(Object sender, FormClosedEventArgs e)
        {
            pelanggan = null;
        }


        public MenuUtama()
        {
            InitializeComponent();
        }
        //ketika submenu buku di klik
        private void sub_buku_Click(object sender, EventArgs e)
        {
            //ketika buku null
            if (buku == null)
            {
                buku = new FormBuku(); //buat objek buku baru
                buku.MdiParent = this; //form buku perntnya adalah menu utama
                buku.FormClosed += new FormClosedEventHandler(FormBukuClose); //pastikan form sudah close / tidak aktif agar tidak duplikat
                buku.Show(); //tampilkan form buku
            }
            else 
            {
                buku.Activate();
            }

        }

        private void sub_pelanggan_Click(object sender, EventArgs e)
        {
            //ketika buku null
            if (pelanggan == null)
            {
                pelanggan = new FormPelanggan(); //buat objek buku baru
                pelanggan.MdiParent = this; //form buku perntnya adalah menu utama
                pelanggan.FormClosed += new FormClosedEventHandler(FormPelangganClose); //pastikan form sudah close / tidak aktif agar tidak duplikat
                pelanggan.Show(); //tampilkan form buku
            }
            else
            {
                pelanggan.Activate();
            }
        }

        private void sub_keluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




    }
}
