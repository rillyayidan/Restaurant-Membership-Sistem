using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using RM.Controller;
using RM.Model.Entity;

namespace RM.View
{
    public partial class frmListPesanan : Form
    {
        private RumahMakanController controller;
        public frmListPesanan(RumahMakanController controller)
        {
            InitializeComponent();
            this.controller = controller;

            // Tambahkan event handler untuk event Load form
            this.Load += FrmListPesanan_Load;

            // Inisialisasi ListView (lvPesanan)
            lvPesanan.View = System.Windows.Forms.View.Details;
            lvPesanan.GridLines = true;
            lvPesanan.FullRowSelect = true;

            // Tambahkan kolom-kolom ke ListView
            lvPesanan.Columns.Add("ID Pesanan", 100, HorizontalAlignment.Center);
            lvPesanan.Columns.Add("List Menu", 200, HorizontalAlignment.Center);
            lvPesanan.Columns.Add("Total Menu", 100, HorizontalAlignment.Center);
            lvPesanan.Columns.Add("Status", 120, HorizontalAlignment.Center);
        }

        // Event handler untuk event Load form
        private void FrmListPesanan_Load(object sender, EventArgs e)
        {
            // Panggil metode inisialisasi saat form dimuat
            InisialisasiListPesanan();
        }

        // Metode untuk menginisialisasi daftar pesanan
        private void InisialisasiListPesanan()
        {
            // Dapatkan daftar pesanan dari controller
            List<Pesanan> daftarPesanan = controller.GetDaftarPesanan();

            // Tambahkan daftar pesanan ke ListView
            foreach (Pesanan pesanan in daftarPesanan)
            {
                ListViewItem item = new ListViewItem(pesanan.IDPesanan.ToString());
                item.SubItems.Add(pesanan.ListMenu);
                item.SubItems.Add(pesanan.TotalMenu.ToString());
                item.SubItems.Add(pesanan.Status);

                lvPesanan.Items.Add(item);
            }
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Pastikan ada item yang dipilih
            if (lvPesanan.SelectedItems.Count > 0)
            {
                // Ambil data dari subitem-subitem yang dipilih
                ListViewItem selectedItem = lvPesanan.SelectedItems[0];
                string idPesanan = selectedItem.SubItems[0].Text; // ID Pesanan berada di kolom pertama (indeks 0)

                // Buat objek Pesanan
                Pesanan pesananDipilih = new Pesanan
                {
                    IDPesanan = int.Parse(idPesanan)
                };

                // Tanyakan konfirmasi kepada pengguna
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus pesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Hapus pesanan dari database menggunakan controller
                    bool berhasil = controller.HapusPesanan(pesananDipilih);

                    // Jika penghapusan berhasil, hapus juga dari ListView
                    if (berhasil)
                    {
                        lvPesanan.Items.Remove(selectedItem);
                        MessageBox.Show("Pesanan berhasil dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus pesanan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih pesanan yang ingin dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnBayar_Click(object sender, EventArgs e)
        {
            // Pastikan ada item yang dipilih
            if (lvPesanan.SelectedItems.Count > 0)
            {
                // Ambil data dari subitem-subitem yang dipilih
                ListViewItem selectedItem = lvPesanan.SelectedItems[0];
                string idPesanan = selectedItem.SubItems[0].Text;
                string listMenu = selectedItem.SubItems[1].Text;
                string totalMenu = selectedItem.SubItems[2].Text;
                string status = selectedItem.SubItems[3].Text;

                // Buat objek Pesanan
                Pesanan pesananDipilih = new Pesanan
                {
                    IDPesanan = int.Parse(idPesanan),
                    ListMenu = listMenu,
                    TotalMenu = int.Parse(totalMenu),
                    Status = status
                };

                // Periksa apakah status "Pending" sebelum melakukan pembayaran
                if (pesananDipilih.Status == "Pending")
                {
                    // Buka form pembayaran dan kirim referensi lvPesanan
                    frmBayar frmBayar = new frmBayar(pesananDipilih, lvPesanan);
                    frmBayar.ShowDialog(); // Menggunakan ShowDialog agar form pembayaran modal

                    // Periksa apakah pembayaran berhasil dilakukan
                    if (frmBayar.PembayaranBerhasil)
                    {
                        // Perbarui status di ListView
                        selectedItem.SubItems[3].Text = "On-Progress";
                    }
                }
                else
                {
                    MessageBox.Show("Pesanan sudah dibayar atau dalam proses.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Pilih pesanan yang ingin dibayar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            // Pastikan ada item yang dipilih
            if (lvPesanan.SelectedItems.Count > 0)
            {
                // Ambil data dari subitem-subitem yang dipilih
                ListViewItem selectedItem = lvPesanan.SelectedItems[0];
                string idPesanan = selectedItem.SubItems[0].Text; // ID Pesanan berada di kolom pertama (indeks 0)
                string listMenu = selectedItem.SubItems[1].Text;
                string totalMenu = selectedItem.SubItems[2].Text;
                string status = selectedItem.SubItems[3].Text;

                // Buat objek Pesanan
                Pesanan pesananDipilih = new Pesanan
                {
                    IDPesanan = int.Parse(idPesanan),
                    ListMenu = listMenu,
                    TotalMenu = int.Parse(totalMenu),
                    Status = status
                };

                // Periksa apakah status "On-Progress" sebelum menyelesaikan pesanan
                if (pesananDipilih.Status == "On-Progress")
                {
                    // Update status pesanan menjadi "Delivered"
                    pesananDipilih.Status = "Delivered";

                    // Perbarui status di ListView
                    selectedItem.SubItems[3].Text = pesananDipilih.Status;

                    MessageBox.Show("Pesanan selesai.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pesanan belum dalam proses.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Pilih pesanan yang ingin diselesaikan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}