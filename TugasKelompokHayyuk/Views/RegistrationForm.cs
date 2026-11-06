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
using TugasKelompokHayyuk.Services;
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
           UserService userService = new UserService();
            userService.UserRegister(txtUsername.Text.Trim(), txtEmail.Text.Trim(), txtFullname.Text.Trim(), txtPssword.Text.Trim(),cmbRole.Text,this);
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Hide();
            loginForm.Show();
        }
    }
}
