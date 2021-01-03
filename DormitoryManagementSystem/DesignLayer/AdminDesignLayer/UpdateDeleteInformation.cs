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
    public partial class UpdateDeleteInformation : Form
    {
        Function fn = new Function();
        string query;
        public UpdateDeleteInformation()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            query= "SELECT * FROM New_student WHERE UserName='"+userNameTextBox.Text+"'";
          
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
                EmergencyFullNameTextBox.Text = ds.Tables[0].Rows[0][9].ToString();
                EmergencyPhoneNumberTextBox.Text = ds.Tables[0].Rows[0][10].ToString();
                emergencyRelationTextBox.Text = ds.Tables[0].Rows[0][11].ToString();
                PhoneNumberTextBox.Text = ds.Tables[0].Rows[0][12].ToString();
                IdNumberTextBox.Text = ds.Tables[0].Rows[0][13].ToString();
                RoomNoText.Text = ds.Tables[0].Rows[0][14].ToString();
                
            }
            else
            {
                userNameTextBox.Text = FullTextBox.Text = PassTextBox.Text = BloodGroupComboBox.Text = DateTimePicker.Text = PhoneNumberTextBox.Text = TextBoxEmail.Text = GenderComboBox.Text = AddressTextBox.Text = EmergencyContactTextBox.Text = EmergencyPhoneNumberTextBox.Text = emergencyRelationTextBox.Text = IdNumberTextBox.Text = RoomNoText.Text= string.Empty;
                MessageBox.Show("No Record Found By the Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void EmojiBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks For Using Our System");
        }

        private void UpdateInfoButton_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(PhoneNumberTextBox.Text);
            Int64 eMobile = Int64.Parse(EmergencyPhoneNumberTextBox.Text);
            String bookingStatus = RoomType.Text;
            query = " UPDATE New_student SET UserName ='" + userNameTextBox.Text + "',FullName='" + FullTextBox.Text + "',Password='" + PassTextBox.Text + "',BloodGroup='" + BloodGroupComboBox.Text + "',DateOfBirth='" + DateTimePicker.Text + "',PhoneNumber=" + mobile + ",Email='" + TextBoxEmail.Text + "',Gender='" + GenderComboBox.Text + "',Address='" + AddressTextBox.Text + "',EmergencyContact='" + EmergencyFullNameTextBox.Text + "',EmergencyPhoneNumber=" + eMobile + ",EmergencyRelation='" + emergencyRelationTextBox.Text + "',VerficationId='" + IdNumberTextBox.Text + "',RoomNumber=" + RoomNoText.Text + " WHERE UserName='"+userNameTextBox.Text+"' UPDATE rooms set Booked='"+bookingStatus+"' WHERE RoomNumber="+RoomNoText.Text+"";
            fn.setData(query, "Updated Successfully......");
            userNameTextBox.Text = FullTextBox.Text = PassTextBox.Text = BloodGroupComboBox.Text = DateTimePicker.Text = PhoneNumberTextBox.Text = TextBoxEmail.Text = GenderComboBox.Text = AddressTextBox.Text = EmergencyContactTextBox.Text = EmergencyPhoneNumberTextBox.Text = emergencyRelationTextBox.Text = IdNumberTextBox.Text = RoomNoText.Text = string.Empty;
            Tenants tenants = new Tenants();
            tenants.Show();
            this.Hide();
            
        }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Are You Sure To Delete???","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                query = "DELETE FROM New_student WHERE UserName='" + userNameTextBox.Text + "'";
                fn.setData(query, "Deleted Successfully....");
                userNameTextBox.Text = FullTextBox.Text = PassTextBox.Text = BloodGroupComboBox.Text = DateTimePicker.Text = PhoneNumberTextBox.Text = TextBoxEmail.Text = GenderComboBox.Text = AddressTextBox.Text = EmergencyContactTextBox.Text = EmergencyPhoneNumberTextBox.Text = emergencyRelationTextBox.Text = IdNumberTextBox.Text = RoomNoText.Text = string.Empty;
                Tenants tenants = new Tenants();
                tenants.Show();
                this.Hide();
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
