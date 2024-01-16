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
    public partial class EditMark : Form
    {
        private string idDiscipline, idStudent, mark, nameDiscipline;
        private string idAcademicpeerfomance;
        private EditPerfomanceOneUser.LoadInfoPerfomanceDelegate lipd;

        private void loadInfoAcademicpeerfomance()
        {
            DB db = new DB();
            string queryInfo = $"SELECT * FROM academicpeerfomance " +
                $"where idStudent = {idStudent} and idDescipline = {idDiscipline}";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                idAcademicpeerfomance = reader[0].ToString();
            }

            reader.Close();

            db.closeConnection();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (mark== "")
            {
                MySqlCommand command = new MySqlCommand($"INSERT into academicpeerfomance (idDescipline, mark, idStudent) values(@idDescipline, @mark, @idStudent)", db.getConnection());
                command.Parameters.AddWithValue("@idDescipline", idDiscipline);
                command.Parameters.AddWithValue("@mark", MarkTextBox.Text);
                command.Parameters.AddWithValue("@idStudent", idStudent);
                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Отметка добавлена");
                    this.Close();
                    db.closeConnection();
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    lipd();
                }

            }
            else
            {
                MySqlCommand command = new MySqlCommand($"update academicpeerfomance set idDescipline=@idDescipline, mark=@mark, idStudent=@idStudent where id = {idAcademicpeerfomance}", db.getConnection());
                command.Parameters.AddWithValue("@idDescipline", idDiscipline);
                command.Parameters.AddWithValue("@mark", MarkTextBox.Text);
                command.Parameters.AddWithValue("@idStudent", AppPage.idStudent);

                db.openConnection();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Отметка изменена");
                    this.Close();
                    db.closeConnection();
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                { 
                    lipd(); 
                }
            }
        }

        public EditMark(string idDiscipline, string idStudent, string mark, string nameDiscipline, EditPerfomanceOneUser.LoadInfoPerfomanceDelegate lipd)
        {
            InitializeComponent();
            this.idStudent= idStudent;
            this.mark= mark;
            this.idStudent= idStudent;
            this.idDiscipline = idDiscipline;
            this.nameDiscipline= nameDiscipline;
            this.lipd=lipd;

            NameDisciplineLabel.Text = nameDiscipline;

            if (mark != "")
            {
                MarkTextBox.Text = mark;
                loadInfoAcademicpeerfomance();
            }
        }
    }
}
