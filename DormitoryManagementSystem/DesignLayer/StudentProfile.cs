using Student_Log_In;
using Student_Log_In.DataAccessLayer;
using Student_Log_In.DesignLayer;
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
        Function fn = new Function();
        String query;
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
            string sql = "INSERT INTO New_student(UserName,FullName,Password,BloodGroup,DateOfBirth,PhoneNumber,Email,Gender,Address,EmergencyContactName,EmergencyPhoneNumber,EmergencyRelationship,VerficationId)VALUES('" + userNameTextBox.Text + "','" + FullNameTextBox.Text + "','" + PasswordTextBox.Text + "','" + BloodGroupComboBox.Text + "','" + DateTimePicker.Text + "'," + PhoneNumberTextBox.Text + ",'" + EmailTextBox.Text + "','" + GenderComboBox.Text + "','" + AddressTextBox.Text + "','" + EmergencyFullNameTextBox.Text + "'," + EmergencyPhoneNumberTextBox.Text + ",'" + emergencyRelationTextBox.Text + "','" + IdNumberTextBox.Text + "')";


            SqlCommand command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("SuccessFully Created.");
                userNameTextBox.Text = FullNameTextBox.Text = PasswordTextBox.Text = BloodGroupComboBox.Text = DateTimePicker.Text = PhoneNumberTextBox.Text = EmailTextBox.Text = GenderComboBox.Text = AddressTextBox.Text = EmergencyContactTextBox.Text = EmergencyPhoneNumberTextBox.Text = emergencyRelationTextBox.Text = IdNumberTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Error in Creation.");
            }

            HomePage studentlogin = new HomePage();
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

                RoomBox.Image = new Bitmap(openFileDialog.FileName);
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

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void EmojiBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for Using Our System");
        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
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

        private void StudentButton_Click(object sender, EventArgs e)
        {
            Tenants tenants = new Tenants();
            tenants.Show();
            this.Hide();
        }

        private void ExpenseBox_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            expense.Show();
            this.Hide();
        }

        private void CreateStudentProfile_Load(object sender, EventArgs e)
        {
            query = "SELECT RoomNumber FROM rooms where Booked='No'";
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count;i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                RoomNoComboBox.Items.Add(room);
            }

        }
    }
}
