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

namespace FortRating.Forms.References
{
    public partial class Groups : Form
    {
        private AppPage.OpenForm of;
        public Groups(AppPage.OpenForm of)
        {
            InitializeComponent();
            this.of = of;
        }
        private void loadInfoGroups()
        {
            DB db = new DB();

            GroupsDataGrid.Rows.Clear();

            string query = $"select * from groups";

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
                    GroupsDataGrid.Rows.Add(s);
            }
            db.closeConnection();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var form = new AddGroup(null, GroupsDataGrid[0, GroupsDataGrid.SelectedCells[0].RowIndex].Value.ToString());
            form.FormClosed += form_FormClosed;
            form.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var form = new AddGroup(null, null);
            form.FormClosed += form_FormClosed;
            form.ShowDialog();
        }
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadInfoGroups();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"delete from groups where id = {GroupsDataGrid[0, GroupsDataGrid.SelectedCells[0].RowIndex].Value}", db.getConnection());
            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Группа удалена");

            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
            loadInfoGroups();
        }

        private void SeacrhButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            GroupsDataGrid.Rows.Clear();

            string searchString = $"select * from groups " +
                $"where concat(name, speciality, academicYear) " +
                $"like '%" + SearchTextBox.Text + "%'";

            db.openConnection();
            using (MySqlCommand mySqlCommand = new MySqlCommand(searchString, db.getConnection()))
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
                    GroupsDataGrid.Rows.Add(s);
            }
            db.closeConnection();
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            loadInfoGroups();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            of(new ReferencesForm(of));
        }
    }
}
