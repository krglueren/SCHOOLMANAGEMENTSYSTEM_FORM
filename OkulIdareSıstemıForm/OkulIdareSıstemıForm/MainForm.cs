using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulIdareSıstemıForm
{
    public partial class MainForm : Form
    {
        /*
        BİLGİ------------------------
        
        Bu birinci yontemimiz statusbar'a birşey yazdıracaksak
        statusbarın o an hangi işlevi yapıyorsa onu yazması
        toolStripStatusLabel1.Text = "Form1'e Tıklandı";
        
        //gelen formu Mdi forma çevirdik sonra bu mainform içinde göstereceğimizi belirttik.
        var form= new Form1();
        form.MdiParent= this;
        form.Show();
        */

        public MainForm()
        {
            InitializeComponent();
        }

        //bir function yazdık. bu bizim formumuzun altındaki statis barın menude neye tıkladıysak onun label'ini yazdırmamı sağlıyor.
        public void SetStatus(ToolStripMenuItem toolStripMenuItem)
        {
            toolStripStatusLabel1.Text = toolStripMenuItem.Text + " Tıklandı";
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Value = 100;
            SetStatus((ToolStripMenuItem)sender);

            //MESSAGEBOX işlemi. 
            const string message = "Çıkış Yapmak İstediğine Emin misin?";
            const string caption = "ÇIKIŞ İŞLEMİ";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result==DialogResult.Yes)
            {
                Application.Exit();
            }

            else
            {
                
            }

            
        }

        private void ogrenciFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStatus((ToolStripMenuItem)sender);
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Value = 100;
            SetStatus((ToolStripMenuItem)sender);

           

            
        }
        
        

        private void öğrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Value = 100;
            var ogrGrs = new OgrenciGiris();
            ogrGrs.MdiParent = this;
            ogrGrs.Show();

            SetStatus((ToolStripMenuItem)sender);
        }

        private void öğrenciEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Value = 100;
            var ogrLst = new OgrenciListele();
            ogrLst.MdiParent = this;
            ogrLst.Show();

            SetStatus((ToolStripMenuItem)sender);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void yönetimGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Value = 100;
            var YntmGrs = new YonetimGiris();
            YntmGrs.MdiParent = this;
            YntmGrs.Show();

            SetStatus((ToolStripMenuItem)sender);
        }

        private void yöetimListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Value = 100;
            var YntmLst = new YonetimListele();
            YntmLst.MdiParent = this;
            YntmLst.Show();

            SetStatus((ToolStripMenuItem)sender);
        }

        private void dersGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Value = 100;
            var DrsGrs = new DersGiris();
            DrsGrs.MdiParent = this;
            DrsGrs.Show();

            SetStatus((ToolStripMenuItem)sender);
        }

        private void dersListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Value = 100;
            var DrsLst = new DersListele();
            DrsLst.MdiParent = this;
            DrsLst.Show();

            SetStatus((ToolStripMenuItem)sender);
        }

        private void fotoğrafKaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Value = 100;
            this.BackgroundImage = null;
        }

        private void öğrenciDersGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Value = 100;
            var OgrDrsGrs = new OgrenciDersGiris();
            OgrDrsGrs.MdiParent = this;
            OgrDrsGrs.Show();

            SetStatus((ToolStripMenuItem)sender);
        }

        private void öğrenciDersListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Value = 100;
            var OgrDrsLstl = new OgrenciDersListele();
            OgrDrsLstl.MdiParent = this;
            OgrDrsLstl.Show();

            SetStatus((ToolStripMenuItem)sender);
        }
    }
}
