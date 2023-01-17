using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulIdareSıstemıForm
{
    public partial class DersGiris : Form
    {
        public DersGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var bul = context.OkulYonetim.FirstOrDefault(x => x.AdSoyad == txt_DersOgretmeni.Text);
            //Burada yeni öğrenci ekledik. değişkenlerin karşılığı olarak textbox değerlerini girdik. 
            var yeni = new Ders()
            {
                Ad = txt_DersAdi.Text,
                Kredisi = txt_DersKredisi.Text,
                OkulYonetimId = bul.Id
            };
            context.Ders.Add(yeni);
            context.SaveChanges();

            MessageBox.Show("İŞLEM TAMAMLANDI...");

            
            txt_DersAdi.Text = string.Empty;
            txt_DersKredisi.Text = string.Empty;
            txt_DersOgretmeni.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DERS GİRİŞ SAYFASI KAPATILIYOR...", "ÇIKIŞ İŞLEMİ");
            this.Close();
        }
    }
}
