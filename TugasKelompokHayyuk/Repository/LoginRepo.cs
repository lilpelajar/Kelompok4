using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TugasKelompokHayyuk.Config;
using TugasKelompokHayyuk.Models;

namespace TugasKelompokHayyuk.Repository
{
    public class LoginRepo : database
    {
        
        public bool UserLogin (UserModels userModels)
        {
            using (var conn = MyConnection())
            {
                conn.Open();
                string query = "Select id, username, password_hash, role_enum from users where username=@username ";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", userModels.Username);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userModels.Id = reader.GetInt64("id");
                            userModels.Username = reader.GetString("username");
                            userModels.Password = reader.GetString("password_hash");
                            userModels.RoleUser = reader.GetString("role_enum");
                            return true;
                        } 
                    }
                }
            }
            return false;
        }
    }
}
