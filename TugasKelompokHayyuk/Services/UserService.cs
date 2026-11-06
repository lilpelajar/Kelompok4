using Org.BouncyCastle.Asn1.X509;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using TugasKelompokHayyuk.Models;
using TugasKelompokHayyuk.Repository;

namespace TugasKelompokHayyuk.Services
{
    public class UserService 
    {
        SignupRepo SignupRepo = new SignupRepo();
        public bool UserRegister (string username, string email, string fullname,string password, string role)
        {
            if (string.IsNullOrWhiteSpace(username) || 
                string.IsNullOrWhiteSpace(email) || 
                string.IsNullOrWhiteSpace(fullname) || 
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(role)
                )
            {
                MessageBox.Show("username, email, fullname, password, atau role belum diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string pwhashed = BCrypt.Net.BCrypt.HashPassword(password);

            UserModels userModels = new UserModels
            {
                Username = username,
                Email = email,
                FullName = fullname,
                Password = pwhashed,
                RoleUser = role
            };

            bool IsSucces = SignupRepo.AddUser(userModels);
            if (IsSucces)
            {
                MessageBox.Show("berhasil ji twerdatar", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("nda berhasil ki terdaftar", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return IsSucces;
        }

        public bool UserLogin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("username, email, fullname, password, atau role belum diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UserModels userModels = new UserModels();
            bool pw = BCrypt.Net.BCrypt.Verify(password, userModels.Password);
            return true;
        }

       
    }
}
