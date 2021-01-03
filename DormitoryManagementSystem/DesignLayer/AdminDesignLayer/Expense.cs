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
    public partial class Expense : Form
    {
        Function fn = new Function();
        String query;
        public Expense()
        {
            InitializeComponent();
        }

        private void EmojiButton_Click(object sender, EventArgs e)
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

        private void ExpenseButton_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            expense.Show();
            this.Hide();
        }

        private void Expense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dormitoryManagementDataSet6.Expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.dormitoryManagementDataSet6.Expenses);
            // TODO: This line of code loads data into the 'dormitoryManagementDataSet6.Expenses' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dormitoryManagementDataSet5.Expenses' table. You can move, or remove it, as needed.
            //this.expensesTableAdapter.Fill(this.dormitoryManagementDataSet5.Expenses);
            this.Location = new Point(350, 170);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MMMM yyyy";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text !="")
            {
                query = "select   UserName,PhoneNumber,RoomNumber from New_student where Email ='" + txtEmail.Text + "'";
                DataSet ds = fn.getData(query);

                if(ds.Tables[0].Rows.Count !=0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtMobile.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtRoomNumber.Text = ds.Tables[0].Rows[0][2].ToString();
                    query = "select * from Expenses where Email = '" +txtEmail.Text+ "'";
                    DataSet ds2 = fn.getData(query);
                    guna2DataGridView1.DataSource = ds2.Tables[0]; 

                    

                }
                else
                {
                    MessageBox.Show("No Record Exicts", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }        
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text !=" "&& txtDuesAmmount.Text!=" ")
            {
                query = "SELECT * FROM Expenses WHERE Email='" + txtEmail.Text + "'AND Month='"+dateTimePicker.Text+"'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    Int64 PhoneNumber = Int64.Parse(txtMobile.Text);
                    String Month = dateTimePicker.Text;
                    String UserName = txtName.Text;
                    Int64 Amount = Int64.Parse(txtDuesAmmount.Text);
                    String PaymentDate = PaymentDatePicker.Text;
                    String Email = txtEmail.Text;
                    query = "INSERT INTO Expenses (PhoneNumber,Month,UserName,Amount,PaymentDate,Email) VALUES(" + PhoneNumber + ",'" + Month + "','" + UserName + "'," + Amount + ",'" + PaymentDate + "','"+Email+"') ";
                    fn.setData(query, "Paid Successfully");
                    Expense_Load(this, null);

                    

                }
                else
                {
                    MessageBox.Show("No Dues of "+dateTimePicker.Text+"Left","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
