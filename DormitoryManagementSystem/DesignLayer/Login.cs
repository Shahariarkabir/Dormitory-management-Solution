using Student_Log_In.BusinessLayer;
using Student_Log_In.DesignLayer;
using Student_Log_In.DesignLayer.StudentDesignLayer;
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

namespace Student_Log_In
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void studentlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" || userPasswordTextBox.Text == "")
            {
                MessageBox.Show("Username or password can not be empty");
            }
            else
            {
                UserService userService = new UserService();
                StudentService studentService = new StudentService();
                bool userResult = userService.LoginValidation(userNameTextBox.Text, userPasswordTextBox.Text);
                bool studentResult = studentService.LoginValidation(userNameTextBox.Text, userPasswordTextBox.Text);
                if (userResult)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else if(studentResult)
                {
                    StudentDashboard student = new StudentDashboard();
                    student.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void signupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateStudentProfile profile = new CreateStudentProfile();
            profile.Show();
            this.Hide();
        }

        private void forgetPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please Contact Our Admins", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

