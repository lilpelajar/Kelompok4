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
            btnLogin = new Button();
            textBox1 = new TextBox();
            txtFullname = new TextBox();
            label1 = new Label();
            txtUsername = new TextBox();
            comboBox1 = new ComboBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(276, 496);
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
            label2.Location = new Point(133, 496);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 12;
            label2.Text = "Belum punya akun?";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(76, 306);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(345, 49);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(74, 211);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Password";
            textBox1.Size = new Size(345, 34);
            textBox1.TabIndex = 9;
            // 
            // txtFullname
            // 
            txtFullname.Font = new Font("Segoe UI", 12F);
            txtFullname.Location = new Point(74, 135);
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
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(74, 262);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(345, 33);
            comboBox1.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(76, 173);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(345, 34);
            txtEmail.TabIndex = 16;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 525);
            Controls.Add(txtEmail);
            Controls.Add(comboBox1);
            Controls.Add(txtUsername);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(textBox1);
            Controls.Add(txtFullname);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label2;
        private Button btnLogin;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private TextBox txtFullname;
        private Label label1;
        private TextBox txtUsername;
        private ComboBox comboBox1;
        private TextBox txtEmail;
    }
}