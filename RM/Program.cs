using RM.Controller;
using RM.View;
using System;
using System.Windows.Forms;
using RM.Model.Context;
using RM.Model.Repository;
namespace RM
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Tentukan path database
            string dbPath = @"C:\Users\zidan\Documents\Final Project\LAST PROJECT\RM\Database\RumahMakanDB.db";

            // Buat objek mainDatabase
            mainDatabase mainDb = new mainDatabase(dbPath);

            ReservasiRepository reservasiRepository = new ReservasiRepository(mainDb);

            // Buat objek PesanRepository
            PesanRepository pesanRepository = new PesanRepository(mainDb);

            ListView lvPesanan = new ListView();

            // Buat objek RumahMakanController dengan menyediakan objek MemberRepository dan PesanRepository
            RumahMakanController rumahMakanController = new RumahMakanController(null, dbPath, reservasiRepository, pesanRepository, lvPesanan);

            // Buat objek MemberRepository
            MemberRepository memberRepository = new MemberRepository(mainDb, rumahMakanController);

            // Set MemberRepository for RumahMakanController
            rumahMakanController.SetMemberRepository(memberRepository);

            // Set PesanRepository for RumahMakanController
            rumahMakanController.SetPesanRepository(pesanRepository);

            // Jalankan aplikasi dengan form login
            Application.Run(new frmLogin(rumahMakanController, mainDb));
        }
    }
}