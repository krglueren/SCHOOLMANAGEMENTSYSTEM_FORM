namespace OkulIdareSıstemıForm
{
    partial class YonetimGiris
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
            this.txt_YonetimYonetimTipi = new System.Windows.Forms.TextBox();
            this.txt_YonetimGorevi = new System.Windows.Forms.TextBox();
            this.txt_YonetimAdSoyad = new System.Windows.Forms.TextBox();
            this.lbl_YonetimYonetimTipi = new System.Windows.Forms.Label();
            this.lbl_YonetimGorevi = new System.Windows.Forms.Label();
            this.lbl_YonetimAdSoyad = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(211, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "ÇIKIŞ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.txt_YonetimYonetimTipi);
            this.panel1.Controls.Add(this.txt_YonetimGorevi);
            this.panel1.Controls.Add(this.txt_YonetimAdSoyad);
            this.panel1.Controls.Add(this.lbl_YonetimYonetimTipi);
            this.panel1.Controls.Add(this.lbl_YonetimGorevi);
            this.panel1.Controls.Add(this.lbl_YonetimAdSoyad);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 199);
            this.panel1.TabIndex = 29;
            // 
            // txt_YonetimYonetimTipi
            // 
            this.txt_YonetimYonetimTipi.Location = new System.Drawing.Point(132, 113);
            this.txt_YonetimYonetimTipi.Name = "txt_YonetimYonetimTipi";
            this.txt_YonetimYonetimTipi.Size = new System.Drawing.Size(100, 20);
            this.txt_YonetimYonetimTipi.TabIndex = 15;
            // 
            // txt_YonetimGorevi
            // 
            this.txt_YonetimGorevi.Location = new System.Drawing.Point(132, 87);
            this.txt_YonetimGorevi.Name = "txt_YonetimGorevi";
            this.txt_YonetimGorevi.Size = new System.Drawing.Size(100, 20);
            this.txt_YonetimGorevi.TabIndex = 14;
            // 
            // txt_YonetimAdSoyad
            // 
            this.txt_YonetimAdSoyad.Location = new System.Drawing.Point(132, 61);
            this.txt_YonetimAdSoyad.Name = "txt_YonetimAdSoyad";
            this.txt_YonetimAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txt_YonetimAdSoyad.TabIndex = 13;
            // 
            // lbl_YonetimYonetimTipi
            // 
            this.lbl_YonetimYonetimTipi.AutoSize = true;
            this.lbl_YonetimYonetimTipi.Location = new System.Drawing.Point(55, 116);
            this.lbl_YonetimYonetimTipi.Name = "lbl_YonetimYonetimTipi";
            this.lbl_YonetimYonetimTipi.Size = new System.Drawing.Size(71, 13);
            this.lbl_YonetimYonetimTipi.TabIndex = 11;
            this.lbl_YonetimYonetimTipi.Text = "Yönetim Tipi=";
            // 
            // lbl_YonetimGorevi
            // 
            this.lbl_YonetimGorevi.AutoSize = true;
            this.lbl_YonetimGorevi.Location = new System.Drawing.Point(82, 90);
            this.lbl_YonetimGorevi.Name = "lbl_YonetimGorevi";
            this.lbl_YonetimGorevi.Size = new System.Drawing.Size(44, 13);
            this.lbl_YonetimGorevi.TabIndex = 10;
            this.lbl_YonetimGorevi.Text = "Görevi=";
            // 
            // lbl_YonetimAdSoyad
            // 
            this.lbl_YonetimAdSoyad.AutoSize = true;
            this.lbl_YonetimAdSoyad.Location = new System.Drawing.Point(67, 64);
            this.lbl_YonetimAdSoyad.Name = "lbl_YonetimAdSoyad";
            this.lbl_YonetimAdSoyad.Size = new System.Drawing.Size(59, 13);
            this.lbl_YonetimAdSoyad.TabIndex = 9;
            this.lbl_YonetimAdSoyad.Text = "Ad Soyad=";
            // 
            // YonetimGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YonetimGiris";
            this.Text = "YÖNETİM GİRİŞ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_YonetimYonetimTipi;
        private System.Windows.Forms.TextBox txt_YonetimGorevi;
        private System.Windows.Forms.TextBox txt_YonetimAdSoyad;
        private System.Windows.Forms.Label lbl_YonetimYonetimTipi;
        private System.Windows.Forms.Label lbl_YonetimGorevi;
        private System.Windows.Forms.Label lbl_YonetimAdSoyad;
    }
}