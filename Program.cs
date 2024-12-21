//PROJE ADI : OTEL OTOMASYONU
//ÖĞRENCİ1 : YUNUS MERİÇ/032290023
//ÖĞRENCİ2 : SEMİHA ÇETİNTAŞ/032290076
//ÖĞRENCİ3 : İREM NUR YILDIRIM/032290039
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyonuu
{
    internal static class Program
    {
        public static CustomerList1 customer_listesi = new CustomerList1();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new giris(customer_listesi));
        }
    }
}
