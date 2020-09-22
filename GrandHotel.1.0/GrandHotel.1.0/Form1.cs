using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrandHotel._1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Kelas.Koneksi con = new Kelas.Koneksi();
            Kelas.Query qr = new Kelas.Query();
            qr.ShowAll("SELECT * FROM Job","JOb",dgv);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            qr.ShowBox("SELECT * FROM Job","Name",cb);
           
                //qr.InUpDel("INSERT INTO Job Values('YYYYY')");
            //con.debug();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tx.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx2.Text = tx.Text.ToString();
            tx.Text = "";
        }
    }
}
