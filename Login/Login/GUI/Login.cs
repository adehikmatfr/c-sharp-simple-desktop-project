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
namespace GUI.Login
{
    public partial class Login : Form
    {
        Class.Koneksi kon = new Class.Koneksi();
        Class.Model mod = new Class.Model();
        //clear data 
        private void clear()
        {
            tx_psw.Text = "";
            tx_user.Text = "";
        }


        public Login()
        {
             InitializeComponent();    
            //MessageBox.Show(kon.debug());
            int q=  mod.Cek("SELECT Username FROM Admin Where Username='Ade'");
            MessageBox.Show(q.ToString());
            
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            if(
            MessageBox.Show("Apakah anda Ingin Kelauar?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information
            )==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
