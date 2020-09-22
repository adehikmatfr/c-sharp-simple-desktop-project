using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GrandHotel.GUI
{
    public partial class Employee : Form
    {
        Kelas.Query qr;
        Kelas.Form qf;
        public void tampil(String q)
        {
            qr = new Kelas.Query();
            qr.ShowAll(q, "Employee", dg_employee);
            dg_employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_employee.AllowUserToAddRows = false;
        }
        public void clear() 
        {
            tx_address.Text = "";
            tx_email.Text = "";
            tx_nama.Text = "";
            tx_psw1.Text = "";
            tx_psw2.Text = "";
            tx_src.Text = "";
            tx_user.Text = "";
            tx_tgl.Text = "";
        }

        public void button(int a) 
        {
         qf = new Kelas.Form();
         if(a==1)//awal
         {
             qf.Btn(ins,upd,del,sav,can,1);
         }
         else if(a==2)//insert
         {
             qf.Btn(ins, upd, del, sav, can, 2);
         }
         else if(a==3)//update
         {
             qf.Btn(ins, upd, del, sav, can, 3);
         }
        }

        public Boolean query(int q)
        {
            String u, p, n, e, d, j, a,query;
            u = tx_user.Text;
            p = tx_psw1.Text;
            n = tx_nama.Text;
            e = tx_email.Text;
            d = tx_tgl.Text;
           // j = id_job;
            a = tx_address.Text;
            if(q==1)//insert
            {
                query = "INSERT INTO Employee";
            }
            return true;
        }

        public Employee()
        {
            InitializeComponent();
            qr = new Kelas.Query();
            String q = "SELECT * from Employee";
            tampil(q);
            qr.ShowBox("SELECT * FROM Job","Name",cm_job);
            clear();
            button(1);
            id.Visible = false;
        }

        private void ins_Click(object sender, EventArgs e)
        {
            clear();
            button(2);
        }

        private void can_Click(object sender, EventArgs e)
        {
            clear();
            button(1);
        }

        private void dg_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tx_user.Text = dg_employee.Rows[e.RowIndex].Cells[0].Value.ToString();
            button(3);
            
        }

 

    }
}
