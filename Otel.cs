using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyonuu
{
    internal class Otel
    {
        public Otel(string _ad, string _il, string _ilce, string _telefon, string _adres,string _e_posta,string _yildiz_sayisi)
        {

            ad = _ad;
            il = _il;
            ilce = _ilce;
            telefon = _telefon;
            adres = _adres;
            e_posta = _e_posta;
            yildiz_sayisi = _yildiz_sayisi;

        }

        public string ad { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }
        public string e_posta { get; set; }
        public string yildiz_sayisi { get; set; }

        public Otel next;
    }
}
