using System;

namespace RM.Model.Entity
{
    public class Reservasi
    {
        public string NomorTelepon { get; set; }
        public string Nama { get; set; }
        public DateTime TanggalJam { get; set; }
        public int JumlahOrang { get; set; }
        public int NomorMeja { get; set; }
    }
}