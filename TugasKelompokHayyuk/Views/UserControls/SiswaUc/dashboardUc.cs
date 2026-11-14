using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using TugasKelompokHayyuk.Models;
using TugasKelompokHayyuk.Repository;

namespace TugasKelompokHayyuk.Views.UserControls.SiswaUc
{
    public partial class dashboardUc : UserControl
    {
        StudentDashboardRepo studentDashboardRepo = new StudentDashboardRepo();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public UserModels LoginUser { get; set; }

        public dashboardUc()
        {
            InitializeComponent();
        }
        
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardUc_Load(object sender, EventArgs e)
        {
            lblUsername.Text = LoginUser.Username ?? "guest";

            if (LoginUser != null && !string.IsNullOrEmpty(LoginUser.Username)) 
            {
                int total = studentDashboardRepo.GetGradesAggregate(LoginUser.Username);
                dgvCoursesTable.DataSource = studentDashboardRepo.ReadTableClasses(LoginUser.Username);
                lblCourses.Text = total.ToString();
            }
           
            dgvCoursesTable.Columns[0].HeaderText = "Subject Name";
            dgvCoursesTable.Columns[1].HeaderText = "Score";
            dgvCoursesTable.Columns[2].HeaderText = "Teacher Name";
        }
    }
}
