using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;

namespace OkulIdareSıstemıForm
{
    public partial class OgrenciListele : Form
    {
        public OgrenciListele()
        {
            InitializeComponent();
        }  


        private void OgrenciListele_Load(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var Ogrnc = context.Ogrenci.ToList();

            var bindingList = new BindingList<Ogrenci>(Ogrnc);
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
                var arama=context.Ogrenci.FirstOrDefault(x=>x.Id==a);
                context.Ogrenci.Remove(arama);
                context.SaveChanges();

                
                var Ogrnc = context.Ogrenci.ToList();
                var bindingList = new BindingList<Ogrenci>(Ogrnc);
                bindingSource1 = new BindingSource(bindingList, null);
                dataGridView1.DataSource = bindingSource1;


            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "GUNCELLE")
            {
                OgrenciGuncelle gnc= new OgrenciGuncelle();                
                gnc.a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                gnc.b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                gnc.c = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                gnc.d = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                gnc.g = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                gnc.h = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                gnc.MdiParent=this.MdiParent;
                gnc.Show();
                var context = new OKULEntities1();
                var Ogrnc = context.Ogrenci.ToList();

                var bindingList = new BindingList<Ogrenci>(Ogrnc);
                bindingSource1 = new BindingSource(bindingList, null);
                dataGridView1.DataSource = bindingSource1;
            }
        }
        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var Ogrnc = context.Ogrenci.Where(x=>x.AdSoyad==toolStripTextBox1.Text).ToList();

            var bindingList = new BindingList<Ogrenci>(Ogrnc);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;

            toolStripTextBox1.Text=string.Empty;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var Ogrnc = context.Ogrenci.ToList();

            var bindingList = new BindingList<Ogrenci>(Ogrnc);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;
        }

        
    }
}
