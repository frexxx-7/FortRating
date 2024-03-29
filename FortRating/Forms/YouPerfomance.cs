﻿using FortRating.Classes;
using Guna.UI2.WinForms;
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

namespace FortRating.Forms
{
    public partial class YouPerfomance : Form
    {
        private string idGroup;
        private int selectSemester;
        public YouPerfomance()
        {
            InitializeComponent();

            loadInfoGroup();
            loadInfoDisciplines();
        }
        private void loadInfoGroup()
        {
            DB db = new DB();
            string queryInfo = $"select students.idGroup from students " +
                $"where id = {AppPage.idStudent} ";
            
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
        private void loadInfoDisciplines()
        {
            PerfomanceDataGrid.Rows.Clear();
            DB db = new DB();
            string queryInfo = selectSemester==0 ? $"select disciplines.id, disciplines.name, academicpeerfomance.mark from disciplines " +
                $"left join academicpeerfomance on academicpeerfomance.idDescipline = disciplines.id and academicpeerfomance.idStudent = {AppPage.idStudent} " +
                $"where disciplines.idGroup = {idGroup}"
                :
                $"select disciplines.id, disciplines.name, academicpeerfomance.mark from disciplines " +
                $"left join academicpeerfomance on academicpeerfomance.idDescipline = disciplines.id and academicpeerfomance.idStudent = {AppPage.idStudent} " +
                $"where disciplines.idGroup = {idGroup} and academicpeerfomance.semester = {selectSemester}"
                ;

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

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectSemester = Convert.ToInt32(guna2ComboBox1.SelectedItem);
            loadInfoDisciplines();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            guna2ComboBox1.Enabled = !guna2ComboBox1.Enabled;
            if (guna2CheckBox1.Checked)
                selectSemester = 0;
            else
                selectSemester = Convert.ToInt32(guna2ComboBox1.SelectedItem);
            loadInfoDisciplines();
        }

        private void YouPerfomance_Load(object sender, EventArgs e)
        {
            guna2CheckBox1.Checked = true;
        }
    }
}
