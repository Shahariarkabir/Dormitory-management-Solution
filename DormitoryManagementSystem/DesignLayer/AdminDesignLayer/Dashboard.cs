using Student_Log_In;
using Student_Log_In.DesignLayer;
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

namespace Student_Profile
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        

        private void guna2PictureBox3_Click_1(object sender, EventArgs e)
        {
            
            HomePage login = new HomePage();
            login.Show();
            this.Hide();

        }

        private void EmojiBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks For Using Our System");
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

        private void TotalStudentButton_Click(object sender, EventArgs e)
        {
            /*string str = "data source = .\\sqlexpress; database= DormitoryManagement;integrated security=true;";
            SqlConnection sqlConnection = new SqlConnection(str);
            SqlCommand command;
            string sql = "SELECT count(UserId) FROM New_student";
            try
            {
                sqlConnection.Open();
                command = new SqlCommand(sql, sqlConnection);
                
                Int32 rows_Count = Convert.ToInt32(command.ExecuteScalar());
                command.Dispose();
                label33.ForeColor = Color.Blue;
                label33.Text = " "+rows_Count.ToString();
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }*/
        }

        

        private void label33_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dormitoryManagementDataSet11.student_user_create' table. You can move, or remove it, as needed.
            this.student_user_createTableAdapter3.Fill(this.dormitoryManagementDataSet11.student_user_create);

            // TODO: This line of code loads data into the 'dormitoryManagementDataSet8.Expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.dormitoryManagementDataSet8.Expenses);
            
            timer1.Start();
            timer2.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            string str = "data source = .\\sqlexpress; database= DormitoryManagement;integrated security=true;";
            SqlConnection sqlConnection = new SqlConnection(str);
            SqlCommand command;
            string sql = "SELECT count(UserId) FROM New_student";
            try
            {
                sqlConnection.Open();
                command = new SqlCommand(sql, sqlConnection);

                Int32 rows_Count = Convert.ToInt32(command.ExecuteScalar());
                command.Dispose();
                label33.ForeColor = Color.Blue;
                
                label33.Text = " " + rows_Count.ToString();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string str = "data source = .\\sqlexpress; database= DormitoryManagement;integrated security=true;";
            SqlConnection sqlConnection = new SqlConnection(str);
            SqlCommand command;
            string sql = "SELECT count(RoomNumber) FROM rooms";
            try
            {
                sqlConnection.Open();
                command = new SqlCommand(sql, sqlConnection);

                Int32 rows_Count = Convert.ToInt32(command.ExecuteScalar());
                command.Dispose();
                label37.ForeColor = Color.Blue;

                label37.Text = " " + rows_Count.ToString();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("hh:MM:ss tt");
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        
    }
}
