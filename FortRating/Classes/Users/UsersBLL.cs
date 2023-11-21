using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortRating.Classes.Users
{
    internal class UsersBLL
    {
        public DataTable GetItemsEvents(string idUser, double startRows, double numberRows, string searchText)
        {
            try
            {
                UsersFunc objdal = new UsersFunc();
                return objdal.ReadItemsEvents(idUser, startRows, numberRows, searchText);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
    }
}
