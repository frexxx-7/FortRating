using FortRating.Classes;
using FortRating.Forms;
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

namespace FortRating.AddEditForms
{
    public partial class AddEvent : Form
    {
        private AppPage.OpenForm of;
        private string idEvent;
        public AddEvent(AppPage.OpenForm of, string idEvent)
        {
            InitializeComponent();
            this.idEvent = idEvent;

            if (idEvent != null)
            {
                label1.Text = "Изменить мероприятие";
                AddButton.Text = "Изменить";
                loadInfoEvent();
            }
            this.of= of;
        }
        private void loadInfoEvent()
        {
            DB db = new DB();
            string queryInfo = $"SELECT * FROM events WHERE id = '{idEvent}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                NameTextBox.Text = reader["name"].ToString();
                DescriptionTextBox.Text = reader["description"].ToString();
                PointsTextBox.Text = reader["points"].ToString();
                guna2DateTimePicker1.Value = Convert.ToDateTime(reader["dateEvent"].ToString());
            }
            reader.Close();

            db.closeConnection();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (idEvent == null)
            {
                MySqlCommand command = new MySqlCommand($"INSERT into events (name, description, dateEvent, points) values(@name, @description, @dateEvent, @points)", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@description", DescriptionTextBox.Text);
                command.Parameters.AddWithValue("@dateEvent", guna2DateTimePicker1.Value.ToString("dd.MM.yyyy"));
                command.Parameters.AddWithValue("@points", PointsTextBox.Text);
                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Мероприятие добавлено");
                    Events ev = new Events(of);
                    of(ev);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Ошибка {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.closeConnection();
            }
            else
            {
                MySqlCommand command = new MySqlCommand($"Update events set name = @name, description = @description, points = @points where id = {idEvent}", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@description", DescriptionTextBox.Text);
                command.Parameters.AddWithValue("@dateEvent", guna2DateTimePicker1.Value.ToString("dd.MM.yyyy"));
                command.Parameters.AddWithValue("@points", PointsTextBox.Text);
                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Мероприятие изменено");
                    Events ev = new Events(of);
                    of(ev);
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.closeConnection();
            }
        }

        private void PointsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }
    }
}
