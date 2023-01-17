namespace OkulIdareSıstemıForm
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ogrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetimGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöetimListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDersGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDersListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fotoğrafKaldırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ogrenciToolStripMenuItem,
            this.yönetimToolStripMenuItem,
            this.dersToolStripMenuItem,
            this.öğrenciDersToolStripMenuItem,
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ogrenciToolStripMenuItem
            // 
            this.ogrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciListeleToolStripMenuItem,
            this.öğrenciEklemeToolStripMenuItem});
            this.ogrenciToolStripMenuItem.Image = global::OkulIdareSıstemıForm.Properties.Resources._2995620;
            this.ogrenciToolStripMenuItem.Name = "ogrenciToolStripMenuItem";
            this.ogrenciToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.ogrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // öğrenciListeleToolStripMenuItem
            // 
            this.öğrenciListeleToolStripMenuItem.Name = "öğrenciListeleToolStripMenuItem";
            this.öğrenciListeleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.öğrenciListeleToolStripMenuItem.Text = "Öğrenci Giriş";
            this.öğrenciListeleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListeleToolStripMenuItem_Click);
            // 
            // öğrenciEklemeToolStripMenuItem
            // 
            this.öğrenciEklemeToolStripMenuItem.Name = "öğrenciEklemeToolStripMenuItem";
            this.öğrenciEklemeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.öğrenciEklemeToolStripMenuItem.Text = "Öğrenci Listele";
            this.öğrenciEklemeToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEklemeToolStripMenuItem_Click);
            // 
            // yönetimToolStripMenuItem
            // 
            this.yönetimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yönetimGirişToolStripMenuItem,
            this.yöetimListeleToolStripMenuItem});
            this.yönetimToolStripMenuItem.Image = global::OkulIdareSıstemıForm.Properties.Resources._1864509;
            this.yönetimToolStripMenuItem.Name = "yönetimToolStripMenuItem";
            this.yönetimToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.yönetimToolStripMenuItem.Text = "Yönetim";
            // 
            // yönetimGirişToolStripMenuItem
            // 
            this.yönetimGirişToolStripMenuItem.Name = "yönetimGirişToolStripMenuItem";
            this.yönetimGirişToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.yönetimGirişToolStripMenuItem.Text = "Yönetim Giriş";
            this.yönetimGirişToolStripMenuItem.Click += new System.EventHandler(this.yönetimGirişToolStripMenuItem_Click);
            // 
            // yöetimListeleToolStripMenuItem
            // 
            this.yöetimListeleToolStripMenuItem.Name = "yöetimListeleToolStripMenuItem";
            this.yöetimListeleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.yöetimListeleToolStripMenuItem.Text = "Yönetim Listele";
            this.yöetimListeleToolStripMenuItem.Click += new System.EventHandler(this.yöetimListeleToolStripMenuItem_Click);
            // 
            // dersToolStripMenuItem
            // 
            this.dersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersGirişToolStripMenuItem,
            this.dersListeleToolStripMenuItem});
            this.dersToolStripMenuItem.Image = global::OkulIdareSıstemıForm.Properties.Resources._3246314;
            this.dersToolStripMenuItem.Name = "dersToolStripMenuItem";
            this.dersToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.dersToolStripMenuItem.Text = "Ders";
            // 
            // dersGirişToolStripMenuItem
            // 
            this.dersGirişToolStripMenuItem.Name = "dersGirişToolStripMenuItem";
            this.dersGirişToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dersGirişToolStripMenuItem.Text = "Ders Giriş";
            this.dersGirişToolStripMenuItem.Click += new System.EventHandler(this.dersGirişToolStripMenuItem_Click);
            // 
            // dersListeleToolStripMenuItem
            // 
            this.dersListeleToolStripMenuItem.Name = "dersListeleToolStripMenuItem";
            this.dersListeleToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dersListeleToolStripMenuItem.Text = "Ders Listele";
            this.dersListeleToolStripMenuItem.Click += new System.EventHandler(this.dersListeleToolStripMenuItem_Click);
            // 
            // öğrenciDersToolStripMenuItem
            // 
            this.öğrenciDersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciDersGirişToolStripMenuItem,
            this.öğrenciDersListeleToolStripMenuItem});
            this.öğrenciDersToolStripMenuItem.Image = global::OkulIdareSıstemıForm.Properties.Resources._5402847;
            this.öğrenciDersToolStripMenuItem.Name = "öğrenciDersToolStripMenuItem";
            this.öğrenciDersToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.öğrenciDersToolStripMenuItem.Text = "Öğrenci Ders";
            // 
            // öğrenciDersGirişToolStripMenuItem
            // 
            this.öğrenciDersGirişToolStripMenuItem.Name = "öğrenciDersGirişToolStripMenuItem";
            this.öğrenciDersGirişToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğrenciDersGirişToolStripMenuItem.Text = "Öğrenci Ders Giriş";
            this.öğrenciDersGirişToolStripMenuItem.Click += new System.EventHandler(this.öğrenciDersGirişToolStripMenuItem_Click);
            // 
            // öğrenciDersListeleToolStripMenuItem
            // 
            this.öğrenciDersListeleToolStripMenuItem.Name = "öğrenciDersListeleToolStripMenuItem";
            this.öğrenciDersListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğrenciDersListeleToolStripMenuItem.Text = "Öğrenci Ders Listele";
            this.öğrenciDersListeleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciDersListeleToolStripMenuItem_Click);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fotoğrafKaldırToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // fotoğrafKaldırToolStripMenuItem
            // 
            this.fotoğrafKaldırToolStripMenuItem.Name = "fotoğrafKaldırToolStripMenuItem";
            this.fotoğrafKaldırToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fotoğrafKaldırToolStripMenuItem.Text = "Fotoğraf Kaldır";
            this.fotoğrafKaldırToolStripMenuItem.Click += new System.EventHandler(this.fotoğrafKaldırToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 806);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(910, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "ANASAYFA";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Value = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OkulIdareSıstemıForm.Properties.Resources.pirireisuniversitesibasinodasilogo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 828);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OKUL İDARE SİSTEMİ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem ogrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yönetimGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöetimListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fotoğrafKaldırToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDersGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDersListeleToolStripMenuItem;
    }
}