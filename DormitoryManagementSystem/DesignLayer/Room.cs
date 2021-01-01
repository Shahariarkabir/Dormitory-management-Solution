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

        private void guna2Button2_Click(object sender, EventArgs e)
        {

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
                    AddRoomTextBox.Text = row.Cells[1].Value.ToString();
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

        private void RoomButton_Click(object sender, EventArgs e)
        {

        }
    }
}


