using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace TugasKelompokHayyuk.Config
{
    public class database
    {
        private readonly string connectionstring = "Server=localhost;Database=siakada ;Uid=root;Pwd=;";

        public MySqlConnection MySqlConnection()
        {
            return new MySqlConnection(connectionstring);
        }
    }
}
