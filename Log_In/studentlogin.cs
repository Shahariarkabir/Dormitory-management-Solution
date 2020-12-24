using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Log_In
{
    public partial class studentlogin : Form
    {
        public studentlogin()
        {
            InitializeComponent();
        }

        private void studentlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void userSignInButton_Click(object sender, EventArgs e)
        {

        }
    }
}
