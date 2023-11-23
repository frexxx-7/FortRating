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
using static FortRating.Forms.Admin.AdditionalPoints;

namespace FortRating.Forms
{
    public partial class InfoPoints : Form
    {
        private int eventPoint, perfomancePoint, additionalPoints;
        private string idGroup;
        public InfoPoints()
        {
            InitializeComponent();
            loadInfoEventPoints();
            loadInfoGroup();
            loadInfoPerfomancePoints();
            loadInfoAdditionalPoints();

            SumPointsLabel.Text = (eventPoint + perfomancePoint + additionalPoints).ToString();
        }
        private void loadInfoAdditionalPoints()
        {
            DB db = new DB();
            string queryInfo = $"select sum(points) from additionalpoints " +
                $"where idStudent = {AppPage.idStudent}";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                additionalPoints = Convert.ToInt32(reader[0]);
                AdditionalPointsLabel.Text = additionalPoints.ToString();
            }
            reader.Close();
            db.closeConnection();
        }
        private void loadInfoEventPoints()
        {
            DB db = new DB();
            string queryInfo = $"select sum(events.points) from participantioninevents " +
                $"left join events on events.id = participantioninevents.idEvent " +
                $"where participantioninevents.idStudent = {AppPage.idStudent}";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                eventPoint = Convert.ToInt32(reader[0]);
                EventsPointsLabel.Text = eventPoint.ToString();
            }
            reader.Close();
            db.closeConnection();
        }
        private void loadInfoGroup()
        {
            DB db = new DB();
            string queryInfo = $"select students.idGroup from students " +
                $"where id = {AppPage.idStudent} ";

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
                $"left join academicpeerfomance on academicpeerfomance.idDescipline = disciplines.id and academicpeerfomance.idStudent = {AppPage.idStudent} " +
                $"where disciplines.idGroup = {idGroup}";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                perfomancePoint = Convert.ToInt32(reader[0]) * 10;
                PerfomancePointsLabel.Text = perfomancePoint.ToString();
            }
            reader.Close();
            db.closeConnection();
        }
    }
}
