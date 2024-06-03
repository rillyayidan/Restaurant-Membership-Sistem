using RM.Model.Context;
using RM.Model.Entity;
using RM.Model.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RM.Controller
{
    public class RumahMakanController
    {
        private MemberRepository _memberRepository;
        private ReservasiRepository _reservasiRepository;
        private PesanRepository _pesanRepository;
        private ListView lvPesanan;

        public MemberRepository MemberRepository
        {
            get { return _memberRepository; }
            set { _memberRepository = value; }
        }
        private ReservasiController reservasiController;
        private mainDatabase database;

        public RumahMakanController(MemberRepository memberRepository, string dbPath, ReservasiRepository rreservasiRepository, PesanRepository pesanRepository, ListView lvPesanan)
        {
            MemberRepository = memberRepository;
            ReservasiRepository reservasiRepository = new ReservasiRepository(new mainDatabase(dbPath));
            reservasiController = new ReservasiController(this, reservasiRepository, reservasiController);
            database = new mainDatabase(dbPath);
            _reservasiRepository = rreservasiRepository;
            this.lvPesanan = lvPesanan;
        }

        public List<Reservasi> GetAllReservasi()
        {
            // Panggil metode atau logika untuk mengambil data reservasi dari database
            return database.GetAllReservasi();
        }

        public void BukaFormReservasi()
        {
            // Memanggil metode BukaFormReservasi dari ReservasiController
            reservasiController.BukaFormReservasi();
        }
        public void SetMemberRepository(MemberRepository memberRepository)
        {
            this.MemberRepository = memberRepository;
        }

        public int EditMember(string nomorTelepon, string newNomorTelepon, string newNama)
        {
            return MemberRepository.EditMember(nomorTelepon, newNomorTelepon, newNama);
        }
        public bool HapusReservasi(string nomorTelepon)
        {
            // Implement logic to delete a reservation
            // Example:
            return _reservasiRepository.Delete(nomorTelepon);
        }

        public bool EditReservasi(Reservasi reservasi)
        {
            // Implement logic to edit a reservation
            // Example:
            return _reservasiRepository.Edit(reservasi);
        } 

        public List<Reservasi> CariReservasi(string keyword)
        {
            // Implement logic to search reservations
            // Example:
            return _reservasiRepository.Search(keyword);
        }
        public void ProsesPesanan(ListView lvKeranjang, int totalMenu)
        {
            string listMenu = string.Join(", ", lvKeranjang.Items.OfType<ListViewItem>().Select(selectedItem => selectedItem.SubItems[0].Text));

            Pesanan pesanan = new Pesanan
            {
                ListMenu = listMenu,
                TotalMenu = totalMenu
            };

            // Tambahkan pesanan ke database dan perbarui IDPesanan
            pesanan.IDPesanan = _pesanRepository.TambahPesanan(pesanan);

            // Setel status pesanan
            pesanan.Status = "Pending";

            // Perbarui ListView dengan pesanan yang baru ditambahkan
            ListViewItem item = new ListViewItem(pesanan.IDPesanan.ToString());
            item.SubItems.Add(pesanan.ListMenu);
            item.SubItems.Add(pesanan.TotalMenu.ToString());
            item.SubItems.Add(pesanan.Status);

            lvPesanan.Items.Add(item);

            // Selanjutnya, Anda dapat melakukan apapun yang diperlukan dengan objek pesanan, jika diperlukan
        }

        public void SetPesanRepository(PesanRepository pesanRepository)
        {
            _pesanRepository = pesanRepository;
        }

        public List<Pesanan> GetDaftarPesanan()
        {
            // Panggil metode atau logika untuk mengambil data pesanan dari database
            return _pesanRepository.DaftarPesanan();
        }
        public bool HapusPesanan(Pesanan pesanan)
        {
            return _pesanRepository.HapusPesanan(pesanan);
        }
    }
}