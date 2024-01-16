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
    public partial class PerfomanceOneStudent : Form
    {
        private string idStudent, FIO, group, idGroup;
        private AppPage.OpenForm of;
        private void AdditionalButton_Click(object sender, EventArgs e)
        {
            AdditionalPoints aap = new AdditionalPoints(idStudent);
            of(aap);
        }

        private void PerfomanceOneStudent_Load(object sender, EventArgs e)
        {
            loadInfoDisciplines();
        }

        public PerfomanceOneStudent(string idStudent, string FIO, string group, string idGroup, AppPage.OpenForm of)
        {
            InitializeComponent();
            this.idStudent = idStudent;
            this.FIO = FIO;
            this.group = group;
            this.idGroup = idGroup;
            this.of = of;

            FIOLabel.Text = FIO;
            GroupLabel.Text = group;
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
    }
}
