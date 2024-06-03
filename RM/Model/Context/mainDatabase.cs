using RM.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace RM.Model.Context
{
    public class mainDatabase : IDisposable
    {
        private SQLiteConnection _conn;

        public mainDatabase(string dbPath)
        {
            string connectionString = $"Data Source={dbPath};Version=3;";
            _conn = new SQLiteConnection(connectionString);
        }

        public SQLiteConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }

        private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = new SQLiteConnection();

            try
            {
                string dbName = Directory.GetCurrentDirectory() + @"\Database\RumahMakanDB.db";
                string connectionString = $"Data Source={dbName};FailIfMissing=True";

                conn = new SQLiteConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Open Connection Error: {ex.Message}");
            }

            return conn;
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed)
                        _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }


        public int ExecuteScalar(string query)
        {
            using (SQLiteCommand command = new SQLiteCommand(query, _conn))
            {
                _conn.Open();
                int result = Convert.ToInt32(command.ExecuteScalar());
                _conn.Close();
                return result;
            }
        }

        public List<Reservasi> GetAllReservasi()
        {
            List<Reservasi> reservasiList = new List<Reservasi>();

            try
            {
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Reservasi", _conn))
                {
                    _conn.Open();
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
                            reservasiList.Add(reservasi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching reservations: {ex.Message}");
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }

            return reservasiList;
        }

        // Di dalam kelas mainDatabase
        public int ExecuteNonQuery(string query)
        {
            using (SQLiteCommand command = new SQLiteCommand(query, Conn))
            {
                try
                {
                    Conn.Open();
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error executing non-query: {ex.Message}");
                    return -1;
                }
                finally
                {
                    Conn.Close();
                }
            }
        }

    }
}
