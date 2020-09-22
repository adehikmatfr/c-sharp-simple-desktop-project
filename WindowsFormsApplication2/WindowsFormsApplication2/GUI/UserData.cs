using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication2.GUI
{
    public partial class UserData : Form
    {

        public UserData()
        {
            InitializeComponent();
            Kelas.Query qr = new Kelas.Query();
            String q = "SELECT * FROM users WHERE users.UseId=detail.UseId";
            qr.ShowAll(q,"users",dg_user);
            dg_user.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_user.AllowUserToAddRows = false;
            dg_user.Refresh();
            qr.ShowBox(q,"UseId",cb1);
        }

        private void dg_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tx_user.Text = dg_user.Rows[e.RowIndex].Cells[1].Value.ToString();
            tx_psw.Text = dg_user.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

    }
}
