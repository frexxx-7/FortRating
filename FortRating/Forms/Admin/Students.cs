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
    public partial class Students : Form
    {
        private AppPage.OpenForm of;
        public Students(AppPage.OpenForm of)
        {
            InitializeComponent();
            this.of= of;
        }
        private void loadInfoStudents()
        {
            DB db = new DB();

            StudentsDataGrid.Rows.Clear();

            string query = $"select students.id, students.surname, students.name, students.patronymic, groups.name from students " +
                $"left join groups on groups.id = students.idGroup";

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

        private void Students_Load(object sender, EventArgs e)
        {
            loadInfoStudents();
        }
    }
}
