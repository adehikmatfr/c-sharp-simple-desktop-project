using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LatihanLks2.GUI
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    /// 

    public partial class UserControl1 : UserControl
    {
        Kelas.Koneksi con = new Kelas.Koneksi();
        Kelas.Query qr = new Kelas.Query();
        public void CoBox()
        {
            String q, f;
            q = "SELECT * FROM tbl_barang";
            f = "NamaBarang";
            qr.ShowBox(q, f, cb);
        }

        public UserControl1()
        {
            InitializeComponent();
        }
    }
}
