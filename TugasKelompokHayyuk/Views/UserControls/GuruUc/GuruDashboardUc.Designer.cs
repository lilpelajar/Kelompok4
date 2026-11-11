namespace TugasKelompokHayyuk.Views.UserControls.GuruUc
{
    partial class GuruDashboardUc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuruDashboardUc));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            lblWelcomeTeacher = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            label6 = new Label();
            dgvSchedules = new DataGridView();
            panel5 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            label7 = new Label();
            panel9 = new Panel();
            dgvCoursesTable = new DataGridView();
            label8 = new Label();
            panel10 = new Panel();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
            panel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCoursesTable).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(916, 48);
            label1.TabIndex = 0;
            label1.Text = "Dashboard Teacher";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblWelcomeTeacher
            // 
            lblWelcomeTeacher.AutoSize = true;
            lblWelcomeTeacher.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcomeTeacher.Location = new Point(3, 50);
            lblWelcomeTeacher.Name = "lblWelcomeTeacher";
            lblWelcomeTeacher.Size = new Size(152, 23);
            lblWelcomeTeacher.TabIndex = 1;
            lblWelcomeTeacher.Text = "Welcome, Teacher!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 77);
            label2.Name = "label2";
            label2.Size = new Size(192, 23);
            label2.TabIndex = 2;
            label2.Text = "Tahun ajaran 2025/2026";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 46, 87);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 171);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(291, 34);
            label3.TabIndex = 5;
            label3.Text = "Teaching Schedules";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 46, 87);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(300, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 171);
            panel2.TabIndex = 6;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(291, 34);
            label4.TabIndex = 5;
            label4.Text = "Not Graded";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(15, 46, 87);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(597, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(292, 171);
            panel3.TabIndex = 7;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(292, 34);
            label5.TabIndex = 5;
            label5.Text = "Attendance";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.4080734F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.2959633F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Location = new Point(9, 146);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(892, 177);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(dgvSchedules);
            panel4.Location = new Point(9, 342);
            panel4.Name = "panel4";
            panel4.Size = new Size(563, 226);
            panel4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(160, 25);
            label6.TabIndex = 5;
            label6.Text = "Today's Schedules";
            // 
            // dgvSchedules
            // 
            dgvSchedules.AllowUserToAddRows = false;
            dgvSchedules.AllowUserToDeleteRows = false;
            dgvSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedules.BackgroundColor = Color.FromArgb(4, 45, 99);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 46, 87);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSchedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(2, 46, 99);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(31, 92, 173);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSchedules.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSchedules.Dock = DockStyle.Bottom;
            dgvSchedules.Location = new Point(0, 57);
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.ReadOnly = true;
            dgvSchedules.RowHeadersVisible = false;
            dgvSchedules.RowHeadersWidth = 51;
            dgvSchedules.ScrollBars = ScrollBars.None;
            dgvSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedules.Size = new Size(563, 169);
            dgvSchedules.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(15, 46, 87);
            panel5.Controls.Add(tableLayoutPanel2);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(590, 343);
            panel5.Name = "panel5";
            panel5.Size = new Size(311, 226);
            panel5.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(panel8, 0, 2);
            tableLayoutPanel2.Controls.Add(panel7, 0, 1);
            tableLayoutPanel2.Controls.Add(panel6, 0, 0);
            tableLayoutPanel2.Location = new Point(8, 31);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(295, 186);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(168, 199, 240);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 127);
            panel8.Name = "panel8";
            panel8.Size = new Size(289, 56);
            panel8.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(168, 199, 240);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 65);
            panel7.Name = "panel7";
            panel7.Size = new Size(289, 56);
            panel7.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(168, 199, 240);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(289, 56);
            panel6.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(128, 28);
            label7.TabIndex = 6;
            label7.Text = "Quick Action";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(dgvCoursesTable);
            panel9.Controls.Add(label8);
            panel9.Location = new Point(9, 588);
            panel9.Name = "panel9";
            panel9.Size = new Size(338, 615);
            panel9.TabIndex = 11;
            panel9.Paint += panel9_Paint;
            // 
            // dgvCoursesTable
            // 
            dgvCoursesTable.AllowUserToAddRows = false;
            dgvCoursesTable.AllowUserToDeleteRows = false;
            dgvCoursesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCoursesTable.BackgroundColor = Color.FromArgb(168, 199, 240);
            dgvCoursesTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(15, 46, 87);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCoursesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCoursesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(2, 46, 99);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(31, 92, 173);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvCoursesTable.DefaultCellStyle = dataGridViewCellStyle4;
            dgvCoursesTable.Dock = DockStyle.Bottom;
            dgvCoursesTable.Location = new Point(0, 53);
            dgvCoursesTable.Name = "dgvCoursesTable";
            dgvCoursesTable.ReadOnly = true;
            dgvCoursesTable.RowHeadersVisible = false;
            dgvCoursesTable.RowHeadersWidth = 51;
            dgvCoursesTable.ScrollBars = ScrollBars.None;
            dgvCoursesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCoursesTable.Size = new Size(338, 562);
            dgvCoursesTable.TabIndex = 12;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(31, 92, 173);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(338, 37);
            label8.TabIndex = 8;
            label8.Text = "Announcement";
            label8.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(dataGridView1);
            panel10.Controls.Add(label9);
            panel10.Location = new Point(375, 588);
            panel10.Name = "panel10";
            panel10.Size = new Size(526, 615);
            panel10.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(4, 45, 99);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(15, 46, 87);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(2, 46, 99);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(31, 92, 173);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(526, 562);
            dataGridView1.TabIndex = 12;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(31, 92, 173);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(526, 37);
            label9.TabIndex = 8;
            label9.Text = "Students";
            label9.TextAlign = ContentAlignment.BottomCenter;
            // 
            // GuruDashboardUc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(lblWelcomeTeacher);
            Controls.Add(label1);
            Name = "GuruDashboardUc";
            Size = new Size(916, 1236);
            Load += GuruDashboardUc_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCoursesTable).EndInit();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblWelcomeTeacher;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Panel panel3;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private DataGridView dgvSchedules;
        private Label label6;
        private Panel panel5;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel9;
        private Label label8;
        private DataGridView dgvCoursesTable;
        private Panel panel10;
        private DataGridView dataGridView1;
        private Label label9;
    }
}
