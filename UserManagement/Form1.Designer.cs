namespace UserManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Button btnClose;
            pictureBox1 = new PictureBox();
            btnMax = new Button();
            linkForgotPassword = new LinkLabel();
            linkRegister = new LinkLabel();
            panel1 = new Panel();
            btnSubmit = new Button();
            txtUserPassword = new TextBox();
            lblPassword = new Label();
            txtUserEmail = new TextBox();
            lblUsername = new Label();
            btnMin = new Button();
            checkPassShow = new CheckBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(452, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.Dock = DockStyle.Right;
            btnClose.Location = new Point(770, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 450);
            btnClose.TabIndex = 23;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMax
            // 
            btnMax.BackColor = Color.Green;
            btnMax.Location = new Point(727, 5);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(32, 29);
            btnMax.TabIndex = 22;
            btnMax.Text = "[]";
            btnMax.UseVisualStyleBackColor = false;
            btnMax.Click += btnMax_Click;
            // 
            // linkForgotPassword
            // 
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.Location = new Point(308, 286);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(118, 20);
            linkForgotPassword.TabIndex = 21;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "Forgot Password";
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Location = new Point(461, 336);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(217, 20);
            linkRegister.TabIndex = 20;
            linkRegister.TabStop = true;
            linkRegister.Text = "Not User? Create new Acccount";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.ControlText;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 450);
            panel1.TabIndex = 19;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.MenuHighlight;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.ForeColor = SystemColors.ControlLight;
            btnSubmit.Location = new Point(339, 332);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(105, 29);
            btnSubmit.TabIndex = 18;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtUserPassword
            // 
            txtUserPassword.BackColor = SystemColors.ScrollBar;
            txtUserPassword.BorderStyle = BorderStyle.FixedSingle;
            txtUserPassword.Location = new Point(308, 233);
            txtUserPassword.Margin = new Padding(0);
            txtUserPassword.Multiline = true;
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.Size = new Size(332, 30);
            txtUserPassword.TabIndex = 17;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            lblPassword.Location = new Point(272, 198);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 29);
            lblPassword.TabIndex = 16;
            lblPassword.Text = "Password";
            // 
            // txtUserEmail
            // 
            txtUserEmail.BackColor = SystemColors.ScrollBar;
            txtUserEmail.BorderStyle = BorderStyle.FixedSingle;
            txtUserEmail.Location = new Point(308, 152);
            txtUserEmail.Multiline = true;
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(332, 30);
            txtUserEmail.TabIndex = 15;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            lblUsername.Location = new Point(273, 117);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(86, 29);
            lblUsername.TabIndex = 14;
            lblUsername.Text = "Username";
            // 
            // btnMin
            // 
            btnMin.AccessibleRole = AccessibleRole.None;
            btnMin.BackColor = Color.Yellow;
            btnMin.Location = new Point(697, 5);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(24, 29);
            btnMin.TabIndex = 13;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // checkPassShow
            // 
            checkPassShow.AutoSize = true;
            checkPassShow.Location = new Point(658, 239);
            checkPassShow.Name = "checkPassShow";
            checkPassShow.Size = new Size(67, 24);
            checkPassShow.TabIndex = 25;
            checkPassShow.Text = "Show";
            checkPassShow.UseVisualStyleBackColor = true;
            checkPassShow.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkPassShow);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(btnMax);
            Controls.Add(linkForgotPassword);
            Controls.Add(linkRegister);
            Controls.Add(panel1);
            Controls.Add(btnSubmit);
            Controls.Add(txtUserPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserEmail);
            Controls.Add(lblUsername);
            Controls.Add(btnMin);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnClose;
        private Button btnMax;
        private LinkLabel linkForgotPassword;
        private LinkLabel linkRegister;
        private Panel panel1;
        private Button btnSubmit;
        private TextBox txtUserPassword;
        private Label lblPassword;
        private TextBox txtUserEmail;
        private Label lblUsername;
        private Button btnMin;
        private CheckBox checkPassShow;
    }
}
