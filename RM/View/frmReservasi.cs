using RM.Controller;
using RM.Model.Entity;
using RM.Model.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RM.View
{
    public partial class frmReservasi : Form
    {
        private RumahMakanController controller;
        private ReservasiController reservasiController;
        private ReservasiRepository repository;

        public frmReservasi(RumahMakanController controller, ReservasiRepository repository, ReservasiController reservasiController)
        {
            InitializeComponent();
            this.controller = controller;
            this.repository = repository;
            this.reservasiController = reservasiController;
            // Inisialisasi ComboBoxJam
            ComboBoxJam.DataSource = new List<string> { "10:00", "12:00", "15:00", "17:00", "19:00" };
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            // Ambil data dari kontrol
            string nomorTelepon = txtNomorTelepon.Text;
            string nama = txtNama.Text;
            int jumlahOrang = Convert.ToInt32(nudJumlahOrang.Value);
            int nomorMeja = Convert.ToInt32(nudNomorMeja.Value);

            // Ambil data dari DateTimePicker dan ComboBox
            DateTime tanggal = dtpTanggal.Value;
            string jam = ComboBoxJam.SelectedItem.ToString();
            DateTime tanggalJam = tanggal.Add(TimeSpan.Parse(jam));

            // Membuat objek Reservasi
            Reservasi reservasi = new Reservasi
            {
                NomorTelepon = nomorTelepon,
                Nama = nama,
                TanggalJam = tanggalJam,
                JumlahOrang = jumlahOrang,
                NomorMeja = nomorMeja
            };

            // Menampilkan kotak dialog konfirmasi
            DialogResult result = MessageBox.Show("Apakah kamu yakin ingin melakukan reservasi? Nomor Telepon tidak dapat diubah.",
                                                  "Konfirmasi Reservasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Jika pengguna memilih "Yes", lanjutkan dengan reservasi
            if (result == DialogResult.Yes)
            {
                // Inisialisasi reservasiController
                ReservasiController reservasiController = new ReservasiController(this.controller, this.repository, this.reservasiController);

                // Memanggil metode untuk membuat reservasi
                bool success = reservasiController.CreateReservasi(reservasi);

                // Menampilkan pesan hasil
                if (success)
                {
                    MessageBox.Show("Reservasi berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Tambahkan logika lain yang diperlukan setelah reservasi berhasil
                }
                else
                {
                    MessageBox.Show("Reservasi gagal. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
