using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GrandHotel._1._2.Kelas
{
    class Program
    {
        public String hash(String s) 
        {
            var cryp = new SHA256Managed();
            String has = String.Empty;
            byte[] byt = cryp.ComputeHash(Encoding.ASCII.GetBytes(s));
            foreach(byte by in byt)
            {
                has += byt.ToString();
            }
            return has;
        }
         
    }
}
