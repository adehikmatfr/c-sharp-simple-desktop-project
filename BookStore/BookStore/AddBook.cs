using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class AddBook : Form
    {
        
        public AddBook()
        {
            InitializeComponent();
            String judul, penulis, penerbit, terbit,PPN,DIS,POK;
            Double harga,ppn,diskon,pokok;
            judul = Tjudul.Text;
            penulis = Tpenulis.Text;
            penerbit = Tpenerbit.Text;
            terbit = Tterbit.Text;
            PPN = Tppn.Text;
            DIS = Tdiskon.Text;
            POK = Tpokok.Text;
            ppn = 0;
            diskon = 0;
            pokok = 0;
                 if(!PPN.Equals(""))
                {
                 ppn=double.Parse(PPN);
                }
                if(!DIS.Equals(""))
                {
                diskon=double.Parse(DIS);
                }
                 if(!POK.Equals(""))
                {
                pokok=double.Parse(POK);
                }

        }

        //method perhitungan
        private double harga(double dis, double ppn, double pokok)
        {   
            double discon, pajak;
            discon = pokok * dis / 100;
            pajak = pokok * ppn / 100;
            return pokok + discon - pajak;
        }
        //clear data
        public void textClear()
        {
            Tpenulis.Text = "";
            Tjudul.Text = "";
            Tpenerbit.Text = "";
            Lharga.Text = "";
            Tpokok.Text = "";
            Tppn.Text = "";
            Tterbit.Text = "";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textClear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            textClear();                                
        }

    }
}
