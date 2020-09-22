using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penjualan.Kelas
{
    class Validasi
    {
        //validasi untuk input kosong 
        public Boolean kosong(String a) 
        {
            Boolean b=true;
            if (a.Equals("") || a.Equals("-Pilih Jenis Buku-"))
            {
            b=false;
            }
            return b;
        }
        //validasi untuk harga
        public Boolean harga(int harga) 
        {
            Boolean b = true;
           if(harga>1000000 || harga<1)
           {
               b = false;
           }
           return b;
        }
        //validasi diskon dan ppn
        public Boolean persen(int persen) 
        {
            Boolean b = true;
            if (persen > 100||persen<0)
            {
                b = false;
            }
            return b;
        }

    }
}
