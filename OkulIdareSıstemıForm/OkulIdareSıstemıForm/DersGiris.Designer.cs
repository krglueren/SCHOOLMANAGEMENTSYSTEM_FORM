namespace OkulIdareSıstemıForm
{
    partial class DersGiris
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_DersOgretmeni = new System.Windows.Forms.TextBox();
            this.txt_DersKredisi = new System.Windows.Forms.TextBox();
            this.txt_DersAdi = new System.Windows.Forms.TextBox();
            this.lbl_DersOgretmeni = new System.Windows.Forms.Label();
            this.lbl_DersKredisi = new System.Windows.Forms.Label();
            this.lbl_DersAdı = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(206, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "ÇIKIŞ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txt_DersOgretmeni);
            this.panel1.Controls.Add(this.txt_DersKredisi);
            this.panel1.Controls.Add(this.txt_DersAdi);
            this.panel1.Controls.Add(this.lbl_DersOgretmeni);
            this.panel1.Controls.Add(this.lbl_DersKredisi);
            this.panel1.Controls.Add(this.lbl_DersAdı);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 199);
            this.panel1.TabIndex = 33;
            // 
            // txt_DersOgretmeni
            // 
            this.txt_DersOgretmeni.Location = new System.Drawing.Point(140, 108);
            this.txt_DersOgretmeni.Name = "txt_DersOgretmeni";
            this.txt_DersOgretmeni.Size = new System.Drawing.Size(100, 20);
            this.txt_DersOgretmeni.TabIndex = 17;
            // 
            // txt_DersKredisi
            // 
            this.txt_DersKredisi.Location = new System.Drawing.Point(140, 82);
            this.txt_DersKredisi.Name = "txt_DersKredisi";
            this.txt_DersKredisi.Size = new System.Drawing.Size(100, 20);
            this.txt_DersKredisi.TabIndex = 16;
            // 
            // txt_DersAdi
            // 
            this.txt_DersAdi.Location = new System.Drawing.Point(140, 56);
            this.txt_DersAdi.Name = "txt_DersAdi";
            this.txt_DersAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_DersAdi.TabIndex = 15;
            // 
            // lbl_DersOgretmeni
            // 
            this.lbl_DersOgretmeni.AutoSize = true;
            this.lbl_DersOgretmeni.Location = new System.Drawing.Point(40, 111);
            this.lbl_DersOgretmeni.Name = "lbl_DersOgretmeni";
            this.lbl_DersOgretmeni.Size = new System.Drawing.Size(94, 13);
            this.lbl_DersOgretmeni.TabIndex = 13;
            this.lbl_DersOgretmeni.Text = "Dersin Öğretmeni=";
            // 
            // lbl_DersKredisi
            // 
            this.lbl_DersKredisi.AutoSize = true;
            this.lbl_DersKredisi.Location = new System.Drawing.Point(57, 85);
            this.lbl_DersKredisi.Name = "lbl_DersKredisi";
            this.lbl_DersKredisi.Size = new System.Drawing.Size(77, 13);
            this.lbl_DersKredisi.TabIndex = 12;
            this.lbl_DersKredisi.Text = "Dersin Kredisi=";
            // 
            // lbl_DersAdı
            // 
            this.lbl_DersAdı.AutoSize = true;
            this.lbl_DersAdı.Location = new System.Drawing.Point(81, 59);
            this.lbl_DersAdı.Name = "lbl_DersAdı";
            this.lbl_DersAdı.Size = new System.Drawing.Size(53, 13);
            this.lbl_DersAdı.TabIndex = 11;
            this.lbl_DersAdı.Text = "Ders Adı=";
            // 
            // DersGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 258);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DersGiris";
            this.Text = "DERS GİRİŞ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_DersOgretmeni;
        private System.Windows.Forms.TextBox txt_DersKredisi;
        private System.Windows.Forms.TextBox txt_DersAdi;
        private System.Windows.Forms.Label lbl_DersOgretmeni;
        private System.Windows.Forms.Label lbl_DersKredisi;
        private System.Windows.Forms.Label lbl_DersAdı;
    }
}