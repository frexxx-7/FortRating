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

namespace FortRating.AddEditForms
{
    public partial class AddParticipantEvent : Form
    {
        private string idEvent;
        private StudentsOnEvent.LoadInfoParticipantInEventDelegate lipied;
        public AddParticipantEvent(string idEvent, StudentsOnEvent.LoadInfoParticipantInEventDelegate lipied)
        {
            InitializeComponent();
            this.idEvent = idEvent;
            loadInfoStudents();
            this.lipied= lipied;
        }
        private void loadInfoStudents()
        {
            StudentsComboBox.Items.Clear();
            DB db = new DB();
            string queryInfo = $"SELECT * FROM students " +
                $"where id not in (select idStudent from participantioninevents " +
                $"where idEvent = {idEvent})";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                FortRating.Classes.ComboBoxItem item = new FortRating.Classes.ComboBoxItem();
                item.Text = $" {reader[1]}";
                item.Value = reader[0];
                StudentsComboBox.Items.Add(item);
            }
            reader.Close();

            db.closeConnection();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"INSERT into participantioninevents (idEvent, idStudent) values(@idEvent, @idStudent)", db.getConnection());
            command.Parameters.AddWithValue("@idEvent", idEvent);
            command.Parameters.AddWithValue("@idStudent", (StudentsComboBox.SelectedItem as FortRating.Classes.ComboBoxItem).Value);
            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Участник добавлен");
                db.closeConnection();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Ошибка {exp}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lipied();
                this.Close();
            }
        }

        private void CanceledButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
