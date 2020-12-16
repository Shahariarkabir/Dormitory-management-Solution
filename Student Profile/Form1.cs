using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Profile
{
    public partial class CreateStudentProfile : Form
    {
        public CreateStudentProfile()
        {
            InitializeComponent();
        }

    

        private void CreateStudentProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CreateProfileButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CreateStudentProfile"].ConnectionString );
            connection.Open();
            string sql = "INSERT INTO students(UserName,FullName,Password,BloodGroup,DateOfBirth,PhoneNumer,EmailAddress,Gender,Address,EmergencyFullName,EmergencyPhoneNumber,EmergencyRelation)VALUES('" + userNameTextBox.Text+"','"+FullNameTextBox.Text+"','"+PasswordTextBox.Text+"','"+BloodGroupComboBox.Text+"','"+DateOfBirthTextBox.Text+"','"+PhoneNumberTextBox.Text+"','"+EmailTextBox.Text+"','"+GenderComboBox.Text+"','"+AddressTextBox.Text+"','"+EmergencyFullNameTextBox.Text+"','"+EmergencyPhoneNumberTextBox.Text+"','"+emergencyRelationTextBox.Text+"')";
            SqlCommand command = new SqlCommand(sql,connection);

            int result =command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("SuccessFully Created.");

            }
            else
            {
                MessageBox.Show("Error in Creation.");
            }
        
        
        
        
        
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
