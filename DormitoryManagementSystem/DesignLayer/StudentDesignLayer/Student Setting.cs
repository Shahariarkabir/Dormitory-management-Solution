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

namespace Student_Log_In.DesignLayer.StudentDesignLayer
{
    public partial class Student_Setting : Form

    {
        Function fn = new Function();
        String query;

        public Student_Setting()
        {
            InitializeComponent();
        }

        private void StudentDashBoardButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void StudentRoomButton_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Show();
            this.Hide();
        }

        private void StudentExpenseButton_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            expense.Show();
            this.Hide();
        }

        private void StudentSettingsButton_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
            this.Hide();
        }

        private void StudentAboutUsButton_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM New_student WHERE UserName='" + userNameTextBox.Text + "'";

            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                FullTextBox.Text = ds.Tables[0].Rows[0][2].ToString();
                TextBoxEmail.Text = ds.Tables[0].Rows[0][3].ToString();
                PassTextBox.Text = ds.Tables[0].Rows[0][4].ToString();
                DateTimePicker.Text = ds.Tables[0].Rows[0][5].ToString();
                GenderComboBox.Text = ds.Tables[0].Rows[0][6].ToString();
                BloodGroupComboBox.Text = ds.Tables[0].Rows[0][7].ToString();
                AddressTextBox.Text = ds.Tables[0].Rows[0][8].ToString();

                PhoneNumberTextBox.Text = ds.Tables[0].Rows[0][12].ToString();
                IdNumberTextBox.Text = ds.Tables[0].Rows[0][13].ToString();
                RoomNoText.Text = ds.Tables[0].Rows[0][14].ToString();

            }
            else
            {
                userNameTextBox.Text = FullTextBox.Text = PassTextBox.Text = BloodGroupComboBox.Text = DateTimePicker.Text = PhoneNumberTextBox.Text = TextBoxEmail.Text = GenderComboBox.Text = AddressTextBox.Text = IdNumberTextBox.Text = RoomNoText.Text = string.Empty;
                MessageBox.Show("No Record Found By the Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StudentUpdateProfileButton_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(PhoneNumberTextBox.Text);


            query = " UPDATE New_student SET UserName ='" + userNameTextBox.Text + "',FullName='" + FullTextBox.Text + "',Password='" + PassTextBox.Text + "',BloodGroup='" + BloodGroupComboBox.Text + "',DateOfBirth='" + DateTimePicker.Text + "',PhoneNumber=" + mobile + ",Email='" + TextBoxEmail.Text + "',Gender='" + GenderComboBox.Text + "',Address='" + AddressTextBox.Text + "',VerficationId='" + IdNumberTextBox.Text + "',RoomNumber=" + RoomNoText.Text + " WHERE UserName='" + userNameTextBox.Text + "' ";
            fn.setData(query, "Updated Successfully......");
            userNameTextBox.Text = FullTextBox.Text = PassTextBox.Text = BloodGroupComboBox.Text = DateTimePicker.Text = PhoneNumberTextBox.Text = TextBoxEmail.Text = GenderComboBox.Text = AddressTextBox.Text = IdNumberTextBox.Text = RoomNoText.Text = string.Empty;
            StudentDashboard student = new StudentDashboard();
            student.Show();
            this.Hide();
        }

        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPasswordTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (this.ConfirmPasswordTextBox.Text != this.PassTextBox.Text)
            {
                this.errorProvider1.SetError(this.ConfirmPasswordTextBox, "Password and Confirm must be the same");
                e.Cancel = true;
                PassTextBox.Clear();

                ConfirmPasswordTextBox.Clear();
            }
            else
            {
                this.errorProvider1.SetError(this.ConfirmPasswordTextBox, "");
            }

        }
    }
}
