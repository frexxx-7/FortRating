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

namespace FortRating.Forms.ReferencesFolder
{
    public partial class Discipline : Form
    {
        private AppPage.OpenForm of;
        public Discipline(AppPage.OpenForm of)
        {
            InitializeComponent();
            this.of = of;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            of(new ReferencesForm(of));
        }

        private void loadInfoDisciplines()
        {
            DB db = new DB();

            DisciplinesDataGrid.Rows.Clear();

            string query = $"select disciplines.id, disciplines.name ,concat(groups.name,' ', groups.academicYear) from disciplines " +
                $"inner join groups on groups.id = disciplines.idGroup";

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
                    DisciplinesDataGrid.Rows.Add(s);
            }
            db.closeConnection();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var form = new AddDisciplines(null, null);
            form.FormClosed += form_FormClosed;
            form.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var form = new AddDisciplines(null, DisciplinesDataGrid[0, DisciplinesDataGrid.SelectedCells[0].RowIndex].Value.ToString());
            form.FormClosed += form_FormClosed;
            form.ShowDialog();
        }
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadInfoDisciplines();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"delete from disciplines where id = {DisciplinesDataGrid[0, DisciplinesDataGrid.SelectedCells[0].RowIndex].Value}", db.getConnection());
            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Дисциплина удалена");

            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
            loadInfoDisciplines();
        }

        private void Discipline_Load(object sender, EventArgs e)
        {
            loadInfoDisciplines();
        }

        private void SeacrhButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DisciplinesDataGrid.Rows.Clear();

            string searchString = $"select disciplines.id, disciplines.name, concat(groups.name,' ', groups.academicYear) from disciplines " +
                $"inner join groups on groups.id = disciplines.idGroup " +
                $"where concat(disciplines.id, concat(groups.name,' ', groups.academicYear), groups.name) " +
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
                    DisciplinesDataGrid.Rows.Add(s);
            }
            db.closeConnection();
        }
    }
}
