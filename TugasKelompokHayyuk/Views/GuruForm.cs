using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TugasKelompokHayyuk.Models;
using TugasKelompokHayyuk.Repository.Voids;
using TugasKelompokHayyuk.Views.UserControls.GuruUc;

namespace TugasKelompokHayyuk.Views
{
    public partial class GuruForm : Form
    {
        VoidsAll VoidsAll = new VoidsAll();
        private UserModels user;
        public GuruForm(UserModels userModels)
        {
            InitializeComponent();
            user = userModels;
        }
        
        private void GuruForm_Load(object sender, EventArgs e)
        {
            btnDashboard_Click(sender, e);
        }
         

        private void GuruForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            GuruDashboardUc dashboardUc = new GuruDashboardUc();
            dashboardUc.LoginUser = user;
            VoidsAll.getUserControl(pnlMain, dashboardUc);
            VoidsAll.buttonOnOff(btnDashboard, btnAttendance, btnCalendar, btnSchedules);

        }
    }
}
