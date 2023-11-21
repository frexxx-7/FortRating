using FortRating.Forms;
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
    public partial class EventControl : UserControl
    {
        private AppPage.OpenForm of;
        private string idEvent, name, description, dateEvent;

        private void NameLabel_MouseMove(object sender, MouseEventArgs e)
        {
            NameLabel.ForeColor = Color.FromArgb(94, 148, 255);
        }

        private void NameLabel_MouseLeave(object sender, EventArgs e)
        {
            NameLabel.ForeColor = Color.Black;
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {
            FullInfoEvent fie = new FullInfoEvent(idEvent, name, description, dateEvent, points, of);
            of(fie);
        }

        private int points;
        public EventControl(AppPage.OpenForm of, string idEvent, string name, string description, string dateEvent, int points)
        {
            InitializeComponent();
            this.of= of;
            this.name= name;
            this.description= description;
            this.dateEvent= dateEvent;
            this.points= points;
            this.idEvent= idEvent;

            NameLabel.Text = name;
            DescriptionLabel.Text = description;
            PointsLabel.Text = points.ToString();
            DateLabel.Text = dateEvent;
        }
    }
}
