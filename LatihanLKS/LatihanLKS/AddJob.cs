using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using LatihanLKS.Model;//panggil modul
using MySql.Data.MySqlClient; //coneksi cilent

namespace LatihanLKS
{
    public partial class AddJob : Form
    {
        Database db = new Database();
        TampilData tampil = new TampilData();
        //untuk mengambil Tjob
        public String job()
        {
            return Tjob.Text;
        }
        
        //clear tjob
        public void clear()
        {
            Tjob.Text = "";
        }
        //function button
        public void ButtonEditOn()
        {
            btnDelete.Enabled = true;
            btnInsert.Enabled = false;
            btnCancle.Enabled = true;
            btnUpdate.Enabled = true;
            button2.Enabled = false;
        }
        //function button
        public void ButtonEditOff()
        {
            btnDelete.Enabled = false;
            btnInsert.Enabled = true;
            btnCancle.Enabled = false;
            btnUpdate.Enabled = false;
            button2.Enabled = false;
        }

        public AddJob()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // db.debugConnection();
            // db.InUpDel("");
            //pamggil data grid
            String query = "SELECT * FROM job";
            tampil.tampilJob(query, "job", dgjob); //parameter query , table ,variable data gird 
            Tid.Visible = false; //agar id tersembunyi
            button2.Enabled = false;
            ButtonEditOff();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM job Where namaJob like '%"+Tsrc.Text+"%'";
            Console.WriteLine(query);
            tampil.tampilJob(query, "job", dgjob); //parameter query , table ,variable data gird 
            Tid.Visible = false; //agar id tersembunyi
            button2.Enabled = false;
        }

        private void simpan_Click(object sender, EventArgs e)
        {

            if (!job().Equals("")) //jika kosong
            {
                String query, cek;
                query = "INSERT into job values ('','" + job() + "')"; //query insert
                cek = "SELECT * FROM job WHERE namaJob='" + job() + "'"; //query cek
                if (!db.NumCek(cek)) //jika data yang di masukan sama
                {
                    if (db.InUpDel(query) != 0) //jika query berhasil
                    {
                        MessageBox.Show("Data Berhasil Di Simpan!");
                        clear(); //bersihkan data
                        String key = "SELECT * FROM job";
                        tampil.tampilJob(key, "job", dgjob);
                        ButtonEditOff();
                    }
                    else
                    {
                        MessageBox.Show("Data Gagal Di Simapn");
                    }
                }
                else
                {
                    MessageBox.Show("Data Sudah Ada!");
                }

            }
            else
            {
                MessageBox.Show("Fild Tidak Boleh Kosong");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgjob.Rows[e.RowIndex]; //intansiasi tada grid
            Tjob.Text = row.Cells["namaJob"].Value.ToString(); //isis fild job
            Tid.Text = row.Cells["jobID"].Value.ToString();
            ButtonEditOn();//btn off
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            ButtonEditOff();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin akan menghapus data ???", "Konfirmasi",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (!job().Equals("")) //jika kosong
                {
                    String query;
                    query = "DELETE FROM job WHERE jobID='" + Tid.Text + "'"; //query insert

                    if (db.InUpDel(query) != 0) //jika query berhasil
                    {
                        MessageBox.Show("Data Berhasil Di Hapus!");
                        clear(); //bersihkan data
                        String key = "SELECT * FROM job";
                        tampil.tampilJob(key, "job", dgjob);
                    }
                    else
                    {
                        MessageBox.Show("Data Gagal Di Hapus");
                    }
                }
                else
                {
                    MessageBox.Show("Fild Tidak Boleh Kosong");
                }

            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Apakah Anda yakin akan menghapus data ???", "Konfirmasi",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (!job().Equals("")) //jika kosong
                {
                    String query, cek;
                    query = "Update job set namaJob='" + job() + "' where jobID='" + Tid.Text + "'"; //query insert
                    cek = "SELECT * FROM job WHERE namaJob='" + job() + "'"; //query cek
                    if (!db.NumCek(cek)) //jika data yang di masukan sama
                    {
                        if (db.InUpDel(query) != 0) //jika query berhasil
                        {
                            MessageBox.Show("Data Berhasil Di Perbaharui!");
                            Console.WriteLine(query);
                            clear(); //bersihkan data
                            String key = "SELECT * FROM job";
                            tampil.tampilJob(key, "job", dgjob);
                            ButtonEditOff();
                        }
                        else
                        {
                            MessageBox.Show("Data Gagal Di Simapn");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data Sudah Ada!");
                    }

                }
                else
                {
                    MessageBox.Show("Fild Tidak Boleh Kosong");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployee em = new AddEmployee();
            em.Show();
            this.Hide();
        }

   
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
