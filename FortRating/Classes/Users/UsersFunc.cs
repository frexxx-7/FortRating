using FortRating.Classes.Events;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortRating.Classes.Users
{
    internal class UsersFunc
    {
        public DataTable ReadItemsEvents(string idUser, double startRows, double numberRows, string searchText)
        {
            DB db = new DB();

            db.openConnection();
            string query = null;
            if (idUser != null)
            {
                query = searchText == null ?
                    $"SELECT * FROM users " +
                    $"WHERE id = {idUser} " +
                    $"ORDER BY id DESC " +
                    $"LIMIT {startRows}, {numberRows};"
                    :
                    $"SELECT * FROM users " +
                    $"WHERE id = {idUser} AND concat(login) LIKE '%{searchText}%' " +
                    $"ORDER BY id DESC " +
                    $"LIMIT {startRows}, {numberRows};"
                    ;
            }
            else
            {
                query = searchText == null ?
                    $"SELECT * FROM users " +
                    $"ORDER BY id DESC " +
                    $"LIMIT {startRows}, {numberRows};"
                    :
                    $"SELECT * FROM users " +
                    $"WHERE concat(login) LIKE '%{searchText}%' " +
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
