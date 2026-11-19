namespace TugasKelompokHayyuk.Views.UserControls.CardsUc
{
    partial class CardNotGradedUc
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
            lblStudnentName = new Label();
            lblClassName = new Label();
            lblDescription = new Label();
            btnRate = new Button();
            lblSubmited = new Label();
            SuspendLayout();
            // 
            // lblStudnentName
            // 
            lblStudnentName.AutoSize = true;
            lblStudnentName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudnentName.Location = new Point(0, 0);
            lblStudnentName.Name = "lblStudnentName";
            lblStudnentName.Size = new Size(140, 28);
            lblStudnentName.TabIndex = 0;
            lblStudnentName.Text = "Student name";
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClassName.Location = new Point(224, 3);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(84, 23);
            lblClassName.TabIndex = 1;
            lblClassName.Text = " Liverpool";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.DimGray;
            lblDescription.Location = new Point(3, 28);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(97, 17);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Base Quantities";
            // 
            // btnRate
            // 
            btnRate.BackColor = Color.FromArgb(4, 45, 99);
            btnRate.FlatStyle = FlatStyle.Popup;
            btnRate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRate.ForeColor = Color.White;
            btnRate.Location = new Point(239, 51);
            btnRate.Name = "btnRate";
            btnRate.Size = new Size(69, 34);
            btnRate.TabIndex = 3;
            btnRate.Text = "Rate";
            btnRate.UseVisualStyleBackColor = false;
            // 
            // lblSubmited
            // 
            lblSubmited.AutoSize = true;
            lblSubmited.Location = new Point(3, 65);
            lblSubmited.Name = "lblSubmited";
            lblSubmited.Size = new Size(143, 20);
            lblSubmited.TabIndex = 4;
            lblSubmited.Text = "2026-11-10 14:30:00";
            // 
            // CardNotGradedUc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblSubmited);
            Controls.Add(btnRate);
            Controls.Add(lblDescription);
            Controls.Add(lblClassName);
            Controls.Add(lblStudnentName);
            Name = "CardNotGradedUc";
            Size = new Size(311, 88);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudnentName;
        private Label lblClassName;
        private Label lblDescription;
        private Button btnRate;
        private Label lblSubmited;
    }
}
