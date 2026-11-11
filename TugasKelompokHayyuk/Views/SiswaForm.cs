using TugasKelompokHayyuk.Repository.Voids;
using TugasKelompokHayyuk.Views.UserControls.SiswaUc;

namespace TugasKelompokHayyuk.Views
{
    public partial class SiswaForm : Form
    {
        VoidsAll VoidsAll = new VoidsAll();
        public SiswaForm()
        {
            InitializeComponent();
         
            
        }
        private void SiswaForm_Load(object sender, EventArgs e)
        {
            btnDashboard_Click(sender, e);

        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
            dashboardUc dashboardUc = new dashboardUc();
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
