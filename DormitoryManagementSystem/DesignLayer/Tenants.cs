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
    public partial class Tenants : Form
    {
        public Tenants()
        {
            InitializeComponent();
        }

        private void EmojiPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for Using Our System");
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

        private void Room_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Show();
            this.Hide();
        }
    }
}
