using RM.Controller;
using RM.Model.Context;
using RM.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.View
{
    public partial class frmMain : Form
    {
        private RumahMakanController controller;
        private ReservasiRepository _reservasiRepository;
        private mainDatabase _database;
        private MemberRepository _memberRepository;
        public frmMain(RumahMakanController controller, ReservasiRepository reservasiRepository, mainDatabase mainDatabase, MemberRepository memberRepository)
        {
            InitializeComponent();
            _reservasiRepository = reservasiRepository;
            _database = mainDatabase;
            this.controller = controller;
            _memberRepository = memberRepository;
        }

        public frmMain(RumahMakanController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void pendaftaranStrip_Click(object sender, EventArgs e)
        {
            // Buat instance frmPendaftaran dan berikan pengontrol
            frmPendaftaran pendaftaranForm = new frmPendaftaran(new PendaftaranController(controller.MemberRepository));

            // Tampilkan formulir
            pendaftaranForm.Show();
        }

        private void listMember_Click(object sender, EventArgs e)
        {
            frmListMember listMemberForm = new frmListMember(controller, _memberRepository);
            listMemberForm.ShowDialog();
        }


        private void reservasiStrip_Click(object sender, EventArgs e)
        {
            controller.BukaFormReservasi();
        }

        private void listReservasi_Click(object sender, EventArgs e)
        {
            frmListReservasi formListReservasi = new frmListReservasi(controller, _database);
            formListReservasi.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pesanStrip_Click(object sender, EventArgs e)
        {
            frmPesan frmPesan = new frmPesan(controller);
            frmPesan.ShowDialog();
        }

        private void listPesanan_Click(object sender, EventArgs e)
        {
            frmListPesanan formListPesanan = new frmListPesanan(controller);
            formListPesanan.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp fromHelp = new frmHelp();
            fromHelp.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout formAbout = new frmAbout();
            formAbout.ShowDialog();
        }
    }
}
