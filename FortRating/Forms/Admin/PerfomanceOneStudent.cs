using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortRating.Forms.Admin
{
    public partial class PerfomanceOneStudent : Form
    {
        private string idStudent, FIO, group;
        public PerfomanceOneStudent(string idStudent, string FIO, string group)
        {
            InitializeComponent();
            this.idStudent = idStudent;
            this.FIO = FIO;
            this.group = group;

            FIOLabel.Text = FIO;
            GroupLabel.Text = group;
        }
    }
}
