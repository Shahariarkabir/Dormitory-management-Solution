using Student_Log_In.DataAccessLayer;
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

namespace Student_Log_In.DesignLayer
{
    public partial class Setting : Form
    {
        Function fn = new Function();
        String query;
        public Setting()
        {
            InitializeComponent();
        }

        private void EmojiPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for Using Our System");
        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Show();
            this.Hide();
        }

        private void BedButton_Click(object sender, EventArgs e)
        {
            Bed bed = new Bed();
            bed.Show();
            this.Hide();
        }

        private void TenantsButton_Click(object sender, EventArgs e)
        {
            Tenants tenants = new Tenants();
            tenants.Show();
            this.Hide();
        }

        private void ExpenseButton_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            expense.Show();
            this.Hide();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
            this.Hide();
        }

        private void AboutUsButton_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
            this.Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateProfileButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text != "" && EmailTextBox.Text != " " && PasswordTextBox.Text != "" && BloodGroupComboBox.Text != "" && DateTimePicker.Text != "" && GenderComboBox.Text != "" && AddressTextBox.Text != "")

            {
                query = "INSERT INTO student_user_create(UserName,FullName,Password,BloodGroup,DateOfBirth,PhoneNumber,Email,Gender,Address,EmergencyContactName,EmergencyPhoneNumber,EmergencyRelationship,VerficationId) VALUES('" + userNameTextBox.Text + "','" + TextBoxFullName.Text + "','" + PasswordTextBox.Text + "','" + BloodGroupComboBox.Text + "','" + DateTimePicker.Text + "'," + PhoneNumberTextBox.Text + ",'" + EmailTextBox.Text + "','" + GenderComboBox.Text + "','" + AddressTextBox.Text + "','" + EmergencyFullNameTextBox.Text + "'," + EmergencyPhoneNumberTextBox.Text + ",'" + emergencyRelationTextBox.Text + "','" + IdNumberTextBox.Text + "') ";
                fn.setData(query, "Admin Added Successfully!!!");
                userNameTextBox.Text = TextBoxFullName.Text = PasswordTextBox.Text = BloodGroupComboBox.Text = DateTimePicker.Text = PhoneNumberTextBox.Text = EmailTextBox.Text = GenderComboBox.Text = AddressTextBox.Text = EmergencyContactTextBox.Text = EmergencyPhoneNumberTextBox.Text = emergencyRelationTextBox.Text = IdNumberTextBox.Text = string.Empty;
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Fill Empty Space", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            CreateStudentProfile studentProfile = new CreateStudentProfile();
            studentProfile.Show();
            this.Hide();
        }
    }
}
