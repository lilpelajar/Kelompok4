using System;
using System.Collections.Generic;
using System.Text;

namespace TugasKelompokHayyuk.Repository.Voids
{
    public class VoidsAll
    {
        public object color { get; set; } = Color.FromArgb(6, 21, 50);
        public void buttonOn(Label labelOn)
        {
            labelOn.BackColor = Color.White;
            labelOn.ForeColor = (Color)color;
        }

        public void buttonOff(Label labelOff)
        {
            labelOff.BackColor = (Color)color;
            labelOff.ForeColor = Color.White;
        }

        public void buttonOnOff(Label lblOn, Label lblOff, Label lblOff2, Label lblOff3) 
        {
            buttonOn(lblOn);
            buttonOff(lblOff);
            buttonOff(lblOff2);
            buttonOff(lblOff3);
        }


        public void getUserControl(Panel panel,UserControl Uc)
        {
            panel.Controls.Clear();
            panel.Controls.Add(Uc);
            Uc.Dock = DockStyle.Top;
        }
    }
}
