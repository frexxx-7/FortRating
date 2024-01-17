using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortRating.Classes.Events
{
    internal class EventsFunc
    {
        public bool AddItemsToTableEvents(string name, string description, string dateEvent, int points)
        {
            DB db = new DB();

            string query = "insert into event (name, description, dateEvent, point) values (@name, @description, " +
                "@dateEvent, @point)";
            db.openConnection();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                {
                    if (name == null || description == null || dateEvent == null || points == 0)
                    {
                        MessageBox.Show("Вы не ввели данные", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@dateEvent", dateEvent);
                        cmd.Parameters.AddWithValue("@point", points);
                        cmd.ExecuteNonQuery();
                        db.closeConnection();
                    }
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        public DataTable ReadItemsEvents(string idEvent, double startRows, double numberRows, string searchText)
        {
            DB db = new DB();

            db.openConnection();
            /*string query = idEvent != null ? $"select * from events " +
                    $"WHERE (id_userComment = {idEvent}) " :
                    "select * from events";*/
            string query = null;
            if (idEvent != null)
            {
                query = searchText == null ?
                    $"SELECT * FROM events " +
                    $"WHERE id = {idEvent} " +
                    $"ORDER BY id DESC " +
                    $"LIMIT {startRows}, {numberRows};"
                    :
                    $"SELECT * FROM events " +
                    $"WHERE id = {idEvent} AND concat(name, description, indicatorName, points) LIKE '%{searchText}%' " +
                    $"ORDER BY id DESC " +
                    $"LIMIT {startRows}, {numberRows};"
                    ;
            }
            else
            {
                query = searchText == null ?
                    $"SELECT * FROM events " +
                    $"ORDER BY id DESC " +
                    $"LIMIT {startRows}, {numberRows};"
                    :
                    $"SELECT * FROM events " +
                    $"WHERE concat(name, description, indicatorName, points) LIKE '%{searchText}%' " +
                    $"ORDER BY id DESC " +
                    $"LIMIT {startRows}, {numberRows};"
                    ;
            }

            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
