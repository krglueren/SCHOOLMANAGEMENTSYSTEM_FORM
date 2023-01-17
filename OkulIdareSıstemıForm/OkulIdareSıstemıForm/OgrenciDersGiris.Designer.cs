namespace OkulIdareSıstemıForm
{
    partial class OgrenciDersGiris
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_OgrenciDersOgrenciAdi = new System.Windows.Forms.TextBox();
            this.txt_OgrenciDersDersAdi = new System.Windows.Forms.TextBox();
            this.lbl_OgrncDersOgrenciAdi = new System.Windows.Forms.Label();
            this.lbl_OgrncDersDersAdi = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.txt_OgrenciDersOgrenciAdi);
            this.panel1.Controls.Add(this.txt_OgrenciDersDersAdi);
            this.panel1.Controls.Add(this.lbl_OgrncDersOgrenciAdi);
            this.panel1.Controls.Add(this.lbl_OgrncDersDersAdi);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 199);
            this.panel1.TabIndex = 29;
            // 
            // txt_OgrenciDersOgrenciAdi
            // 
            this.txt_OgrenciDersOgrenciAdi.Location = new System.Drawing.Point(140, 97);
            this.txt_OgrenciDersOgrenciAdi.Name = "txt_OgrenciDersOgrenciAdi";
            this.txt_OgrenciDersOgrenciAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_OgrenciDersOgrenciAdi.TabIndex = 14;
            // 
            // txt_OgrenciDersDersAdi
            // 
            this.txt_OgrenciDersDersAdi.Location = new System.Drawing.Point(140, 71);
            this.txt_OgrenciDersDersAdi.Name = "txt_OgrenciDersDersAdi";
            this.txt_OgrenciDersDersAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_OgrenciDersDersAdi.TabIndex = 13;
            // 
            // lbl_OgrncDersOgrenciAdi
            // 
            this.lbl_OgrncDersOgrenciAdi.AutoSize = true;
            this.lbl_OgrncDersOgrenciAdi.Location = new System.Drawing.Point(52, 100);
            this.lbl_OgrncDersOgrenciAdi.Name = "lbl_OgrncDersOgrenciAdi";
            this.lbl_OgrncDersOgrenciAdi.Size = new System.Drawing.Size(82, 13);
            this.lbl_OgrncDersOgrenciAdi.TabIndex = 11;
            this.lbl_OgrncDersOgrenciAdi.Text = "Öğrencinin Adı=";
            // 
            // lbl_OgrncDersDersAdi
            // 
            this.lbl_OgrncDersDersAdi.AutoSize = true;
            this.lbl_OgrncDersDersAdi.Location = new System.Drawing.Point(73, 74);
            this.lbl_OgrncDersDersAdi.Name = "lbl_OgrncDersDersAdi";
            this.lbl_OgrncDersDersAdi.Size = new System.Drawing.Size(61, 13);
            this.lbl_OgrncDersDersAdi.TabIndex = 10;
            this.lbl_OgrncDersDersAdi.Text = "Dersin Adı=";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "ÇIKIŞ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OgrenciDersGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 269);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OgrenciDersGiris";
            this.Text = "ÖĞRENCİ DERS GİRİŞ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_OgrenciDersOgrenciAdi;
        private System.Windows.Forms.TextBox txt_OgrenciDersDersAdi;
        private System.Windows.Forms.Label lbl_OgrncDersOgrenciAdi;
        private System.Windows.Forms.Label lbl_OgrncDersDersAdi;
    }
}