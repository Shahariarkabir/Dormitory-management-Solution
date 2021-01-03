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
    public partial class StudentDashbord : Form
    {
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox LogOutBox;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button AboutUsButton;
        private Guna.UI2.WinForms.Guna2Button SettingsButton;
        private Guna.UI2.WinForms.Guna2Button ExpenseButton;
        private Guna.UI2.WinForms.Guna2Button RoomButton;
        private Guna.UI2.WinForms.Guna2Button DashBoardButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox14;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox13;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox12;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox11;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox EmojiBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;

        public StudentDashbord()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.LogOutBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.AboutUsButton = new Guna.UI2.WinForms.Guna2Button();
            this.SettingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.ExpenseButton = new Guna.UI2.WinForms.Guna2Button();
            this.RoomButton = new Guna.UI2.WinForms.Guna2Button();
            this.DashBoardButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox14 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox13 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox12 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox11 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.EmojiBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmojiBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.LogOutBox);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.AboutUsButton);
            this.guna2Panel1.Controls.Add(this.SettingsButton);
            this.guna2Panel1.Controls.Add(this.ExpenseButton);
            this.guna2Panel1.Controls.Add(this.RoomButton);
            this.guna2Panel1.Controls.Add(this.DashBoardButton);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox14);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox13);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox12);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox11);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox4);
            this.guna2Panel1.Location = new System.Drawing.Point(1, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(134, 672);
            this.guna2Panel1.TabIndex = 46;
            // 
            // LogOutBox
            // 
            this.LogOutBox.Image = global::Student_Log_In.Properties.Resources.Group_187;
            this.LogOutBox.Location = new System.Drawing.Point(7, 544);
            this.LogOutBox.Name = "LogOutBox";
            this.LogOutBox.ShadowDecoration.Parent = this.LogOutBox;
            this.LogOutBox.Size = new System.Drawing.Size(122, 117);
            this.LogOutBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogOutBox.TabIndex = 140;
            this.LogOutBox.TabStop = false;
            this.LogOutBox.Click += new System.EventHandler(this.LogOutBox_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Location = new System.Drawing.Point(2, 137);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(10, 28);
            this.guna2PictureBox1.TabIndex = 140;
            this.guna2PictureBox1.TabStop = false;
            // 
            // AboutUsButton
            // 
            this.AboutUsButton.CheckedState.Parent = this.AboutUsButton;
            this.AboutUsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutUsButton.CustomImages.Parent = this.AboutUsButton;
            this.AboutUsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.AboutUsButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold);
            this.AboutUsButton.ForeColor = System.Drawing.Color.Black;
            this.AboutUsButton.HoverState.Parent = this.AboutUsButton;
            this.AboutUsButton.Image = global::Student_Log_In.Properties.Resources.Vector__10_;
            this.AboutUsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AboutUsButton.Location = new System.Drawing.Point(2, 404);
            this.AboutUsButton.Name = "AboutUsButton";
            this.AboutUsButton.ShadowDecoration.Parent = this.AboutUsButton;
            this.AboutUsButton.Size = new System.Drawing.Size(127, 22);
            this.AboutUsButton.TabIndex = 141;
            this.AboutUsButton.Text = "About us";
            this.AboutUsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AboutUsButton.Click += new System.EventHandler(this.AboutUsButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.CheckedState.Parent = this.SettingsButton;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.CustomImages.Parent = this.SettingsButton;
            this.SettingsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.SettingsButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.Black;
            this.SettingsButton.HoverState.Parent = this.SettingsButton;
            this.SettingsButton.Image = global::Student_Log_In.Properties.Resources.options1;
            this.SettingsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SettingsButton.Location = new System.Drawing.Point(2, 326);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.ShadowDecoration.Parent = this.SettingsButton;
            this.SettingsButton.Size = new System.Drawing.Size(127, 22);
            this.SettingsButton.TabIndex = 140;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ExpenseButton
            // 
            this.ExpenseButton.CheckedState.Parent = this.ExpenseButton;
            this.ExpenseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExpenseButton.CustomImages.Parent = this.ExpenseButton;
            this.ExpenseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ExpenseButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseButton.ForeColor = System.Drawing.Color.Black;
            this.ExpenseButton.HoverState.Parent = this.ExpenseButton;
            this.ExpenseButton.Image = global::Student_Log_In.Properties.Resources.Vector;
            this.ExpenseButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ExpenseButton.Location = new System.Drawing.Point(2, 255);
            this.ExpenseButton.Name = "ExpenseButton";
            this.ExpenseButton.ShadowDecoration.Parent = this.ExpenseButton;
            this.ExpenseButton.Size = new System.Drawing.Size(129, 22);
            this.ExpenseButton.TabIndex = 140;
            this.ExpenseButton.Text = "Expense";
            this.ExpenseButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ExpenseButton.Click += new System.EventHandler(this.ExpenseButton_Click);
            // 
            // RoomButton
            // 
            this.RoomButton.CheckedState.Parent = this.RoomButton;
            this.RoomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoomButton.CustomImages.Parent = this.RoomButton;
            this.RoomButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.RoomButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomButton.ForeColor = System.Drawing.Color.Black;
            this.RoomButton.HoverState.Parent = this.RoomButton;
            this.RoomButton.Image = global::Student_Log_In.Properties.Resources.home;
            this.RoomButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RoomButton.Location = new System.Drawing.Point(3, 188);
            this.RoomButton.Name = "RoomButton";
            this.RoomButton.ShadowDecoration.Parent = this.RoomButton;
            this.RoomButton.Size = new System.Drawing.Size(129, 22);
            this.RoomButton.TabIndex = 140;
            this.RoomButton.Text = "Room";
            this.RoomButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DashBoardButton
            // 
            this.DashBoardButton.BackColor = System.Drawing.Color.Black;
            this.DashBoardButton.CheckedState.Parent = this.DashBoardButton;
            this.DashBoardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashBoardButton.CustomImages.Parent = this.DashBoardButton;
            this.DashBoardButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.DashBoardButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoardButton.ForeColor = System.Drawing.Color.Black;
            this.DashBoardButton.HoverState.Parent = this.DashBoardButton;
            this.DashBoardButton.Image = global::Student_Log_In.Properties.Resources.template;
            this.DashBoardButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DashBoardButton.Location = new System.Drawing.Point(3, 120);
            this.DashBoardButton.Name = "DashBoardButton";
            this.DashBoardButton.ShadowDecoration.Parent = this.DashBoardButton;
            this.DashBoardButton.Size = new System.Drawing.Size(129, 22);
            this.DashBoardButton.TabIndex = 18;
            this.DashBoardButton.Text = "Dashboard";
            this.DashBoardButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2PictureBox14
            // 
            this.guna2PictureBox14.Location = new System.Drawing.Point(50, 590);
            this.guna2PictureBox14.Name = "guna2PictureBox14";
            this.guna2PictureBox14.ShadowDecoration.Parent = this.guna2PictureBox14;
            this.guna2PictureBox14.Size = new System.Drawing.Size(26, 5);
            this.guna2PictureBox14.TabIndex = 19;
            this.guna2PictureBox14.TabStop = false;
            // 
            // guna2PictureBox13
            // 
            this.guna2PictureBox13.Location = new System.Drawing.Point(0, 518);
            this.guna2PictureBox13.Name = "guna2PictureBox13";
            this.guna2PictureBox13.ShadowDecoration.Parent = this.guna2PictureBox13;
            this.guna2PictureBox13.Size = new System.Drawing.Size(135, 2);
            this.guna2PictureBox13.TabIndex = 17;
            this.guna2PictureBox13.TabStop = false;
            // 
            // guna2PictureBox12
            // 
            this.guna2PictureBox12.Location = new System.Drawing.Point(67, 582);
            this.guna2PictureBox12.Name = "guna2PictureBox12";
            this.guna2PictureBox12.ShadowDecoration.Parent = this.guna2PictureBox12;
            this.guna2PictureBox12.Size = new System.Drawing.Size(15, 21);
            this.guna2PictureBox12.TabIndex = 16;
            this.guna2PictureBox12.TabStop = false;
            // 
            // guna2PictureBox11
            // 
            this.guna2PictureBox11.Location = new System.Drawing.Point(42, 572);
            this.guna2PictureBox11.Name = "guna2PictureBox11";
            this.guna2PictureBox11.ShadowDecoration.Parent = this.guna2PictureBox11;
            this.guna2PictureBox11.Size = new System.Drawing.Size(19, 39);
            this.guna2PictureBox11.TabIndex = 15;
            this.guna2PictureBox11.TabStop = false;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = global::Student_Log_In.Properties.Resources.Group_186;
            this.guna2PictureBox4.Location = new System.Drawing.Point(7, 20);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.ShadowDecoration.Parent = this.guna2PictureBox4;
            this.guna2PictureBox4.Size = new System.Drawing.Size(118, 77);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 0;
            this.guna2PictureBox4.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.EmojiBox);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel2.Location = new System.Drawing.Point(132, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1120, 67);
            this.guna2Panel2.TabIndex = 47;
            // 
            // EmojiBox
            // 
            this.EmojiBox.BackColor = System.Drawing.Color.Transparent;
            this.EmojiBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmojiBox.Image = global::Student_Log_In.Properties.Resources.Group__1_;
            this.EmojiBox.Location = new System.Drawing.Point(1038, 6);
            this.EmojiBox.Name = "EmojiBox";
            this.EmojiBox.ShadowDecoration.Parent = this.EmojiBox;
            this.EmojiBox.Size = new System.Drawing.Size(18, 18);
            this.EmojiBox.TabIndex = 4;
            this.EmojiBox.TabStop = false;
            this.EmojiBox.UseTransparentBackground = true;
            this.EmojiBox.Click += new System.EventHandler(this.EmojiBox_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1068, 5);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(18, 18);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1091, 6);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(18, 18);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // StudentDashbord
            // 
            this.ClientSize = new System.Drawing.Size(1250, 666);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentDashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogOutBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmojiBox)).EndInit();
            this.ResumeLayout(false);

        }

        private void EmojiBox_Click(object sender, EventArgs e)
        {

        }

        private void LogOutBox_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
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

        }
    }
}
