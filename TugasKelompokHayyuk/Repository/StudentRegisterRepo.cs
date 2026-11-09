using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using TugasKelompokHayyuk.Config;
using TugasKelompokHayyuk.Models;

namespace TugasKelompokHayyuk.Repository
{
    public class StudentRegisterRepo : database
    {
        public bool StudentRegister(UserModels userModels)
        {
            using (var conn = MyConnection())
            {
                conn.Open();
                using (MySqlTransaction transaction = conn.BeginTransaction())
                {

                }
                return true;
            }
        }
    }
}