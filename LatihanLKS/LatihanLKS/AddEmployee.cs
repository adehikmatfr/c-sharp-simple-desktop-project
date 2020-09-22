using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LatihanLKS.Model;
using MySql.Data.MySqlClient;
namespace LatihanLKS
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();

        }
        Database db = new Database();
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            comboBox1_DropDown();
           
        }

        private void comboBox1(object sender, EventArgs e)
        {
           

        }

        private void comboBox1_DropDown() 
        {
            MySqlConnection con;
            MySqlCommand command;
            try
            {
                con = db.koneksi();
                con.Open();
                command = new MySqlCommand("SELECT namaJob from job", con);
                MySqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    combo.Items.Add(dr.GetString("namaJob"));
                }
                Console.WriteLine("ok");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            } 
        
        }

    }
}
