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
    
    public partial class personelEkleme : Form
    {
        PersonelTablo personel_listesi;
        Otel_list otel_listesi;
        CustomerList1 customer_listesi;
        public personelEkleme(Otel_list otel_listesi, PersonelTablo personel_listesi, CustomerList1 customer_listesi)

        {
            this.otel_listesi = otel_listesi;
            this.personel_listesi = personel_listesi;
            this.customer_listesi = customer_listesi;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personel_listesi.Ekle(textBox1.Text, textBox2.Text, textBox3.Text); 
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = ""; 
            MessageBox.Show("Personel Başarıyla Eklendi");
        }

        private void müşteriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void otelEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelEkle ekle = new otelEkle(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            ekle.Show();
        }

        private void otelSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelSil sil = new otelSil(otel_listesi,customer_listesi, personel_listesi);
            this.Hide();
            sil.Show();
        }

        private void otelGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelGuncelleme guncel = new otelGuncelleme(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            guncel.Show();
        }

        private void otelGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelListele listele = new otelListele(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            listele.Show();
        }

        private void müşteriGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_view a = new Customer_view(customer_listesi, otel_listesi, personel_listesi);
            this.Hide();
            a.Show();
        }

        private void personelSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelSilme s = new personelSilme(otel_listesi, personel_listesi, customer_listesi);
            this.Hide();
            s.Show();
        }

        private void personelGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelListele l = new personelListele(otel_listesi, personel_listesi, customer_listesi);
            this.Hide(); 
            l.Show();
        }
    }
}
