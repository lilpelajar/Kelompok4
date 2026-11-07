using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TugasKelompokHayyuk.Views.UserControls.SiswaUc;

namespace TugasKelompokHayyuk.Views
{
    public partial class SiswaForm : Form
    {
        public SiswaForm()
        {
            InitializeComponent();
        }
        public static object color = Color.FromArgb(6, 21, 50);

        private void SiswaForm_Load(object sender, EventArgs e)
        {
            btnDashboard_Click(sender, e);
        }

        private void ButtonOn(Label labelOn)
        {
            labelOn.BackColor = Color.White;
            labelOn.ForeColor = (Color)color;
        }
        private void ButtonOff(Label labelOff)
        {
            labelOff.BackColor = (Color)color;
            labelOff.ForeColor = Color.White;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboardUc dashboardUc = new dashboardUc();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(dashboardUc);
            dashboardUc.Dock = DockStyle.Top;
            ButtonOn(btnDashboard);
            ButtonOff(btnCourses);
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CoursesUc coursesUc = new CoursesUc();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(coursesUc);
            coursesUc.Dock = DockStyle.Top;
            ButtonOn(btnCourses);
            ButtonOff(btnDashboard);
        }
    }
}
