using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using RM.Model.Context;
using RM.Model.Entity;

namespace RM.Model.Repository
{
    public class PesanRepository
    {
        private mainDatabase _mainDatabase;

        public PesanRepository(mainDatabase mainDatabase)
        {
            _mainDatabase = mainDatabase;
        }

        public int TambahPesanan(Pesanan pesanan)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Pesanan (ListMenu, TotalMenu, Status) VALUES (@ListMenu, @TotalMenu, @Status); SELECT last_insert_rowid() as IDPesanan;", _mainDatabase.Conn))
                {
                    command.Parameters.AddWithValue("@ListMenu", pesanan.ListMenu);
                    command.Parameters.AddWithValue("@TotalMenu", pesanan.TotalMenu);
                    command.Parameters.AddWithValue("@Status", pesanan.Status); // Tambahkan status di sini

                    _mainDatabase.Conn.Open();
                    pesanan.IDPesanan = Convert.ToInt32(command.ExecuteScalar());

                    return pesanan.IDPesanan;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding order: {ex.Message}");
                return -1; // Nilai kembalian yang menunjukkan kesalahan
            }
            finally
            {
                if (_mainDatabase.Conn.State == ConnectionState.Open)
                {
                    _mainDatabase.Conn.Close();
                }
            }
        }

        private void SetStatusPesanan(int idPesanan, string status)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand("UPDATE Pesanan SET Status = @Status WHERE IDPesanan = @IDPesanan", _mainDatabase.Conn))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@IDPesanan", idPesanan);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting order status: {ex.Message}");
            }
        }

        public List<Pesanan> DaftarPesanan()
        {
            List<Pesanan> result = new List<Pesanan>();

            try
            {
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Pesanan", _mainDatabase.Conn))
                {
                    _mainDatabase.Conn.Open();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pesanan pesanan = new Pesanan
                            {
                                IDPesanan = Convert.ToInt32(reader["IDPesanan"]),  // Ambil nilai IDPesanan
                                ListMenu = reader["ListMenu"].ToString(),
                                TotalMenu = Convert.ToInt32(reader["TotalMenu"])
                            };

                            result.Add(pesanan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching orders: {ex.Message}");
            }
            finally
            {
                if (_mainDatabase.Conn.State == ConnectionState.Open)
                {
                    _mainDatabase.Conn.Close();
                }
            }

            return result;
        }


        public bool HapusPesanan(Pesanan pesanan)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Pesanan WHERE IDPesanan=@IDPesanan", _mainDatabase.Conn))
                {
                    command.Parameters.AddWithValue("@IDPesanan", pesanan.IDPesanan);

                    _mainDatabase.Conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    _mainDatabase.Conn.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting order: {ex.Message}");
                return false;
            }
        }
    }
}
