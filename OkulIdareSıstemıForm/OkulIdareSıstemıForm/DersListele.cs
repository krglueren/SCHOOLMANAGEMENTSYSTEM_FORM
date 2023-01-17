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
    public partial class DersListele : Form
    {
        public DersListele()
        {
            InitializeComponent();
        }

        private void DersListele_Load(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var lstl=context.Ders.ToList();
            var lstlyntm=context.OkulYonetim.ToList();
            var con = new SqlConnection("Initial Catalog=OKUL;Data Source=KRGLUEREN;TrustServerCertificate=True;Persist Security Info=True;User ID=krglueren;Password=1234erenkoroglu");
            var da = new SqlDataAdapter("SELECT  m.Id, m.Ad, m.Kredisi, s.AdSoyad FROM Ders m , OkulYonetim s  WHERE m.OkulYonetimId =s.Id ", con);
            var ds = new DataSet();
            con.Open();
            da.Fill(ds, "Ders");
            dataGridView1.DataSource = ds.Tables["Ders"];
            con.Close();


           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var lstl = context.Ders.Where(x => x.Ad == toolStripTextBox1.Text).ToList();
            var con = new SqlConnection("Initial Catalog=OKUL;Data Source=KRGLUEREN;TrustServerCertificate=True;Persist Security Info=True;User ID=krglueren;Password=1234erenkoroglu");
            var da = new SqlDataAdapter("SELECT  m.Id, m.Ad, m.Kredisi, s.AdSoyad FROM Ders m , OkulYonetim s WHERE m.OkulYonetimId =s.Id AND Ad like '" + toolStripTextBox1.Text + "%' ", con);
            var ds = new DataSet();
            con.Open();
            da.Fill(ds, "Ders");
            dataGridView1.DataSource = ds.Tables["Ders"];
            con.Close();

            toolStripTextBox1.Text=string.Empty;
        }

        

        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                string rw = row.Cells["Ad"].Value.ToString();
                if (rw == "İnternet Programcılığı")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                    row.Cells["DersinRengi"].Value = "gri";
                }

                else if (rw == "Veri Tabanı Programlama")
                {
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                    row.Cells["DersinRengi"].Value = "sarı";
                }

                else if (rw == "Veri Yapıları ve Algoritma")
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                    row.Cells["DersinRengi"].Value = "mavi";
                }

                else if (rw == "Matematik" )
                {
                    row.DefaultCellStyle.BackColor = Color.LightSalmon;
                    row.Cells["DersinRengi"].Value = "turuncu";
                }

                else if (rw == "Gastronomi")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.Cells["DersinRengi"].Value = "yeşil";
                }

                else if (rw == "Nesneye Dayalı Programlama")
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                    row.Cells["DersinRengi"].Value = "pembe";
                }

            }
        }

        private void denKüçükDerslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var lstl = context.Ders.ToList();
            var lstlyntm = context.OkulYonetim.ToList();
            var con = new SqlConnection("Initial Catalog=OKUL;Data Source=KRGLUEREN;TrustServerCertificate=True;Persist Security Info=True;User ID=krglueren;Password=1234erenkoroglu");
            var da = new SqlDataAdapter("SELECT  m.Id, m.Ad, m.Kredisi, s.AdSoyad FROM Ders m , OkulYonetim s  WHERE m.OkulYonetimId =s.Id AND Kredisi <= 2 ", con);
            var ds = new DataSet();
            con.Open();
            da.Fill(ds, "Ders");
            dataGridView1.DataSource = ds.Tables["Ders"];
            con.Close();


        }

        private void denBüyükDerslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var lstl = context.Ders.ToList();
            var lstlyntm = context.OkulYonetim.ToList();
            var con = new SqlConnection("Initial Catalog=OKUL;Data Source=KRGLUEREN;TrustServerCertificate=True;Persist Security Info=True;User ID=krglueren;Password=1234erenkoroglu");
            var da = new SqlDataAdapter("SELECT  m.Id, m.Ad, m.Kredisi, s.AdSoyad FROM Ders m , OkulYonetim s  WHERE m.OkulYonetimId =s.Id AND Kredisi > 2 ", con);
            var ds = new DataSet();
            con.Open();
            da.Fill(ds, "Ders");
            dataGridView1.DataSource = ds.Tables["Ders"];
            con.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var context = new OKULEntities1();
            var lstl = context.Ders.ToList();
            var lstlyntm = context.OkulYonetim.ToList();
            var con = new SqlConnection("Initial Catalog=OKUL;Data Source=KRGLUEREN;TrustServerCertificate=True;Persist Security Info=True;User ID=krglueren;Password=1234erenkoroglu");
            var da = new SqlDataAdapter("SELECT  m.Id, m.Ad, m.Kredisi, s.AdSoyad FROM Ders m , OkulYonetim s  WHERE m.OkulYonetimId =s.Id ", con);
            var ds = new DataSet();
            con.Open();
            da.Fill(ds, "Ders");
            dataGridView1.DataSource = ds.Tables["Ders"];
            con.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "SIL")
            {
                OKULEntities1 context = new OKULEntities1();

                var deger = dataGridView1.CurrentRow.Cells["Id"].Value;
                int a = (int)deger;
                var arama = context.Ders.FirstOrDefault(x => x.Id == a);
                context.Ders.Remove(arama);
                context.SaveChanges();

                
                var lstl = context.Ders.ToList();
                var lstlyntm = context.OkulYonetim.ToList();
                var con = new SqlConnection("Initial Catalog=OKUL;Data Source=KRGLUEREN;TrustServerCertificate=True;Persist Security Info=True;User ID=krglueren;Password=1234erenkoroglu");
                var da = new SqlDataAdapter("SELECT  m.Id, m.Ad, m.Kredisi, s.AdSoyad FROM Ders m , OkulYonetim s  WHERE m.OkulYonetimId =s.Id ", con);
                var ds = new DataSet();
                con.Open();
                da.Fill(ds, "Ders");
                dataGridView1.DataSource = ds.Tables["Ders"];
                con.Close();



            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "GUNCELLE")
            {
                DersGuncelle gnc = new DersGuncelle();
                gnc.a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                gnc.b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                gnc.c = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                gnc.d = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                gnc.g = dataGridView1.CurrentRow.Cells[4].Value.ToString();                
                gnc.MdiParent = this.MdiParent;
                gnc.Show();

                var context = new OKULEntities1();
                var lstl = context.Ders.ToList();
                var lstlyntm = context.OkulYonetim.ToList();
                var con = new SqlConnection("Initial Catalog=OKUL;Data Source=KRGLUEREN;TrustServerCertificate=True;Persist Security Info=True;User ID=krglueren;Password=1234erenkoroglu");
                var da = new SqlDataAdapter("SELECT  m.Id, m.Ad, m.Kredisi, s.AdSoyad FROM Ders m , OkulYonetim s  WHERE m.OkulYonetimId =s.Id ", con);
                var ds = new DataSet();
                con.Open();
                da.Fill(ds, "Ders");
                dataGridView1.DataSource = ds.Tables["Ders"];
                con.Close();
            }
        }
    }
}
