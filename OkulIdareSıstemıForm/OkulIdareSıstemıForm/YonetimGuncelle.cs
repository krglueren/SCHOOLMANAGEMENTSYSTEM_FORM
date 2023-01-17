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
    public partial class YonetimGuncelle : Form
    {
        public YonetimGuncelle()
        {
            InitializeComponent();
        }

        public string a, b, c, d;

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var deger = int.Parse(txt_YonetimId.Text);
            var gncl = context.OkulYonetim.Find(deger);
            gncl.Id = int.Parse(txt_YonetimId.Text);
            gncl.AdSoyad = txt_YonetimAdSoyad.Text;
            gncl.Gorevi = txt_YonetimGorevi.Text;
            gncl.YonetimTip = txt_YonetimYonetimTipi.Text;
            context.SaveChanges();
            MessageBox.Show("BAŞARIYLA GÜNCELLENDİ...");
            this.Close();
        }

        private void YonetimGuncelle_Load(object sender, EventArgs e)
        {
            txt_YonetimId.Text = a;
            txt_YonetimAdSoyad.Text = b;
            txt_YonetimGorevi.Text = c;
            txt_YonetimYonetimTipi.Text = d;
            
            
        }
    }
}
