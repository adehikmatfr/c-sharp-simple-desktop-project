using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//import sql client
using System.Data.SqlClient;
//regek
using System.Text.RegularExpressions;

namespace Penjualan.GUI
{
    public partial class FormBuku : Form
    {
        //buat variable koneksi,dataset,adabter
        SqlConnection conn; //koneksi
        SqlCommand cmd; //perintah sql
        SqlDataAdapter da; //eksekusi sql
        DataSet ds; //mengeset data
        //buat objek kelas koneksi
        Kelas.Koneksi con = new Kelas.Koneksi();
        //buat method untuk merefresh data girdview
        public void TampilData(String query,String tabel)
        {

            SqlConnection conn = con.GetCon();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand(query,conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds,tabel);
                    GridBuku.DataSource = ds;
                    GridBuku.DataMember = tabel;
                    GridBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    GridBuku.AllowUserToAddRows = false;
                    GridBuku.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString()); //pesan error
                }
                finally 
                {
                    conn.Close(); //tutup koneksi
                }
            }
        }

        //membuat fungsi bersih data
        public void clear() 
        {
            tx_code.Text = "";
            tx_diskon.Text = "0";
            tx_harga.Text = "0";
            tx_nama.Text = "";
            tx_ppn.Text = "0";
            tx_stok.Text = "0";
            hargajual.Text = "0";
            cb_jenis.Text = "-Pilih Jenis Buku-";
        }
        //validasi fild
        public int falid_input() 
        {
            if (!tx_ppn.Text.Equals("") && !tx_harga.Text.Equals("") && !tx_diskon.Text.Equals(""))
            {
                String cod, nama, jenis;
                int ppn, dis, stok, har, jual;
                cod = tx_code.Text;
                nama = tx_nama.Text;
                jenis = cb_jenis.Text;
                ppn = int.Parse(tx_ppn.Text);
                dis = int.Parse(tx_diskon.Text);
                stok = int.Parse(tx_stok.Text);
                har = int.Parse(tx_harga.Text);
                jual = int.Parse(hargajual.Text);
                Kelas.Validasi val = new Kelas.Validasi();
                if (!val.kosong(cod) || !val.kosong(nama) || !val.kosong(jenis) || !val.persen(ppn) || !val.persen(dis) || !val.harga(stok) || !val.harga(har) || !val.harga(jual))
                {
                    return 0;
                }
            }
           return 1;
        }
        //sting query
        public String Query(int a)
        {
            String cod,dis,har,nam,ppn,stok,jual,jenis,query;
            query = "";
           cod= tx_code.Text;
            dis=tx_diskon.Text;
            har=tx_harga.Text;
            nam=tx_nama.Text;
            ppn=tx_ppn.Text ;
            stok=tx_stok.Text ;
            jual=hargajual.Text;
            jenis=cb_jenis.Text;
            //insert
            if(a==1){
            query = "INSERT into tbl_buku values('" + cod + "','" + nam + "','" + jenis + "','" + 
                     ppn + "','" + dis + "','" + har + "','" + jual + "','" + stok + "')";
            }
            else if (a == 2)
            {
                query = "UPDATE tbl_buku SET KodeBuku='" + cod + "'," +
                         "NamaBuku='" + nam + "',"+
                         "JenisBuku='" + jenis + "'," +
                         "PPN='" + ppn + "'," +
                         "Diskon='" + dis + "'," +
                         "HargaPokok='" + har + "'," +
                         "HargaJual='" + jual + "'," +
                         "Stok='" + stok + "'"+
                         " Where KodeBuku='"+cod+"'";
                         
            }
            else if(a==3){
                query = "DELETE FROM tbl_buku WHERE KodeBuku='" + cod + "'";
            }
            return query;
        }
        //fungsi tombol
        public void EditOFF(Boolean st) 
        {
            btn_hapus.Enabled = st;
            btn_ubah.Enabled = st;
            tx_code.Enabled = false;
        }
         public void EditON(Boolean st)
        {
            tx_code.Enabled = false;
            btn_simpan.Enabled=st;
        }

        public FormBuku()
        {
            InitializeComponent(); //iini adalah method konstarktor / method yang slalu di jalankan
            clear();
            EditOFF(false);
            TampilData("SELECT * FROM tbl_buku","tbl_buku");
        }

        //method untuk menghitung harga barang buku
        public int hargabuku(int ppn,int dis, int pokok) 
        {
            int pajak, diskon, harga;
            pajak = pokok * ppn / 100;
            diskon = pokok * dis / 100;
            harga = pokok + pajak - diskon;
            return harga;
        }
        //ketika di isi form maka akan memunculkan hasil
        private void tx_harga_TextChanged(object sender, EventArgs e)
        {
            if (!tx_ppn.Text.Equals("") && !tx_harga.Text.Equals("") && !tx_diskon.Text.Equals(""))
            {
                int ppn, dis, pokok, harga;

                ppn = int.Parse(tx_ppn.Text);
                dis = int.Parse(tx_diskon.Text);
                pokok = int.Parse(tx_harga.Text);
                harga = hargabuku(ppn, dis, pokok);

                hargajual.Text = harga.ToString();
            }
            else 
            {
                hargajual.Text ="Null, invalid input!";
            }

        }
        //ketika di isi form maka akan memunculkan hasil
        private void tx_diskon_TextChanged(object sender, EventArgs e)
        {
            if (!tx_ppn.Text.Equals("") && !tx_harga.Text.Equals("") && !tx_diskon.Text.Equals(""))
            {
                int ppn, dis, pokok, harga;
                ppn = int.Parse(tx_ppn.Text);
                dis = int.Parse(tx_diskon.Text);
                pokok = int.Parse(tx_harga.Text);
                harga = hargabuku(ppn, dis, pokok);

                hargajual.Text = harga.ToString();
            }
            else
            {
                hargajual.Text = "Null, invalid input!";
            }

        }
        //ketika di isi form maka akan memunculkan hasil
        private void tx_ppn_TextChanged(object sender, EventArgs e)
        {
   
            if (!tx_ppn.Text.Equals("") && !tx_harga.Text.Equals("") && !tx_diskon.Text.Equals(""))
            {
                int ppn, dis, pokok, harga;
                ppn = int.Parse(tx_ppn.Text);
                dis = int.Parse(tx_diskon.Text);
                pokok = int.Parse(tx_harga.Text);
                harga = hargabuku(ppn, dis, pokok);

                hargajual.Text = harga.ToString();
            }
            else
            {
                hargajual.Text = "Null, invalid input!";
            }

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (!tx_code.Text.Equals(""))
            {
                if(MessageBox.Show("Apakah Anda Yakin ingin membuat Baru?","INFORMASI",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes){
                    clear();
                    Kelas.Code kod = new Kelas.Code();
                    String kode = kod.BuatKode("B", "SELECT KodeBuku FROM tbl_buku ORDER by KodeBuku DESC");
                    tx_code.Text = kode;
                    EditOFF(false);
                    EditON(true);
                }
            }
            else
            {
                clear();
                Kelas.Code kod = new Kelas.Code();
                String kode = kod.BuatKode("B", "SELECT KodeBuku FROM tbl_buku ORDER by KodeBuku DESC");
                tx_code.Text = kode;
                EditOFF(false);
                EditON(true);
            }
        }

        private void GridBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tx_code.Text = GridBuku.Rows[e.RowIndex].Cells[0].Value.ToString();
            tx_nama.Text = GridBuku.Rows[e.RowIndex].Cells[1].Value.ToString();
            cb_jenis.Text = GridBuku.Rows[e.RowIndex].Cells[2].Value.ToString();
            tx_ppn.Text = GridBuku.Rows[e.RowIndex].Cells[3].Value.ToString();
            tx_diskon.Text = GridBuku.Rows[e.RowIndex].Cells[4].Value.ToString();
           tx_harga.Text = GridBuku.Rows[e.RowIndex].Cells[5].Value.ToString();
           hargajual.Text = GridBuku.Rows[e.RowIndex].Cells[6].Value.ToString();
            tx_stok.Text = GridBuku.Rows[e.RowIndex].Cells[7].Value.ToString();
            EditON(false);
            EditOFF(true);

        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rsl;
                Kelas.Query key = new Kelas.Query();
                rsl = key.InUpDel(Query(2));
                if (rsl == 1)
                {
                    MessageBox.Show("Data Berhasil Di ubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    TampilData("SELECT * FROM tbl_buku", "tbl_buku");
                    EditOFF(false);
                }
                else
                {
                    MessageBox.Show("Data Berhasil Di ubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (falid_input() == 1)
            {
                int rsl;
                Kelas.Query key = new Kelas.Query();
                rsl = key.InUpDel(Query(1));
                if (rsl == 1)
                {
                    MessageBox.Show("Data Berhasil Di Simpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    TampilData("SELECT * FROM tbl_buku", "tbl_buku");
                    EditOFF(false);
                }
                else
                {
                    MessageBox.Show("Data Berhasil Di Simpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Periksa Kembali inputan anda!","INPORMASI", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah Anda yakin?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes){
             int rsl;
            Kelas.Query key = new Kelas.Query();
            rsl = key.InUpDel(Query(3));
            if (rsl == 1)
            {
                clear();
                TampilData("SELECT * FROM tbl_buku", "tbl_buku");
                EditOFF(false);
                MessageBox.Show("Data Berhasil Di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Gagal Di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String src = textBox1.Text;
            String q = "SELECT * FROM tbl_buku WHERE KodeBuku Like '%" + src + "%' OR " +
                         "NamaBuku LIKE '%" + src + "%' OR " +
                         "JenisBuku LIKE '%" + src + "%' OR " +
                         "PPN LIKE '%" + src + "%' OR " +
                         "Diskon LIKE '%" + src + "%' OR " +
                         "HargaPokok LIKE '%" + src + "%' OR " +
                         "HargaJual LIKE '%" + src + "%' OR " +
                         "Stok LIKE '%" + src + "%'";
            TampilData(q, "tbl_buku");
            
        }

        private void FormBuku_Load(object sender, EventArgs e)
        {

        }


    }
}
