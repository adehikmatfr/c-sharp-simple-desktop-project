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
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.MdiParent = this;
            log.Show();
        }

    


      //  private void ShowNewForm(object sender, EventArgs e)
       // {
         //   Form childForm = new Form();
          //  childForm.MdiParent = this;
          //  childForm.Text = "Window " + childFormNumber++;
           // childForm.Show();
       // }
  
    }
}
