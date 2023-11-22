using FontAwesome.Sharp;
using FortRating.Classes;
using FortRating.Forms.Admin;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FortRating.Forms
{
    public partial class AppPage : Form
    {
        public static string idUser, login;
        private Panel leftBorderBtn;
        private IconButton currentBtn;
        private Form currentChildForm;
        public delegate void OpenForm(Form childForm);
        public delegate void changeActiveButton(object senderBtn);
        public static changeActiveButton cab;
        public static string idStudent = null;
        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(233,233,233);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = Color.Black;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = Color.Black;
            }
        }
        private void loadInfoUserStudent()
        {
            DB db = new DB();
            string queryInfo = $"select students.id from students " +
                $"left join users on users.id = students.idUser " +
                $"where students.idUser = {AppPage.idUser} ";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                idStudent = reader["id"].ToString();
            }
            reader.Close();

            db.closeConnection();

        }
        private void AppPage_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            OpenForm of = new OpenForm(OpenChildForm);
            Profile profile = new Profile(of, null);
            OpenChildForm(profile);
            loadInfoUserStudent();
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(childForm);
            PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleChildForm.Text = currentBtn.Text;
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            OpenForm of = new OpenForm(OpenChildForm);
            Profile profile = new Profile(of, null);
            ActiveButton(sender);
            OpenChildForm(profile);

        }

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RatingButton_Click(object sender, EventArgs e)
        {
            OpenForm of = new OpenForm(OpenChildForm);
            Rating rating = new Rating(of);
            ActiveButton(sender); 
            OpenChildForm(rating);
        }

        private void EventsButton_Click(object sender, EventArgs e)
        {
            OpenForm of = new OpenForm(OpenChildForm);
            Events events = new Events(of);
            ActiveButton(sender);
            OpenChildForm(events);
        }

        private void InfoRatingButton_Click(object sender, EventArgs e)
        {
            OpenForm of = new OpenForm(OpenChildForm);
            InfoRating ir = new InfoRating();
            ActiveButton(sender);
            OpenChildForm(ir);
        }

        private void YouPerfomance_Click(object sender, EventArgs e)
        {
            OpenForm of = new OpenForm(OpenChildForm);
            YouPerfomance yp = new YouPerfomance();
            ActiveButton(sender);
            OpenChildForm(yp);
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            OpenForm of = new OpenForm(OpenChildForm);
            Users users = new Users(of);
            ActiveButton(sender);
            OpenChildForm(users);
        }

        private void StudentsButton_Click(object sender, EventArgs e)
        {
            OpenForm of = new OpenForm(OpenChildForm);
            Students students = new Students(of);
            ActiveButton(sender);
            OpenChildForm(students);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenForm of = new OpenForm(OpenChildForm);
            PerfomanceStudents ps = new PerfomanceStudents(of);
            ActiveButton(sender);
            OpenChildForm(ps);
        }

        public AppPage()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            panelMenu.Controls.Add(leftBorderBtn);
            this.ControlBox = false;
            this.DoubleBuffered= true;
            ActiveButton(ProfileButton);
            this.Size = new Size(1400, 800);
            cab = new changeActiveButton(ActiveButton);
        }
    }
}
