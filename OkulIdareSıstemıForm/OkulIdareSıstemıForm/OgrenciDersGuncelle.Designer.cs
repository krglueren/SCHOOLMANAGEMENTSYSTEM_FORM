namespace OkulIdareSıstemıForm
{
    partial class OgrenciDersGuncelle
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
            this.txt_OgrenciDersOgrenciAdi = new System.Windows.Forms.TextBox();
            this.txt_OgrenciDersDersAdi = new System.Windows.Forms.TextBox();
            this.txt_OgrenciDersId = new System.Windows.Forms.TextBox();
            this.lbl_OgrncDersOgrenciAdi = new System.Windows.Forms.Label();
            this.lbl_OgrncDersDersAdi = new System.Windows.Forms.Label();
            this.lbl_OgrncDersId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "GÜNCELLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.txt_OgrenciDersOgrenciAdi);
            this.panel1.Controls.Add(this.txt_OgrenciDersDersAdi);
            this.panel1.Controls.Add(this.txt_OgrenciDersId);
            this.panel1.Controls.Add(this.lbl_OgrncDersOgrenciAdi);
            this.panel1.Controls.Add(this.lbl_OgrncDersDersAdi);
            this.panel1.Controls.Add(this.lbl_OgrncDersId);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 199);
            this.panel1.TabIndex = 31;
            // 
            // txt_OgrenciDersOgrenciAdi
            // 
            this.txt_OgrenciDersOgrenciAdi.Location = new System.Drawing.Point(161, 118);
            this.txt_OgrenciDersOgrenciAdi.Name = "txt_OgrenciDersOgrenciAdi";
            this.txt_OgrenciDersOgrenciAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_OgrenciDersOgrenciAdi.TabIndex = 14;
            // 
            // txt_OgrenciDersDersAdi
            // 
            this.txt_OgrenciDersDersAdi.Location = new System.Drawing.Point(161, 92);
            this.txt_OgrenciDersDersAdi.Name = "txt_OgrenciDersDersAdi";
            this.txt_OgrenciDersDersAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_OgrenciDersDersAdi.TabIndex = 13;
            // 
            // txt_OgrenciDersId
            // 
            this.txt_OgrenciDersId.Location = new System.Drawing.Point(161, 66);
            this.txt_OgrenciDersId.Name = "txt_OgrenciDersId";
            this.txt_OgrenciDersId.Size = new System.Drawing.Size(100, 20);
            this.txt_OgrenciDersId.TabIndex = 12;
            // 
            // lbl_OgrncDersOgrenciAdi
            // 
            this.lbl_OgrncDersOgrenciAdi.AutoSize = true;
            this.lbl_OgrncDersOgrenciAdi.Location = new System.Drawing.Point(73, 121);
            this.lbl_OgrncDersOgrenciAdi.Name = "lbl_OgrncDersOgrenciAdi";
            this.lbl_OgrncDersOgrenciAdi.Size = new System.Drawing.Size(82, 13);
            this.lbl_OgrncDersOgrenciAdi.TabIndex = 11;
            this.lbl_OgrncDersOgrenciAdi.Text = "Öğrencinin Adı=";
            // 
            // lbl_OgrncDersDersAdi
            // 
            this.lbl_OgrncDersDersAdi.AutoSize = true;
            this.lbl_OgrncDersDersAdi.Location = new System.Drawing.Point(94, 95);
            this.lbl_OgrncDersDersAdi.Name = "lbl_OgrncDersDersAdi";
            this.lbl_OgrncDersDersAdi.Size = new System.Drawing.Size(61, 13);
            this.lbl_OgrncDersDersAdi.TabIndex = 10;
            this.lbl_OgrncDersDersAdi.Text = "Dersin Adı=";
            // 
            // lbl_OgrncDersId
            // 
            this.lbl_OgrncDersId.AutoSize = true;
            this.lbl_OgrncDersId.Location = new System.Drawing.Point(31, 69);
            this.lbl_OgrncDersId.Name = "lbl_OgrncDersId";
            this.lbl_OgrncDersId.Size = new System.Drawing.Size(124, 13);
            this.lbl_OgrncDersId.TabIndex = 9;
            this.lbl_OgrncDersId.Text = "Öğrencinin Dersinin Idsi=";
            // 
            // OgrenciDersGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OgrenciDersGuncelle";
            this.Text = "ÖĞRENCİ DERS GÜNCELLE";
            this.Load += new System.EventHandler(this.OgrenciDersGuncelle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_OgrenciDersOgrenciAdi;
        private System.Windows.Forms.TextBox txt_OgrenciDersDersAdi;
        private System.Windows.Forms.TextBox txt_OgrenciDersId;
        private System.Windows.Forms.Label lbl_OgrncDersOgrenciAdi;
        private System.Windows.Forms.Label lbl_OgrncDersDersAdi;
        private System.Windows.Forms.Label lbl_OgrncDersId;
    }
}