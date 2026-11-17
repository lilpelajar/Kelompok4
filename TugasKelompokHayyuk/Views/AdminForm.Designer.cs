namespace TugasKelompokHayyuk.Views
{
    partial class AdminForm
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
            PanelSideBar = new Panel();
            PanelHeader = new Panel();
            lblLogo = new Label();
            panelhead = new Panel();
            btnDashboard = new Button();
            btnAkademik = new Button();
            btnPengguna = new Button();
            button1 = new Button();
            button2 = new Button();
            PanelSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // PanelSideBar
            // 
            PanelSideBar.BackColor = Color.FromArgb(32, 89, 232);
            PanelSideBar.Controls.Add(button2);
            PanelSideBar.Controls.Add(button1);
            PanelSideBar.Controls.Add(btnPengguna);
            PanelSideBar.Controls.Add(btnAkademik);
            PanelSideBar.Controls.Add(btnDashboard);
            PanelSideBar.Controls.Add(PanelHeader);
            PanelSideBar.Controls.Add(lblLogo);
            PanelSideBar.Dock = DockStyle.Left;
            PanelSideBar.Location = new Point(0, 0);
            PanelSideBar.Name = "PanelSideBar";
            PanelSideBar.Size = new Size(355, 704);
            PanelSideBar.TabIndex = 1;
            PanelSideBar.Paint += panel1_Paint;
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.White;
            PanelHeader.Location = new Point(355, 38);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1104, 117);
            PanelHeader.TabIndex = 2;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(9, 102);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(340, 45);
            lblLogo.TabIndex = 2;
            lblLogo.Text = "▦  Admin Dashboard";
            lblLogo.Click += label2_Click;
            // 
            // panelhead
            // 
            panelhead.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelhead.Location = new Point(355, 0);
            panelhead.Name = "panelhead";
            panelhead.Size = new Size(935, 75);
            panelhead.TabIndex = 2;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(32, 89, 232);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 74, 210);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 89, 232);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(-3, 215);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.RightToLeft = RightToLeft.No;
            btnDashboard.Size = new Size(358, 67);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "🎓 Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnAkademik
            // 
            btnAkademik.BackColor = Color.FromArgb(32, 89, 232);
            btnAkademik.Cursor = Cursors.Hand;
            btnAkademik.FlatAppearance.BorderSize = 0;
            btnAkademik.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 74, 210);
            btnAkademik.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 89, 232);
            btnAkademik.FlatStyle = FlatStyle.Flat;
            btnAkademik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAkademik.ForeColor = Color.White;
            btnAkademik.Location = new Point(-3, 288);
            btnAkademik.Name = "btnAkademik";
            btnAkademik.Size = new Size(358, 65);
            btnAkademik.TabIndex = 3;
            btnAkademik.Text = "▣  Akademik";
            btnAkademik.UseVisualStyleBackColor = false;
            // 
            // btnPengguna
            // 
            btnPengguna.BackColor = Color.FromArgb(32, 89, 232);
            btnPengguna.Cursor = Cursors.Hand;
            btnPengguna.FlatAppearance.BorderSize = 0;
            btnPengguna.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 74, 210);
            btnPengguna.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 89, 232);
            btnPengguna.FlatStyle = FlatStyle.Flat;
            btnPengguna.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPengguna.ForeColor = Color.White;
            btnPengguna.Location = new Point(-3, 359);
            btnPengguna.Name = "btnPengguna";
            btnPengguna.Size = new Size(358, 68);
            btnPengguna.TabIndex = 3;
            btnPengguna.Text = "♙  Pengguna";
            btnPengguna.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 89, 232);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 74, 210);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 89, 232);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(-3, 433);
            button1.Name = "button1";
            button1.Size = new Size(358, 65);
            button1.TabIndex = 3;
            button1.Text = "◫  Courses";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(32, 89, 232);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 74, 210);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 89, 232);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(-3, 504);
            button2.Name = "button2";
            button2.Size = new Size(358, 71);
            button2.TabIndex = 6;
            button2.Text = "▤  Nilai";
            button2.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1292, 704);
            Controls.Add(panelhead);
            Controls.Add(PanelSideBar);
            Margin = new Padding(4);
            MinimumSize = new Size(1100, 700);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            PanelSideBar.ResumeLayout(false);
            PanelSideBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelSideBar;
        private Label lblLogo;
        private Panel PanelHeader;
        private Panel panelhead;
        private Button btnDashboard;
        private Button btnAkademik;
        private Button button2;
        private Button button1;
        private Button btnPengguna;
    }
}