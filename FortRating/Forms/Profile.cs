using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
