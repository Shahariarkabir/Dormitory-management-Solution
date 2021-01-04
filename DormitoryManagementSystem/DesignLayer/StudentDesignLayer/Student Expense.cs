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
    public partial class Student_Expense : Form
    {
        Function fn = new Function();
        String query;
        public Student_Expense()
        {
            InitializeComponent();
        }

        private void StudentDashBoardButton_Click(object sender, EventArgs e)
        {
            StudentDashboard dashboard = new StudentDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void StudentRoomButton_Click(object sender, EventArgs e)
        {
            StudentRoom room = new StudentRoom();
            room.Show();
            this.Hide();
        }

        private void StudentExpenseButton_Click(object sender, EventArgs e)
        {
            Student_Expense expense = new Student_Expense();
            expense.Show();
            this.Hide();
        }

        private void StudentSettingsButton_Click(object sender, EventArgs e)
        {
            Student_Setting setting = new Student_Setting();
            setting.Show();
            this.Hide();
        }

        private void StudentAboutUsButton_Click(object sender, EventArgs e)
        {
            StudentAboutUs aboutUs = new StudentAboutUs();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                query = "select   UserName,PhoneNumber,RoomNumber from New_student where Email ='" + txtEmail.Text + "'";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtMobile.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtRoomNumber.Text = ds.Tables[0].Rows[0][2].ToString();
                    query = "select * from Expenses where Email = '" + txtEmail.Text + "'";
                    DataSet ds2 = fn.getData(query);




                }
                else
                {
                    MessageBox.Show("No Record Exicts", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != " " && txtDuesAmmount.Text != " ")
            {
                query = "SELECT * FROM Expenses WHERE Email='" + txtEmail.Text + "'AND Month='" + dateTimePicker.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    Int64 PhoneNumber = Int64.Parse(txtMobile.Text);
                    String Month = dateTimePicker.Text;
                    String UserName = txtName.Text;
                    Int64 Amount = Int64.Parse(txtDuesAmmount.Text);
                    String PaymentDate = PaymentDatePicker.Text;
                    String Email = txtEmail.Text;
                    query = "INSERT INTO Expenses (PhoneNumber,Month,UserName,Amount,PaymentDate,Email) VALUES(" + PhoneNumber + ",'" + Month + "','" + UserName + "'," + Amount + ",'" + PaymentDate + "','" + Email + "') ";
                    fn.setData(query, "Paid Successfully");




                }
                else
                {
                    MessageBox.Show("No Dues of " + dateTimePicker.Text + "Left", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtMobile.Clear();
            txtName.Clear();
            txtDuesAmmount.Clear();
            txtRoomNumber.Clear();
        }
    }
}