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
        public AddGroup(EditProfile.LoadInfoGroups lig)
        {
            InitializeComponent();
            this.lig = lig;
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"INSERT into groups (name) values(@name)", db.getConnection());
            command.Parameters.AddWithValue("@name", NameTextBox.Text);
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
                lig();
                this.Close();
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
    }
}
