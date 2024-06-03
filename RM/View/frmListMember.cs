using System;
using System.Linq;
using System.Windows.Forms;
using RM.Controller;
using RM.Model.Context;
using RM.Model.Repository;
namespace RM.View
{
    public partial class frmListMember : Form
    {
        private RumahMakanController controller;
        private MemberRepository memberRepository;
        public frmListMember(RumahMakanController controller, MemberRepository memberRepository)
        {
            InitializeComponent();
            this.controller = controller;
            this.memberRepository = memberRepository;
        }

        private void frmListMember_Load(object sender, EventArgs e)
        {
            // Panggil metode untuk mengisi ListView dengan data member
            TampilkanMember();
        }

        private void TampilkanMember()
        {
            // Bersihkan item pada ListView
            lvMember.Items.Clear();

            // Dapatkan daftar member dari controller
            var members = controller.MemberRepository.GetAllMembers();

            // Tambahkan setiap member ke ListView
            foreach (var member in members)
            {
                ListViewItem item = new ListViewItem(member.NomorTelepon);
                item.SubItems.Add(member.Nama);
                lvMember.Items.Add(item);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Pastikan ada item yang dipilih
            if (lvMember.SelectedItems.Count > 0)
            {
                // Dapatkan nomor telepon member yang dipilih
                string nomorTelepon = lvMember.SelectedItems[0].Text;

                // Tampilkan konfirmasi penghapusan
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus member ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Panggil method DeleteMember di MemberRepository
                    bool success = controller.MemberRepository.DeleteMember(nomorTelepon);

                    if (success)
                    {
                        // Member berhasil dihapus, tampilkan pesan sukses
                        MessageBox.Show("Member berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh ListView
                        TampilkanMember();
                    }
                    else
                    {
                        // Gagal menghapus member, tampilkan pesan error
                        MessageBox.Show("Gagal menghapus member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Tidak ada item yang dipilih, tampilkan pesan
                MessageBox.Show("Pilih member yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Dapatkan data member yang terpilih
            if (lvMember.SelectedItems.Count > 0)
            {
                string nomorTelepon = lvMember.SelectedItems[0].Text;
                string nama = lvMember.SelectedItems[0].SubItems[1].Text;

                // Tampilkan frmEditMember dengan data member yang dipilih
                frmEditMember editMemberForm = new frmEditMember(nomorTelepon, nama, controller, memberRepository);
                editMemberForm.ShowDialog();

                // Refresh data setelah editing
                TampilkanMember();
            }
            else
            {
                MessageBox.Show("Pilih member yang akan diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            // Bersihkan item pada ListView
            lvMember.Items.Clear();

            // Dapatkan daftar member dari controller
            var members = controller.MemberRepository.GetAllMembers();

            // Dapatkan kata kunci pencarian dari TextBox
            string keyword = txtCari.Text.ToLower();

            // Filter data berdasarkan kata kunci
            var filteredMembers = members.Where(member => member.Nama.ToLower().Contains(keyword) || member.NomorTelepon.Contains(keyword));

            // Tambahkan setiap member hasil pencarian ke ListView
            foreach (var member in filteredMembers)
            {
                ListViewItem item = new ListViewItem(member.NomorTelepon);
                item.SubItems.Add(member.Nama);
                lvMember.Items.Add(item);
            }
        }
    }
}
