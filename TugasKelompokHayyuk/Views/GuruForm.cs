using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TugasKelompokHayyuk.Repository.Voids;
using TugasKelompokHayyuk.Views.UserControls.GuruUc;

namespace TugasKelompokHayyuk.Views
{
    public partial class GuruForm : Form
    {
        GuruDashboardUc dashboardGuru = new GuruDashboardUc();
        VoidsAll VoidsAll = new VoidsAll();
        public GuruForm()
        {
            InitializeComponent();
        }
        
        private void GuruForm_Load(object sender, EventArgs e)
        {
            GuruDashboardUc guruDashboardUc = new GuruDashboardUc();
            pnlMain.Controls.Add(guruDashboardUc);
            btnDashboard_Click(sender, e);
        }


        private void GuruForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            VoidsAll.getUserControl(pnlMain, dashboardGuru);
            VoidsAll.buttonOnOff(btnDashboard, btnAttendance, btnCalendar, btnSchedules);

        }
    }
}
