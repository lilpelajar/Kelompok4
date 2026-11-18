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
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            lblWelcomeTeacher = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label6 = new Label();
            dgvSchedules = new DataGridView();
            panel5 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel6 = new Panel();
            label10 = new Label();
            lblStudentName = new Label();
            panel7 = new Panel();
            label7 = new Label();
            panel9 = new Panel();
            dgvCoursesTable = new DataGridView();
            label8 = new Label();
            panel10 = new Panel();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            panel11 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            lblTeachingSchedule = new Label();
            label3 = new Label();
            panel3 = new Panel();
            lblAttendance = new Label();
            label5 = new Label();
            panel2 = new Panel();
            lblNotGraded = new Label();
            label4 = new Label();
            panel8 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
            panel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCoursesTable).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel11.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcomeTeacher
            // 
            lblWelcomeTeacher.Dock = DockStyle.Top;
            lblWelcomeTeacher.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeTeacher.Location = new Point(0, 0);
            lblWelcomeTeacher.Name = "lblWelcomeTeacher";
            lblWelcomeTeacher.Size = new Size(916, 48);
            lblWelcomeTeacher.TabIndex = 0;
            lblWelcomeTeacher.Text = "Welcome, *Teacher name ";
            lblWelcomeTeacher.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 49);
            label2.Name = "label2";
            label2.Size = new Size(192, 23);
            label2.TabIndex = 2;
            label2.Text = "Tahun ajaran 2025/2026";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(dgvSchedules);
            panel4.Location = new Point(11, 364);
            panel4.Name = "panel4";
            panel4.Size = new Size(543, 226);
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
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(15, 46, 87);
            dataGridViewCellStyle19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle19.ForeColor = Color.White;
            dataGridViewCellStyle19.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dgvSchedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = Color.FromArgb(2, 46, 99);
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle20.ForeColor = Color.White;
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(31, 92, 173);
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            dgvSchedules.DefaultCellStyle = dataGridViewCellStyle20;
            dgvSchedules.Dock = DockStyle.Bottom;
            dgvSchedules.Location = new Point(0, 40);
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.ReadOnly = true;
            dgvSchedules.RowHeadersVisible = false;
            dgvSchedules.RowHeadersWidth = 51;
            dgvSchedules.ScrollBars = ScrollBars.None;
            dgvSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedules.Size = new Size(543, 186);
            dgvSchedules.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(15, 46, 87);
            panel5.Controls.Add(flowLayoutPanel1);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(569, 364);
            panel5.Name = "panel5";
            panel5.Size = new Size(320, 226);
            panel5.TabIndex = 10;
            panel5.Paint += panel5_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Location = new Point(2, 39);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(341, 184);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label10);
            panel6.Controls.Add(lblStudentName);
            panel6.Location = new Point(3, 97);
            panel6.Name = "panel6";
            panel6.Size = new Size(311, 88);
            panel6.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(5, 29);
            label10.Name = "label10";
            label10.Size = new Size(50, 17);
            label10.TabIndex = 1;
            label10.Text = "label10";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentName.Location = new Point(4, 1);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(143, 28);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "Student Name";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(3, 191);
            panel7.Name = "panel7";
            panel7.Size = new Size(311, 88);
            panel7.TabIndex = 1;
            panel7.Paint += panel7_Paint;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(320, 28);
            label7.TabIndex = 6;
            label7.Text = "Not Graded";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(dgvCoursesTable);
            panel9.Controls.Add(label8);
            panel9.Location = new Point(9, 610);
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
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = Color.FromArgb(15, 46, 87);
            dataGridViewCellStyle21.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle21.ForeColor = Color.White;
            dataGridViewCellStyle21.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            dgvCoursesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            dgvCoursesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = Color.FromArgb(2, 46, 99);
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle22.ForeColor = Color.White;
            dataGridViewCellStyle22.SelectionBackColor = Color.FromArgb(31, 92, 173);
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.False;
            dgvCoursesTable.DefaultCellStyle = dataGridViewCellStyle22;
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
            panel10.Location = new Point(366, 610);
            panel10.Name = "panel10";
            panel10.Size = new Size(523, 615);
            panel10.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(4, 45, 99);
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = Color.FromArgb(15, 46, 87);
            dataGridViewCellStyle23.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle23.ForeColor = Color.White;
            dataGridViewCellStyle23.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = Color.FromArgb(2, 46, 99);
            dataGridViewCellStyle24.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle24.ForeColor = Color.White;
            dataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(31, 92, 173);
            dataGridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle24;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(523, 562);
            dataGridView1.TabIndex = 12;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(31, 92, 173);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(523, 37);
            label9.TabIndex = 8;
            label9.Text = "Students";
            label9.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Controls.Add(tableLayoutPanel1);
            panel11.Location = new Point(12, 128);
            panel11.Name = "panel11";
            panel11.Size = new Size(877, 215);
            panel11.TabIndex = 14;
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
            tableLayoutPanel1.Location = new Point(18, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(842, 179);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 46, 87);
            panel1.Controls.Add(lblTeachingSchedule);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 171);
            panel1.TabIndex = 4;
            // 
            // lblTeachingSchedule
            // 
            lblTeachingSchedule.Dock = DockStyle.Fill;
            lblTeachingSchedule.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblTeachingSchedule.ForeColor = Color.White;
            lblTeachingSchedule.Location = new Point(0, 34);
            lblTeachingSchedule.Name = "lblTeachingSchedule";
            lblTeachingSchedule.Size = new Size(274, 137);
            lblTeachingSchedule.TabIndex = 6;
            lblTeachingSchedule.Text = "label13";
            lblTeachingSchedule.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(274, 34);
            label3.TabIndex = 5;
            label3.Text = "Teaching Schedules";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(15, 46, 87);
            panel3.Controls.Add(lblAttendance);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(564, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 171);
            panel3.TabIndex = 7;
            // 
            // lblAttendance
            // 
            lblAttendance.Dock = DockStyle.Fill;
            lblAttendance.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblAttendance.ForeColor = Color.White;
            lblAttendance.Location = new Point(0, 34);
            lblAttendance.Name = "lblAttendance";
            lblAttendance.Size = new Size(275, 137);
            lblAttendance.TabIndex = 8;
            lblAttendance.Text = "label15";
            lblAttendance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(275, 34);
            label5.TabIndex = 5;
            label5.Text = "Attendance";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 46, 87);
            panel2.Controls.Add(lblNotGraded);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(283, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 171);
            panel2.TabIndex = 6;
            // 
            // lblNotGraded
            // 
            lblNotGraded.Dock = DockStyle.Fill;
            lblNotGraded.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblNotGraded.ForeColor = Color.White;
            lblNotGraded.Location = new Point(0, 34);
            lblNotGraded.Name = "lblNotGraded";
            lblNotGraded.Size = new Size(275, 137);
            lblNotGraded.TabIndex = 7;
            lblNotGraded.Text = "label14";
            lblNotGraded.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(275, 34);
            label4.TabIndex = 5;
            label4.Text = "Not Graded";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(311, 88);
            panel8.TabIndex = 2;
            // 
            // GuruDashboardUc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(lblWelcomeTeacher);
            Name = "GuruDashboardUc";
            Size = new Size(916, 1236);
            Load += GuruDashboardUc_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).EndInit();
            panel5.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCoursesTable).EndInit();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel11.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcomeTeacher;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel4;
        private DataGridView dgvSchedules;
        private Label label6;
        private Panel panel5;
        private Label label7;
        private Panel panel9;
        private Label label8;
        private DataGridView dgvCoursesTable;
        private Panel panel10;
        private DataGridView dataGridView1;
        private Label label9;
        private Panel panel11;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label3;
        private Panel panel3;
        private Label label5;
        private Panel panel2;
        private Label label4;
        private Label lblTeachingSchedule;
        private Label lblAttendance;
        private Label lblNotGraded;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel6;
        private Label label10;
        private Label lblStudentName;
        private Panel panel7;
        private Panel panel8;
    }
}
