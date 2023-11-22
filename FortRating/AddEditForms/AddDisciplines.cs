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
using System.Windows.Forms;

namespace FortRating.AddEditForms
{
    public partial class AddDisciplines : Form
    {
        private EditPerfomanceOneUser.LoadInfoPerfomanceDelegate lipd;
        public AddDisciplines(EditPerfomanceOneUser.LoadInfoPerfomanceDelegate lipd)
        {
            InitializeComponent();
            this.lipd = lipd;
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

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"INSERT into disciplines (name, idGroup) values(@name, @idGroup)", db.getConnection());
            command.Parameters.AddWithValue("@name", NameTextBox.Text);
            command.Parameters.AddWithValue("@idGroup", (GroupComboBox.SelectedItem as FortRating.Classes.ComboBoxItem).Value);
            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Дисциплина добавлена");
                db.closeConnection();
            }
            catch(Exception exp)
            {
                MessageBox.Show($"Ошибка {exp}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lipd();
                this.Close();
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
        }
    }
}
