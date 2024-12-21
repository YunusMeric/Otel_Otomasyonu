using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyonuu
{
    public class Customer {

        public Customer(string _isim,string _telefon, string _otel, string _yorum, string _puan) {

            isim = _isim;
            telefon = _telefon;
            otel = _otel;
            yorum = _yorum;
            puan = _puan;

        }
        public string isim { get; set; }
        public string telefon { get; set; }
        public string otel { get; set; }
        public string yorum { get; set; }
        public string puan { get; set; }

        public Customer next;

       
    }

       

}
