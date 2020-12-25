using Student_Log_In;
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
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DormitoryManagement"].ConnectionString);
            connection.Open();
            string sql = "INSERT INTO student_user_create(UserName,FullName,Password,BloodGroup,DateOfBirth,PhoneNumber,Email,Gender,Address,EmergencyContactName,EmergencyPhoneNumber,EmergencyRelationship,VerficationId)VALUES('" + userNameTextBox.Text + "','" + FullNameTextBox.Text + "','" + PasswordTextBox.Text + "','" + BloodGroupComboBox.Text + "','" + DateOfBirthTextBox.Text + "'," + PhoneNumberTextBox.Text + ",'" + EmailTextBox.Text + "','" + GenderComboBox.Text + "','" + AddressTextBox.Text + "','" + EmergencyFullNameTextBox.Text + "'," + EmergencyPhoneNumberTextBox.Text + ",'" + emergencyRelationTextBox.Text + "','" + IdNumberTextBox.Text + "')";


            SqlCommand command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("SuccessFully Created.");
                userNameTextBox.Text = FullNameTextBox.Text = PasswordTextBox.Text = BloodGroupComboBox.Text = DateOfBirthTextBox.Text = PhoneNumberTextBox.Text = EmailTextBox.Text = GenderComboBox.Text = AddressTextBox.Text = EmergencyContactTextBox.Text = EmergencyPhoneNumberTextBox.Text = emergencyRelationTextBox.Text = IdNumberTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Error in Creation.");
            }

            studentlogin studentlogin = new studentlogin();
            studentlogin.Show();
            this.Hide();





        }

        /* private void guna2Button1_Click(object sender, EventArgs e)
         {
             OpenFileDialog openFileDialog = new OpenFileDialog();
             openFileDialog.Filter = "Image Files(*jpg,*png)";
             if (openFileDialog.ShowDialog()==DialogResult.OK){

                 guna2Button1.Image = new Bitmap(openFileDialog.FileName);
             }
         */

        private void UpdatePhotoPictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*jpg,*png)";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                guna2Button1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void ConfirmPasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
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
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png)|*.jpg;*.png ";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                UpdatePhotoPictureBox.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
