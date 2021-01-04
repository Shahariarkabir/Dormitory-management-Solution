using Student_Profile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Log_In.DesignLayer.StudentDesignLayer
{
    public partial class StudentRoom : Form
    {
        public StudentRoom()
        {
            InitializeComponent();
        }


        private void StudentDashBoardButton_Click(object sender, EventArgs e)
        {
            StudentDashboard dashboard = new StudentDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void StudentRoomButton_Click(object sender, EventArgs e)
        {
            StudentRoom room = new StudentRoom();
            room.Show();
            this.Hide();
        }

        private void StudentExpenseButton_Click(object sender, EventArgs e)
        {
            Student_Expense expense = new Student_Expense();
            expense.Show();
            this.Hide();
        }

        private void StudentSettingsButton_Click(object sender, EventArgs e)
        {
            Student_Setting setting = new Student_Setting();
            setting.Show();
            this.Hide();
        }

        private void StudentAboutUsButton_Click(object sender, EventArgs e)
        {

            StudentAboutUs aboutUs = new StudentAboutUs();
            aboutUs.Show();
            this.Hide();
        }

        private void StudentEmojiBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks For Using Our System");
        }

        private void LogOutBox_Click(object sender, EventArgs e)
        {
            HomePage login = new HomePage();
            login.Show();
            this.Hide();
        }

        private void StudentRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dormitoryManagementDataSet12.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.dormitoryManagementDataSet12.rooms);

        }
    }
}
