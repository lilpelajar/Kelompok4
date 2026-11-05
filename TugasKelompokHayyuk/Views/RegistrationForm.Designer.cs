namespace TugasKelompokHayyuk.Views
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            btnSignup = new Button();
            txtPssword = new TextBox();
            txtFullname = new TextBox();
            label1 = new Label();
            txtUsername = new TextBox();
            cmbRole = new ComboBox();
            txtEmail = new TextBox();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(276, 567);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(74, 20);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Buat akun";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(133, 567);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 12;
            label2.Text = "Belum punya akun?";
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(76, 423);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(345, 49);
            btnSignup.TabIndex = 11;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnLogin_Click;
            // 
            // txtPssword
            // 
            txtPssword.Font = new Font("Segoe UI", 12F);
            txtPssword.Location = new Point(76, 245);
            txtPssword.Name = "txtPssword";
            txtPssword.PlaceholderText = "Password";
            txtPssword.Size = new Size(345, 34);
            txtPssword.TabIndex = 9;
            // 
            // txtFullname
            // 
            txtFullname.Font = new Font("Segoe UI", 12F);
            txtFullname.Location = new Point(76, 141);
            txtFullname.Name = "txtFullname";
            txtFullname.PlaceholderText = "Full Name";
            txtFullname.Size = new Size(345, 34);
            txtFullname.TabIndex = 8;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(500, 56);
            label1.TabIndex = 7;
            label1.Text = "Sign up";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(76, 89);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(345, 34);
            txtUsername.TabIndex = 14;
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Guru", "Siswa" });
            cmbRole.Location = new Point(76, 328);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(345, 33);
            cmbRole.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(76, 193);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(345, 34);
            txtEmail.TabIndex = 16;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(76, 287);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(132, 24);
            chkShowPassword.TabIndex = 17;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 596);
            Controls.Add(chkShowPassword);
            Controls.Add(txtEmail);
            Controls.Add(cmbRole);
            Controls.Add(txtUsername);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(btnSignup);
            Controls.Add(txtPssword);
            Controls.Add(txtFullname);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label2;
        private Button btnSignup;
        private CheckBox chkShowPassword;
        private TextBox txtPssword;
        private TextBox txtFullname;
        private Label label1;
        private TextBox txtUsername;
        private ComboBox cmbRole;
        private TextBox txtEmail;
    }
}