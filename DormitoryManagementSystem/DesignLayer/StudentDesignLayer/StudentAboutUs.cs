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
    public partial class StudentAboutUs : Form
    {
        public StudentAboutUs()
        {
            InitializeComponent();
        }

        private void EmojiBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks For Using Our System");
        }

        private void LogOutBox_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            StudentDashboard student = new StudentDashboard();
            student.Show();
            this.Hide();
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            StudentRoom studentRoom = new StudentRoom();
            studentRoom.Show();
            this.Hide();
        }

        private void ExpenseButton_Click(object sender, EventArgs e)
        {
            Student_Expense student = new Student_Expense();
            student.Show();
            this.Hide();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Student_Setting student = new Student_Setting();
            student.Show();
            this.Hide();
        }
    }
}
