namespace UserManagement
{
    partial class AdminDashboard
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
            textEmpID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textEmpName = new TextBox();
            label3 = new Label();
            textEmpSalary = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBoxDepart = new ComboBox();
            comboBoxGender = new ComboBox();
            btnAdd = new Button();
            btnClear = new Button();
            label6 = new Label();
            btnBack = new Button();
            dataFetchUser = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            textSearch = new TextBox();
            btnSearch = new Button();
            btncr = new Button();
            ((System.ComponentModel.ISupportInitialize)dataFetchUser).BeginInit();
            SuspendLayout();
            // 
            // textEmpID
            // 
            textEmpID.BorderStyle = BorderStyle.FixedSingle;
            textEmpID.Location = new Point(120, 100);
            textEmpID.Multiline = true;
            textEmpID.Name = "textEmpID";
            textEmpID.Size = new Size(175, 34);
            textEmpID.TabIndex = 0;
            textEmpID.TextChanged += textEmpID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 102);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Emp ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 158);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 3;
            label2.Text = "Emp Name";
            // 
            // textEmpName
            // 
            textEmpName.BorderStyle = BorderStyle.FixedSingle;
            textEmpName.Location = new Point(120, 155);
            textEmpName.Multiline = true;
            textEmpName.Name = "textEmpName";
            textEmpName.Size = new Size(175, 34);
            textEmpName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 209);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 5;
            label3.Text = "Salary";
            // 
            // textEmpSalary
            // 
            textEmpSalary.BorderStyle = BorderStyle.FixedSingle;
            textEmpSalary.Location = new Point(120, 206);
            textEmpSalary.Multiline = true;
            textEmpSalary.Name = "textEmpSalary";
            textEmpSalary.Size = new Size(175, 34);
            textEmpSalary.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 264);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 7;
            label4.Text = "Department";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 317);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 9;
            label5.Text = "Gender";
            // 
            // comboBoxDepart
            // 
            comboBoxDepart.FormattingEnabled = true;
            comboBoxDepart.Items.AddRange(new object[] { "IT", "CSE", "ECE", "EEE", "MECH", "CHEM", "AI & ML" });
            comboBoxDepart.Location = new Point(120, 261);
            comboBoxDepart.Name = "comboBoxDepart";
            comboBoxDepart.Size = new Size(175, 28);
            comboBoxDepart.TabIndex = 10;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "MALE", "FEMALE" });
            comboBoxGender.Location = new Point(120, 317);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(175, 28);
            comboBoxGender.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.MenuHighlight;
            btnAdd.FlatStyle = FlatStyle.System;
            btnAdd.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(120, 367);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.MenuHighlight;
            btnClear.FlatStyle = FlatStyle.System;
            btnClear.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(238, 367);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(57, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 57);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(255, 23);
            label6.TabIndex = 14;
            label6.Text = "Add Company Employee Detail";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.MenuHighlight;
            btnBack.FlatStyle = FlatStyle.System;
            btnBack.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(69, 29);
            btnBack.TabIndex = 15;
            btnBack.Text = "< back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += button1_Click;
            // 
            // dataFetchUser
            // 
            dataFetchUser.BackgroundColor = SystemColors.ActiveCaption;
            dataFetchUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataFetchUser.Location = new Point(332, 57);
            dataFetchUser.Name = "dataFetchUser";
            dataFetchUser.RowHeadersWidth = 51;
            dataFetchUser.Size = new Size(735, 381);
            dataFetchUser.TabIndex = 16;
            dataFetchUser.CellContentClick += dataFetchUser_CellContentClick;
            dataFetchUser.CellContentDoubleClick += dataFetchUser_CellDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.MenuHighlight;
            btnDelete.FlatStyle = FlatStyle.System;
            btnDelete.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(238, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(57, 29);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.MenuHighlight;
            btnUpdate.FlatStyle = FlatStyle.System;
            btnUpdate.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(120, 409);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(69, 29);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textSearch
            // 
            textSearch.BorderStyle = BorderStyle.FixedSingle;
            textSearch.Location = new Point(332, 18);
            textSearch.Multiline = true;
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Search user list based on ID, Name, Salary, Department and Gender";
            textSearch.Size = new Size(608, 27);
            textSearch.TabIndex = 19;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.MenuHighlight;
            btnSearch.FlatStyle = FlatStyle.System;
            btnSearch.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(946, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(69, 29);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btncr
            // 
            btncr.BackColor = SystemColors.MenuHighlight;
            btncr.FlatStyle = FlatStyle.System;
            btncr.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncr.Location = new Point(1021, 18);
            btncr.Name = "btncr";
            btncr.Size = new Size(40, 29);
            btncr.TabIndex = 21;
            btncr.Text = "X";
            btncr.UseVisualStyleBackColor = false;
            btncr.Click += btncr_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(1079, 458);
            Controls.Add(btncr);
            Controls.Add(btnSearch);
            Controls.Add(textSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dataFetchUser);
            Controls.Add(btnBack);
            Controls.Add(label6);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(comboBoxGender);
            Controls.Add(comboBoxDepart);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textEmpSalary);
            Controls.Add(label2);
            Controls.Add(textEmpName);
            Controls.Add(label1);
            Controls.Add(textEmpID);
            ForeColor = Color.Cornsilk;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            ((System.ComponentModel.ISupportInitialize)dataFetchUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textEmpID;
        private Label label1;
        private Label label2;
        private TextBox textEmpName;
        private Label label3;
        private TextBox textEmpSalary;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxDepart;
        private ComboBox comboBoxGender;
        private Button btnAdd;
        private Button btnClear;
        private Label label6;
        private Button btnBack;
        private DataGridView dataFetchUser;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox textSearch;
        private Button btnSearch;
        private Button btncr;
    }
}