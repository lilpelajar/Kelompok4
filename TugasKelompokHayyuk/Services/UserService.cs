using Org.BouncyCastle.Asn1.X509;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TugasKelompokHayyuk.Models;
using TugasKelompokHayyuk.Repository;
using TugasKelompokHayyuk.Views;

namespace TugasKelompokHayyuk.Services
{
    public class UserService 
    {
        SignupRepo SignupRepo = new SignupRepo();
        LoginRepo LoginRepo = new LoginRepo();

        //forms
        AdminForm AdminForm = new AdminForm();
        GuruForm GuruForm = new GuruForm();
    
        

        private void LoadFormRoleBased(Form form1, Form form2)
        {
            MessageBox.Show($"berhasil ke {form2.Name}", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            form1.Hide();
            form2.Show();
        }
        public bool UserRegister (string username, string email, string fullname,string password, string role, Form form)
        {
            if (string.IsNullOrWhiteSpace(username) || 
                string.IsNullOrWhiteSpace(email) || 
                string.IsNullOrWhiteSpace(fullname) || 
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(role)
                )
            {
                MessageBox.Show("username, email, fullname, password, atau role belum diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
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

            bool IsSucces =false;

            if (userModels.RoleUser == "Siswa")
            {
                IsSucces = SignupRepo.RegistStudent(userModels);
            }
            else if (userModels.RoleUser == "Guru")
            {
                IsSucces = SignupRepo.RegistTeachers(userModels);
            } else
            {
                IsSucces = SignupRepo.AddUser(userModels);
            }

            if (IsSucces)
            {
                MessageBox.Show("Terdaftar mi.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form formtrgt = null;
                switch (userModels.RoleUser)
                {
                    case "Admin":
                        LoadFormRoleBased(form, AdminForm);
                        break;
                    case "Guru":
                        LoadFormRoleBased(form, GuruForm);
                        break;
                    case "Siswa":
                        formtrgt = new SiswaForm(userModels);
                        break;
                }
                if (formtrgt !=null)
                {
                    LoadFormRoleBased(form, formtrgt);
                }
            }
            else
            {
                MessageBox.Show("error skibidi", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IsSucces;
        }

        public bool UserLogin (string username, string password, Form form)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("username atau password blm diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return false;
            }
            UserModels userModels = new UserModels
            {
                Username = username
            };

            bool usrname = LoginRepo.UserLogin(userModels);
            if (!usrname)
            {
                MessageBox.Show("salah username nu kapang", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            bool pwuser = BCrypt.Net.BCrypt.Verify(password, userModels.Password);
            if (!pwuser)
            {
                MessageBox.Show("salah pw nu woi", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Form formtrgt = null;
           
            switch (userModels.RoleUser)
            {
                case "Admin":
                    LoadFormRoleBased(form, AdminForm);
                    break;
                case "Guru":
                    LoadFormRoleBased(form, GuruForm);
                    break;
                case "Siswa":
                    formtrgt = new SiswaForm(userModels);
                    break;
            }
            if (formtrgt != null)
            {
                LoadFormRoleBased(form, formtrgt);
            }
            
            return true;
        }
    }
}
