using Student_Log_In.DataAccessLayer;
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
    public partial class SelfCreateStudentProfile : Form
    {
        Function fn = new Function();
        String query;
        public SelfCreateStudentProfile()
        {
            InitializeComponent();
        }

       

        private void EmojiBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks For Using Our System");
        }

        private void CreateProfileButton_Click(object sender, EventArgs e)
        {

            if (userNameTextBox.Text != "" && EmailTextBox.Text != " " && PasswordTextBox.Text != "" && BloodGroupComboBox.Text != "" && DateTimePicker.Text != "" && GenderComboBox.Text != "" && AddressTextBox.Text != "")

            {
                query = "INSERT INTO New_student(UserName,FullName,Password,BloodGroup,DateOfBirth,PhoneNumber,Email,Gender,Address,EmergencyContact,EmergencyPhoneNumber,EmergencyRelation,VerficationId,RoomNumber)VALUES('" + userNameTextBox.Text + "','" + FullNameTextBox.Text + "','" + PasswordTextBox.Text + "','" + BloodGroupComboBox.Text + "','" + DateTimePicker.Text + "'," + PhoneNumberTextBox.Text + ",'" + EmailTextBox.Text + "','" + GenderComboBox.Text + "','" + AddressTextBox.Text + "','" + EmergencyFullNameTextBox.Text + "'," + EmergencyPhoneNumberTextBox.Text + ",'" + emergencyRelationTextBox.Text + "','" + IdNumberTextBox.Text + "'," + RoomNoComboBox.Text + ") UPDATE rooms SET Booked='Yes' Where RoomNumber=" + RoomNoComboBox.Text + "";
                fn.setData(query, "Student Added Successfully!!!");
                userNameTextBox.Text = FullNameTextBox.Text = PasswordTextBox.Text = BloodGroupComboBox.Text = DateTimePicker.Text = PhoneNumberTextBox.Text = EmailTextBox.Text = GenderComboBox.Text = AddressTextBox.Text = EmergencyContactTextBox.Text = EmergencyPhoneNumberTextBox.Text = emergencyRelationTextBox.Text = IdNumberTextBox.Text = RoomNoComboBox.Text = string.Empty;
            }

            else
            {
                MessageBox.Show("Fill Empty Space", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ConfirmPasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (this.ConfirmPasswordTextBox.Text != this.PasswordTextBox.Text)
            {
                this.errorProvider1.SetError(this.ConfirmPasswordTextBox, "Password and Confirm must be the same");
                e.Cancel = true;
                PasswordTextBox.Clear();
                ConfirmPasswordTextBox.Clear();
            }
            else
            {
                this.errorProvider1.SetError(this.ConfirmPasswordTextBox, "");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Show();
        }
    }
}
