using FortRating.Classes;
using FortRating.Forms;
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
    public partial class AddAdditionalPoints : Form
    {
        private AdditionalPoints.LoadInfoAdditionalPoints liap;
        public AddAdditionalPoints(AdditionalPoints.LoadInfoAdditionalPoints liap)
        {
            InitializeComponent();
            this.liap= liap;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"INSERT into additionalpoints (idStudent, points) values (@idStudent, @points)", db.getConnection());
            command.Parameters.AddWithValue("@idStudent", AppPage.idStudent);
            command.Parameters.AddWithValue("@points", PointsTextBox.Text);
            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Доп баллы добавлены");
                db.closeConnection();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Ошибка {exp}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                liap();
                this.Close();
            }
        }

        private void PointsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number !=45) 
            {
                e.Handled = true;
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
