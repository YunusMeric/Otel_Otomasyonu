using System.Windows.Forms;
using System;

namespace Otel_Otomasyonuu
{
    public partial class otelSil : Form
    {
        public Otel_list otel_listesi;
        public CustomerList1 customer_listesi;
        public PersonelTablo personel_listesi;
        public otelSil(Otel_list otelListesi,CustomerList1 customer_listesi, PersonelTablo personel_listesi)
        {
            InitializeComponent();
            this.otel_listesi = otelListesi;
            this.customer_listesi = customer_listesi;
            this.personel_listesi = personel_listesi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            otel_listesi.istenilenOteliSil(textBox1.Text);
            

            textBox1.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void otelEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelEkle ekle = new otelEkle(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            ekle.Show();
        }

        private void otelGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelGuncelleme güncelleme = new otelGuncelleme(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            güncelleme.Show();
        }

        private void otelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void otelListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelListele listeleme = new otelListele(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            listeleme.Show();
        }

        private void müşteriİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Customer_view view = new Customer_view(customer_listesi,otel_listesi, personel_listesi);
            this.Hide();
            view.Show();
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelEkleme ekleme = new personelEkleme(otel_listesi,personel_listesi,customer_listesi);
            this.Hide();
            ekleme.Show();
        }

        private void personelSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelSilme silme = new personelSilme(otel_listesi, personel_listesi, customer_listesi);
            this.Hide();
            silme.Show();
        }

   

        private void personelGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
