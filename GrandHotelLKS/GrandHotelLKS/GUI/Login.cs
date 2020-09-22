using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrandHotelLKS.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            Kelas.Program prog=new Kelas.Program();
            InitializeComponent();
            psw.PasswordChar = '*';
            psw.MaxLength = 14;
            user.Text = prog.GetHash("ade");
        }

        private void can_Click(object sender, EventArgs e)
        {

        }

        private void log_Click(object sender, EventArgs e)
        {

        }

       
    }
}
