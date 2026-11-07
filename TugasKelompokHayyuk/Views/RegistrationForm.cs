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
            userService.UserRegister(txtUsername.Text.Trim(), txtEmail.Text.Trim(), txtFullname.Text.Trim(), txtPssword.Text.Trim(), cmbRole.Text, this);
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Hide();
            loginForm.Show();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Source - https://stackoverflow.com/a/24907802
            // Posted by Christos, modified by community. See post 'Timeline' for change history
            // Retrieved 2026-11-07, License - CC BY-SA 3.0

            if (chkShowPassword.Checked)
                txtPssword.PasswordChar = '\0';
            else
                txtPssword.PasswordChar = '*';
        }
    }
}
