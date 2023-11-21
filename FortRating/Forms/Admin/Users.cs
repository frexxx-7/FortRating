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
    public partial class Users : Form
    {
        private AppPage.OpenForm of;
        public Users(AppPage.OpenForm of)
        {
            InitializeComponent();
            this.of = of;
        }
        private void loadInfoUsers()
        {
            DB db = new DB();

            UsersDataGrid.Rows.Clear();

            string query = $"select users.id, login, password from users ";

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
                    UsersDataGrid.Rows.Add(s);
            }
            db.closeConnection();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            loadInfoUsers();
        }
    }
}
