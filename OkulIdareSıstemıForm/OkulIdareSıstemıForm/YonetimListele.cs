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
    public partial class YonetimListele : Form
    {
        public YonetimListele()
        {
            InitializeComponent();
        }

        private void YonetimListele_Load(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var Yntm = context.OkulYonetim.ToList();

            var bindingList = new BindingList<OkulYonetim>(Yntm);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var Yontm = context.OkulYonetim.Where(x => x.AdSoyad == toolStripTextBox1.Text).ToList();

            var bindingList = new BindingList<OkulYonetim>(Yontm);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;

            toolStripTextBox1.Text = string.Empty;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var Yontm = context.OkulYonetim.ToList();

            var bindingList = new BindingList<OkulYonetim>(Yontm);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;
        }

        private void İdareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var Yontm = context.OkulYonetim.Where(x=>x.YonetimTip=="İdare").ToList();

            var bindingList = new BindingList<OkulYonetim>(Yontm);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;
        }

        private void öğretmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var Yontm = context.OkulYonetim.Where(x => x.YonetimTip == "Öğretmen").ToList();

            var bindingList = new BindingList<OkulYonetim>(Yontm);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;
        }

        private void öğrenciİşleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var Yontm = context.OkulYonetim.Where(x => x.YonetimTip == "Öğrenci İşleri").ToList();

            var bindingList = new BindingList<OkulYonetim>(Yontm);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "SIL")
            {
                OKULEntities1 context = new OKULEntities1();

                var deger = dataGridView1.CurrentRow.Cells["Id"].Value;
                int a = (int)deger;
                var arama = context.OkulYonetim.FirstOrDefault(x => x.Id == a);
                context.OkulYonetim.Remove(arama);
                context.SaveChanges();


                var Yntm = context.OkulYonetim.ToList();
                var bindingList = new BindingList<OkulYonetim>(Yntm);
                bindingSource1 = new BindingSource(bindingList, null);
                dataGridView1.DataSource = bindingSource1;


            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "GUNCELLE")
            {
                YonetimGuncelle gnc = new YonetimGuncelle();
                gnc.a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                gnc.b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                gnc.c = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                gnc.d = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                gnc.MdiParent = this.MdiParent;
                gnc.Show();
                var context = new OKULEntities1();
                var Yntm = context.OkulYonetim.ToList();

                var bindingList = new BindingList<OkulYonetim>(Yntm);
                bindingSource1 = new BindingSource(bindingList, null);
                dataGridView1.DataSource = bindingSource1;
            }
        }
    }
}
