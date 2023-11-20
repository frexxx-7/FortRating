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
using System.Xml;

namespace FortRating.Forms
{
    public partial class Profile : Form
    {
        private AppPage.OpenForm of;
        public Profile(AppPage.OpenForm of)
        {
            InitializeComponent();
            this.of = of;
        }
        private void loadAllInfoUser()
        {
            DB db = new DB();
            string queryInfo = $"select concat(students.surname,' ', students.name,' ', students.patronymic) as FIO, users.* from students " +
                $"left join users on users.id = students.idUser " +
                $"where students.idUser = {AppPage.idUser} ";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                LoginLabel.Text = reader["login"].ToString();
                FIOLabel.Text = reader["FIO"].ToString() != "" ? reader["FIO"].ToString() : "Не указано";
            }
            reader.Close();

            db.closeConnection();

        }

        private void EditProfieButton_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            of(ep);
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            loadAllInfoUser();
        }
    }
}
