using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace UserManagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            txtPassword.PasswordChar = '*';
            txtNewPassword.PasswordChar = '*';

            // Add the event handler for the CheckBox
            passwordCheckbox.CheckedChanged += new EventHandler(this.checkBox2_CheckedChanged);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {


            // Trimmed input values
            string firstName = txtFirstname.Text.Trim();
            string secondName = txtSecondname.Text.Trim();
            string mobile = txtMobile.Text.Trim();
            string password = txtPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string address1 = txtAdd1.Text.Trim();
            string address2 = txtAdd2.Text.Trim();
            string email = txtEmail.Text.Trim();

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string mobilePattern = @"^\d{10}$"; // Assumes a 10-digit phone number



            if (firstName != "" && secondName != "" && mobile != "" && password != ""
                && address1 != "" && address2 != "" && email != "")
            {


                if (password == newPassword && newPassword.Length > 8)
                {
                    if (Regex.IsMatch(email, emailPattern))
                    {
                        if (Regex.IsMatch(mobile, mobilePattern))
                        {

                            if (passwordCheckbox.Checked)
                            {
                                fnCallInsertQuary();
                            }
                            else
                            {
                                MessageBox.Show("Accept Terms and Condition");
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Invalid phone number");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email address");
                    }
                }
                else
                {
                    MessageBox.Show("Password mismatched or too short length of password");
                }
            }
            else
            {
                MessageBox.Show("All fields are required");
            }

        }
        private void fnCallInsertQuary()
        {

            try
            {
                SqlConnection sql = new SqlConnection("Data Source=SASI-PC\\MICROSOFTSQL;Initial Catalog=db_usermanagement;Integrated Security=True");
                sql.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_usermanagement", sql);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = new SqlParameter("@first_name", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txtFirstname.Text;

                SqlParameter param2 = new SqlParameter("@last_name", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value = txtSecondname.Text;

                SqlParameter param3 = new SqlParameter("@email", SqlDbType.VarChar);
                cmd.Parameters.Add(param3).Value = txtEmail.Text;

                SqlParameter param4 = new SqlParameter("@phone", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = txtMobile.Text;

                SqlParameter param5 = new SqlParameter("@set_password", SqlDbType.VarChar);
                cmd.Parameters.Add(param5).Value = txtNewPassword.Text;

                SqlParameter param6 = new SqlParameter("@address_line_one", SqlDbType.VarChar);
                cmd.Parameters.Add(param6).Value = txtAdd1.Text;

                SqlParameter param7 = new SqlParameter("@address_line_two", SqlDbType.VarChar);
                cmd.Parameters.Add(param7).Value = txtAdd2.Text;

                int exe = cmd.ExecuteNonQuery();
                
                if (exe > 0)
                {
                    MessageBox.Show("User registered successfully");
                }
                else
                {
                    MessageBox.Show("Tyr Again Later");
                }
                sql.Close();

            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000) // Error number for RAISERROR in the stored procedure
                {
                    MessageBox.Show(ex.Message);
                }
                else
                {
                    MessageBox.Show("An error occurred while registering the user");
                }
            }
        }

        private void txtSecondname_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheckbox.Checked)
            {
                // Show the password
                txtPassword.PasswordChar = '\0';
                txtNewPassword.PasswordChar = '\0';
            }
            else
            {
                // Hide the password
                txtPassword.PasswordChar = '*';
                txtNewPassword.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           txtFirstname.Text = "";
           txtSecondname.Text = "";
           txtMobile.Text = "";
           txtPassword.Text = "";
           txtNewPassword.Text = "";
           txtAdd1.Text = "";
           txtAdd2.Text = "";
           txtEmail.Text = "";
            passwordCheckbox.Checked = false;
            txtPassword.PasswordChar = '*';
            txtNewPassword.PasswordChar = '*';

        }
    }
}
