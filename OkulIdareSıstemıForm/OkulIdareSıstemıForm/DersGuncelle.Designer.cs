namespace OkulIdareSıstemıForm
{
    partial class DersGuncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_DersOgretmeni = new System.Windows.Forms.TextBox();
            this.txt_DersKredisi = new System.Windows.Forms.TextBox();
            this.txt_DersAdi = new System.Windows.Forms.TextBox();
            this.txt_DersId = new System.Windows.Forms.TextBox();
            this.lbl_DersOgretmeni = new System.Windows.Forms.Label();
            this.lbl_DersKredisi = new System.Windows.Forms.Label();
            this.lbl_DersAdı = new System.Windows.Forms.Label();
            this.lbl_DersId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "GÜNCELLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txt_DersOgretmeni);
            this.panel1.Controls.Add(this.txt_DersKredisi);
            this.panel1.Controls.Add(this.txt_DersAdi);
            this.panel1.Controls.Add(this.txt_DersId);
            this.panel1.Controls.Add(this.lbl_DersOgretmeni);
            this.panel1.Controls.Add(this.lbl_DersKredisi);
            this.panel1.Controls.Add(this.lbl_DersAdı);
            this.panel1.Controls.Add(this.lbl_DersId);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 199);
            this.panel1.TabIndex = 31;
            // 
            // txt_DersOgretmeni
            // 
            this.txt_DersOgretmeni.Location = new System.Drawing.Point(139, 128);
            this.txt_DersOgretmeni.Name = "txt_DersOgretmeni";
            this.txt_DersOgretmeni.Size = new System.Drawing.Size(100, 20);
            this.txt_DersOgretmeni.TabIndex = 17;
            // 
            // txt_DersKredisi
            // 
            this.txt_DersKredisi.Location = new System.Drawing.Point(139, 102);
            this.txt_DersKredisi.Name = "txt_DersKredisi";
            this.txt_DersKredisi.Size = new System.Drawing.Size(100, 20);
            this.txt_DersKredisi.TabIndex = 16;
            // 
            // txt_DersAdi
            // 
            this.txt_DersAdi.Location = new System.Drawing.Point(139, 76);
            this.txt_DersAdi.Name = "txt_DersAdi";
            this.txt_DersAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_DersAdi.TabIndex = 15;
            // 
            // txt_DersId
            // 
            this.txt_DersId.Location = new System.Drawing.Point(139, 50);
            this.txt_DersId.Name = "txt_DersId";
            this.txt_DersId.Size = new System.Drawing.Size(100, 20);
            this.txt_DersId.TabIndex = 14;
            // 
            // lbl_DersOgretmeni
            // 
            this.lbl_DersOgretmeni.AutoSize = true;
            this.lbl_DersOgretmeni.Location = new System.Drawing.Point(39, 131);
            this.lbl_DersOgretmeni.Name = "lbl_DersOgretmeni";
            this.lbl_DersOgretmeni.Size = new System.Drawing.Size(94, 13);
            this.lbl_DersOgretmeni.TabIndex = 13;
            this.lbl_DersOgretmeni.Text = "Dersin Öğretmeni=";
            // 
            // lbl_DersKredisi
            // 
            this.lbl_DersKredisi.AutoSize = true;
            this.lbl_DersKredisi.Location = new System.Drawing.Point(56, 105);
            this.lbl_DersKredisi.Name = "lbl_DersKredisi";
            this.lbl_DersKredisi.Size = new System.Drawing.Size(77, 13);
            this.lbl_DersKredisi.TabIndex = 12;
            this.lbl_DersKredisi.Text = "Dersin Kredisi=";
            // 
            // lbl_DersAdı
            // 
            this.lbl_DersAdı.AutoSize = true;
            this.lbl_DersAdı.Location = new System.Drawing.Point(80, 79);
            this.lbl_DersAdı.Name = "lbl_DersAdı";
            this.lbl_DersAdı.Size = new System.Drawing.Size(53, 13);
            this.lbl_DersAdı.TabIndex = 11;
            this.lbl_DersAdı.Text = "Ders Adı=";
            // 
            // lbl_DersId
            // 
            this.lbl_DersId.AutoSize = true;
            this.lbl_DersId.Location = new System.Drawing.Point(86, 53);
            this.lbl_DersId.Name = "lbl_DersId";
            this.lbl_DersId.Size = new System.Drawing.Size(47, 13);
            this.lbl_DersId.TabIndex = 10;
            this.lbl_DersId.Text = "Ders Id=";
            // 
            // DersGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DersGuncelle";
            this.Text = "DERS GÜNCELLE";
            this.Load += new System.EventHandler(this.DersGuncelle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_DersOgretmeni;
        private System.Windows.Forms.TextBox txt_DersKredisi;
        private System.Windows.Forms.TextBox txt_DersAdi;
        private System.Windows.Forms.TextBox txt_DersId;
        private System.Windows.Forms.Label lbl_DersOgretmeni;
        private System.Windows.Forms.Label lbl_DersKredisi;
        private System.Windows.Forms.Label lbl_DersAdı;
        private System.Windows.Forms.Label lbl_DersId;
    }
}