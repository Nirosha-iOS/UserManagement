namespace UserManagement
{
    partial class Form2
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
            panel2 = new Panel();
            lblRegisterTitle = new Label();
            linkAlreadyUser = new LinkLabel();
            btnRegister = new Button();
            checkBoxTC = new CheckBox();
            txtAdd1 = new TextBox();
            txtAdd2 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtEmail = new TextBox();
            txtMobile = new TextBox();
            txtFirstname = new TextBox();
            panel1 = new Panel();
            txtSecondname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            passwordCheckbox = new CheckBox();
            btnClear = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(lblRegisterTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 54);
            panel2.TabIndex = 46;
            // 
            // lblRegisterTitle
            // 
            lblRegisterTitle.AutoSize = true;
            lblRegisterTitle.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegisterTitle.ForeColor = SystemColors.ControlLight;
            lblRegisterTitle.Location = new Point(274, 20);
            lblRegisterTitle.Name = "lblRegisterTitle";
            lblRegisterTitle.Size = new Size(232, 20);
            lblRegisterTitle.TabIndex = 0;
            lblRegisterTitle.Text = "User Management Register";
            // 
            // linkAlreadyUser
            // 
            linkAlreadyUser.AutoSize = true;
            linkAlreadyUser.LinkColor = Color.FromArgb(64, 0, 0);
            linkAlreadyUser.Location = new Point(504, 315);
            linkAlreadyUser.Name = "linkAlreadyUser";
            linkAlreadyUser.Size = new Size(171, 20);
            linkAlreadyUser.TabIndex = 45;
            linkAlreadyUser.TabStop = true;
            linkAlreadyUser.Text = "Already registered User?";
            linkAlreadyUser.LinkClicked += linkRegister_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.MenuHighlight;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = SystemColors.ControlLight;
            btnRegister.Location = new Point(274, 311);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(129, 29);
            btnRegister.TabIndex = 44;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // checkBoxTC
            // 
            checkBoxTC.AutoSize = true;
            checkBoxTC.ForeColor = SystemColors.MenuHighlight;
            checkBoxTC.Location = new Point(39, 311);
            checkBoxTC.Name = "checkBoxTC";
            checkBoxTC.Size = new Size(218, 24);
            checkBoxTC.TabIndex = 43;
            checkBoxTC.Text = "Accept Terms and Condition";
            checkBoxTC.UseVisualStyleBackColor = true;
            // 
            // txtAdd1
            // 
            txtAdd1.BackColor = SystemColors.ActiveBorder;
            txtAdd1.BorderStyle = BorderStyle.FixedSingle;
            txtAdd1.Font = new Font("Arial Rounded MT Bold", 10.2F);
            txtAdd1.Location = new Point(140, 256);
            txtAdd1.Multiline = true;
            txtAdd1.Name = "txtAdd1";
            txtAdd1.Size = new Size(185, 27);
            txtAdd1.TabIndex = 7;
            // 
            // txtAdd2
            // 
            txtAdd2.BackColor = SystemColors.ActiveBorder;
            txtAdd2.BorderStyle = BorderStyle.FixedSingle;
            txtAdd2.Font = new Font("Arial Rounded MT Bold", 10.2F);
            txtAdd2.Location = new Point(504, 256);
            txtAdd2.Multiline = true;
            txtAdd2.Name = "txtAdd2";
            txtAdd2.Size = new Size(185, 27);
            txtAdd2.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 9F, FontStyle.Bold);
            label7.Location = new Point(371, 256);
            label7.Name = "label7";
            label7.Size = new Size(97, 18);
            label7.TabIndex = 40;
            label7.Text = "Address Line 2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 9F, FontStyle.Bold);
            label8.Location = new Point(36, 256);
            label8.Name = "label8";
            label8.Size = new Size(97, 18);
            label8.TabIndex = 39;
            label8.Text = "Address Line 1";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ActiveBorder;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Arial Rounded MT Bold", 10.2F);
            txtPassword.Location = new Point(140, 209);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(185, 27);
            txtPassword.TabIndex = 5;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = SystemColors.ActiveBorder;
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Font = new Font("Arial Rounded MT Bold", 10.2F);
            txtNewPassword.Location = new Point(504, 209);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(185, 27);
            txtNewPassword.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ActiveBorder;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Arial Rounded MT Bold", 10.2F);
            txtEmail.Location = new Point(140, 157);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(185, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtMobile
            // 
            txtMobile.BackColor = SystemColors.ActiveBorder;
            txtMobile.BorderStyle = BorderStyle.FixedSingle;
            txtMobile.Font = new Font("Arial Rounded MT Bold", 10.2F);
            txtMobile.Location = new Point(504, 157);
            txtMobile.Multiline = true;
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(185, 27);
            txtMobile.TabIndex = 4;
            // 
            // txtFirstname
            // 
            txtFirstname.BackColor = SystemColors.ActiveBorder;
            txtFirstname.BorderStyle = BorderStyle.FixedSingle;
            txtFirstname.Font = new Font("Arial Rounded MT Bold", 10.2F);
            txtFirstname.Location = new Point(140, 100);
            txtFirstname.Multiline = true;
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(185, 27);
            txtFirstname.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 409);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 41);
            panel1.TabIndex = 33;
            // 
            // txtSecondname
            // 
            txtSecondname.BackColor = SystemColors.ActiveBorder;
            txtSecondname.BorderStyle = BorderStyle.FixedSingle;
            txtSecondname.Font = new Font("Arial Rounded MT Bold", 10.2F);
            txtSecondname.Location = new Point(504, 103);
            txtSecondname.Multiline = true;
            txtSecondname.Name = "txtSecondname";
            txtSecondname.Size = new Size(185, 25);
            txtSecondname.TabIndex = 2;
            txtSecondname.TextChanged += txtSecondname_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 9F, FontStyle.Bold);
            label6.Location = new Point(371, 209);
            label6.Name = "label6";
            label6.Size = new Size(119, 18);
            label6.TabIndex = 31;
            label6.Text = "Confirm Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9F, FontStyle.Bold);
            label5.Location = new Point(371, 157);
            label5.Name = "label5";
            label5.Size = new Size(107, 18);
            label5.TabIndex = 30;
            label5.Text = "Mobile Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9F, FontStyle.Bold);
            label4.Location = new Point(36, 209);
            label4.Name = "label4";
            label4.Size = new Size(99, 18);
            label4.TabIndex = 29;
            label4.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F, FontStyle.Bold);
            label3.Location = new Point(36, 157);
            label3.Name = "label3";
            label3.Size = new Size(57, 18);
            label3.TabIndex = 28;
            label3.Text = "Email Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F, FontStyle.Bold);
            label2.Location = new Point(371, 103);
            label2.Name = "label2";
            label2.Size = new Size(67, 18);
            label2.TabIndex = 27;
            label2.Text = "Lastname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9F, FontStyle.Bold);
            label1.Location = new Point(36, 103);
            label1.Name = "label1";
            label1.Size = new Size(70, 18);
            label1.TabIndex = 26;
            label1.Text = "Firstname";
            // 
            // passwordCheckbox
            // 
            passwordCheckbox.AutoSize = true;
            passwordCheckbox.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordCheckbox.Location = new Point(706, 212);
            passwordCheckbox.Name = "passwordCheckbox";
            passwordCheckbox.Size = new Size(63, 21);
            passwordCheckbox.TabIndex = 48;
            passwordCheckbox.Text = "Show";
            passwordCheckbox.UseVisualStyleBackColor = true;
            passwordCheckbox.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.MenuHighlight;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = SystemColors.ControlLight;
            btnClear.Location = new Point(434, 311);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(56, 29);
            btnClear.TabIndex = 50;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(passwordCheckbox);
            Controls.Add(panel2);
            Controls.Add(linkAlreadyUser);
            Controls.Add(btnRegister);
            Controls.Add(checkBoxTC);
            Controls.Add(txtAdd1);
            Controls.Add(txtAdd2);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtMobile);
            Controls.Add(txtFirstname);
            Controls.Add(panel1);
            Controls.Add(txtSecondname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblRegisterTitle;
        private LinkLabel linkAlreadyUser;
        private Button btnRegister;
        private CheckBox checkBoxTC;
        private TextBox txtAdd1;
        private TextBox txtAdd2;
        private Label label7;
        private Label label8;
        private TextBox txtPassword;
        private TextBox txtNewPassword;
        private TextBox txtEmail;
        private TextBox txtMobile;
        private TextBox txtFirstname;
        private Panel panel1;
        private TextBox txtSecondname;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox passwordCheckbox;
        private Button btnClear;
    }
}