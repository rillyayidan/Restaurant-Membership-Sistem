using System;
using System.Windows.Forms;
using RM.Model.Entity;

namespace RM.View
{
    public partial class frmBayar : Form
    {
        private Pesanan pesanan;
        private ListView lvPesanan;

        public bool PembayaranBerhasil { get; private set; }

        public frmBayar(Pesanan pesanan, ListView lvPesanan)
        {
            InitializeComponent();
            this.pesanan = pesanan ?? throw new ArgumentNullException(nameof(pesanan), "Pesanan tidak boleh null.");
            this.lvPesanan = lvPesanan;

            // Tambahkan event handler untuk event SelectedIndexChanged dari lvPesanan
            this.lvPesanan.SelectedIndexChanged += lvPesanan_SelectedIndexChanged;

            // Tambahkan event handler untuk menutup form ketika form di-close
            this.FormClosed += frmBayar_FormClosed;
        }

        private void lvPesanan_SelectedIndexChanged(object sender, EventArgs e)
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

                // Lakukan sesuatu dengan data yang sudah diambil
                lblTotalHarga.Text = $"ID Pesanan: {idPesanan}, List Menu: {listMenu}, Total Menu: {totalMenu}, Status: {status}";
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            // Pastikan pesanan tidak null
            if (pesanan != null)
            {
                // Cek apakah status saat ini adalah "Pending"
                if (pesanan.Status.Equals("Pending", StringComparison.OrdinalIgnoreCase))
                {
                    // Ambil jumlah bayar dari TextBox
                    if (int.TryParse(txtJumlahBayar.Text, out int jumlahBayar))
                    {
                        // Periksa apakah jumlah bayar mencukupi
                        if (jumlahBayar >= pesanan.TotalMenu)
                        {
                            // Update status pesanan menjadi "On-Progress"
                            pesanan.Status = "On-Progress";

                            // Setel PembayaranBerhasil menjadi true
                            PembayaranBerhasil = true;

                            // Tampilkan pesan bahwa pembayaran berhasil
                            MessageBox.Show("Pembayaran berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Tutup form pembayaran
                            this.Close();
                        }
                        else
                        {
                            // Tampilkan pesan bahwa jumlah bayar kurang
                            MessageBox.Show("Jumlah bayar kurang. Silakan masukkan jumlah bayar yang mencukupi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        // Tampilkan pesan bahwa input jumlah bayar tidak valid
                        MessageBox.Show("Masukkan jumlah bayar yang valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Tampilkan pesan bahwa status pesanan sudah diubah
                    MessageBox.Show("Status pesanan sudah diubah. Pembayaran tidak dapat diproses.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Tutup form pembayaran
                    this.Close();
                }
            }
        }

        private void frmBayar_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Tutup form hanya jika pembayaran berhasil
            if (PembayaranBerhasil)
            {
                this.Close();
            }
        }
    }
}
