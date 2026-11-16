namespace TugasKelompokHayyuk.Views.UserControls.SiswaUc
{
    partial class dashboardUc
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel10 = new Panel();
            dgvCoursesTable = new DataGridView();
            label2 = new Label();
            panel8 = new Panel();
            lblUsername = new Label();
            lblSemester = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            lblAvgScore = new Label();
            label10 = new Label();
            panel1 = new Panel();
            lblLevel = new Label();
            label8 = new Label();
            panel2 = new Panel();
            lblCourses = new Label();
            label9 = new Label();
            label1 = new Label();
            monthCalendar1 = new MonthCalendar();
            panel4 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            panel7 = new Panel();
            flpAssigmentCard = new FlowLayoutPanel();
            panel12 = new Panel();
            label21 = new Label();
            button3 = new Button();
            label25 = new Label();
            label27 = new Label();
            label28 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel6 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel9 = new Panel();
            label5 = new Label();
            panel11 = new Panel();
            label11 = new Label();
            panel13 = new Panel();
            label12 = new Label();
            panel14 = new Panel();
            label13 = new Label();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCoursesTable).BeginInit();
            panel8.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            flpAssigmentCard.SuspendLayout();
            panel12.SuspendLayout();
            panel6.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            SuspendLayout();
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(dgvCoursesTable);
            panel10.Controls.Add(label2);
            panel10.Location = new Point(16, 275);
            panel10.Name = "panel10";
            panel10.Size = new Size(613, 240);
            panel10.TabIndex = 8;
            // 
            // dgvCoursesTable
            // 
            dgvCoursesTable.AllowUserToAddRows = false;
            dgvCoursesTable.AllowUserToDeleteRows = false;
            dgvCoursesTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCoursesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCoursesTable.BackgroundColor = Color.FromArgb(4, 45, 99);
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
            dgvCoursesTable.Location = new Point(3, 54);
            dgvCoursesTable.Name = "dgvCoursesTable";
            dgvCoursesTable.ReadOnly = true;
            dgvCoursesTable.RowHeadersVisible = false;
            dgvCoursesTable.RowHeadersWidth = 51;
            dgvCoursesTable.ScrollBars = ScrollBars.Vertical;
            dgvCoursesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCoursesTable.Size = new Size(607, 183);
            dgvCoursesTable.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1, 1);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 2;
            label2.Text = "Today's Courses";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(lblUsername);
            panel8.Controls.Add(lblSemester);
            panel8.Controls.Add(tableLayoutPanel1);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(16, 21);
            panel8.Name = "panel8";
            panel8.Size = new Size(613, 245);
            panel8.TabIndex = 7;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(170, 3);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(118, 31);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemester.Location = new Point(6, 34);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(106, 20);
            lblSemester.TabIndex = 2;
            lblSemester.Text = "label semester";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 82);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(610, 160);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(16, 27, 57);
            panel3.Controls.Add(lblAvgScore);
            panel3.Controls.Add(label10);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(409, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 154);
            panel3.TabIndex = 2;
            // 
            // lblAvgScore
            // 
            lblAvgScore.Dock = DockStyle.Fill;
            lblAvgScore.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblAvgScore.ForeColor = Color.White;
            lblAvgScore.Location = new Point(0, 40);
            lblAvgScore.Name = "lblAvgScore";
            lblAvgScore.Size = new Size(198, 114);
            lblAvgScore.TabIndex = 4;
            lblAvgScore.Text = "label13";
            lblAvgScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(198, 40);
            label10.TabIndex = 0;
            label10.Text = "Avg. Score";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 27, 57);
            panel1.Controls.Add(lblLevel);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 154);
            panel1.TabIndex = 0;
            // 
            // lblLevel
            // 
            lblLevel.Dock = DockStyle.Fill;
            lblLevel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblLevel.ForeColor = Color.White;
            lblLevel.Location = new Point(0, 40);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(197, 114);
            lblLevel.TabIndex = 2;
            lblLevel.Text = "X";
            lblLevel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(197, 40);
            label8.TabIndex = 1;
            label8.Text = "Level";
            label8.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 27, 57);
            panel2.Controls.Add(lblCourses);
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(206, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 154);
            panel2.TabIndex = 1;
            // 
            // lblCourses
            // 
            lblCourses.Dock = DockStyle.Fill;
            lblCourses.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourses.ForeColor = Color.White;
            lblCourses.Location = new Point(0, 40);
            lblCourses.Name = "lblCourses";
            lblCourses.Size = new Size(197, 114);
            lblCourses.TabIndex = 3;
            lblCourses.Text = "label12";
            lblCourses.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(197, 40);
            label9.TabIndex = 0;
            label9.Text = "Courses";
            label9.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(180, 31);
            label1.TabIndex = 0;
            label1.Text = "Good Morning, ";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(638, 21);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(4, 45, 99);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(638, 238);
            panel4.Name = "panel4";
            panel4.Size = new Size(262, 202);
            panel4.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 2);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 3;
            label3.Text = "Today's Courses";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(16, 27, 57);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(638, 450);
            panel5.Name = "panel5";
            panel5.Size = new Size(262, 443);
            panel5.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 1);
            label4.Name = "label4";
            label4.Size = new Size(171, 31);
            label4.TabIndex = 3;
            label4.Text = "Announcement";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(flpAssigmentCard);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(293, 526);
            panel7.Name = "panel7";
            panel7.Size = new Size(336, 367);
            panel7.TabIndex = 12;
            // 
            // flpAssigmentCard
            // 
            flpAssigmentCard.AutoScroll = true;
            flpAssigmentCard.Controls.Add(panel12);
            flpAssigmentCard.FlowDirection = FlowDirection.TopDown;
            flpAssigmentCard.Location = new Point(0, 47);
            flpAssigmentCard.Name = "flpAssigmentCard";
            flpAssigmentCard.Size = new Size(358, 325);
            flpAssigmentCard.TabIndex = 6;
            flpAssigmentCard.WrapContents = false;
            // 
            // panel12
            // 
            panel12.Controls.Add(label21);
            panel12.Controls.Add(button3);
            panel12.Controls.Add(label25);
            panel12.Controls.Add(label27);
            panel12.Controls.Add(label28);
            panel12.Location = new Point(3, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(330, 101);
            panel12.TabIndex = 20;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.White;
            label21.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.DimGray;
            label21.Location = new Point(6, 39);
            label21.Name = "label21";
            label21.Size = new Size(77, 17);
            label21.TabIndex = 14;
            label21.Text = "Not graded";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(15, 46, 87);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(254, 64);
            button3.Name = "button3";
            button3.Size = new Size(72, 33);
            button3.TabIndex = 13;
            button3.Text = "View";
            button3.UseVisualStyleBackColor = false;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.White;
            label25.Font = new Font("Segoe UI", 9F);
            label25.ForeColor = Color.FromArgb(192, 0, 0);
            label25.Location = new Point(82, 78);
            label25.Name = "label25";
            label25.Size = new Size(85, 20);
            label25.TabIndex = 12;
            label25.Text = "2026/10/09";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.White;
            label27.Font = new Font("Segoe UI", 9F);
            label27.ForeColor = Color.FromArgb(192, 0, 0);
            label27.Location = new Point(3, 78);
            label27.Name = "label27";
            label27.Size = new Size(73, 20);
            label27.TabIndex = 11;
            label27.Text = "Due date:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.Location = new Point(2, 10);
            label28.Name = "label28";
            label28.Size = new Size(223, 31);
            label28.TabIndex = 10;
            label28.Text = "Math4 - Assignment";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(3, 2);
            label7.Name = "label7";
            label7.Size = new Size(75, 25);
            label7.TabIndex = 5;
            label7.Text = "Futures";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(3, 2);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 4;
            label6.Text = "Tasks";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(flowLayoutPanel1);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(16, 526);
            panel6.Name = "panel6";
            panel6.Size = new Size(265, 367);
            panel6.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel9);
            flowLayoutPanel1.Controls.Add(panel11);
            flowLayoutPanel1.Controls.Add(panel13);
            flowLayoutPanel1.Controls.Add(panel14);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(1, 50);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(287, 317);
            flowLayoutPanel1.TabIndex = 13;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(label5);
            panel9.Location = new Point(3, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(258, 81);
            panel9.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 7);
            label5.Name = "label5";
            label5.Size = new Size(223, 31);
            label5.TabIndex = 15;
            label5.Text = "Math4 - Assignment";
            // 
            // panel11
            // 
            panel11.Controls.Add(label11);
            panel11.Location = new Point(3, 90);
            panel11.Name = "panel11";
            panel11.Size = new Size(258, 81);
            panel11.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(15, 7);
            label11.Name = "label11";
            label11.Size = new Size(223, 31);
            label11.TabIndex = 15;
            label11.Text = "Math4 - Assignment";
            // 
            // panel13
            // 
            panel13.Controls.Add(label12);
            panel13.Location = new Point(3, 177);
            panel13.Name = "panel13";
            panel13.Size = new Size(258, 81);
            panel13.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(15, 7);
            label12.Name = "label12";
            label12.Size = new Size(223, 31);
            label12.TabIndex = 15;
            label12.Text = "Math4 - Assignment";
            // 
            // panel14
            // 
            panel14.Controls.Add(label13);
            panel14.Location = new Point(3, 264);
            panel14.Name = "panel14";
            panel14.Size = new Size(258, 81);
            panel14.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(15, 7);
            label13.Name = "label13";
            label13.Size = new Size(223, 31);
            label13.TabIndex = 15;
            label13.Text = "Math4 - Assignment";
            // 
            // dashboardUc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel10);
            Controls.Add(panel8);
            Controls.Add(monthCalendar1);
            Name = "dashboardUc";
            Size = new Size(915, 1329);
            Load += dashboardUc_Load;
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCoursesTable).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            flpAssigmentCard.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel10;
        private Panel panel8;
        private MonthCalendar monthCalendar1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private DataGridView dgvCoursesTable;
        private Label label2;
        private Panel panel4;
        private Label lblSemester;
        private Label label3;
        private Panel panel5;
        private Label label4;
        private Panel panel7;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label lblUsername;
        private Label lblLevel;
        private Label lblAvgScore;
        private Label lblCourses;
        private FlowLayoutPanel flpAssigmentCard;
        private Panel panel12;
        private Label label21;
        private Button button3;
        private Label label25;
        private Label label27;
        private Label label28;
        private Label label6;
        private Panel panel6;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel9;
        private Label label5;
        private Panel panel11;
        private Label label11;
        private Panel panel13;
        private Label label12;
        private Panel panel14;
        private Label label13;
    }
}
