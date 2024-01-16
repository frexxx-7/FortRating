using FortRating.Forms.Admin;
using FortRating.Forms.References;
using FortRating.Forms.ReferencesFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortRating.Forms
{
    public partial class ReferencesForm : Form
    {
        private AppPage.OpenForm of;
        public ReferencesForm(AppPage.OpenForm of)
        {
            InitializeComponent();
            this.of = of;
        }

        private void GroupsButton_Click(object sender, EventArgs e)
        {
            of(new Groups(of));
        }

        private void DisciplinesButton_Click(object sender, EventArgs e)
        {
            of(new Discipline(of));
        }

        private void EventsButton_Click(object sender, EventArgs e)
        {
            of(new Events(of));
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            of(new Users(of));
        }

        private void StydentsButton_Click(object sender, EventArgs e)
        {
            of(new Students(of));
        }
    }
}
