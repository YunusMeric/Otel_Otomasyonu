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
    public partial class personelSilme : Form
    {
        PersonelTablo personel_listesi;
        Otel_list otel_listesi;
        CustomerList1 customer_listesi;
        public personelSilme(Otel_list otel_listesi, PersonelTablo personel_listesi, CustomerList1 customer_listesi)
        {
            this.otel_listesi = otel_listesi;
            this.personel_listesi = personel_listesi;
            this.customer_listesi = customer_listesi;
            InitializeComponent();
        }

        private void otelEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelEkle ekle = new otelEkle(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            ekle.Show();
        }

        private void otelSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelSil s = new otelSil(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            s.Show();
        }

       

        private void otelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void otelGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelGuncelleme g = new otelGuncelleme(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            g.Show();
        }

        private void otelGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelListele l = new otelListele(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            l.Show();

        }

        private void müşteriGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_view v = new Customer_view(customer_listesi, otel_listesi, personel_listesi);
            this.Hide();
            v.Show();
        }

        private void personelEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelEkleme ekle = new personelEkleme(otel_listesi, personel_listesi , customer_listesi );
            this.Hide();
            ekle.Show();
        }

        private void personelGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelListele l = new personelListele(otel_listesi, personel_listesi, customer_listesi);
            this.Hide(); 
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personel_listesi.Sil(textBox1.Text);
            textBox1.Text = "";
         
            
        }
    }
}
