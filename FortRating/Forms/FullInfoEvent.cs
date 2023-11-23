using FontAwesome.Sharp;
using FortRating.AddEditForms;
using FortRating.Classes;
using FortRating.Forms.Admin;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FortRating.Forms
{
    public partial class FullInfoEvent : Form
    {
        private string idEvent, name, description, dateEvent;
        private int points;
        private AppPage.OpenForm of;

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"delete from events where id = {idEvent}", db.getConnection());
            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Мероприятие удалено");
                db.closeConnection();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Events events = new Events(of);
                of(events);
            }

        }

        private void EditParticipant_Click(object sender, EventArgs e)
        {
            StudentsOnEvent soe = new StudentsOnEvent(of, idEvent, name);
            of(soe);
        }

        private void FullInfoEvent_Load(object sender, EventArgs e)
        {
            NameLabel.Text = name;
            DescriptionLabel.Text = description;
            DateEventLabel.Text = dateEvent;
            PointsLabel.Text = points.ToString();
            if (AppPage.login != "admin" && AppPage.login != "Admin")
            {
                EditButton.Visible = false;
                DeleteButton.Visible = false;
                EditParticipant.Visible = false;
            }
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
