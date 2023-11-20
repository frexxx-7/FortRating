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
        private string name, description, dateEvent;
        private int points;
        public EventControl(AppPage.OpenForm of, string name, string description, string dateEvent, int points)
        {
            InitializeComponent();
            this.of= of;
            this.name= name;
            this.description= description;
            this.dateEvent= dateEvent;
            this.points= points;

            NameLabel.Text = name;
            DescriptionLabel.Text = description;
            PointsLabel.Text = points.ToString();
            DateLabel.Text = dateEvent;
        }
    }
}
