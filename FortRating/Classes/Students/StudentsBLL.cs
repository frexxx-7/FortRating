using FortRating.Classes.Events;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortRating.Classes.Students
{
    internal class StudentsBLL
    {
        public DataTable GetItemsEvents(string idStudent, double startRows, double numberRows, string searchText)
        {
            try
            {
                StudentsFunc objdal = new StudentsFunc();
                return objdal.ReadItemsEvents(idStudent, startRows, numberRows, searchText);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
    }
}
