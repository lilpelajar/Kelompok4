using TugasKelompokHayyuk.Services;
using TugasKelompokHayyuk.Views;

namespace TugasKelompokHayyuk
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            Hide();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            userService.UserLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim(), this);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Source - https://stackoverflow.com/a/24907802
            // Posted by Christos, modified by community. See post 'Timeline' for change history
            // Retrieved 2026-11-07, License - CC BY-SA 3.0

            if (checkBox1.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }
    }
}
