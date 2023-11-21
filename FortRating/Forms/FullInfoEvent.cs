using FortRating.AddEditForms;
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
    public partial class FullInfoEvent : Form
    {
        private string idEvent, name, description, dateEvent;
        private int points;
        private AppPage.OpenForm of;

        private void FullInfoEvent_Load(object sender, EventArgs e)
        {
            NameLabel.Text = name;
            DescriptionLabel.Text = description;
            DateEventLabel.Text = dateEvent;
            PointsLabel.Text = points.ToString();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddEvent ae = new AddEvent(of, idEvent);
            of(ae);
        }

        public FullInfoEvent(string idEvent, string name, string description, string dateEvent, int points, AppPage.OpenForm of)
        {
            InitializeComponent();
            this.idEvent = idEvent;
            this.name = name; 
            this.description = description;
            this.points = points;
            this.of = of;
            this.dateEvent = dateEvent;
        }
    }
}
