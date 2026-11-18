using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TugasKelompokHayyuk.Models;

namespace TugasKelompokHayyuk.Views.UserControls.CardsUc
{
    public partial class CardAssignmentUc : UserControl 
    {
        public CardAssignmentUc()
        {
            InitializeComponent();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SubjectName
        {
            get { return lblSubjectName.Text; }
            set { lblSubjectName.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Grade
        {
            get { return lblIsGraded.Text; }
            set { lblIsGraded.Text = value; }
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DueDate
        {
           get { return lblDueDate.Text; }
           set { lblDueDate.Text = value; }
        }
    }
}
