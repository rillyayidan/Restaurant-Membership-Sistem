namespace RM.View
{
    partial class frmListPesanan
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
            this.lvPesanan = new System.Windows.Forms.ListView();
            this.btnSelesai = new Guna.UI2.WinForms.Guna2Button();
            this.btnBayar = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lvPesanan
            // 
            this.lvPesanan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvPesanan.HideSelection = false;
            this.lvPesanan.Location = new System.Drawing.Point(0, 0);
            this.lvPesanan.Name = "lvPesanan";
            this.lvPesanan.Size = new System.Drawing.Size(721, 377);
            this.lvPesanan.TabIndex = 0;
            this.lvPesanan.UseCompatibleStateImageBehavior = false;
            // 
            // btnSelesai
            // 
            this.btnSelesai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelesai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelesai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelesai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelesai.FillColor = System.Drawing.Color.Teal;
            this.btnSelesai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelesai.ForeColor = System.Drawing.Color.White;
            this.btnSelesai.Image = global::RM.Properties.Resources.complete;
            this.btnSelesai.Location = new System.Drawing.Point(499, 433);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(59, 49);
            this.btnSelesai.TabIndex = 1;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // btnBayar
            // 
            this.btnBayar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBayar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBayar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBayar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBayar.FillColor = System.Drawing.Color.Teal;
            this.btnBayar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBayar.ForeColor = System.Drawing.Color.White;
            this.btnBayar.Image = global::RM.Properties.Resources.valid;
            this.btnBayar.Location = new System.Drawing.Point(575, 433);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(59, 49);
            this.btnBayar.TabIndex = 1;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
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
            this.btnHapus.Location = new System.Drawing.Point(650, 433);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(59, 49);
            this.btnHapus.TabIndex = 1;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // frmListPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 511);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.lvPesanan);
            this.Name = "frmListPesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Pesanan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPesanan;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2Button btnBayar;
        private Guna.UI2.WinForms.Guna2Button btnSelesai;
    }
}