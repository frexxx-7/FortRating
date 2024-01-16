using FortRating.AddEditForms;
using FortRating.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FortRating.Forms
{
    public partial class Profile : Form
    {
        private AppPage.OpenForm of;
        private string idStudent, idAnotherUser;
        public Profile(AppPage.OpenForm of, string idAnotherUser)
        {
            InitializeComponent();
            this.of = of;
            this.idAnotherUser= idAnotherUser;
        }
        private void loadInfoUser()
        {
            DB db = new DB();
            string queryInfo = idAnotherUser == null
            ?
                $"select users.* from users " +
                $"where id = {AppPage.idUser} "
            :
                $"select users.* from users " +
                $"where id = {idAnotherUser} ";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                LoginLabel.Text = reader["login"].ToString();

                string ifImage = "";
                if (ifImage != reader["image"].ToString())
                {
                    System.Drawing.Image avatar = (Bitmap)((new ImageConverter()).ConvertFrom(reader["image"]));
                    avatarPicture.Image = avatar;
                    avatarPicture.Invalidate();
                }
            }
            reader.Close();

            db.closeConnection();
        }
        private void loadInfoUserStudent()
        {
            DB db = new DB();
            string queryInfo = idAnotherUser == null
            ?
                $"select students.id, concat(students.surname,' ', students.name,' ', students.patronymic) as FIO, users.* from students " +
                $"left join users on users.id = students.idUser " +
                $"where students.idUser = {AppPage.idUser} "
            :
                $"select students.id, concat(students.surname,' ', students.name,' ', students.patronymic) as FIO, users.* from students " +
                $"left join users on users.id = students.idUser " +
                $"where students.idUser = {idAnotherUser} ";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                idStudent= reader["id"].ToString();
                FIOLabel.Text = reader["FIO"].ToString() != "" ? reader["FIO"].ToString() : "Не указано";
            }
            reader.Close();

            db.closeConnection();

        }

        private void EditProfieButton_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile(idStudent, idAnotherUser);
            of(ep);
        }

        private void avatarPicture_Click(object sender, EventArgs e)
        {
            if (idAnotherUser== null)
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand($"UPDATE users SET image = @image WHERE id = '{AppPage.idUser}'", db.getConnection());

                db.openConnection();

                OpenFileDialog open_dialog = new OpenFileDialog();
                open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                if (open_dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        command.Parameters.AddWithValue("@image", File.ReadAllBytes($"{open_dialog.FileName}"));
                        command.ExecuteNonQuery();

                        Bitmap image = new Bitmap(open_dialog.FileName);
                        avatarPicture.Image = image;
                        avatarPicture.Invalidate();
                    }
                    catch
                    {
                        MessageBox.Show("Выбранное вами изображение больше 16 МБ, выберите другое", "Ошибка изображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                db.closeConnection();
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            loadInfoUserStudent();
            loadInfoUser();

            if(AppPage.idStudent == null)
            {
                label1.Visible = false;
                FIOLabel.Visible = false;
            }
        }
    }
}
