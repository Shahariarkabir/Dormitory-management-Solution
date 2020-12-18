namespace Registration
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.regPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.regCross = new Guna.UI2.WinForms.Guna2ControlBox();
            this.regMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.regMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.regUsername = new System.Windows.Forms.Label();
            this.registration = new System.Windows.Forms.Label();
            this.regPassword = new System.Windows.Forms.Label();
            this.regConfirmPassword = new System.Windows.Forms.Label();
            this.regEmail = new System.Windows.Forms.Label();
            this.regBtnUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.regCreateAnAccount = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.regBtnEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.regBtnConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.regBtnPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.regPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // regPicture
            // 
            this.regPicture.FillColor = System.Drawing.Color.Transparent;
            this.regPicture.Image = global::Registration.Properties.Resources.Visual_collaboration_1;
            this.regPicture.Location = new System.Drawing.Point(405, 125);
            this.regPicture.Name = "regPicture";
            this.regPicture.ShadowDecoration.Parent = this.regPicture;
            this.regPicture.Size = new System.Drawing.Size(366, 408);
            this.regPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.regPicture.TabIndex = 0;
            this.regPicture.TabStop = false;
            // 
            // regCross
            // 
            this.regCross.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.regCross.FillColor = System.Drawing.Color.Transparent;
            this.regCross.HoverState.Parent = this.regCross;
            this.regCross.IconColor = System.Drawing.Color.Black;
            this.regCross.Location = new System.Drawing.Point(753, 2);
            this.regCross.Name = "regCross";
            this.regCross.ShadowDecoration.Parent = this.regCross;
            this.regCross.Size = new System.Drawing.Size(46, 29);
            this.regCross.TabIndex = 4;
            // 
            // regMin
            // 
            this.regMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.regMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.regMin.FillColor = System.Drawing.Color.Transparent;
            this.regMin.HoverState.Parent = this.regMin;
            this.regMin.IconColor = System.Drawing.Color.Black;
            this.regMin.Location = new System.Drawing.Point(675, 2);
            this.regMin.Name = "regMin";
            this.regMin.ShadowDecoration.Parent = this.regMin;
            this.regMin.Size = new System.Drawing.Size(46, 29);
            this.regMin.TabIndex = 5;
            // 
            // regMax
            // 
            this.regMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.regMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.regMax.FillColor = System.Drawing.Color.Transparent;
            this.regMax.HoverState.Parent = this.regMax;
            this.regMax.IconColor = System.Drawing.Color.Black;
            this.regMax.Location = new System.Drawing.Point(714, 2);
            this.regMax.Name = "regMax";
            this.regMax.ShadowDecoration.Parent = this.regMax;
            this.regMax.Size = new System.Drawing.Size(46, 29);
            this.regMax.TabIndex = 6;
            // 
            // regUsername
            // 
            this.regUsername.AutoSize = true;
            this.regUsername.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.regUsername.Location = new System.Drawing.Point(192, 170);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(90, 21);
            this.regUsername.TabIndex = 7;
            this.regUsername.Text = "Username";
            // 
            // registration
            // 
            this.registration.AutoSize = true;
            this.registration.Font = new System.Drawing.Font("JetBrains Mono", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.registration.Location = new System.Drawing.Point(66, 90);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(364, 64);
            this.registration.TabIndex = 8;
            this.registration.Text = "Registration";
           // this.registration.Click += new System.EventHandler(this.label2_Click);
            // 
            // regPassword
            // 
            this.regPassword.AutoSize = true;
            this.regPassword.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.regPassword.Location = new System.Drawing.Point(192, 333);
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(90, 21);
            this.regPassword.TabIndex = 9;
            this.regPassword.Text = "Password";
            // 
            // regConfirmPassword
            // 
            this.regConfirmPassword.AutoSize = true;
            this.regConfirmPassword.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.regConfirmPassword.Location = new System.Drawing.Point(167, 412);
            this.regConfirmPassword.Name = "regConfirmPassword";
            this.regConfirmPassword.Size = new System.Drawing.Size(170, 21);
            this.regConfirmPassword.TabIndex = 10;
            this.regConfirmPassword.Text = "Confirm Password";
            // 
            // regEmail
            // 
            this.regEmail.AutoSize = true;
            this.regEmail.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.regEmail.Location = new System.Drawing.Point(203, 251);
            this.regEmail.Name = "regEmail";
            this.regEmail.Size = new System.Drawing.Size(70, 21);
            this.regEmail.TabIndex = 11;
            this.regEmail.Text = "E-mail";
            //this.regEmail.Click += new System.EventHandler(this.label5_Click);
            // 
            // regBtnUsername
            // 
            this.regBtnUsername.BorderRadius = 20;
            this.regBtnUsername.BorderThickness = 2;
            this.regBtnUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regBtnUsername.DefaultText = "";
            this.regBtnUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.regBtnUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.regBtnUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regBtnUsername.DisabledState.Parent = this.regBtnUsername;
            this.regBtnUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regBtnUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regBtnUsername.FocusedState.Parent = this.regBtnUsername;
            this.regBtnUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regBtnUsername.HoverState.Parent = this.regBtnUsername;
            this.regBtnUsername.Location = new System.Drawing.Point(97, 194);
            this.regBtnUsername.Name = "regBtnUsername";
            this.regBtnUsername.PasswordChar = '\0';
            this.regBtnUsername.PlaceholderText = "";
            this.regBtnUsername.SelectedText = "";
            this.regBtnUsername.ShadowDecoration.Parent = this.regBtnUsername;
            this.regBtnUsername.Size = new System.Drawing.Size(302, 43);
            this.regBtnUsername.TabIndex = 12;
            // 
            // regCreateAnAccount
            // 
            this.regCreateAnAccount.BorderRadius = 20;
            this.regCreateAnAccount.BorderThickness = 2;
            this.regCreateAnAccount.CheckedState.Parent = this.regCreateAnAccount;
            this.regCreateAnAccount.CustomImages.Parent = this.regCreateAnAccount;
            this.regCreateAnAccount.FillColor = System.Drawing.Color.Black;
            this.regCreateAnAccount.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold);
            this.regCreateAnAccount.ForeColor = System.Drawing.Color.White;
            this.regCreateAnAccount.HoverState.Parent = this.regCreateAnAccount;
            this.regCreateAnAccount.Location = new System.Drawing.Point(97, 504);
            this.regCreateAnAccount.Name = "regCreateAnAccount";
            this.regCreateAnAccount.ShadowDecoration.Parent = this.regCreateAnAccount;
            this.regCreateAnAccount.Size = new System.Drawing.Size(302, 43);
            this.regCreateAnAccount.TabIndex = 16;
            this.regCreateAnAccount.Text = "Create an account";
            this.regCreateAnAccount.Click += new System.EventHandler(this.regCreateAnAccount_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // regBtnEmail
            // 
            this.regBtnEmail.BorderRadius = 20;
            this.regBtnEmail.BorderThickness = 2;
            this.regBtnEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regBtnEmail.DefaultText = "";
            this.regBtnEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.regBtnEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.regBtnEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regBtnEmail.DisabledState.Parent = this.regBtnEmail;
            this.regBtnEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regBtnEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regBtnEmail.FocusedState.Parent = this.regBtnEmail;
            this.regBtnEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regBtnEmail.HoverState.Parent = this.regBtnEmail;
            this.regBtnEmail.Location = new System.Drawing.Point(93, 275);
            this.regBtnEmail.Name = "regBtnEmail";
            this.regBtnEmail.PasswordChar = '\0';
            this.regBtnEmail.PlaceholderText = "";
            this.regBtnEmail.SelectedText = "";
            this.regBtnEmail.ShadowDecoration.Parent = this.regBtnEmail;
            this.regBtnEmail.Size = new System.Drawing.Size(302, 43);
            this.regBtnEmail.TabIndex = 17;
            // 
            // regBtnConfirmPassword
            // 
            this.regBtnConfirmPassword.BorderRadius = 20;
            this.regBtnConfirmPassword.BorderThickness = 2;
            this.regBtnConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regBtnConfirmPassword.DefaultText = "";
            this.regBtnConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.regBtnConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.regBtnConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regBtnConfirmPassword.DisabledState.Parent = this.regBtnConfirmPassword;
            this.regBtnConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regBtnConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regBtnConfirmPassword.FocusedState.Parent = this.regBtnConfirmPassword;
            this.regBtnConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regBtnConfirmPassword.HoverState.Parent = this.regBtnConfirmPassword;
            this.regBtnConfirmPassword.Location = new System.Drawing.Point(97, 436);
            this.regBtnConfirmPassword.Name = "regBtnConfirmPassword";
            this.regBtnConfirmPassword.PasswordChar = '\0';
            this.regBtnConfirmPassword.PlaceholderText = "";
            this.regBtnConfirmPassword.SelectedText = "";
            this.regBtnConfirmPassword.ShadowDecoration.Parent = this.regBtnConfirmPassword;
            this.regBtnConfirmPassword.Size = new System.Drawing.Size(302, 43);
            this.regBtnConfirmPassword.TabIndex = 18;
            this.regBtnConfirmPassword.UseSystemPasswordChar = true;
            // 
            // regBtnPassword
            // 
            this.regBtnPassword.BorderRadius = 20;
            this.regBtnPassword.BorderThickness = 2;
            this.regBtnPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regBtnPassword.DefaultText = "";
            this.regBtnPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.regBtnPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.regBtnPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regBtnPassword.DisabledState.Parent = this.regBtnPassword;
            this.regBtnPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regBtnPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regBtnPassword.FocusedState.Parent = this.regBtnPassword;
            this.regBtnPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regBtnPassword.HoverState.Parent = this.regBtnPassword;
            this.regBtnPassword.Location = new System.Drawing.Point(97, 357);
            this.regBtnPassword.Name = "regBtnPassword";
            this.regBtnPassword.PasswordChar = '\0';
            this.regBtnPassword.PlaceholderText = "";
            this.regBtnPassword.SelectedText = "";
            this.regBtnPassword.ShadowDecoration.Parent = this.regBtnPassword;
            this.regBtnPassword.Size = new System.Drawing.Size(302, 43);
            this.regBtnPassword.TabIndex = 19;
            this.regBtnPassword.UseSystemPasswordChar = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.regBtnPassword);
            this.Controls.Add(this.regBtnConfirmPassword);
            this.Controls.Add(this.regBtnEmail);
            this.Controls.Add(this.regCreateAnAccount);
            this.Controls.Add(this.regBtnUsername);
            this.Controls.Add(this.regEmail);
            this.Controls.Add(this.regConfirmPassword);
            this.Controls.Add(this.regPassword);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.regUsername);
            this.Controls.Add(this.regMax);
            this.Controls.Add(this.regMin);
            this.Controls.Add(this.regCross);
            this.Controls.Add(this.regPicture);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
           // this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.regPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox regPicture;
        private Guna.UI2.WinForms.Guna2ControlBox regCross;
        private Guna.UI2.WinForms.Guna2ControlBox regMin;
        private Guna.UI2.WinForms.Guna2ControlBox regMax;
        private System.Windows.Forms.Label regUsername;
        private System.Windows.Forms.Label registration;
        private System.Windows.Forms.Label regPassword;
        private System.Windows.Forms.Label regConfirmPassword;
        private System.Windows.Forms.Label regEmail;
        private Guna.UI2.WinForms.Guna2TextBox regBtnUsername;
        private Guna.UI2.WinForms.Guna2TileButton regCreateAnAccount;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox regBtnPassword;
        private Guna.UI2.WinForms.Guna2TextBox regBtnConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox regBtnEmail;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}

