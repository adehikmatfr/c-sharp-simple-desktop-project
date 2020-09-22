using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Kelas.Koneksi con = new Kelas.Koneksi();
            Kelas.Query qr = new Kelas.Query();
            con.DebugCon();
        }
    }
}
