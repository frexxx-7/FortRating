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

namespace FortRating.Forms
{
    public partial class Rating : Form
    {
        private AppPage.OpenForm of;
        private int eventPoint, perfomancePoint, additionalPoints;
        private string idGroup;
        private int sumPoints;
        private string idStudent, FIOStudent;
        private string selectedIdGroup;
        public Rating(AppPage.OpenForm of)
        {
            InitializeComponent();
            this.of = of;

            loadInfoGroups();
        }
        private void loadInfoGroups()
        {
            GroupComboBox.Items.Clear();
            DB db = new DB();
            string queryInfo = $"SELECT id, name FROM groups";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                FortRating.Classes.ComboBoxItem item = new FortRating.Classes.ComboBoxItem();
                item.Text = $" {reader[1]}";
                item.Value = reader[0];
                GroupComboBox.Items.Add(item);
            }
            reader.Close();

            db.closeConnection();
        }
        private void loadInfoAdditionalPoints()
        {
            DB db = new DB();
            string queryInfo = $"select sum(points) from additionalpoints " +
                $"where idStudent = {idStudent}";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                additionalPoints = !DBNull.Value.Equals(reader[0]) ?  Convert.ToInt32(reader[0]) : 0;
            }
            reader.Close();
            db.closeConnection();
        }
        private void loadInfoEventPoints()
        {
            DB db = new DB();
            string queryInfo = $"select sum(events.points) from participantioninevents " +
                $"left join events on events.id = participantioninevents.idEvent " +
                $"where participantioninevents.idStudent = {idStudent}";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                eventPoint = !DBNull.Value.Equals(reader[0]) ? Convert.ToInt32(reader[0]) : 0;
            }
            reader.Close();
            db.closeConnection();
        }
        private void loadInfoRating()
        {
            RatingDataGrid.Rows.Clear();
            DB db = new DB();
            string queryInfo = selectedIdGroup == null ? $"select id, concat(students.surname, ' ', students.name, ' ', students.patronymic) from students"
                :
                $"select id, concat(students.surname, ' ', students.name, ' ', students.patronymic) from students where idGroup = {selectedIdGroup}"
                ;

            db.openConnection();

            using (MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection()))
            {
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                List<string[]> dataDB = new List<string[]>();
                int counter = 1;
                while (reader.Read())
                {
                    dataDB.Add(new string[3]);

                    idStudent = reader[0].ToString();
                    FIOStudent = reader[1].ToString();

                    loadInfoEventPoints();
                    loadInfoGroup();
                    loadInfoPerfomancePoints();
                    loadInfoAdditionalPoints();

                    sumPoints = eventPoint + perfomancePoint + additionalPoints;

                    dataDB[dataDB.Count - 1][0] = counter.ToString();
                    dataDB[dataDB.Count - 1][1] = FIOStudent.ToString();
                    dataDB[dataDB.Count - 1][2] = sumPoints.ToString();

                    if (idStudent == AppPage.idStudent)
                    {
                        PlaceInRatingLabel.Text = counter.ToString();
                    }
                    counter++;
                }
                reader.Close();
                foreach (string[] s in dataDB)
                    RatingDataGrid.Rows.Add(s);
            }

            db.closeConnection();
        }
        private void Rating_Load(object sender, EventArgs e)
        {
            loadInfoRating();
        }

        private void GroupComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedIdGroup  = (GroupComboBox.SelectedItem as FortRating.Classes.ComboBoxItem).Value.ToString();
            loadInfoRating();
        }

        private void loadInfoGroup()
        {
            DB db = new DB();
            string queryInfo = $"select students.idGroup from students " +
                $"where id = {idStudent} ";

            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                idGroup = reader["idGroup"].ToString();
            }
            reader.Close();

            db.closeConnection();
        }
        private void loadInfoPerfomancePoints()
        {
            DB db = new DB();
            string queryInfo = $"select avg(academicpeerfomance.mark) from disciplines " +
                $"left join academicpeerfomance on academicpeerfomance.idDescipline = disciplines.id and academicpeerfomance.idStudent = {idStudent} " +
                $"where disciplines.idGroup = {idGroup}";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                perfomancePoint = !DBNull.Value.Equals(reader[0]) ? Convert.ToInt32(reader[0]) * 10 : 0;
            }
            reader.Close();
            db.closeConnection();
        }
    }
}
