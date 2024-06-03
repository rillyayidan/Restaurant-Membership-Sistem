using System;

namespace RM.Model.Entity
{
    public class Pesanan
    {
        public int IDPesanan { get; set; }
        public string ListMenu { get; set; }
        public int TotalMenu { get; set; }
        public string Status { get; set; }

        public Pesanan()
        {
            // Inisialisasi status menjadi "Pending" secara default
            Status = "Pending";
        }
    }
}
