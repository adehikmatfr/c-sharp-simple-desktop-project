using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrandHotelLKS
{
    public partial class Form1 : Form
    {
        Kelas.Koneksi con = new Kelas.Koneksi();
        Kelas.Query qry = new Kelas.Query();
        Kelas.Program prog = new Kelas.Program();
        public Form1()
        {
            InitializeComponent();
           // con.debug();
           // String q = "INSERT INTO Job Values('Front House Keeper Suervisor')";
           // qry.InUpDel(q,"INSERT Data Succes!");
           // textBox1.Text=prog.GetHash("OK");
           // textBox1.Text = prog.GetCod("SELECT * FROM Job Order by JobID DESC","JobID");
          // textBox2.Text = DateTime.Now.ToString();
           // qry.ShowBox("SELECT * FROM Job","Name",comboBox1);
           // qry.ShowAll("SELECT * FROM Job","Job",dataGridView1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            prog.buttonAct(button1,button2,button3,button4,button5);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textBox2.Text = timer1.ToString();
        }
    }
}
