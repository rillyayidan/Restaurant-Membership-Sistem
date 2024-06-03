using System;
using System.Windows.Forms;
using RM.Controller;

namespace RM.View
{
    public partial class frmPendaftaran : Form
    {
        private PendaftaranController controller;

        public frmPendaftaran(PendaftaranController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string nomorTelepon = txtNomorTelepon.Text;
            string nama = txtNama.Text;

            // Validasi nomor telepon dan nama sebelum mendaftarkan
            if (string.IsNullOrWhiteSpace(nomorTelepon) || string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nomor Telepon dan Nama harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Panggil method untuk mendaftarkan member
            controller.DaftarMember(nomorTelepon, nama);

            // Clear input setelah mendaftar
            txtNomorTelepon.Clear();
            txtNama.Clear();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
