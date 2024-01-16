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

namespace FortRating.AddEditForms
{
    public partial class AddGroup : Form
    {
        private EditProfile.LoadInfoGroups lig;
        private string idGroup;
        public AddGroup(EditProfile.LoadInfoGroups lig, string idGroup)
        {
            InitializeComponent();
            this.lig = lig;
            this.idGroup= idGroup;
        }
        private void loadInfoForGroup()
        {
            DB db = new DB();
            string queryInfo = $"SELECT * FROM groups WHERE id = '{idGroup}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                NameTextBox.Text = reader[1].ToString();
                SpecialityTextBox.Text = reader["speciality"].ToString();
                for (int i = 0; i < YearComboBox.Items.Count; i++)
                {
                    if (reader["academicYear"].ToString() != "")
                    {
                        if (YearComboBox.Items[i].ToString() == reader["academicYear"].ToString())
                        {
                            YearComboBox.SelectedIndex = i;
                        }
                    }
                }
            }
            reader.Close();

            db.closeConnection();
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (idGroup == null)
            {
                MySqlCommand command = new MySqlCommand($"INSERT into groups (name, academicYear, speciality) values(@name, @academicYear, @speciality)", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@academicYear", YearComboBox.SelectedItem);
                command.Parameters.AddWithValue("@speciality", SpecialityTextBox.Text);
                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Группа добавлена");
                    db.closeConnection();
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (lig != null)
                        lig();
                    this.Close();
                }
            }
            else
            {
                MySqlCommand command = new MySqlCommand($"update groups set name = @name, academicYear = @academicYear, speciality = @speciality where id = {idGroup}", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@academicYear", YearComboBox.SelectedItem);
                command.Parameters.AddWithValue("@speciality", SpecialityTextBox.Text);

                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Группа изменена");
                    this.Close();

                }
                catch
                {
                    MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.closeConnection();
            }

        }

        private void CanceledButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {
            if (idGroup != null)
            {
                label1.Text = "Изменить предмет";
                AddGroupButton.Text = "Изменить";
                loadInfoForGroup();
            }
        }
    }
}
