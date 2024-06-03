using RM.Model.Entity;
using RM.Model.Repository;
using RM.View;
using System;
using System.Collections.Generic;

namespace RM.Controller
{
    public class ReservasiController
    {
        private RumahMakanController controller { get; set; }
        private ReservasiRepository reservasiRepository;
        private ReservasiController reservasiController;
        public ReservasiController(RumahMakanController rumahMakanController, ReservasiRepository reservasiRepository, ReservasiController reservasiController)
        {
            this.reservasiRepository = reservasiRepository;
            this.controller = rumahMakanController;
            this.reservasiController = reservasiController;
        }

        public void BukaFormReservasi()
        {
            // Membuat objek frmReservasi dan memberikan instance ReservasiController
            frmReservasi formReservasi = new frmReservasi(controller, reservasiRepository, reservasiController);

            // Menampilkan frmReservasi
            formReservasi.ShowDialog();
        }

        public bool CreateReservasi(Reservasi reservasi)
        {
            // Implement logic to create a reservation
            // Example:
            return reservasiRepository.Create(reservasi);
        }

        public bool EditReservasi(Reservasi reservasi)
        {
            // Implement logic to edit a reservation
            // Example:
            return reservasiRepository.Edit(reservasi);
        }

    }
}