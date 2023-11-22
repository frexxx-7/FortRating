using FortRating.Forms;
using FortRating.Forms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortRating.UserControls
{
    public partial class StudentControl : UserControl
    {
        private AppPage.OpenForm of;
        private string idStudent, FIO, group;
        private bool onPrefomance;

        private void FIOLabel_MouseLeave(object sender, EventArgs e)
        {
            FIOLabel.ForeColor = Color.Black;
        }

        private void FIOLabel_Click(object sender, EventArgs e)
        {
            PerfomanceOneStudent pos = new PerfomanceOneStudent(idStudent, FIO, group);
            EditPerfomanceOneUser epou = new EditPerfomanceOneUser(of, idStudent, FIO, group);
            if(onPrefomance)
                of(epou);
            else
                of(pos);
        }

        private void FIOLabel_MouseMove(object sender, MouseEventArgs e)
        {
            FIOLabel.ForeColor = Color.FromArgb(94, 148, 255);
        }

        public StudentControl(AppPage.OpenForm of, string idStudent, string FIO, string group, bool onPerfomance)
        {
            InitializeComponent();
            this.idStudent = idStudent;
            this.FIO = FIO;
            this.group = group;
            this.of = of;
            this.onPrefomance = onPerfomance;

            FIOLabel.Text = FIO;
            GroupLabel.Text = group;
        }
    }
}
