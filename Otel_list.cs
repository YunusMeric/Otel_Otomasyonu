//PROJE ADI : OTEL OTOMASYONU
//ÖĞRENCİ1 : YUNUS MERİÇ/032290023
//ÖĞRENCİ2 : SEMİHA ÇETİNTAŞ/032290076
//ÖĞRENCİ3 : İREM NUR YILDIRIM/032290039
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyonuu
{
    public class Otel_list
    {
        Otel head;

        public Otel_list()
        {
            head = null;
        }
        public void ekle(string _ad, string _il, string _ilce, string _telefon, string _adres, string _e_posta, string _yildiz_sayisi)
        {
            Otel eleman = new Otel(_ad, _il, _ilce, _telefon, _adres, _e_posta, _yildiz_sayisi);
            if (head == null)
            {
                head = eleman;
            }
            else
            {
                Otel temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = eleman;
            }
        }
        public void istenilenOteliSil(string _ad)
        {
            if (head == null) //Otel boşsa
            {
                MessageBox.Show("Otel Bulunmamaktadır.");
            }

            else if (head.next == null && head.ad == _ad ) //sadece head varsa
            {
                head = null;
                MessageBox.Show("Otel Silinmiştir.");
            }

            else
            {
                Otel temp = head;
                Otel previous = temp;

                if (head.ad == _ad) // head silinecekse
                {
                    head = head.next;
                }
                while (temp.next != null)
                {

                    if (temp.ad == _ad)
                    {
                        previous.next = temp.next;
                        MessageBox.Show("Otel Silinmiştir.");
                        return;
                    }

                    previous = temp;
                    temp = temp.next;

                }
                if (temp.next == null && temp.ad == _ad)// son eleman silinecekse
                {
                    previous.next = null;
                    MessageBox.Show("Otel Silinmiştir.");
                    return;
                }

                MessageBox.Show("Aradığınız Otel Bulunamadı");
            }

        }
        public void otelGuncelleme(string _ad, string ozellik, string yeni_deger)
        {
            if (head == null)
            {
                MessageBox.Show("Otel bulunmamaktadır");
                return;
            }

            Otel temp = head;
            while (temp != null)
            {
                if (temp.ad == _ad)
                {
                    switch (ozellik)
                    {
                        case "Ad":
                            temp.ad = yeni_deger;
                            break;
                        case "Il":
                            temp.il = yeni_deger;
                            break;
                        case "Ilce":
                            temp.ilce = yeni_deger;
                            break;
                        case "Adres":
                            temp.adres = yeni_deger;
                            break;
                        case "Telefon":
                            temp.telefon = yeni_deger;
                            break;
                        case "E-Posta":
                            temp.e_posta = yeni_deger;
                            break;
                        case "Yıldız":
                            temp.yildiz_sayisi = yeni_deger;
                            break;
                        default:
                            MessageBox.Show("Geçersiz özellik");
                            return;
                    }
                    MessageBox.Show("Otel Başarıyla Güncellendi");
                    return;
                }
                temp = temp.next;
            }
            MessageBox.Show("Aradığınız otel bulunamadı");
        }

        public void goruntule(ListBox listBox)
        {
            if (head == null)
            {
                MessageBox.Show("Listelenecek Otel Bulunamadı !");
            }
            else
            {
                Otel temp = head;
                while (temp != null)
                {

                    string otelBilgisi = ($"Ad: {temp.ad}, İl: {temp.il}, İlçe: {temp.ilce}, Telefon: {temp.telefon}, Adres: {temp.adres}, E-Posta: {temp.e_posta}, Yıldız Sayısı: {temp.yildiz_sayisi}");
                    listBox.Items.Add(otelBilgisi);
                    temp = temp.next;

                }
            }
        }
        public void istenilenOteliGoruntule(string otel_ad, ListBox listbox)
        {
            listbox.Items.Clear(); //Koymazsak çıktı vermedi.

            Otel temp = head;
            while (temp != null)
            {
                if (temp.ad == otel_ad)
                {
                    string otelBilgisi = ($"Ad: {temp.ad}, İl: {temp.il}, İlçe: {temp.ilce}, Telefon: {temp.telefon}, Adres: {temp.adres}, E-Posta: {temp.e_posta}, Yıldız Sayısı: {temp.yildiz_sayisi}");
                    listbox.Items.Add(otelBilgisi);
                    return;
                }
                temp = temp.next;
            }
            MessageBox.Show("İstediğiniz Otel Bulunamadı !");
        }


    }
}
   