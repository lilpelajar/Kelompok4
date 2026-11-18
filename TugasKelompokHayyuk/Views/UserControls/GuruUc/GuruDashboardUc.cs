using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TugasKelompokHayyuk.Models;
using TugasKelompokHayyuk.Repository;

namespace TugasKelompokHayyuk.Views.UserControls.GuruUc
{
    public partial class GuruDashboardUc : UserControl
    {
        TeacherDashboardRepo teacherDashboardRepo = new TeacherDashboardRepo();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public UserModels LoginUser { get; set; }
        public GuruDashboardUc()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GuruDashboardUc_Load(object sender, EventArgs e)
        {
            lblWelcomeTeacher.Text = "Welcome, " + LoginUser.Username ?? "guest";
            dgvSchedules.DataSource = teacherDashboardRepo.ReadTodaySchedule(LoginUser.Username);
            lblTeachingSchedule.Text = teacherDashboardRepo.GetTeachingScheduleAgg(LoginUser.Username).ToString();
            lblNotGraded.Text = teacherDashboardRepo.GetNotGradedAgg(LoginUser.Username).ToString();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
