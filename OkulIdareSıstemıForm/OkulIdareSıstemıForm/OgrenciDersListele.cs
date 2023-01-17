using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulIdareSıstemıForm
{
    public partial class OgrenciDersListele : Form
    {
        public OgrenciDersListele()
        {
            InitializeComponent();
        }

       

        private void OgrenciDersListele_Load(object sender, EventArgs e)
        {
            var con = new SqlConnection("Initial Catalog=OKUL;Data Source=KRGLUEREN;TrustServerCertificate=True;Persist Security Info=True;User ID=krglueren;Password=1234erenkoroglu");
            var da = new SqlDataAdapter("SELECT  m.Id, s.Ad, a.AdSoyad FROM OgrenciDers m , Ders s, Ogrenci a  WHERE m.DersId = s.Id and m.OgrenciId= a.Id ", con);
            var ds = new DataSet();
            con.Open();
            da.Fill(ds, "OgrenciDers");
            dataGridView1.DataSource = ds.Tables["OgrenciDers"];
            con.Close();
            

            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection("Initial Catalog=OKUL;Data Source=KRGLUEREN;TrustServerCertificate=True;Persist Security Info=True;User ID=krglueren;Password=1234erenkoroglu");
            var da = new SqlDataAdapter("SELECT  m.Id, s.Ad, a.AdSoyad FROM OgrenciDers m , Ders s, Ogrenci a  WHERE m.DersId = s.Id and m.OgrenciId= a.Id ", con);
            var ds = new DataSet();
            con.Open();
            da.Fill(ds, "OgrenciDers");
            dataGridView1.DataSource = ds.Tables["OgrenciDers"];
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "SIL")
            {
                OKULEntities1 context = new OKULEntities1();

                var deger = dataGridView1.CurrentRow.Cells["Id"].Value;
                int a = (int)deger;
                var arama = context.OgrenciDers.FirstOrDefault(x => x.Id == a);
                context.OgrenciDers.Remove(arama);
                context.SaveChanges();

                var con = new SqlConnection("Initial Catalog=OKUL;Data Source=KRGLUEREN;TrustServerCertificate=True;Persist Security Info=True;User ID=krglueren;Password=1234erenkoroglu");
                var da = new SqlDataAdapter("SELECT  m.Id, s.Ad, a.AdSoyad FROM OgrenciDers m , Ders s, Ogrenci a  WHERE m.DersId = s.Id and m.OgrenciId= a.Id ", con);
                var ds = new DataSet();
                con.Open();
                da.Fill(ds, "OgrenciDers");
                dataGridView1.DataSource = ds.Tables["OgrenciDers"];
                con.Close();

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "GUNCELLE")
            {
                OgrenciDersGuncelle gnc = new OgrenciDersGuncelle();
                gnc.a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                gnc.b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                gnc.c = dataGridView1.CurrentRow.Cells[2].Value.ToString();                
                gnc.MdiParent = this.MdiParent;
                gnc.Show();

                var con = new SqlConnection("Initial Catalog=OKUL;Data Source=KRGLUEREN;TrustServerCertificate=True;Persist Security Info=True;User ID=krglueren;Password=1234erenkoroglu");
                var da = new SqlDataAdapter("SELECT  m.Id, s.Ad, a.AdSoyad FROM OgrenciDers m , Ders s, Ogrenci a  WHERE m.DersId = s.Id and m.OgrenciId= a.Id ", con);
                var ds = new DataSet();
                con.Open();
                da.Fill(ds, "OgrenciDers");
                dataGridView1.DataSource = ds.Tables["OgrenciDers"];
                con.Close();


            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var lstl = context.Ders.Where(x => x.Ad == toolStripTextBox1.Text).ToList();
            var con = new SqlConnection("Initial Catalog=OKUL;Data Source=KRGLUEREN;TrustServerCertificate=True;Persist Security Info=True;User ID=krglueren;Password=1234erenkoroglu");
            var da = new SqlDataAdapter("SELECT  m.Id, s.Ad, a.AdSoyad FROM OgrenciDers m , Ders s, Ogrenci a  WHERE m.DersId = s.Id and m.OgrenciId= a.Id AND Ad like '" + toolStripTextBox1.Text + "%' ", con);
            var ds = new DataSet();
            con.Open();
            da.Fill(ds, "OgrenciDers");
            dataGridView1.DataSource = ds.Tables["OgrenciDers"];
            con.Close();

            toolStripTextBox1.Text = string.Empty;
        }
    }
}
