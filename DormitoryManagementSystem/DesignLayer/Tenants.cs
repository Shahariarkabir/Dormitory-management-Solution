﻿using Student_Profile;
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

<<<<<<< HEAD
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
=======
        private void Room_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Show();
>>>>>>> 3c79683fe02b361820cbd8814cdea47cf65a8a97
            this.Hide();
        }

        private void Tenants_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dormitoryManagementDataSet3.New_student' table. You can move, or remove it, as needed.
            this.new_studentTableAdapter.Fill(this.dormitoryManagementDataSet3.New_student);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UpdateDeleteInformation information = new UpdateDeleteInformation();
            information.Show();
            this.Hide();
        }
    }
}
