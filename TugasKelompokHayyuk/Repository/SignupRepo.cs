using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using TugasKelompokHayyuk.Config;
using TugasKelompokHayyuk.Models;

namespace TugasKelompokHayyuk.Repository
{
    public class SignupRepo : database
    {
        public bool AddUser(UserModels userModels)
        {
            using (var conn = MyConnection())
            {
                conn.Open();
                string query = @"insert into users (username, email, password_hash, full_name, role_enum)
                                 values (@username, @email, @password_hash, @full_name, @role_enum)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", userModels.Username);
                    cmd.Parameters.AddWithValue("@email", userModels.Email);
                    cmd.Parameters.AddWithValue("@password_hash", userModels.Password);
                    cmd.Parameters.AddWithValue("@full_name", userModels.FullName);
                    cmd.Parameters.AddWithValue("@role_enum", userModels.RoleUser);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
