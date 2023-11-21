using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortRating.Forms.Admin
{
    public partial class Users : Form
    {
        private AppPage.OpenForm of;
        public Users(AppPage.OpenForm of)
        {
            InitializeComponent();
            this.of = of;
        }
    }
}
