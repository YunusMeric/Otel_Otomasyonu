using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Otel_Otomasyonuu
{
    public partial class customerEkle : Form
    {
        CustomerList1 customer_listesi;
        public customerEkle(CustomerList1 customer_listesi)
        {
            this.customer_listesi = customer_listesi;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            Customer musteri = new Customer(textBox7.Text, textBox2.Text, textBox8.Text,textBox3.Text,textBox1.Text);
            customer_listesi.customerAdd(musteri.isim, musteri.telefon, musteri.otel, musteri.yorum, musteri.puan);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

            MessageBox.Show("Bilgileriniz Başarıyla Eklendi!");
            giris frm1 = new giris(customer_listesi);
            this.Hide();
            frm1.ShowDialog();

           
             
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Customer_Load(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void müşteriSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
