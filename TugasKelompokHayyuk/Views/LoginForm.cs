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
            userService.UserLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim(),this);
        }
    }
}
