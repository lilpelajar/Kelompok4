using TugasKelompokHayyuk.Models;
using TugasKelompokHayyuk.Repository.Voids;
using TugasKelompokHayyuk.Views.UserControls.SiswaUc;

namespace TugasKelompokHayyuk.Views
{
    public partial class SiswaForm : Form
    {
        VoidsAll VoidsAll = new VoidsAll();
        private UserModels user;
        public SiswaForm(UserModels userModels)
        {
            InitializeComponent();
            user = userModels;
        }

        private void SiswaForm_Load(object sender, EventArgs e)
        {
            btnDashboard_Click(sender, e);

        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
            dashboardUc dashboardUc = new dashboardUc();
            dashboardUc.LoginUser = user;
            VoidsAll.getUserControl(pnlMain, dashboardUc);
            VoidsAll.buttonOnOff(btnDashboard, btnCourses, btnCalendar, btnGrades);
            
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CoursesUc coursesUc = new CoursesUc();
            VoidsAll.getUserControl(pnlMain, coursesUc);
            VoidsAll.buttonOnOff(btnCourses, btnDashboard, btnCalendar, btnGrades);
        }
    }
}
