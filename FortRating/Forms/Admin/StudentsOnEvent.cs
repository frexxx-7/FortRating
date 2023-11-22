using FortRating.AddEditForms;
using FortRating.Classes;
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

namespace FortRating.Forms.Admin
{
    public partial class StudentsOnEvent : Form
    {
        private AppPage.OpenForm of;
        private string idEvent, name;
        public delegate void LoadInfoParticipantInEventDelegate();

        private void AddParticipantButton_Click(object sender, EventArgs e)
        {
            LoadInfoParticipantInEventDelegate lipied = new  LoadInfoParticipantInEventDelegate(loadInfoParticipantInEvent);
            AddParticipantEvent ape = new AddParticipantEvent(idEvent, lipied);
            ape.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"delete from participantioninevents where id = {StudentsDataGrid[0, StudentsDataGrid.SelectedCells[0].RowIndex].Value}", db.getConnection());
            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Участник удален");

            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
            loadInfoParticipantInEvent();
        }
        private void loadInfoParticipantInEvent()
        {
            DB db = new DB();

            StudentsDataGrid.Rows.Clear();

            string query = $"select participantioninevents.id, concat(students.surname, ' ', students.name, ' ', students.patronymic) from participantioninevents " +
                $"left join students on participantioninevents.idStudent = students.id " +
                $"where participantioninevents.idEvent = {idEvent}";

            db.openConnection();
            using (MySqlCommand mySqlCommand = new MySqlCommand(query, db.getConnection()))
            {
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                List<string[]> dataDB = new List<string[]>();
                while (reader.Read())
                {
                    dataDB.Add(new string[reader.FieldCount]);

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataDB[dataDB.Count - 1][i] = reader[i].ToString();
                    }
                }
                reader.Close();
                foreach (string[] s in dataDB)
                    StudentsDataGrid.Rows.Add(s);
            }
            db.closeConnection();
        }

        private void StudentsOnEvent_Load(object sender, EventArgs e)
        {
            loadInfoParticipantInEvent();
        }

        public StudentsOnEvent(AppPage.OpenForm of, string idEvent, string name)
        {
            InitializeComponent();
            this.of = of;
            this.idEvent = idEvent;
            this.name = name;
        }
    }
}
