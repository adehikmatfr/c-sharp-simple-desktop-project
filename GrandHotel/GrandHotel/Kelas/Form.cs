using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrandHotel.Kelas
{
    class Form
    {
        public void Btn(Button ins,Button up,Button del,Button sev,Button can,int ed) 
        {
            if (ed == 1)//awal
            {
                ins.Enabled = true;
                up.Enabled = false;
                del.Enabled = false;
                sev.Enabled = false;
                can.Enabled = false;
            }
            else if(ed == 2) //insert
            {
                ins.Enabled = true;
                up.Enabled = false;
                del.Enabled = false;
                sev.Enabled = true;
                can.Enabled = true;
            }
            else if(ed == 3)//update
            {
                ins.Enabled = false;
                up.Enabled = true;
                del.Enabled = true;
                sev.Enabled = false;
                can.Enabled = true;            
            }
        }
    }
}
