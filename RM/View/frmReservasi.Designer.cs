namespace RM.View
{
    partial class frmReservasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNomorTelepon = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpTanggal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ComboBoxJam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nudJumlahOrang = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnReservasi = new Guna.UI2.WinForms.Guna2Button();
            this.nudNomorMeja = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnSelesai = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahOrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNomorMeja)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nomor Telepon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tanggal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Jam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Jumlah Orang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nomor Meja";
            // 
            // txtNama
            // 
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Location = new System.Drawing.Point(209, 38);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderText = "";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(229, 33);
            this.txtNama.TabIndex = 1;
            // 
            // txtNomorTelepon
            // 
            this.txtNomorTelepon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomorTelepon.DefaultText = "";
            this.txtNomorTelepon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomorTelepon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomorTelepon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomorTelepon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomorTelepon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomorTelepon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNomorTelepon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomorTelepon.Location = new System.Drawing.Point(209, 100);
            this.txtNomorTelepon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomorTelepon.Name = "txtNomorTelepon";
            this.txtNomorTelepon.PasswordChar = '\0';
            this.txtNomorTelepon.PlaceholderText = "";
            this.txtNomorTelepon.SelectedText = "";
            this.txtNomorTelepon.Size = new System.Drawing.Size(229, 36);
            this.txtNomorTelepon.TabIndex = 1;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Checked = true;
            this.dtpTanggal.FillColor = System.Drawing.Color.Teal;
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTanggal.Location = new System.Drawing.Point(209, 161);
            this.dtpTanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTanggal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(288, 45);
            this.dtpTanggal.TabIndex = 2;
            this.dtpTanggal.Value = new System.DateTime(2023, 12, 13, 0, 1, 30, 183);
            // 
            // ComboBoxJam
            // 
            this.ComboBoxJam.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxJam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxJam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxJam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxJam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxJam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxJam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxJam.ItemHeight = 30;
            this.ComboBoxJam.Location = new System.Drawing.Point(209, 239);
            this.ComboBoxJam.Name = "ComboBoxJam";
            this.ComboBoxJam.Size = new System.Drawing.Size(229, 36);
            this.ComboBoxJam.TabIndex = 3;
            // 
            // nudJumlahOrang
            // 
            this.nudJumlahOrang.BackColor = System.Drawing.Color.Transparent;
            this.nudJumlahOrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudJumlahOrang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudJumlahOrang.Location = new System.Drawing.Point(209, 308);
            this.nudJumlahOrang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudJumlahOrang.Name = "nudJumlahOrang";
            this.nudJumlahOrang.Size = new System.Drawing.Size(114, 48);
            this.nudJumlahOrang.TabIndex = 4;
            // 
            // btnReservasi
            // 
            this.btnReservasi.Animated = true;
            this.btnReservasi.AutoRoundedCorners = true;
            this.btnReservasi.BorderRadius = 21;
            this.btnReservasi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReservasi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReservasi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReservasi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReservasi.FillColor = System.Drawing.Color.Teal;
            this.btnReservasi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReservasi.ForeColor = System.Drawing.Color.White;
            this.btnReservasi.Location = new System.Drawing.Point(77, 464);
            this.btnReservasi.Name = "btnReservasi";
            this.btnReservasi.Size = new System.Drawing.Size(180, 45);
            this.btnReservasi.TabIndex = 5;
            this.btnReservasi.Text = "Reservasi";
            this.btnReservasi.Click += new System.EventHandler(this.btnReservasi_Click);
            // 
            // nudNomorMeja
            // 
            this.nudNomorMeja.BackColor = System.Drawing.Color.Transparent;
            this.nudNomorMeja.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNomorMeja.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudNomorMeja.Location = new System.Drawing.Point(209, 383);
            this.nudNomorMeja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudNomorMeja.Name = "nudNomorMeja";
            this.nudNomorMeja.Size = new System.Drawing.Size(114, 48);
            this.nudNomorMeja.TabIndex = 4;
            // 
            // btnSelesai
            // 
            this.btnSelesai.Animated = true;
            this.btnSelesai.AutoRoundedCorners = true;
            this.btnSelesai.BorderRadius = 21;
            this.btnSelesai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelesai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelesai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelesai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelesai.FillColor = System.Drawing.Color.Teal;
            this.btnSelesai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelesai.ForeColor = System.Drawing.Color.White;
            this.btnSelesai.Location = new System.Drawing.Point(301, 464);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(180, 45);
            this.btnSelesai.TabIndex = 6;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // frmReservasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 563);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnReservasi);
            this.Controls.Add(this.nudNomorMeja);
            this.Controls.Add(this.nudJumlahOrang);
            this.Controls.Add(this.ComboBoxJam);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.txtNomorTelepon);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReservasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservasi";
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahOrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNomorMeja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtNomorTelepon;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTanggal;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxJam;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudJumlahOrang;
        private Guna.UI2.WinForms.Guna2Button btnReservasi;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNomorMeja;
        private Guna.UI2.WinForms.Guna2Button btnSelesai;
    }
}