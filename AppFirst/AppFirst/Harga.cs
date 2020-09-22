using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppFirst.model;
namespace AppFirst
{
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
        }
        private void Default_Load(object sender, EventArgs e)
        {
            judul.Text = "Shoes Form";
            judul.Font = new Font("Arial", 20);
            Crud kon = new Crud();
            kon.read();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
