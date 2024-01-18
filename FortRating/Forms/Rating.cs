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
using System.Windows.Documents;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FortRating.Forms
{
    public partial class Rating : Form
    {
        private AppPage.OpenForm of;
        private double eventPoint, additionalPoints;
        private double perfomancePoint;
        private string idGroup;
        private double sumPoints;
        private string idStudent, FIOStudent;
        private string selectedIdGroup;
        
        public Rating(AppPage.OpenForm of)
        {
            InitializeComponent();
            this.of = of;

            loadInfoGroups();
        }
        private void loadInfoGroups()
        {
            GroupComboBox.Items.Clear();
            DB db = new DB();
            string queryInfo = $"SELECT id, name, academicYear FROM groups";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                FortRating.Classes.ComboboxItem item = new FortRating.Classes.ComboboxItem();
                item.Text = $" {reader[1]} {reader[2]}";
                item.Value = reader[0];
                GroupComboBox.Items.Add(item);
            }
            reader.Close();

            db.closeConnection();
        }
        private void loadInfoAdditionalPoints()
        {
            DB db = new DB();
            string queryInfo = $"select sum(points) from additionalpoints " +
                $"where idStudent = {idStudent}";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                additionalPoints = !DBNull.Value.Equals(reader[0]) ?  Convert.ToDouble(reader[0]) : 0;
            }
            reader.Close();
            db.closeConnection();
        }
        private void loadInfoEventPoints()
        {
            DB db = new DB();
            string queryInfo = $"select sum(events.points) from participantioninevents " +
                $"left join events on events.id = participantioninevents.idEvent " +
                $"where participantioninevents.idStudent = {idStudent}";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                eventPoint = !DBNull.Value.Equals(reader[0]) ? Convert.ToDouble(reader[0]) : 0;
            }
            reader.Close();
            db.closeConnection();
        }
        private void loadInfoRating()
        {
            RatingDataGrid.Rows.Clear();
            DB db = new DB();
            string queryInfo = null;
            if (selectedIdGroup == null)
            {
                queryInfo = $"select id, concat(students.surname, ' ', students.name, ' ', students.patronymic) from students";
            }
            else
            {
                queryInfo = $"select id, concat(students.surname, ' ', students.name, ' ', students.patronymic) from students where idGroup = {selectedIdGroup}";
            }
            db.openConnection();

            using (MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection()))
            {
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                List<string[]> dataDB = new List<string[]>();
                int counter = 1;
                while (reader.Read())
                {
                    dataDB.Add(new string[3]);

                    idStudent = reader[0].ToString();
                    FIOStudent = reader[1].ToString();

                    loadInfoEventPoints();
                    loadInfoGroup();
                    loadInfoPerfomancePoints();
                    loadInfoAdditionalPoints();

                    sumPoints = eventPoint + perfomancePoint + additionalPoints;

                    
                    dataDB[dataDB.Count - 1][1] = FIOStudent.ToString();
                    dataDB[dataDB.Count - 1][2] = sumPoints.ToString();

                    if (idStudent == AppPage.idStudent)
                    {
                        PlaceInRatingLabel.Text = counter.ToString();
                    }
                    counter++;
                }
                reader.Close();
                dataDB.Sort((x, y) => Comparer<int>.Default.Compare(int.Parse(y[2]), int.Parse(x[2])));
                counter = 1;
                foreach (var data in dataDB)
                {
                    data[0] = counter.ToString();
                    counter++;
                }
                foreach (string[] s in dataDB)
                    RatingDataGrid.Rows.Add(s);
            }

            db.closeConnection();
        }
        private void Rating_Load(object sender, EventArgs e)
        {
            loadInfoRating();
            guna2CheckBox1.Checked = true;
        }

        private void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            GroupComboBox.Enabled = !GroupComboBox.Enabled;
            selectedIdGroup = null;
            loadInfoRating();
        }

        private void GroupComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedIdGroup  = (GroupComboBox.SelectedItem as FortRating.Classes.ComboboxItem).Value.ToString();
            loadInfoRating();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Cells[1, 1] = "Группа:";
            worksheet.Cells[1, 2] = !guna2CheckBox1.Checked ? GroupComboBox.SelectedItem.ToString() : "Все группы"; 
            for (int j = 0; j < RatingDataGrid.Columns.Count; j++)
            {
                if (RatingDataGrid.Columns[j].Visible)
                {
                    worksheet.Cells[2, j+1] = RatingDataGrid.Columns[j].HeaderText;
                }
            }
            for (int i = 0; i < RatingDataGrid.Rows.Count; i++)
            {
                for (int j = 0; j < RatingDataGrid.Columns.Count; j++)
                {
                    if (RatingDataGrid.Columns[j].Visible)
                    {
                        worksheet.Cells[i + 3, j+1] = RatingDataGrid.Rows[i].Cells[j].Value;
                    }
                }
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel File|*.xlsx";
            saveFileDialog1.Title = "Сохранить Excel файл";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                workbook.SaveAs(saveFileDialog1.FileName);
            }
            workbook.Close();
            excelApp.Quit();
        }

        private void loadInfoGroup()
        {
            DB db = new DB();
            string queryInfo = $"select students.idGroup from students " +
                $"where id = {idStudent} ";

            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                idGroup = reader["idGroup"].ToString();
            }
            reader.Close();

            db.closeConnection();
        }
        private void loadInfoPerfomancePoints()
        {
            DB db = new DB();
            string queryInfo = $"select avg(academicpeerfomance.mark) from disciplines " +
                $"left join academicpeerfomance on academicpeerfomance.idDescipline = disciplines.id and academicpeerfomance.idStudent = {idStudent} " +
                $"where disciplines.idGroup = {idGroup}";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                perfomancePoint = !DBNull.Value.Equals(reader[0]) ? Convert.ToDouble(reader[0]) * 10 : 0;
            }
            reader.Close();
            db.closeConnection();
        }
    }
}
