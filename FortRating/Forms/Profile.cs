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
        private void loadInfoUser()
        {
            /*DB db = new DB();
            string queryInfo = $"SELECT users.*, userInfo.*, concat(address.house, address.street, address.city, address.country) as addressInfo FROM users " +
                $"left join userInfo on users.idUserInfo = userInfo.id " +
                $"left join address on userInfo.idAddress = address.id " +
                $"WHERE users.id = '{AppPage.idUser}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                LoginLabel.Text = reader["login"].ToString();

            }
            reader.Close();

            db.closeConnection();*/
        }

        private void EditProfieButton_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            of(ep);
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            loadInfoUser();
        }
    }
}
