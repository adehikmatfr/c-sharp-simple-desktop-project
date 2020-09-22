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
    public partial class Main : Form
    {
        Employee em;
        //closeform
        public void FCE(Object sender ,FormClosedEventArgs e) 
        {
            em = null;
        }

        public Main()
        {
            InitializeComponent();
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dd/MM/yyy hh:mm:ss");
        }

        private void sub_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sub_employee_Click(object sender, EventArgs e)
        {
            if (em == null)
            {
                Employee emp = new Employee();
                emp.MdiParent = this;
                emp.FormClosed += new FormClosedEventHandler(FCE);
                emp.Show();
            }
            else 
            {
                em.Activate();
            }
        }
       


    }
}
