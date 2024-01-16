using FortRating.Classes;
using FortRating.Forms.Admin;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace FortRating.AddEditForms
{
    public partial class AddDisciplines : Form
    {
        private EditPerfomanceOneUser.LoadInfoPerfomanceDelegate lipd;
        private string idDiscipline;
        public AddDisciplines(EditPerfomanceOneUser.LoadInfoPerfomanceDelegate lipd, string idDiscipline)
        {
            InitializeComponent();
            this.lipd = lipd;
            this.idDiscipline = idDiscipline;
        }
        private void loadInfoDiscipline()
        {
            DB db = new DB();
            string queryInfo = $"SELECT * FROM disciplines WHERE id = '{idDiscipline}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                NameTextBox.Text = reader[1].ToString();
                for (int i = 0; i < GroupComboBox.Items.Count; i++)
                {
                    if (reader["idGroup"].ToString() != "")
                    {
                        if (Convert.ToInt32((GroupComboBox.Items[i] as ComboboxItem).Value) == Convert.ToInt32(reader["idGroup"]))
                        {
                            GroupComboBox.SelectedIndex = i;
                        }
                    }
                }
            }
            reader.Close();

            db.closeConnection();
        }
        private void loadInfoGroups()
        {
            GroupComboBox.Items.Clear();
            DB db = new DB();
            string queryInfo = $"SELECT id, name, academicYear FROM groups";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                FortRating.Classes.ComboboxItem item = new FortRating.Classes.ComboboxItem();
                item.Text = $" {reader[1]} {reader[2]}";
                item.Value = reader[0];
                GroupComboBox.Items.Add(item);
            }
            reader.Close();

            db.closeConnection();
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (idDiscipline == null)
            {
                MySqlCommand command = new MySqlCommand($"INSERT into disciplines (name, idGroup) values(@name, @idGroup)", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@idGroup", (GroupComboBox.SelectedItem as FortRating.Classes.ComboboxItem).Value);
                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Дисциплина добавлена");
                    db.closeConnection();
                }
                catch (Exception exp)
                {
                    MessageBox.Show($"Ошибка {exp}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (lipd != null)
                        lipd();
                    this.Close();
                }
            }
            else
            {
                MySqlCommand command = new MySqlCommand($"update disciplines set name = @name, idGroup = @idGroup where id = {idDiscipline}", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@idGroup", (GroupComboBox.SelectedItem as FortRating.Classes.ComboboxItem).Value);

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

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CanceledButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDisciplines_Load(object sender, EventArgs e)
        {
            loadInfoGroups();

            if (idDiscipline != null)
            {
                label1.Text = "Изменить дисциплину";
                AddGroupButton.Text = "Изменить";
                loadInfoDiscipline();
            }
        }
    }
}
