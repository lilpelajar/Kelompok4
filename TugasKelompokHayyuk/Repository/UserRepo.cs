using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using TugasKelompokHayyuk.Config;
using TugasKelompokHayyuk.Models;

namespace TugasKelompokHayyuk.Repository
{
    public class UserRepo : database
    {
        

        public bool UserLogin (UserModels userModels)
        {
            using (var conn = MyConnection())
            {
                conn.Open();
                string query = "Select * from users where username =@username and password_hash = @password_hash";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", userModels.Username);
                    cmd.Parameters.AddWithValue("username", userModels.Password);
                    return cmd.ExecuteNonQuery() > 0;
                }

            }
        }
    }
}
