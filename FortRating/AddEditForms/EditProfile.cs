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
        public EditProfile()
        {
            InitializeComponent();
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            LoadInfoGroups lig = new LoadInfoGroups(loadInfoGroups);
            new AddGroup(lig).Show();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            if(AppPage.login == "admin" || AppPage.login == "Admin")
            {
                AddGroupButton.Visible = true;
            }
            else
            {
                AddGroupButton.Visible = false;
            }
            loadInfoGroups();
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
                FortRating.Classes.ComboBoxItem item = new FortRating.Classes.ComboBoxItem();
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
                MySqlCommand command = new MySqlCommand($"INSERT into students (name, surname, patronymic, idGroup) values(@name, @surname, @patronymic, @idGroup);" +
                $"where idUser= {AppPage.idUser} ", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@surname", SurnameTextBox.Text);
                command.Parameters.AddWithValue("@patronymic", PatronymicTextBox.Text);
                command.Parameters.AddWithValue("@idGroup", PatronymicTextBox.Text);

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
                MySqlCommand command = new MySqlCommand($"update userInfo set name = @name, surname = @surname, patronymic = @patronymic, numberPhone = @numberPhone, numberPassport = @numberPassport, idAddress = @idAddress " +
                $"where userInfo.id = {2} ", db.getConnection());
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@surname", SurnameTextBox.Text);
                command.Parameters.AddWithValue("@patronymic", PatronymicTextBox.Text);
                command.Parameters.AddWithValue("@idAddress", (GroupComboBox.SelectedItem as FortRating.Classes.ComboBoxItem).Value);

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

            MySqlCommand commandUser = new MySqlCommand($"update users set login = @login, password = @password where id = {AppPage.idUser}", db.getConnection());
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
