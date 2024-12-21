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
    public partial class otelListele : Form
    {
        Otel_list otel_listesi;
        CustomerList1 customer_listesi;
        PersonelTablo personel_listesi;
        public otelListele(Otel_list otel_listesi, CustomerList1 customer_listesi, PersonelTablo personel_listesi)
        {
            InitializeComponent();
            this.otel_listesi = otel_listesi;
            this.customer_listesi = customer_listesi;
            this.personel_listesi = personel_listesi;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            otel_listesi.istenilenOteliGoruntule(textBox2.Text, listBox1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            otel_listesi.goruntule(listBox1); 
            
            
            


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void otelEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelEkle ekle = new otelEkle(otel_listesi,customer_listesi, personel_listesi);
            this.Hide();
            ekle.Show();

        }

        private void otelSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelSil sil = new otelSil(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            sil.Show();
        }

        private void otelGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelGuncelleme guncelleme = new otelGuncelleme(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            guncelleme.Show();
        }

        private void otelListele_Load(object sender, EventArgs e)
        {

        }

        private void müşteriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_view view = new Customer_view(customer_listesi, otel_listesi, personel_listesi);
            this.Hide();
            view.Show();
        }

        private void personelEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelEkleme ekle = new personelEkleme(otel_listesi, personel_listesi, customer_listesi); 
            this.Hide();
            ekle.Show();

        }

        private void personelSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelSilme silme = new personelSilme(otel_listesi, personel_listesi, customer_listesi);
            this.Hide();
            silme.Show();
        }

        private void personelGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelListele liste = new personelListele(otel_listesi, personel_listesi, customer_listesi);
            this.Hide();
            liste.Show();
        }
    }
}
