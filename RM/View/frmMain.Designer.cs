namespace RM.View
{
    partial class frmMain
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
            this.mainStrip = new System.Windows.Forms.MenuStrip();
            this.menuData = new System.Windows.Forms.ToolStripMenuItem();
            this.listMember = new System.Windows.Forms.ToolStripMenuItem();
            this.listReservasi = new System.Windows.Forms.ToolStripMenuItem();
            this.listPesanan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.pendaftaranStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasiStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.pesanStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTentang = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStrip
            // 
            this.mainStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuData,
            this.menuTransaksi,
            this.menuTentang});
            this.mainStrip.Location = new System.Drawing.Point(0, 0);
            this.mainStrip.Name = "mainStrip";
            this.mainStrip.Size = new System.Drawing.Size(800, 30);
            this.mainStrip.TabIndex = 0;
            this.mainStrip.Text = "menuStrip1";
            // 
            // menuData
            // 
            this.menuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listMember,
            this.listReservasi,
            this.listPesanan});
            this.menuData.Name = "menuData";
            this.menuData.Size = new System.Drawing.Size(55, 24);
            this.menuData.Text = "Data";
            // 
            // listMember
            // 
            this.listMember.Name = "listMember";
            this.listMember.Size = new System.Drawing.Size(179, 26);
            this.listMember.Text = "List Member";
            this.listMember.Click += new System.EventHandler(this.listMember_Click);
            // 
            // listReservasi
            // 
            this.listReservasi.Name = "listReservasi";
            this.listReservasi.Size = new System.Drawing.Size(179, 26);
            this.listReservasi.Text = "List Reservasi";
            this.listReservasi.Click += new System.EventHandler(this.listReservasi_Click);
            // 
            // listPesanan
            // 
            this.listPesanan.Name = "listPesanan";
            this.listPesanan.Size = new System.Drawing.Size(179, 26);
            this.listPesanan.Text = "List Pesanan";
            this.listPesanan.Click += new System.EventHandler(this.listPesanan_Click);
            // 
            // menuTransaksi
            // 
            this.menuTransaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendaftaranStrip,
            this.reservasiStrip,
            this.pesanStrip});
            this.menuTransaksi.Name = "menuTransaksi";
            this.menuTransaksi.Size = new System.Drawing.Size(82, 24);
            this.menuTransaksi.Text = "Transaksi";
            // 
            // pendaftaranStrip
            // 
            this.pendaftaranStrip.Name = "pendaftaranStrip";
            this.pendaftaranStrip.Size = new System.Drawing.Size(231, 26);
            this.pendaftaranStrip.Text = "Pendaftaran Member";
            this.pendaftaranStrip.Click += new System.EventHandler(this.pendaftaranStrip_Click);
            // 
            // reservasiStrip
            // 
            this.reservasiStrip.Name = "reservasiStrip";
            this.reservasiStrip.Size = new System.Drawing.Size(231, 26);
            this.reservasiStrip.Text = "Reservasi";
            this.reservasiStrip.Click += new System.EventHandler(this.reservasiStrip_Click);
            // 
            // pesanStrip
            // 
            this.pesanStrip.Name = "pesanStrip";
            this.pesanStrip.Size = new System.Drawing.Size(231, 26);
            this.pesanStrip.Text = "Pesan";
            this.pesanStrip.Click += new System.EventHandler(this.pesanStrip_Click);
            // 
            // menuTentang
            // 
            this.menuTentang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuTentang.Name = "menuTentang";
            this.menuTentang.Size = new System.Drawing.Size(76, 26);
            this.menuTentang.Text = "Tentang";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainStrip);
            this.MainMenuStrip = this.mainStrip;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Rumah Makan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainStrip.ResumeLayout(false);
            this.mainStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainStrip;
        private System.Windows.Forms.ToolStripMenuItem menuData;
        private System.Windows.Forms.ToolStripMenuItem listMember;
        private System.Windows.Forms.ToolStripMenuItem listReservasi;
        private System.Windows.Forms.ToolStripMenuItem listPesanan;
        private System.Windows.Forms.ToolStripMenuItem menuTransaksi;
        private System.Windows.Forms.ToolStripMenuItem pendaftaranStrip;
        private System.Windows.Forms.ToolStripMenuItem reservasiStrip;
        private System.Windows.Forms.ToolStripMenuItem pesanStrip;
        private System.Windows.Forms.ToolStripMenuItem menuTentang;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}