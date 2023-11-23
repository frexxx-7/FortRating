using FortRating.Forms;
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

namespace FortRating.UserControls
{
    public partial class UsersControl1 : UserControl
    {
        private AppPage.OpenForm of;
        private string idUser, login;
        public Image image;
        public UsersControl1(AppPage.OpenForm of, string idUser, string login)
        {
            InitializeComponent();
            this.of = of;
            this.idUser = idUser;
            this.login = login;

            LoginLabel.Text = login;
            
        }

        private void LoginLabel_MouseMove(object sender, MouseEventArgs e)
        {
            LoginLabel.ForeColor = Color.FromArgb(94, 148, 255);
        }

        private void LoginLabel_MouseLeave(object sender, EventArgs e)
        {
            LoginLabel.ForeColor = Color.Black;
        }

        private void UsersControl1_Load(object sender, EventArgs e)
        {
            if (image != null)
            {
                avatarPicture.Image = image;
                avatarPicture.Invalidate();
            }
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(of, idUser);
            of(profile);
        }
    }
}
