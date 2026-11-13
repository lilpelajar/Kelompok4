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
            label26 = new Label();
            button4 = new Button();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            SuspendLayout();
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.White;
            label26.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.DimGray;
            label26.Location = new Point(7, 35);
            label26.Name = "label26";
            label26.Size = new Size(77, 17);
            label26.TabIndex = 19;
            label26.Text = "Not graded";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(15, 46, 87);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(255, 60);
            button4.Name = "button4";
            button4.Size = new Size(72, 33);
            button4.TabIndex = 18;
            button4.Text = "View";
            button4.UseVisualStyleBackColor = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.White;
            label22.Font = new Font("Segoe UI", 9F);
            label22.ForeColor = Color.FromArgb(192, 0, 0);
            label22.Location = new Point(83, 74);
            label22.Name = "label22";
            label22.Size = new Size(85, 20);
            label22.TabIndex = 17;
            label22.Text = "2026/10/09";
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
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(3, 6);
            label24.Name = "label24";
            label24.Size = new Size(219, 31);
            label24.TabIndex = 15;
            label24.Text = "Math1 - Assignment";
            // 
            // CardAssignmentUc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label26);
            Controls.Add(button4);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label24);
            Name = "CardAssignmentUc";
            Size = new Size(330, 101);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label26;
        private Button button4;
        private Label label22;
        private Label label23;
        private Label label24;
    }
}
