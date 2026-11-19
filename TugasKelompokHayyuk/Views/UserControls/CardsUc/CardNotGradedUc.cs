using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TugasKelompokHayyuk.Views.UserControls.CardsUc
{
    public partial class CardNotGradedUc : UserControl
    {
        public CardNotGradedUc()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string StudentName
        {
            get { return lblStudnentName.Text; }
            set { lblStudnentName.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ClassaName
        {
            get { return lblClassName.Text; }
            set { lblClassName.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Description
        {
            get => lblDescription.Text;
            set => lblDescription.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime Submitted
        {
            get { return DateTime.TryParse(lblSubmited.Text, out DateTime result) ? result : DateTime.MinValue; }
            set { lblSubmited.Text = value.ToString("yyyy-MM-dd HH:mm:ss"); }
        }
    }
}
