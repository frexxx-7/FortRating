using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortRating.Classes.Events
{
    internal class EventsBLL
    {
        public bool SaveItemEvent(string name, string description, string dateEvent, int points)
        {
            try
            {
                EventsFunc objdal = new EventsFunc();
                return objdal.AddItemsToTableEvents(name, description, dateEvent, points);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public DataTable GetItemsEvents(string idEvent, double startRows, double numberRows, string searchText)
        {
            try
            {
                EventsFunc objdal = new EventsFunc();
                return objdal.ReadItemsEvents(idEvent, startRows, numberRows, searchText);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
    }
}
