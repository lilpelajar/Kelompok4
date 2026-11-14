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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            panel6 = new Panel();
            label6 = new Label();
            panel7 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel13 = new Panel();
            label26 = new Label();
            button4 = new Button();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            panel9 = new Panel();
            label11 = new Label();
            button1 = new Button();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            panel11 = new Panel();
            label17 = new Label();
            button2 = new Button();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            panel12 = new Panel();
            label21 = new Label();
            button3 = new Button();
            label25 = new Label();
            label27 = new Label();
            label28 = new Label();
            label7 = new Label();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCoursesTable).BeginInit();
            panel8.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel13.SuspendLayout();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(15, 46, 87);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvCoursesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCoursesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(2, 46, 99);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(31, 92, 173);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvCoursesTable.DefaultCellStyle = dataGridViewCellStyle6;
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
            label2.Location = new Point(3, 3);
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
            lblLevel.Text = "label12";
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
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label6);
            panel6.Location = new Point(16, 526);
            panel6.Name = "panel6";
            panel6.Size = new Size(265, 367);
            panel6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(3, 2);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 4;
            label6.Text = "Courses";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(flowLayoutPanel1);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(293, 526);
            panel7.Name = "panel7";
            panel7.Size = new Size(336, 367);
            panel7.TabIndex = 12;

            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel13);
            flowLayoutPanel1.Controls.Add(panel9);
            flowLayoutPanel1.Controls.Add(panel11);
            flowLayoutPanel1.Controls.Add(panel12);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 47);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(358, 325);
            flowLayoutPanel1.TabIndex = 6;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel13
            // 
            panel13.Controls.Add(label26);
            panel13.Controls.Add(button4);
            panel13.Controls.Add(label22);
            panel13.Controls.Add(label23);
            panel13.Controls.Add(label24);
            panel13.Location = new Point(3, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(330, 101);
            panel13.TabIndex = 17;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.White;
            label26.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.DimGray;
            label26.Location = new Point(6, 39);
            label26.Name = "label26";
            label26.Size = new Size(77, 17);
            label26.TabIndex = 14;
            label26.Text = "Not graded";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(15, 46, 87);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(254, 64);
            button4.Name = "button4";
            button4.Size = new Size(72, 33);
            button4.TabIndex = 13;
            button4.Text = "View";
            button4.UseVisualStyleBackColor = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.White;
            label22.Font = new Font("Segoe UI", 9F);
            label22.ForeColor = Color.FromArgb(192, 0, 0);
            label22.Location = new Point(82, 78);
            label22.Name = "label22";
            label22.Size = new Size(85, 20);
            label22.TabIndex = 12;
            label22.Text = "2026/10/09";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.White;
            label23.Font = new Font("Segoe UI", 9F);
            label23.ForeColor = Color.FromArgb(192, 0, 0);
            label23.Location = new Point(3, 78);
            label23.Name = "label23";
            label23.Size = new Size(73, 20);
            label23.TabIndex = 11;
            label23.Text = "Due date:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(2, 10);
            label24.Name = "label24";
            label24.Size = new Size(219, 31);
            label24.TabIndex = 10;
            label24.Text = "Math1 - Assignment";
            // 
            // panel9
            // 
            panel9.Controls.Add(label11);
            panel9.Controls.Add(button1);
            panel9.Controls.Add(label14);
            panel9.Controls.Add(label15);
            panel9.Controls.Add(label16);
            panel9.Location = new Point(3, 110);
            panel9.Name = "panel9";
            panel9.Size = new Size(330, 101);
            panel9.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(6, 39);
            label11.Name = "label11";
            label11.Size = new Size(77, 17);
            label11.TabIndex = 14;
            label11.Text = "Not graded";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(15, 46, 87);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(254, 64);
            button1.Name = "button1";
            button1.Size = new Size(72, 33);
            button1.TabIndex = 13;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI", 9F);
            label14.ForeColor = Color.FromArgb(192, 0, 0);
            label14.Location = new Point(82, 78);
            label14.Name = "label14";
            label14.Size = new Size(85, 20);
            label14.TabIndex = 12;
            label14.Text = "2026/10/09";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Segoe UI", 9F);
            label15.ForeColor = Color.FromArgb(192, 0, 0);
            label15.Location = new Point(3, 78);
            label15.Name = "label15";
            label15.Size = new Size(73, 20);
            label15.TabIndex = 11;
            label15.Text = "Due date:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(2, 10);
            label16.Name = "label16";
            label16.Size = new Size(223, 31);
            label16.TabIndex = 10;
            label16.Text = "Math2 - Assignment";
            // 
            // panel11
            // 
            panel11.Controls.Add(label17);
            panel11.Controls.Add(button2);
            panel11.Controls.Add(label18);
            panel11.Controls.Add(label19);
            panel11.Controls.Add(label20);
            panel11.Location = new Point(3, 217);
            panel11.Name = "panel11";
            panel11.Size = new Size(330, 101);
            panel11.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.White;
            label17.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.DimGray;
            label17.Location = new Point(6, 39);
            label17.Name = "label17";
            label17.Size = new Size(77, 17);
            label17.TabIndex = 14;
            label17.Text = "Not graded";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(15, 46, 87);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(254, 64);
            button2.Name = "button2";
            button2.Size = new Size(72, 33);
            button2.TabIndex = 13;
            button2.Text = "View";
            button2.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.White;
            label18.Font = new Font("Segoe UI", 9F);
            label18.ForeColor = Color.FromArgb(192, 0, 0);
            label18.Location = new Point(82, 78);
            label18.Name = "label18";
            label18.Size = new Size(85, 20);
            label18.TabIndex = 12;
            label18.Text = "2026/10/09";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.White;
            label19.Font = new Font("Segoe UI", 9F);
            label19.ForeColor = Color.FromArgb(192, 0, 0);
            label19.Location = new Point(3, 78);
            label19.Name = "label19";
            label19.Size = new Size(73, 20);
            label19.TabIndex = 11;
            label19.Text = "Due date:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(2, 10);
            label20.Name = "label20";
            label20.Size = new Size(223, 31);
            label20.TabIndex = 10;
            label20.Text = "Math3 - Assignment";
            // 
            // panel12
            // 
            panel12.Controls.Add(label21);
            panel12.Controls.Add(button3);
            panel12.Controls.Add(label25);
            panel12.Controls.Add(label27);
            panel12.Controls.Add(label28);
            panel12.Location = new Point(3, 324);
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
            label7.Size = new Size(112, 25);
            label7.TabIndex = 5;
            label7.Text = "Assignment";
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
            Size = new Size(915, 902);
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
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
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
        private Panel panel6;
        private Panel panel7;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label lblUsername;
        private Label lblLevel;
        private Label lblAvgScore;
        private Label lblCourses;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel13;
        private Button button4;
        private Label label22;
        private Label label23;
        private Label label26;
        private Label label24;
        private Panel panel9;
        private Label label11;
        private Button button1;
        private Label label14;
        private Label label15;
        private Label label16;
        private Panel panel11;
        private Label label17;
        private Button button2;
        private Label label18;
        private Label label19;
        private Label label20;
        private Panel panel12;
        private Label label21;
        private Button button3;
        private Label label25;
        private Label label27;
        private Label label28;
    }
}
