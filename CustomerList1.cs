//PROJE ADI : OTEL OTOMASYONU
//ÖĞRENCİ1 : YUNUS MERİÇ/032290023
//ÖĞRENCİ2 : SEMİHA ÇETİNTAŞ/032290076
//ÖĞRENCİ3 : İREM NUR YILDIRIM/032290039
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyonuu
{
    public class CustomerList1
    {
        Customer front;
        Customer rear;
        public CustomerList1()
        {
            front = null;
            rear = null;
        }
        public void customerAdd(string _ad,string _telefon,string _otel,string _yorum,string _puan)
        {

            Customer musteri = new Customer(_ad, _telefon, _otel, _yorum, _puan);
            if (front == null)
            {
                front = rear = musteri;
            }
            else
            {
                rear.next = musteri;
                rear = musteri;
            }
        }
        public void customer_view(ListBox listBox)
        {
            
            if (front == null)
            {
                MessageBox.Show("Müşteri Bulunamamıştır");
            }
            else {
                Customer temp = front;
                while (temp != null)
                {
                    string customer_info = $"Müşteri İsmi-Soyismi:{temp.isim},Telefon:{temp.telefon},Kaldığı Otel:{temp.otel},Yorum:{temp.yorum},Puan:{temp.yorum}";
                    listBox.Items.Add(customer_info);
                    temp = temp.next;
                }
            }
      
        }

        public void customer_comment(ListBox listBox)
        {
            if (front == null)
            {
                MessageBox.Show("Müşteri Bulunmamaktadır");
            }
            else
            {
                Customer temp = front;
                while (temp != null)
                {
                       listBox.Items.Add(temp.yorum);
                       temp = temp.next;
                }
            }
        }
        


    }
}