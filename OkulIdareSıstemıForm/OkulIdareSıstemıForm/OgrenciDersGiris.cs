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
    public partial class OgrenciDersGiris : Form
    {
        public OgrenciDersGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var bul = context.Ders.FirstOrDefault(x => x.Ad == txt_OgrenciDersDersAdi.Text);
            var bul2 = context.Ogrenci.FirstOrDefault(x => x.AdSoyad == txt_OgrenciDersOgrenciAdi.Text);
            var yeni = new OgrenciDers()
            {
                DersId = bul.Id,
                OgrenciId = bul2.Id,

            };
            context.OgrenciDers.Add(yeni);
            context.SaveChanges();

            MessageBox.Show("İŞLEM TAMAMLANDI...");
                        
            txt_OgrenciDersDersAdi.Text = string.Empty;
            txt_OgrenciDersOgrenciAdi.Text = string.Empty;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ÖĞRENCİ DERS GİRİŞ SAYFASI KAPATILIYOR...", "ÇIKIŞ İŞLEMİ");
            this.Close();
        }
    }
}
