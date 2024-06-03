using RM.Controller;
using RM.Model.Context;
using RM.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace RM.Model.Repository
{
    public class MemberRepository
    {
        private mainDatabase _mainDatabase;
        private RumahMakanController _controller;

        public MemberRepository(mainDatabase mainDatabase, RumahMakanController controller)
        {
            _mainDatabase = mainDatabase;
            _controller = controller;
        }

        public List<Member> GetAllMembers()
        {
            List<Member> members = new List<Member>();

            try
            {
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Member", _mainDatabase.Conn))
                {
                    _mainDatabase.Conn.Open();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member member = new Member
                            {
                                NomorTelepon = reader["NomorTelepon"].ToString(),
                                Nama = reader["Nama"].ToString()
                            };
                            members.Add(member);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching members: {ex.Message}");
            }
            finally
            {
                _mainDatabase.Conn.Close(); ;
            }

            return members;
        }

        public bool Create(Member member)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Member (NomorTelepon, Nama) VALUES (@NomorTelepon, @Nama)", _mainDatabase.Conn))
                {
                    command.Parameters.AddWithValue("@NomorTelepon", member.NomorTelepon);
                    command.Parameters.AddWithValue("@Nama", member.Nama);

                    _mainDatabase.Conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating member: {ex.Message}");
                return false;
            }
            finally
            {
                _mainDatabase.Conn.Close();
            }
        }

        public bool DeleteMember(string nomorTelepon)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Member WHERE NomorTelepon = @NomorTelepon", _mainDatabase.Conn))
                {
                    command.Parameters.AddWithValue("@NomorTelepon", nomorTelepon);

                    _mainDatabase.Conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting member: {ex.Message}");
                return false;
            }
            finally
            {
                _mainDatabase.Conn.Close();
            }
        }

        public int EditMember(string nomorTelepon, string newNomorTelepon, string newNama)
        {
            string query = $"UPDATE Member SET NomorTelepon='{newNomorTelepon}', Nama='{newNama}' WHERE NomorTelepon='{nomorTelepon}'";

            return ExecuteNonQuery(query);
        }

        private int ExecuteNonQuery(string query)
        {
            using (SQLiteCommand command = new SQLiteCommand(query, _mainDatabase.Conn))
            {
                try
                {
                    _mainDatabase.Conn.Open();
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error executing non-query: {ex.Message}");
                    return -1;
                }
                finally
                {
                    _mainDatabase.Conn.Close();
                }
            }
        }

        public bool ValidateLogin(string nama, string nomorTelepon)
        {
            // Implement logic for login validation
            // Example:
            int result = _mainDatabase.ExecuteScalar($"SELECT COUNT(*) FROM Users WHERE Nama='{nama}' AND NomorTelepon='{nomorTelepon}'");
            return result > 0;
        }
    }
}
