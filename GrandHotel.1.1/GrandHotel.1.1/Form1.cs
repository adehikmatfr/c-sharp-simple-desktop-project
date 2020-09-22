using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GrandHotel._1._1
{
    public partial class Form1 : Form
    {
        static string hash(String s) 
        {
            var cryp = new SHA1Managed();
            String hash = "";
            byte[] cr = cryp.ComputeHash(Encoding.ASCII.GetBytes(s));
            foreach (byte byt in cr)
            {
                hash += byt.ToString();
            }
            return hash;
        }

        public string hashs(String s) 
        {
            var cryp = new SHA256Managed();
            String hash ="";
            byte[] byt = cryp.ComputeHash(Encoding.UTF8.GetBytes(s));
            foreach (byte by in byt)
            {
                hash += by.ToString();
            }
            return hash;
        }
     // 10410129896510325022517637681691632113402001032022255591981821808156712376187125
   //   172501361101617010110532126203471462111382033884240421694425220854232824832233250233
   //   2021511291820227189202250194491791543522077167134239248201247811418512811913317523872187
 //     2021511291820227189202250194491791543522077167134239248201247811418512811913317523872187
      //2021511291820227189202250194491791543522077167134239248201247811418512811913317523872187
      //13424722855250165167252225932922018523423423455118103184

        public Form1()
        {
            InitializeComponent();
            if(MessageBox.Show("yi","kom",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = hash(textBox1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = hash(textBox3.Text);
            if (textBox2.Text == textBox4.Text)
            {
                MessageBox.Show("sama");
            }
            else
            {
                MessageBox.Show("tidak sama");
            }
        }
    }
}
