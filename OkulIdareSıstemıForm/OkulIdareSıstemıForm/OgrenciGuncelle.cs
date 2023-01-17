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
    public partial class OgrenciGuncelle : Form
    {
        public OgrenciGuncelle()
        {
            InitializeComponent();
        }

        public string a, b, c, d;
        public string g,h;

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var deger = int.Parse(txt_OgrncId.Text);
            var gncl = context.Ogrenci.Find(deger);
            gncl.Id = int.Parse(txt_OgrncId.Text);
            gncl.AdSoyad = txt_OgrncAdSoyad.Text;
            gncl.KayitTarih = DateTime.Parse(txt_OgrncKayitTarihi.Text);
            gncl.OgrenciNo = txt_OgrncNo.Text;
            gncl.DTarih = DateTime.Parse(txt_OgrncDogumTarihi.Text);
            gncl.Bolum = txt_OgrncBolum.Text;
            context.SaveChanges();
            MessageBox.Show("BAŞARIYLA GÜNCELLENDİ...");
            this.Close();
        }

        
        private void OgrenciGuncelle_Load(object sender, EventArgs e)
        {
            txt_OgrncId.Text = a;
            txt_OgrncAdSoyad.Text = b;
            txt_OgrncKayitTarihi.Text = c;
            txt_OgrncNo.Text= d;
            txt_OgrncDogumTarihi.Text= g;
            txt_OgrncBolum.Text = h;
        }
    }
}
