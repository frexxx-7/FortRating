using FortRating.Classes;
using FortRating.Forms;
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
    public partial class EditProfile : Form
    {
        private string idStudent;
        public delegate void LoadInfoGroups();
        public EditProfile(string idStudent)
        {
            InitializeComponent();
            this.idStudent = idStudent;
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            LoadInfoGroups lig = new LoadInfoGroups(loadInfoGroups);
            new AddGroup(lig, null).Show();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            if(AppPage.login != "admin" && AppPage.login != "Admin")
            {
                AddGroupButton.Visible = false;
            }
            loadInfoGroups();
            loadAllInfoUser();
        }

        private void loadAllInfoUser()
        {
            DB db = new DB();
            string queryInfo = idStudent!=null ? $"select students.*, users.* from students " +
                $"left join users on users.id = students.idUser " +
                $"where students.idUser = {AppPage.idUser} " :
                $"select * from users " +
                $"where id = {AppPage.idUser}";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                LoginTextBox.Text = reader["login"].ToString();
                if (idStudent != null)
                {
                    NameTextBox.Text = reader["name"].ToString() != "" ? reader["name"].ToString() : "Не указано";
                    PatronymicTextBox.Text = reader["patronymic"].ToString() != "" ? reader["patronymic"].ToString() : "Не указано";
                    SurnameTextBox.Text = reader["surname"].ToString() != "" ? reader["surname"].ToString() : "Не указано";
                    for (int i = 0; i < GroupComboBox.Items.Count; i++)
                    {
                        if (reader["idGroup"].ToString() != "")
                        {
                            if (Convert.ToInt32((GroupComboBox.Items[i] as FortRating.Classes.ComboboxItem).Value) == Convert.ToInt32(reader["idGroup"]))
                            {
                                GroupComboBox.SelectedIndex = i;
                            }
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
            string queryInfo = $"SELECT id, name FROM groups";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                FortRating.Classes.ComboboxItem item = new FortRating.Classes.ComboboxItem();
                item.Text = $" {reader[1]}";
                item.Value = reader[0];
                GroupComboBox.Items.Add(item);
            }
            reader.Close();

            db.closeConnection();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (idStudent == null)
            {
                MySqlCommand command = new MySqlCommand($"INSERT into students (name, surname, patronymic, idGroup, idUser) values(@name, @surname, @patronymic, @idGroup, @idUser)", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@surname", SurnameTextBox.Text);
                command.Parameters.AddWithValue("@patronymic", PatronymicTextBox.Text);
                command.Parameters.AddWithValue("@idGroup", (GroupComboBox.SelectedItem as FortRating.Classes.ComboboxItem).Value);
                command.Parameters.AddWithValue("@idUser", AppPage.idUser);

                db.openConnection();

                try
                {
                    command.ExecuteScalar();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }

                db.closeConnection();
            }
            else
            {
                MySqlCommand command = new MySqlCommand($"update students set name = @name, surname = @surname, patronymic = @patronymic, idGroup = @idGroup " +
                $"where students.id = {idStudent} ", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@surname", SurnameTextBox.Text);
                command.Parameters.AddWithValue("@patronymic", PatronymicTextBox.Text);
                command.Parameters.AddWithValue("@idGroup", (GroupComboBox.SelectedItem as FortRating.Classes.ComboboxItem).Value);

                db.openConnection();

                try
                {
                    command.ExecuteScalar();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }

                db.closeConnection();
            }

            MySqlCommand commandUser = new MySqlCommand($"update users set login = @login where id = {AppPage.idUser}", db.getConnection());
            commandUser.Parameters.AddWithValue("@login", LoginTextBox.Text);

            db.openConnection();

            try
            {
                commandUser.ExecuteNonQuery();
                MessageBox.Show("Информация обновлена");
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }
    }
}
