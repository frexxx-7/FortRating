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
    public partial class AdditionalPoints : Form
    {
        private int sumPoints;
        public delegate void LoadInfoAdditionalPoints();
        private string idStudent;
        public AdditionalPoints(string idStudent)
        {
            InitializeComponent();
            this.idStudent = idStudent;
            loadInfoAdditionalPointsUser();
        }
        private void loadInfoAdditionalPointsUser()
        {
            AdditionalPointsDataGrid.Rows.Clear();
            DB db = new DB();
            string queryInfo = $"select * from additionalpoints where idStudent = {idStudent}";

            db.openConnection();

            using (MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection()))
            {
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                List<string[]> dataDB = new List<string[]>();
                while (reader.Read())
                {
                    dataDB.Add(new string[reader.FieldCount]);
                    sumPoints += Convert.ToInt32(reader["points"]);

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataDB[dataDB.Count - 1][i] = reader[i].ToString();
                    }
                }
                reader.Close();
                foreach (string[] s in dataDB)
                    AdditionalPointsDataGrid.Rows.Add(s);
            }

            db.closeConnection();

            SumPointsLabel.Text = sumPoints.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            LoadInfoAdditionalPoints liap = new LoadInfoAdditionalPoints(loadInfoAdditionalPointsUser);
            new AddAdditionalPoints(liap).Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"delete from additionalpoints where id = {AdditionalPointsDataGrid[0, AdditionalPointsDataGrid.SelectedCells[0].RowIndex].Value}", db.getConnection());
            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Доп баллы удалены");

            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
            loadInfoAdditionalPointsUser();
        }
    }
}
