using RM.Controller;
using RM.Model.Context;
using RM.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.View
{
    public partial class frmEditReservasi : Form
    {
        private RumahMakanController controller;
        private mainDatabase database;
        private Reservasi reservasiToEdit;

        public frmEditReservasi(RumahMakanController controller, mainDatabase database, Reservasi reservasi)
        {
            InitializeComponent();
            this.controller = controller;
            this.database = database;
            this.reservasiToEdit = reservasi;

            // Tampilkan data reservasi yang akan diedit pada komponen form
            txtNomorTelepon.Text = reservasiToEdit.NomorTelepon;
            txtNama.Text = reservasiToEdit.Nama;
            nudJumlahOrang.Value = reservasiToEdit.JumlahOrang;
            nudNomorMeja.Value = reservasiToEdit.NomorMeja;
            dtpTanggal.Value = reservasiToEdit.TanggalJam.Date;
            ComboBoxJam.SelectedItem = reservasiToEdit.TanggalJam.ToString("HH:mm");
            ComboBoxJam.DataSource = new List<string> { "10:00", "12:00", "15:00", "17:00", "19:00" };
            ComboBoxJam.SelectedIndex = 0; // Set index pertama sebagai default (atau sesuaikan dengan kebutuhan)
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            // Ambil data dari kontrol
            string nomorTeleponBaru = txtNomorTelepon.Text; // Ambil nomor telepon yang baru
            string nama = txtNama.Text;
            int jumlahOrang = Convert.ToInt32(nudJumlahOrang.Value);
            int nomorMeja = Convert.ToInt32(nudNomorMeja.Value);

            // Ambil data dari DateTimePicker dan ComboBox
            DateTime tanggal = dtpTanggal.Value;

            // Periksa jika ComboBoxJam.SelectedItem null atau kosong
            string jam = ComboBoxJam.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(jam))
            {
                MessageBox.Show("Pilih jam terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lanjutkan dengan menggunakan nilai 'jam' yang valid
            DateTime tanggalJam = tanggal.Add(TimeSpan.Parse(jam));

            // Perbarui nilai NomorTelepon pada objek reservasiToEdit
            reservasiToEdit.NomorTelepon = nomorTeleponBaru;

            // Update data pada objek reservasiToEdit
            reservasiToEdit.Nama = nama;
            reservasiToEdit.TanggalJam = tanggalJam;
            reservasiToEdit.JumlahOrang = jumlahOrang;
            reservasiToEdit.NomorMeja = nomorMeja;

            // Panggil metode untuk mengedit reservasi
            bool success = controller.EditReservasi(reservasiToEdit);

            // Menampilkan pesan hasil
            if (success)
            {
                MessageBox.Show("Reservasi berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal mengubah reservasi. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
