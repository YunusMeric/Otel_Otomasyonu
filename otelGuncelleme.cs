using System.Windows.Forms;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Otel_Otomasyonuu
{
    public partial class otelGuncelleme : Form
    {
        public CustomerList1 customer_listesi;
        public Otel_list otel_listesi;
        public PersonelTablo personel_listesi;

        public otelGuncelleme(Otel_list otel_listesi, CustomerList1 customer_listesi, PersonelTablo personel_listesi)
        {
            InitializeComponent();
            this.otel_listesi = otel_listesi;
            this.customer_listesi = customer_listesi;
            this.personel_listesi = personel_listesi;

            comboBox1.Items.AddRange(new string[] { "Ad", "Il", "Ilce", "Telefon", "Adres", "E-Posta", "Yıldız" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            otel_listesi.otelGuncelleme(textBox1.Text, comboBox1.Text, textBox2.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            otelSil sil = new otelSil(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            sil.Show();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void otelListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelListele listele = new otelListele(otel_listesi, customer_listesi, personel_listesi);
            this.Hide();
            listele.Show();
        }

        private void müşteriGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_view view = new Customer_view(customer_listesi, otel_listesi, personel_listesi);
            this.Hide();
            view.Show();
        }

        private void personelEklemeToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void personelGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelListele listeleme = new personelListele(otel_listesi, personel_listesi, customer_listesi); 
            this.Hide();
            listeleme.Show();
        }
    }
}
