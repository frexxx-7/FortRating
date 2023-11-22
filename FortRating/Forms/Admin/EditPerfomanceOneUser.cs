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

namespace FortRating.Forms.Admin
{
    public partial class EditPerfomanceOneUser : Form
    {
        private AppPage.OpenForm of;
        private string idStudent, FIO, group, idGroup;
        public delegate void LoadInfoPerfomanceDelegate();

        private void AddDisciplines_Click(object sender, EventArgs e)
        {
            LoadInfoPerfomanceDelegate lipd = new LoadInfoPerfomanceDelegate(loadInfoDisciplines);
            new AddDisciplines(lipd).Show();
        }

        private void EditPerfomanceOneUser_Load(object sender, EventArgs e)
        {
            loadInfoDisciplines();
        }

        private void EditMark_Click(object sender, EventArgs e)
        {
            LoadInfoPerfomanceDelegate lipd = new LoadInfoPerfomanceDelegate(loadInfoDisciplines);
            new EditMark(PerfomanceDataGrid[0, PerfomanceDataGrid.SelectedCells[0].RowIndex].Value.ToString(), idStudent, PerfomanceDataGrid[2, PerfomanceDataGrid.SelectedCells[0].RowIndex].Value.ToString(), PerfomanceDataGrid[1, PerfomanceDataGrid.SelectedCells[0].RowIndex].Value.ToString(), lipd).Show();
        }

        private void loadInfoDisciplines()
        {
            PerfomanceDataGrid.Rows.Clear();
            DB db = new DB();
            string queryInfo = $"select disciplines.id, disciplines.name, academicpeerfomance.mark from disciplines " +
                $"left join academicpeerfomance on academicpeerfomance.idDescipline = disciplines.id and academicpeerfomance.idStudent = {idStudent} " +
                $"where disciplines.idGroup = {idGroup}";

            db.openConnection();

            using (MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection()))
            {
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                List<string[]> dataDB = new List<string[]>();
                while (reader.Read())
                {
                    dataDB.Add(new string[reader.FieldCount]);

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataDB[dataDB.Count - 1][i] = reader[i].ToString();
                    }
                }
                reader.Close();
                foreach (string[] s in dataDB)
                    PerfomanceDataGrid.Rows.Add(s);
            }

            db.closeConnection();
        }
        public EditPerfomanceOneUser(AppPage.OpenForm of,string idStudent, string FIO, string group, string idGroup)
        {
            InitializeComponent();
            this.idStudent = idStudent;
            this.FIO = FIO;
            this.group = group;
            this.of = of;
            this.idGroup= idGroup;

            FIOLabel.Text = FIO;
            GroupLabel.Text = group;
        }
    }
}
