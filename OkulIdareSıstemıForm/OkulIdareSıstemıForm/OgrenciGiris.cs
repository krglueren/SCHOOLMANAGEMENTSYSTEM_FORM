using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulIdareSıstemıForm
{
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();

            //Burada yeni öğrenci ekledik. değişkenlerin karşılığı olarak textbox değerlerini girdik. 
            var yeni = new Ogrenci()
            {
                AdSoyad = txt_OgrncAdSoyad.Text,
                KayitTarih = DateTime.Parse(txt_OgrncKayitTarihi.Text),
                OgrenciNo = txt_OgrncNo.Text,
                DTarih = DateTime.Parse(txt_OgrncDogumTarihi.Text),
                Bolum = txt_OgrncBolum.Text
            };
            context.Ogrenci.Add(yeni);
            context.SaveChanges();

            MessageBox.Show("İŞLEM TAMAMLANDI...");

            txt_OgrncAdSoyad.Text = string.Empty;
            txt_OgrncKayitTarihi.Text = string.Empty;
            txt_OgrncNo.Text = string.Empty;
            txt_OgrncDogumTarihi.Text = string.Empty;
            txt_OgrncBolum.Text = string.Empty;
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ÖĞRENCİ GİRİŞ SAYFASI KAPATILIYOR...", "ÇIKIŞ İŞLEMİ");
            this.Close();
        }

        private void OgrenciGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
