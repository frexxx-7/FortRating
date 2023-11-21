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

namespace FortRating.UserControls
{
    public partial class UsersControl1 : UserControl
    {
        private AppPage.OpenForm of;
        private string login;
        private Image image;
        public UsersControl1(AppPage.OpenForm of, string login, Image image)
        {
            InitializeComponent();
            this.of = of;
            this.login = login;
            this.image = image;
        }
    }
}
