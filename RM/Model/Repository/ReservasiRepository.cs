using RM.Model.Context;
using RM.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace RM.Model.Repository
{
    public class ReservasiRepository
    {
        private mainDatabase _mainDatabase;

        public ReservasiRepository(mainDatabase mainDatabase)
        {
            _mainDatabase = mainDatabase;
        }
        public List<Reservasi> Search(string keyword)
        {
            List<Reservasi> result = new List<Reservasi>();

            try
            {
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Reservasi WHERE NomorTelepon LIKE @Keyword OR Nama LIKE @Keyword", _mainDatabase.Conn))
                {
                    command.Parameters.AddWithValue("@Keyword", $"%{keyword}%");

                    _mainDatabase.Conn.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Reservasi reservasi = new Reservasi
                            {
                                NomorTelepon = reader["NomorTelepon"].ToString(),
                                Nama = reader["Nama"].ToString(),
                                TanggalJam = Convert.ToDateTime(reader["TanggalJam"]),
                                JumlahOrang = Convert.ToInt32(reader["JumlahOrang"]),
                                NomorMeja = Convert.ToInt32(reader["NomorMeja"])
                            };
                            result.Add(reservasi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching reservations: {ex.Message}");
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

        public bool Create(Reservasi reservasi)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Reservasi (NomorTelepon, Nama, TanggalJam, JumlahOrang, NomorMeja) VALUES (@NomorTelepon, @Nama, @TanggalJam, @JumlahOrang, @NomorMeja)", _mainDatabase.Conn))
                {
                    command.Parameters.AddWithValue("@NomorTelepon", reservasi.NomorTelepon);
                    command.Parameters.AddWithValue("@Nama", reservasi.Nama);
                    command.Parameters.AddWithValue("@TanggalJam", reservasi.TanggalJam);
                    command.Parameters.AddWithValue("@JumlahOrang", reservasi.JumlahOrang);
                    command.Parameters.AddWithValue("@NomorMeja", reservasi.NomorMeja);

                    _mainDatabase.Conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    _mainDatabase.Conn.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating reservation: {ex.Message}");
                return false;
            }
        }
        public bool Delete(string nomorTelepon)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Reservasi WHERE NomorTelepon=@NomorTelepon", _mainDatabase.Conn))
                {
                    command.Parameters.AddWithValue("@NomorTelepon", nomorTelepon);

                    _mainDatabase.Conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    _mainDatabase.Conn.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting reservation: {ex.Message}");
                return false;
            }
        }

        public bool Edit(Reservasi reservasi)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand("UPDATE Reservasi SET Nama=@Nama, TanggalJam=@TanggalJam, JumlahOrang=@JumlahOrang, NomorMeja=@NomorMeja WHERE NomorTelepon=@NomorTelepon", _mainDatabase.Conn))
                {
                    command.Parameters.AddWithValue("@Nama", reservasi.Nama);
                    command.Parameters.AddWithValue("@TanggalJam", reservasi.TanggalJam);
                    command.Parameters.AddWithValue("@JumlahOrang", reservasi.JumlahOrang);
                    command.Parameters.AddWithValue("@NomorMeja", reservasi.NomorMeja);
                    command.Parameters.AddWithValue("@NomorTelepon", reservasi.NomorTelepon);

                    _mainDatabase.Conn.Open();
                    Console.WriteLine(reservasi.NomorTelepon);
                    int rowsAffected = command.ExecuteNonQuery();
                    _mainDatabase.Conn.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error editing reservation: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }
    }
}
