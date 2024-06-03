namespace RM.View
{
    partial class frmPesan
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
            this.components = new System.ComponentModel.Container();
            this.lvKeranjang = new System.Windows.Forms.ListView();
            this.dgvDaftarMenu = new System.Windows.Forms.DataGridView();
            this.NamaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipeMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tambah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pesananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesan = new Guna.UI2.WinForms.Guna2Button();
            this.btnHitung = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lvKeranjang
            // 
            this.lvKeranjang.HideSelection = false;
            this.lvKeranjang.Location = new System.Drawing.Point(0, 325);
            this.lvKeranjang.Name = "lvKeranjang";
            this.lvKeranjang.Size = new System.Drawing.Size(832, 382);
            this.lvKeranjang.TabIndex = 1;
            this.lvKeranjang.UseCompatibleStateImageBehavior = false;
            // 
            // dgvDaftarMenu
            // 
            this.dgvDaftarMenu.AutoGenerateColumns = false;
            this.dgvDaftarMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaftarMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamaMenu,
            this.TipeMenu,
            this.HargaMenu,
            this.Tambah});
            this.dgvDaftarMenu.DataSource = this.pesananBindingSource;
            this.dgvDaftarMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDaftarMenu.Location = new System.Drawing.Point(0, 0);
            this.dgvDaftarMenu.Name = "dgvDaftarMenu";
            this.dgvDaftarMenu.RowHeadersWidth = 51;
            this.dgvDaftarMenu.RowTemplate.Height = 24;
            this.dgvDaftarMenu.Size = new System.Drawing.Size(832, 287);
            this.dgvDaftarMenu.TabIndex = 2;
            // 
            // NamaMenu
            // 
            this.NamaMenu.DataPropertyName = "Nama";
            this.NamaMenu.HeaderText = "Nama";
            this.NamaMenu.MinimumWidth = 6;
            this.NamaMenu.Name = "NamaMenu";
            this.NamaMenu.Width = 150;
            // 
            // TipeMenu
            // 
            this.TipeMenu.DataPropertyName = "Tipe";
            this.TipeMenu.HeaderText = "Tipe";
            this.TipeMenu.MinimumWidth = 6;
            this.TipeMenu.Name = "TipeMenu";
            this.TipeMenu.Width = 150;
            // 
            // HargaMenu
            // 
            this.HargaMenu.DataPropertyName = "Harga";
            this.HargaMenu.HeaderText = "Harga";
            this.HargaMenu.MinimumWidth = 6;
            this.HargaMenu.Name = "HargaMenu";
            this.HargaMenu.Width = 125;
            // 
            // Tambah
            // 
            this.Tambah.HeaderText = "Tambah";
            this.Tambah.MinimumWidth = 6;
            this.Tambah.Name = "Tambah";
            this.Tambah.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tambah.Text = "Tambah";
            this.Tambah.UseColumnTextForButtonValue = true;
            this.Tambah.Width = 125;
            // 
            // pesananBindingSource
            // 
            this.pesananBindingSource.DataSource = typeof(RM.Model.Entity.DaftarMenu);
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Location = new System.Drawing.Point(362, 730);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(229, 45);
            this.txtTotal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 742);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOTAL";
            // 
            // btnPesan
            // 
            this.btnPesan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPesan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPesan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPesan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPesan.FillColor = System.Drawing.Color.Teal;
            this.btnPesan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPesan.ForeColor = System.Drawing.Color.White;
            this.btnPesan.Image = global::RM.Properties.Resources.bill;
            this.btnPesan.Location = new System.Drawing.Point(609, 730);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(60, 45);
            this.btnPesan.TabIndex = 6;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // btnHitung
            // 
            this.btnHitung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHitung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHitung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHitung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHitung.FillColor = System.Drawing.Color.Teal;
            this.btnHitung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHitung.ForeColor = System.Drawing.Color.White;
            this.btnHitung.Image = global::RM.Properties.Resources.calculator;
            this.btnHitung.Location = new System.Drawing.Point(684, 730);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(60, 45);
            this.btnHitung.TabIndex = 3;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHapus.FillColor = System.Drawing.Color.Teal;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnHapus.Image = global::RM.Properties.Resources.delete;
            this.btnHapus.Location = new System.Drawing.Point(760, 730);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(60, 45);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // frmPesan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(832, 804);
            this.Controls.Add(this.btnPesan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.dgvDaftarMenu);
            this.Controls.Add(this.lvKeranjang);
            this.Name = "frmPesan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftarMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource pesananBindingSource;
        private System.Windows.Forms.ListView lvKeranjang;
        private System.Windows.Forms.DataGridView dgvDaftarMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipeMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaMenu;
        private System.Windows.Forms.DataGridViewButtonColumn Tambah;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2Button btnHitung;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnPesan;
    }
}