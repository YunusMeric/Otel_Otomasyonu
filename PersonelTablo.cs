
//PROJE ADI : OTEL OTOMASYONU
//ÖĞRENCİ1 : YUNUS MERİÇ/032290023
//ÖĞRENCİ2 : SEMİHA ÇETİNTAŞ/032290076
//ÖĞRENCİ3 : İREM NUR YILDIRIM/032290039
using System;
using System.Windows.Forms;
//Departmanlar: Yöneticilik,Mutfak,Kat Sorumlusu,Güvenlik
namespace Otel_Otomasyonuu
{
    public class PersonelTablo
    {
        private Personel[] departmanlar; 

        public PersonelTablo(int size)
        {
            departmanlar = new Personel[size];
        }

        public void Ekle(string isim, string departman, string gorev)
        {
            Personel eleman = new Personel(isim, departman, gorev);
            int indis = Hash(departman); 

            
            if (departmanlar[indis] == null)
            {
                departmanlar[indis] = eleman;
            }
            else
            {
               
                Personel sonPersonel = departmanlar[indis];
                while (sonPersonel.next != null)
                {
                    sonPersonel = sonPersonel.next;
                }
                sonPersonel.next = eleman;
            }
        }

        public void Sil(string isim)
        {
            foreach (Personel personel in departmanlar)
            {
                if (personel == null)
                    continue;

                
                Personel temp = personel;
                if (temp.isim == isim)
                {
                    departmanlar[Hash(temp.departman)] = temp.next;
                    MessageBox.Show("Başarıyla Silindi");
                    return;
                }

                while (temp.next != null)
                {
                    if (temp.next.isim == isim)
                    {
                        temp.next = temp.next.next;
                        MessageBox.Show("Başarıyla Silindi");
                        return;
                    }
                    temp = temp.next;
                }
            }

            MessageBox.Show("Aradığınız Personel Bulunamadı.");
        }

        
        private int Hash(string departman)
        {
            return departman.Length % departmanlar.Length;
        }

        public void Listele(ListBox listBox)
        {
            
            listBox.Items.Clear();

            
            foreach (Personel personelListesi in departmanlar)
            {
                
                if (personelListesi != null)
                {
                    
                    Personel personel = personelListesi;
                    while (personel != null)
                    {
                        
                        string info = $"İsim: {personel.isim}, Departman: {personel.departman}, Görev: {personel.gorev}";

                        
                        listBox.Items.Add(info);

                        
                        personel = personel.next;
                    }
                }
            }
        }

    }
}