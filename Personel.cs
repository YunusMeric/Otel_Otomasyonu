using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyonuu
{
    internal class Personel
    {
        
        public string isim;
        public string departman;
        public string gorev;

       public Personel next;

        public Personel()
        {
            this.next = null;
        }
        public Personel(string isim,string departman,string gorev)
        {
           
            this.isim = isim;
            this.departman = departman;
            this.gorev = gorev;
        } 

    }
}
