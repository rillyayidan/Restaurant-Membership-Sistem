using Guna.UI2.AnimatorNS;
using RM.Controller;
using RM.Model.Context;
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
    public partial class frmLogin : Form
    {
        private RumahMakanController controller;
        private mainDatabase mainDb;

        public frmLogin(RumahMakanController controller, mainDatabase mainDb)
        {
            InitializeComponent();
            this.controller = controller;
            this.mainDb = mainDb;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string password = txtPassword.Text;

            // Validasi login
            bool isValidLogin = controller.MemberRepository.ValidateLogin(nama, password);

            if (isValidLogin)
            {
                MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmMain mainForm = new frmMain(controller);
            mainForm.Show();
            this.Hide();
            }
            else
            {
                MessageBox.Show("Login gagal. Nama atau password salah.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
