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
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void EmojiBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks For Using Our System");
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            StudentRoom student = new StudentRoom();
            student.Show();
            this.Hide();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Student_Setting student = new Student_Setting();
            student.Show();
            this.Hide();
        }

        private void AboutUsButton_Click(object sender, EventArgs e)
        {


            StudentAboutUs studentAbout = new StudentAboutUs();
            studentAbout.Show();
            this.Hide();
        }

        private void ExpenseButton_Click(object sender, EventArgs e)
        {
            Student_Expense student = new Student_Expense();
            student.Show();
            this.Hide();
        }

        private void LogOutBox_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("hh:MM:ss tt");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }
    }
}
