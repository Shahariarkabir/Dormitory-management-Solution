using Student_Log_In.DataAccessLayer;
using Student_Profile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Log_In.DesignLayer

{
   
    public partial class Room : Form
    {
        Function fn = new Function();
        string query;
        public Room()
        {
            InitializeComponent();
        }

        private void EmojiPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for Using our system");
        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
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

        private void AboutUsButton_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
            this.Hide();

        }

       
        private void Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dormitoryManagementDataSet2.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter2.Fill(this.dormitoryManagementDataSet2.rooms);
            // TODO: This line of code loads data into the 'dormitoryManagementDataSet1.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter1.Fill(this.dormitoryManagementDataSet1.rooms);
            // TODO: This line of code loads data into the 'dormitoryManagementDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.dormitoryManagementDataSet.rooms);
            labelRoom.Visible = false;
            labelRoomExist.Visible = false;
        }
        SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DormitoryManagement"].ConnectionString);

        private void RoomsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.RoomDataGridView.Rows[e.RowIndex];
                    //AddRoomTextBox.Text = row.Cells[1].Value.ToString();
                    /*UpdateDescription.Text = row.Cells[2].Value.ToString();

                    MarkAsComboBox.Text = row.Cells[3].Value.ToString();
                    guna2DateTimePicker2.Text = row.Cells[5].Value.ToString();
                    UpdateEventId.Text = row.Cells[0].Value.ToString();
                */
                }
            }
        }

        private void labelRoom_Click(object sender, EventArgs e)
        {

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
            this.Hide();
        }

        private void ExpenseButton_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            expense.Show();
            this.Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

<<<<<<< HEAD
        private void RoomButton_Click(object sender, EventArgs e)
        {

=======
        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM rooms WHERE RoomNumber ="+AddRoomTextBox.Text+"";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                string status;
                if (AddRoomCheckBox.Checked)
                {
                    status = "Yes";
                }
                else
                {
                    status = "No";
                }
                labelRoom.Visible = false;
                query = "INSERT INTO rooms(RoomNumber,RoomType,Booked)VALUES("+AddRoomTextBox.Text+",'"+AddRoomComboBox.Text+"','"+status+"')";
                fn.setData(query, "Room Added");
                Room_Load(this, null);

            }
            else
            {
                labelRoom.Text = "Room Already Exists!!";
                labelRoom.Visible = true;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM rooms WHERE RoomNumber =" + UpdateDeleteTextBox.Text + "";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                labelRoomExist.Text = "No Room Exists";
                labelRoomExist.Visible = true;
                CheckBox2.Checked = false;
            }
            else
            {
                labelRoomExist.Text = "Room Found!!!";
                labelRoomExist.Visible = true;
                if (ds.Tables[0].Rows[0][2].ToString() == "Yes")
                {
                    CheckBox2.Checked = true;
                }
                else
                {
                    CheckBox2.Checked = false;
                }
            }
        }

        private void UpdateRoomButton_Click(object sender, EventArgs e)
        {
            string status;
            if (CheckBox2.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            query="UPDATE rooms set Booked='"+status+"'WHERE RoomNumber="+UpdateDeleteTextBox.Text+"";
            fn.setData(query, "Booking Updated..");
            Room_Load(this, null);      }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            if(labelRoomExist.Text== "Room Found!!!")
            {
                query = "DELETE FROM rooms WHERE RoomNumber=" + UpdateDeleteTextBox.Text + "";
                fn.setData(query, "Delete SuccessFully");
                Room_Load(this, null);
            }
            else
            {
                MessageBox.Show("Trying To Delete Something Which Doesn't Exist!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
>>>>>>> 3c79683fe02b361820cbd8814cdea47cf65a8a97
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            CreateStudentProfile studentProfile = new CreateStudentProfile();
            studentProfile.Show();
            this.Hide();

        }
    }
}


