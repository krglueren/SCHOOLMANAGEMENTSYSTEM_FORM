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
    public partial class DersGuncelle : Form
    {
        public DersGuncelle()
        {
            InitializeComponent();
        }

        public string a, b, c, d;
        public string g;


        private void button1_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var deger = int.Parse(txt_DersId.Text);
            var gncl = context.Ders.Find(deger);
            gncl.Id = int.Parse(txt_DersId.Text);
            gncl.Ad = txt_DersAdi.Text;
            gncl.Kredisi = txt_DersKredisi.Text;
            var bul = context.OkulYonetim.FirstOrDefault(x => x.AdSoyad == txt_DersOgretmeni.Text);
            gncl.OkulYonetimId = bul.Id;
            context.SaveChanges();
            MessageBox.Show("BAŞARIYLA GÜNCELLENDİ...");
            this.Close();
        }

        
        private void DersGuncelle_Load(object sender, EventArgs e)
        {
            txt_DersId.Text = a;
            txt_DersAdi.Text = b;
            txt_DersKredisi.Text = c;
            txt_DersOgretmeni.Text = d;
            
        }
    }
}
