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
    public partial class YonetimGiris : Form
    {
        public YonetimGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            //Burada yeni öğrenci ekledik. değişkenlerin karşılığı olarak textbox değerlerini girdik. 
            var yeni = new OkulYonetim()
            {
                AdSoyad = txt_YonetimAdSoyad.Text,
                Gorevi = txt_YonetimGorevi.Text,
                YonetimTip = txt_YonetimYonetimTipi.Text
            };
            context.OkulYonetim.Add(yeni);
            context.SaveChanges();

            MessageBox.Show("İŞLEM TAMAMLANDI...");

            txt_YonetimAdSoyad.Text=string.Empty;
            txt_YonetimGorevi.Text=string.Empty;
            txt_YonetimYonetimTipi.Text=string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YÖNETİM GİRİŞ SAYFASI KAPATILIYOR...", "ÇIKIŞ İŞLEMİ");
            this.Close();
        }
    }
}
