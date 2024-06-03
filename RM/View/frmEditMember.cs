using RM.Controller;
using RM.Model.Repository;
using System;
using System.ComponentModel.Design.Serialization;
using System.Windows.Forms;

namespace RM.View
{
    public partial class frmEditMember : Form
    {
        private string nomorTelepon;
        private string nama;
        private RumahMakanController controller;
        private MemberRepository memberRepository;

        public frmEditMember(string nomorTelepon, string nama, RumahMakanController controller, MemberRepository memberRepository)
        {
            InitializeComponent();
            this.nomorTelepon = nomorTelepon;
            this.nama = nama;
            this.controller = controller;
        }

        private void frmEditMember_Load(object sender, EventArgs e)
        {
            // Tampilkan data member pada form
            txtNomorTelepon.Text = nomorTelepon;
            txtNama.Text = nama;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Lakukan logika editing data member
            // Misalnya, panggil method di controller untuk menyimpan perubahan
            controller.EditMember(nomorTelepon, txtNomorTelepon.Text, txtNama.Text);

            // Kemudian tutup form ini
            this.Close();
        }
    }
}
