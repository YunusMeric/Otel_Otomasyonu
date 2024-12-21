using System;
using System.Windows.Forms;

namespace Otel_Otomasyonuu
{
    public partial class giris : Form
    {

        public Otel_list otel_listesi = new Otel_list();
        CustomerList1 customer_listesi;
        PersonelTablo personel_listesi = new PersonelTablo(4);

        public giris(CustomerList1 customer_listesi)
        {
            this.customer_listesi = customer_listesi;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "SYİ" && Convert.ToInt32(textBox2.Text) == 1234)
            {
                otelEkle frm2 = new otelEkle(otel_listesi,customer_listesi, personel_listesi);
                this.Hide();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış Tekrar Deneyiniz !");
                Application.Restart();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            customerEkle frm_c = new customerEkle(customer_listesi);
            this.Hide();
            MessageBox.Show("Müşteri Yorum Sayfasına Yönlendiriliyorsunuz");
            frm_c.Show();
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }
    }
}
