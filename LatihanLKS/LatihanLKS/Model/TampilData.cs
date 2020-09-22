using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LatihanLKS.Model;
using System.Drawing;

namespace LatihanLKS.Model
{
    class TampilData
    {

        public void tampilJob(string query, string table, DataGridView DG)
        {
            Database db = new Database();
            try
            {
                DG.DataSource = db.DataGrid(query, table);
                 DG.DataMember = table;
                 DG.Columns[0].HeaderText = "NO";
                 DG.Columns[1].HeaderText = "Nama Job";

                   DG.Columns[0].DefaultCellStyle.Alignment =
                   DataGridViewContentAlignment.MiddleCenter;
                   DG.Columns[1].DefaultCellStyle.Alignment =
                   DataGridViewContentAlignment.MiddleCenter;
                //DG.Columns[4].DefaultCellStyle.Alignment =
                  //  DataGridViewContentAlignment.MiddleCenter;

               // DG.AutoResizeColumns();
                DG.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally { }
        }


    }
}
