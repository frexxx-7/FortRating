﻿using FortRating.Classes;
using FortRating.Forms;
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

namespace FortRating
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @uL AND password = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginTextBox.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PasswordTextBox.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                string queryAccount = $"SELECT id, login FROM users WHERE login = '{LoginTextBox.Text}'";
                MySqlCommand mySqlCommand = new MySqlCommand(queryAccount, db.getConnection());

                db.openConnection();

                using (MySqlCommand mySqlCommand2 = new MySqlCommand(queryAccount, db.getConnection()))
                {
                    MySqlDataReader reader = mySqlCommand2.ExecuteReader();

                    while (reader.Read())
                    {
                        AppPage main = new AppPage();
                        AppPage.idUser = reader[0].ToString();
                        AppPage.login = reader[1].ToString();
                        this.Hide();
                        main.Show();
                        MessageBox.Show("Добро пожаловать");
                    }
                    reader.Close();
                }

                db.closeConnection();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
