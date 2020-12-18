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
using AMRConnector;
namespace HomePage
{
    public partial class WelcomePage : Form
    {
        DbConnector db;
        public WelcomePage()
        {
            InitializeComponent();
            db = new DbConnector();
        }

     

       
        private void guna2TileButton1_Click(object sender, EventArgs e)

        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CreateStudentProfile"].ConnectionString);
            bool check = db.IsValidNamePass(EmailTextBox.Text.Trim(), PasswordTextBox.Text.Trim());
            if(EmailTextBox.Text.Trim()== string.Empty || PasswordTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill Out all fields", "Required Field",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (check)
                {
                    AdminDashBoard ad = new AdminDashBoard(); 
                }
                else
                    MessageBox.Show("Invalid Email or Password", "Please give valid email or password to log in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
