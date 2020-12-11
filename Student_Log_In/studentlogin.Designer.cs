
namespace Student_Log_In
{
    partial class studentlogin
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.statementLabel = new System.Windows.Forms.Label();
            this.statement2Label = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.remeberCheckBox = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.rememberLabel = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.donothaveLabel = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.signupLinkLabel = new System.Windows.Forms.LinkLabel();
            this.forgetPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.userSignInButton = new Guna.UI2.WinForms.Guna2Button();
            this.clickhereLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("JetBrains Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.welcomeLabel.Location = new System.Drawing.Point(410, 55);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(362, 44);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome to the DMS";
            // 
            // statementLabel
            // 
            this.statementLabel.AutoSize = true;
            this.statementLabel.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statementLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.statementLabel.Location = new System.Drawing.Point(435, 111);
            this.statementLabel.Name = "statementLabel";
            this.statementLabel.Size = new System.Drawing.Size(296, 18);
            this.statementLabel.TabIndex = 3;
            this.statementLabel.Text = "If you have a student account in DMS";
            // 
            // statement2Label
            // 
            this.statement2Label.AutoSize = true;
            this.statement2Label.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statement2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.statement2Label.Location = new System.Drawing.Point(435, 128);
            this.statement2Label.Name = "statement2Label";
            this.statement2Label.Size = new System.Drawing.Size(208, 18);
            this.statement2Label.TabIndex = 4;
            this.statement2Label.Text = "Please Sign in the below.";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(434, 190);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(210, 21);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "Email or User Name :";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BorderColor = System.Drawing.Color.Black;
            this.userNameTextBox.BorderRadius = 20;
            this.userNameTextBox.BorderThickness = 2;
            this.userNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTextBox.DefaultText = "";
            this.userNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTextBox.DisabledState.Parent = this.userNameTextBox;
            this.userNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTextBox.FocusedState.Parent = this.userNameTextBox;
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.userNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.userNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTextBox.HoverState.Parent = this.userNameTextBox;
            this.userNameTextBox.Location = new System.Drawing.Point(429, 225);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PasswordChar = '\0';
            this.userNameTextBox.PlaceholderText = "";
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.ShadowDecoration.Parent = this.userNameTextBox;
            this.userNameTextBox.Size = new System.Drawing.Size(302, 43);
            this.userNameTextBox.TabIndex = 6;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(440, 277);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(110, 21);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password :";
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.BorderColor = System.Drawing.Color.Black;
            this.userPasswordTextBox.BorderRadius = 20;
            this.userPasswordTextBox.BorderThickness = 2;
            this.userPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userPasswordTextBox.DefaultText = "";
            this.userPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userPasswordTextBox.DisabledState.Parent = this.userPasswordTextBox;
            this.userPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userPasswordTextBox.FocusedState.Parent = this.userPasswordTextBox;
            this.userPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.userPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.userPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userPasswordTextBox.HoverState.Parent = this.userPasswordTextBox;
            this.userPasswordTextBox.Location = new System.Drawing.Point(429, 308);
            this.userPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.PasswordChar = '\0';
            this.userPasswordTextBox.PlaceholderText = "";
            this.userPasswordTextBox.SelectedText = "";
            this.userPasswordTextBox.ShadowDecoration.Parent = this.userPasswordTextBox;
            this.userPasswordTextBox.Size = new System.Drawing.Size(302, 43);
            this.userPasswordTextBox.TabIndex = 8;
            this.userPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // remeberCheckBox
            // 
            this.remeberCheckBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.remeberCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.remeberCheckBox.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.remeberCheckBox.CheckedState.BorderRadius = 1;
            this.remeberCheckBox.CheckedState.BorderThickness = 2;
            this.remeberCheckBox.CheckedState.FillColor = System.Drawing.Color.Green;
            this.remeberCheckBox.CheckedState.Parent = this.remeberCheckBox;
            this.remeberCheckBox.CheckMarkColor = System.Drawing.Color.Black;
            this.remeberCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remeberCheckBox.Location = new System.Drawing.Point(448, 358);
            this.remeberCheckBox.Name = "remeberCheckBox";
            this.remeberCheckBox.ShadowDecoration.Parent = this.remeberCheckBox;
            this.remeberCheckBox.Size = new System.Drawing.Size(20, 20);
            this.remeberCheckBox.TabIndex = 9;
            this.remeberCheckBox.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.remeberCheckBox.UncheckedState.BorderRadius = 1;
            this.remeberCheckBox.UncheckedState.BorderThickness = 2;
            this.remeberCheckBox.UncheckedState.FillColor = System.Drawing.Color.White;
            this.remeberCheckBox.UncheckedState.Parent = this.remeberCheckBox;
            // 
            // rememberLabel
            // 
            this.rememberLabel.AutoSize = true;
            this.rememberLabel.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberLabel.Location = new System.Drawing.Point(474, 359);
            this.rememberLabel.Name = "rememberLabel";
            this.rememberLabel.Size = new System.Drawing.Size(96, 18);
            this.rememberLabel.TabIndex = 10;
            this.rememberLabel.Text = "Remember me";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Student_Log_In.Properties.Resources.Group_12;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 110);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(401, 304);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // donothaveLabel
            // 
            this.donothaveLabel.AutoSize = true;
            this.donothaveLabel.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donothaveLabel.Location = new System.Drawing.Point(493, 472);
            this.donothaveLabel.Name = "donothaveLabel";
            this.donothaveLabel.Size = new System.Drawing.Size(184, 18);
            this.donothaveLabel.TabIndex = 15;
            this.donothaveLabel.Text = "Don’t have an account ";
            this.donothaveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(745, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(29, 29);
            this.guna2ControlBox1.TabIndex = 18;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.guna2ControlBox2.Location = new System.Drawing.Point(710, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(29, 29);
            this.guna2ControlBox2.TabIndex = 19;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.guna2ControlBox3.Location = new System.Drawing.Point(675, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(29, 29);
            this.guna2ControlBox3.TabIndex = 20;
            // 
            // signupLinkLabel
            // 
            this.signupLinkLabel.AutoSize = true;
            this.signupLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupLinkLabel.Font = new System.Drawing.Font("JetBrains Mono", 9.75F);
            this.signupLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.signupLinkLabel.Location = new System.Drawing.Point(606, 493);
            this.signupLinkLabel.Name = "signupLinkLabel";
            this.signupLinkLabel.Size = new System.Drawing.Size(64, 18);
            this.signupLinkLabel.TabIndex = 21;
            this.signupLinkLabel.TabStop = true;
            this.signupLinkLabel.Text = "Sign Up";
            // 
            // forgetPasswordLinkLabel
            // 
            this.forgetPasswordLinkLabel.AutoSize = true;
            this.forgetPasswordLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgetPasswordLinkLabel.Font = new System.Drawing.Font("JetBrains Mono", 9.75F);
            this.forgetPasswordLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.forgetPasswordLinkLabel.Location = new System.Drawing.Point(592, 359);
            this.forgetPasswordLinkLabel.Name = "forgetPasswordLinkLabel";
            this.forgetPasswordLinkLabel.Size = new System.Drawing.Size(128, 18);
            this.forgetPasswordLinkLabel.TabIndex = 22;
            this.forgetPasswordLinkLabel.TabStop = true;
            this.forgetPasswordLinkLabel.Text = "Forgot Password";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // userSignInButton
            // 
            this.userSignInButton.BorderRadius = 20;
            this.userSignInButton.CheckedState.Parent = this.userSignInButton;
            this.userSignInButton.CustomImages.Parent = this.userSignInButton;
            this.userSignInButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.userSignInButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSignInButton.ForeColor = System.Drawing.Color.White;
            this.userSignInButton.HoverState.Parent = this.userSignInButton;
            this.userSignInButton.Location = new System.Drawing.Point(507, 410);
            this.userSignInButton.Name = "userSignInButton";
            this.userSignInButton.ShadowDecoration.Parent = this.userSignInButton;
            this.userSignInButton.Size = new System.Drawing.Size(151, 43);
            this.userSignInButton.TabIndex = 23;
            this.userSignInButton.Text = "Sign In";
            // 
            // clickhereLabel
            // 
            this.clickhereLabel.AutoSize = true;
            this.clickhereLabel.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickhereLabel.Location = new System.Drawing.Point(493, 493);
            this.clickhereLabel.Name = "clickhereLabel";
            this.clickhereLabel.Size = new System.Drawing.Size(112, 18);
            this.clickhereLabel.TabIndex = 24;
            this.clickhereLabel.Text = "Click here to";
            this.clickhereLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.clickhereLabel);
            this.Controls.Add(this.userSignInButton);
            this.Controls.Add(this.forgetPasswordLinkLabel);
            this.Controls.Add(this.signupLinkLabel);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.donothaveLabel);
            this.Controls.Add(this.rememberLabel);
            this.Controls.Add(this.remeberCheckBox);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.statement2Label);
            this.Controls.Add(this.statementLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "studentlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Log In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.studentlogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label statementLabel;
        private System.Windows.Forms.Label statement2Label;
        private System.Windows.Forms.Label userNameLabel;
        private Guna.UI2.WinForms.Guna2TextBox userNameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private Guna.UI2.WinForms.Guna2TextBox userPasswordTextBox;
        private Guna.UI2.WinForms.Guna2CustomCheckBox remeberCheckBox;
        private System.Windows.Forms.Label rememberLabel;
        private System.Windows.Forms.Label donothaveLabel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private System.Windows.Forms.LinkLabel signupLinkLabel;
        private System.Windows.Forms.LinkLabel forgetPasswordLinkLabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button userSignInButton;
        private System.Windows.Forms.Label clickhereLabel;
    }
}

