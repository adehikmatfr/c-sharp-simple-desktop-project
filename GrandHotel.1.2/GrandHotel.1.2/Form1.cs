using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrandHotel._1._2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            Kelas.Koneksi con = new Kelas.Koneksi();
            Kelas.Query qr = new Kelas.Query();
            InitializeComponent();
            //con.debug();
            //MessageBox.Show(qr.CekData("SELECT * FROM Job WHERE JobID=1","Name"));
            qr.ShowAll("SELECT * FROM Job","Job",dgv1);
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.AllowUserToAddRows = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
                gb1.Visible = true;
                gb2.Visible = false;
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gb1.Visible = false;
            gb2.Visible = true;
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tx1.Text = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
