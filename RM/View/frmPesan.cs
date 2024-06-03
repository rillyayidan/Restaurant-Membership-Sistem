using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Guna.UI2.AnimatorNS;
using RM.Controller;
using RM.Model.Entity;

namespace RM.View
{
    public partial class frmPesan : Form
    {
        private RumahMakanController controller;

        public frmPesan(RumahMakanController controller)
        {
            InitializeComponent();
            // Tambahkan event handler untuk event Load form
            this.Load += FrmPesan_Load;
            this.controller = controller;
        }

        // Metode untuk menginisialisasi daftar menu
        private void InisialisasiDaftarMenu()
        {
            // Buat daftar menu dan tambahkan beberapa contoh menu
            List<DaftarMenu> daftarMenu = new List<DaftarMenu>
            {
                new DaftarMenu { Nama = "Nasi Goreng", Tipe = "Makanan", Harga = 20000 },
                new DaftarMenu { Nama = "Ayam Bakar Taliwang", Tipe = "Makanan", Harga = 35000 },
                new DaftarMenu { Nama = "Sate Ayam Madura", Tipe = "Makanan", Harga = 20000 },
                new DaftarMenu { Nama = "Mie Goreng Jawa", Tipe = "Makanan", Harga = 18000 },
                new DaftarMenu { Nama = "Gado-Gado", Tipe = "Makanan", Harga = 15000 },
                new DaftarMenu { Nama = "Pecel Lele", Tipe = "Makanan", Harga = 22000 },
                new DaftarMenu { Nama = "Soto Ayam", Tipe = "Makanan", Harga = 25000 },
                new DaftarMenu { Nama = "Rendang Daging", Tipe = "Makanan", Harga = 40000 },
                new DaftarMenu { Nama = "Nasi Rawon", Tipe = "Makanan", Harga = 30000 },
                new DaftarMenu { Nama = "Capcay Goreng", Tipe = "Makanan", Harga = 28000 },
                new DaftarMenu { Nama = "Es Teh Manis", Tipe = "Minuman", Harga = 5000 },
                new DaftarMenu { Nama = "Jus Alpukat", Tipe = "Minuman", Harga = 12000 },
                new DaftarMenu { Nama = "Es Jeruk Nipis", Tipe = "Minuman", Harga = 6000 },
                new DaftarMenu { Nama = "Teh Tarik", Tipe = "Minuman", Harga = 8000 },
                new DaftarMenu { Nama = "Jus Mangga", Tipe = "Minuman", Harga = 10000 },
                new DaftarMenu { Nama = "Es Cincau Hijau", Tipe = "Minuman", Harga = 7000 },
                new DaftarMenu { Nama = "Kopi Tubruk", Tipe = "Minuman", Harga = 9000 },
                new DaftarMenu { Nama = "Jus Strawberry", Tipe = "Minuman", Harga = 11000 },
                new DaftarMenu { Nama = "Es Campur", Tipe = "Minuman", Harga = 10000 },
                new DaftarMenu { Nama = "Susu Jahe", Tipe = "Minuman", Harga = 12000 },
            };

            // Tambahkan daftar menu ke DataGridView
            dgvDaftarMenu.DataSource = daftarMenu;
        }

        // Event handler untuk event Load form
        private void FrmPesan_Load(object sender, EventArgs e)
        {
            // Panggil metode inisialisasi saat form dimuat
            InisialisasiDaftarMenu();

            // Inisialisasi ListView (lvKeranjang)
            lvKeranjang.View = System.Windows.Forms.View.Details;
            lvKeranjang.GridLines = true;
            lvKeranjang.FullRowSelect = true;

            // Tambahkan kolom-kolom ke ListView
            lvKeranjang.Columns.Add("Nama Menu", 120);
            lvKeranjang.Columns.Add("Tipe Menu", 100);
            lvKeranjang.Columns.Add("Harga", 100);
            lvKeranjang.Columns.Add("Jumlah", 100);
            lvKeranjang.Columns.Add("Total", 100);

            dgvDaftarMenu.CellContentClick += dgvDaftarMenu_CellContentClick;
        }

        // Event handler untuk event CellFormatting DataGridView
        private void dgvDaftarMenu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Format harga agar ditampilkan sebagai angka
            if (dgvDaftarMenu.Columns[e.ColumnIndex].Name == "Harga" && e.RowIndex >= 0)
            {
                e.Value = ((int)e.Value).ToString("C0");
            }
        }

        // Event handler untuk event CellContentClick DataGridView
        private void dgvDaftarMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDaftarMenu.Columns["Tambah"].Index)
            {
                // Ambil data menu dari baris yang dipilih
                DaftarMenu menuDipilih = (DaftarMenu)dgvDaftarMenu.Rows[e.RowIndex].DataBoundItem;

                // Tambahkan menu ke ListView (lvKeranjang)
                ListViewItem item = new ListViewItem(menuDipilih.Nama);
                item.SubItems.Add(menuDipilih.Tipe);
                item.SubItems.Add(menuDipilih.Harga.ToString("C0")); // Format harga sebagai mata uang
                item.SubItems.Add("1"); // Jumlah awal diatur sebagai 1
                item.SubItems.Add(menuDipilih.Harga.ToString("C0")); // Total awal diatur sebagai harga menu

                lvKeranjang.Items.Add(item);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Pastikan ada item yang dipilih di lvKeranjang
            if (lvKeranjang.SelectedItems.Count > 0)
            {
                // Ambil item yang dipilih
                ListViewItem selectedItem = lvKeranjang.SelectedItems[0];

                // Hapus item dari lvKeranjang
                lvKeranjang.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Pilih item yang ingin dihapus dari keranjang.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            // Inisialisasi total sebagai 0
            int totalHarga = 0;

            // Loop melalui setiap item di lvKeranjang dan tambahkan harga ke total
            foreach (ListViewItem item in lvKeranjang.Items)
            {
                // Ambil nilai harga dari item dan tambahkan ke totalHarga
                int hargaItem = int.Parse(item.SubItems[2].Text, System.Globalization.NumberStyles.Currency);
                totalHarga += hargaItem;
            }

            // Tampilkan totalHarga di TextBox txtTotal
            txtTotal.Text = totalHarga.ToString("C0");
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            // Menghitung total harga dari lvKeranjang
            int totalHarga = int.Parse(txtTotal.Text, System.Globalization.NumberStyles.Currency);

            // Memanggil metode ProsesPesanan dari controller
            controller.ProsesPesanan(lvKeranjang, totalHarga);

            // Menampilkan MessageBox pesan keberhasilan
            MessageBox.Show("Pesanan berhasil ditambahkan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
