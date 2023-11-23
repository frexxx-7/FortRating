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
    public partial class InfoRating : Form
    {
        private int eventPoint, perfomanceEvg;
        private string idGroup;
        public InfoRating()
        {
            InitializeComponent();
            loadInfoEventPoints();
            loadInfoGroup();
            loadInfoPerfomancePoints();
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
                perfomanceEvg = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            db.closeConnection();
        }
    }
}
