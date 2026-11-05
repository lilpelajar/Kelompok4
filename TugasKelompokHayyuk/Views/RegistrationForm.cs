using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TugasKelompokHayyuk.Models;
using TugasKelompokHayyuk.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TugasKelompokHayyuk.Views
{
    public partial class RegistrationForm : Form
    {
        SignupRepo SignupRepo = new SignupRepo();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {    
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Nama belum diisi", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Email belum diisi", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else if (string.IsNullOrWhiteSpace(txtFullname.Text))
                {
                    MessageBox.Show("Full name belum diisi", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else if (string.IsNullOrWhiteSpace(txtPssword.Text))
                {
                    MessageBox.Show("Password belum diisi", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbRole.Text == "")
                {
                    MessageBox.Show("Role Masih Kosong", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                SignupRepo.AddUser(new UserModels
                {
                    Username = txtUsername.Text,
                    Email = txtEmail.Text,
                    FullName = txtFullname.Text,
                    Password = txtPssword.Text,
                    RoleUser = cmbRole.Text
                });
                MessageBox.Show("data terdaftar", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
