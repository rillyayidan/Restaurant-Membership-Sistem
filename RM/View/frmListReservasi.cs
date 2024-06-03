using RM.Controller;
using RM.Model.Context;
using RM.Model.Entity;
using System;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace RM.View
{
    public partial class frmListReservasi : Form
    {
        private RumahMakanController controller;
        private mainDatabase database;
        private Reservasi reservasiToEdit;

        public frmListReservasi(RumahMakanController controller, mainDatabase database)
        {
            InitializeComponent();
            this.controller = controller;

            // Panggil metode untuk menyiapkan dan menampilkan data reservasi
            SetupListView();
            LoadReservasiData();
            this.database = database;
            UpdateListView();
        }

        private void SetupListView()
        {
            // Inisialisasi ListView
            lvReservasi.View = System.Windows.Forms.View.Details;
            lvReservasi.GridLines = true;
            lvReservasi.FullRowSelect = true;

            // Tambahkan kolom-kolom ke ListView
            lvReservasi.Columns.Add("Nomor Telepon", 120);
            lvReservasi.Columns.Add("Nama", 120);
            lvReservasi.Columns.Add("Tanggal & Jam", 150, HorizontalAlignment.Center);
            lvReservasi.Columns.Add("Jumlah Orang", 100, HorizontalAlignment.Center);
            lvReservasi.Columns.Add("Nomor Meja", 100, HorizontalAlignment.Center);
        }

        private void LoadReservasiData()
        {
            // Panggil metode atau logika untuk mengambil data reservasi dari database
            // Misalnya, menggunakan controller.GetAllReservasi() dan mengisi ListView
            var reservasiList = controller.GetAllReservasi();

            // Tambahkan data ke ListView
            foreach (var reservasi in reservasiList)
            {
                ListViewItem item = new ListViewItem(reservasi.NomorTelepon);
                item.SubItems.Add(reservasi.Nama);
                item.SubItems.Add(reservasi.TanggalJam.ToString("yyyy-MM-dd HH:mm"));
                item.SubItems.Add(reservasi.JumlahOrang.ToString());
                item.SubItems.Add(reservasi.NomorMeja.ToString());

                lvReservasi.Items.Add(item);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvReservasi.SelectedItems.Count > 0)
            {
                // Ambil Nomor Telepon dari item yang dipilih
                string nomorTelepon = lvReservasi.SelectedItems[0].Text;

                // Lakukan logika penghapusan reservasi melalui controller
                bool success = controller.HapusReservasi(nomorTelepon);

                // Jika penghapusan berhasil, hapus item dari ListView
                if (success)
                {
                    lvReservasi.SelectedItems[0].Remove();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus reservasi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pilih reservasi yang ingin dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            // Ambil keyword dari TextBox
            string keyword = txtCari.Text.Trim();

            // Lakukan pencarian menggunakan controller
            var searchResult = controller.CariReservasi(keyword);

            // Clear ListView sebelum menambahkan hasil pencarian
            lvReservasi.Items.Clear();

            // Tambahkan hasil pencarian ke ListView
            foreach (var reservasi in searchResult)
            {
                ListViewItem item = new ListViewItem(reservasi.NomorTelepon);
                item.SubItems.Add(reservasi.Nama);
                item.SubItems.Add(reservasi.TanggalJam.ToString("yyyy-MM-dd HH:mm"));
                item.SubItems.Add(reservasi.JumlahOrang.ToString());
                item.SubItems.Add(reservasi.NomorMeja.ToString());

                lvReservasi.Items.Add(item);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvReservasi.SelectedItems.Count > 0)
            {
                // Ambil Nomor Telepon dari item yang dipilih
                string nomorTelepon = lvReservasi.SelectedItems[0].Text;

                // Temukan data reservasi yang akan diedit
                reservasiToEdit = controller.GetAllReservasi().FirstOrDefault(r => r.NomorTelepon == nomorTelepon);

                // Membuat objek frmEditReservasi dan memberikan instance ReservasiController
                frmEditReservasi formEditReservasi = new frmEditReservasi(controller, database, reservasiToEdit);

                // Menampilkan frmEditReservasi
                formEditReservasi.ShowDialog();

                // Panggil metode UpdateListView setelah formEditReservasi ditutup
                UpdateListView();
            }
            else
            {
                MessageBox.Show("Pilih reservasi yang ingin diedit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void UpdateListView()
        {
            // Clear ListView sebelum menambahkan data terbaru
            lvReservasi.Items.Clear();

            // Panggil metode atau logika untuk mengambil data reservasi dari database
            // Misalnya, menggunakan controller.GetAllReservasi() dan mengisi ListView
            var reservasiList = controller.GetAllReservasi();

            // Tambahkan data ke ListView
            foreach (var reservasi in reservasiList)
            {
                ListViewItem item = new ListViewItem(reservasi.NomorTelepon);
                item.SubItems.Add(reservasi.Nama);
                item.SubItems.Add(reservasi.TanggalJam.ToString("yyyy-MM-dd HH:mm"));
                item.SubItems.Add(reservasi.JumlahOrang.ToString());
                item.SubItems.Add(reservasi.NomorMeja.ToString());

                lvReservasi.Items.Add(item);
            }
        }
    }
}