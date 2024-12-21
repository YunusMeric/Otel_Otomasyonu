using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyonuu
{
    public partial class Customer_view : Form
    {
        public Otel_list otel_listesi;
        public CustomerList1 customer_listesi;
        public PersonelTablo personel_listesi;
        public Customer_view(CustomerList1 customer_listesi,Otel_list otel_listesi, PersonelTablo personel_listesi)
        {
            InitializeComponent();
            this.otel_listesi = otel_listesi;
            this.customer_listesi = customer_listesi;
            this.personel_listesi = personel_listesi;
            comboBox1.Items.Add("Müşteri Bilgilerini Görüntüle");
            comboBox1.Items.Add("Yorumları Görüntüle");
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Müşteri Bilgilerini Görüntüle")
                {
                    customer_listesi.customer_view(listbox1);
                    
                }
                else if (comboBox1.SelectedItem.ToString() == "Yorumları Görüntüle")
                {
                    customer_listesi.customer_comment(listbox1);
                    
                }
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız !");
            }
        }


        private void otelEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelEkle ekle = new otelEkle(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            ekle.Show();
        }

        private void otelSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelSil sil = new otelSil(otel_listesi , customer_listesi , personel_listesi);
            this.Hide();
            sil.Show();
        }

        private void otelGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelGuncelleme guncelleme = new otelGuncelleme(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            guncelleme.Show();
        }

        private void otelListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelListele liste = new otelListele(otel_listesi,customer_listesi, personel_listesi);
            this.Hide();
            liste.Show();
        }

        private void personelGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelListele listeleme = new personelListele(otel_listesi, personel_listesi, customer_listesi);
            this.Hide();
            listeleme.Show();
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelEkleme ekleme = new personelEkleme(otel_listesi, personel_listesi, customer_listesi);
            this.Hide();
            ekleme.Show();
        }

        private void personelSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelSilme silme = new personelSilme(otel_listesi, personel_listesi, customer_listesi);
            this.Hide();
            silme.Show();
        }
    }
}
