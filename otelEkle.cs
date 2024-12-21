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
    public partial class otelEkle : Form
    {
        Otel_list otel_listesi;
        CustomerList1 customer_listesi;
        PersonelTablo personel_listesi;
        public otelEkle(Otel_list otel_listesi,CustomerList1 customer_listesi, PersonelTablo personel_listesi)
        {
            this.personel_listesi = personel_listesi;
            this.otel_listesi = otel_listesi;
            this.customer_listesi = customer_listesi;
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void otelEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void otelSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelSil otel_Sil = new otelSil(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            otel_Sil.Show();
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Otel eleman = new Otel(textBox9.Text, textBox8.Text, textBox7.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox4.Text);
            otel_listesi.ekle(eleman.ad, eleman.il, eleman.ilce, eleman.telefon, eleman.adres, eleman.e_posta, eleman.yildiz_sayisi);

            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";

          
           

            MessageBox.Show("Otel Başarıyla Eklendi!");
        }

        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void otelListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelListele view_Hotels = new otelListele(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            view_Hotels.Show();
        }

        private void otelGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelGuncelleme otel_Güncelleme = new otelGuncelleme(otel_listesi, customer_listesi,personel_listesi);
            this.Hide();
            otel_Güncelleme.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void müşteriGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_view view = new Customer_view(customer_listesi,otel_listesi, personel_listesi);
            this.Hide();
            view.Show();
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelEkleme ekleme = new personelEkleme(otel_listesi,personel_listesi, customer_listesi);
            this.Hide();
            ekleme.Show();
        }

        private void personelSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelSilme silme = new personelSilme(otel_listesi, personel_listesi,customer_listesi);
            this.Hide(); 
            silme.Show();
        }

        private void personelGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelListele listeleme = new personelListele(otel_listesi, personel_listesi, customer_listesi);
            this.Hide();
            listeleme.Show();
        }
    }


}