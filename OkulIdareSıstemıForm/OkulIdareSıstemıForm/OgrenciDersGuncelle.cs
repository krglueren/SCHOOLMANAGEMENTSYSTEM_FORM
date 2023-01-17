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
    public partial class OgrenciDersGuncelle : Form
    {
        public OgrenciDersGuncelle()
        {
            InitializeComponent();
        }

        public string a, b, c;

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var deger = int.Parse(txt_OgrenciDersId.Text);
            var gncl = context.OgrenciDers.Find(deger);
            gncl.Id = int.Parse(txt_OgrenciDersId.Text);
            var bul = context.Ders.FirstOrDefault(x => x.Ad == txt_OgrenciDersDersAdi.Text);
            gncl.DersId = bul.Id;
            var bul2 = context.Ogrenci.FirstOrDefault(x => x.AdSoyad == txt_OgrenciDersOgrenciAdi.Text);
            gncl.OgrenciId = bul2.Id;
            context.SaveChanges();

            MessageBox.Show("BAŞARIYLA GÜNCELLENDİ...");
            this.Close();
        }

        private void OgrenciDersGuncelle_Load(object sender, EventArgs e)
        {
            txt_OgrenciDersId.Text = a;
            txt_OgrenciDersDersAdi.Text = b;
            txt_OgrenciDersOgrenciAdi.Text = c;
        }
    }
}
