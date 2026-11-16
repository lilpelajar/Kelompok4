namespace TugasKelompokHayyuk.Views.UserControls.CardsUc
{
    partial class CardAssignmentUc
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
            lblIsGraded = new Label();
            btnView = new Button();
            lblDueDate = new Label();
            label23 = new Label();
            lblSubjectName = new Label();
            SuspendLayout();
            // 
            // lblIsGraded
            // 
            lblIsGraded.AutoSize = true;
            lblIsGraded.BackColor = Color.White;
            lblIsGraded.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIsGraded.ForeColor = Color.DimGray;
            lblIsGraded.Location = new Point(7, 35);
            lblIsGraded.Name = "lblIsGraded";
            lblIsGraded.Size = new Size(77, 17);
            lblIsGraded.TabIndex = 19;
            lblIsGraded.Text = "Not graded";
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(15, 46, 87);
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(255, 60);
            btnView.Name = "btnView";
            btnView.Size = new Size(72, 33);
            btnView.TabIndex = 18;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.BackColor = Color.White;
            lblDueDate.Font = new Font("Segoe UI", 9F);
            lblDueDate.ForeColor = Color.FromArgb(192, 0, 0);
            lblDueDate.Location = new Point(83, 74);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(85, 20);
            lblDueDate.TabIndex = 17;
            lblDueDate.Text = "2026/10/09";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.White;
            label23.Font = new Font("Segoe UI", 9F);
            label23.ForeColor = Color.FromArgb(192, 0, 0);
            label23.Location = new Point(4, 74);
            label23.Name = "label23";
            label23.Size = new Size(73, 20);
            label23.TabIndex = 16;
            label23.Text = "Due date:";
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubjectName.Location = new Point(3, 6);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(219, 31);
            lblSubjectName.TabIndex = 15;
            lblSubjectName.Text = "Math1 - Assignment";
            // 
            // CardAssignmentUc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblIsGraded);
            Controls.Add(btnView);
            Controls.Add(lblDueDate);
            Controls.Add(label23);
            Controls.Add(lblSubjectName);
            Name = "CardAssignmentUc";
            Size = new Size(330, 101);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIsGraded;
        private Button btnView;
        private Label lblDueDate;
        private Label label23;
        private Label lblSubjectName;
    }
}
