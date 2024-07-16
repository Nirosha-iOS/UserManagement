using System.Data;
using System.Data.SqlClient;

namespace UserManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 register = new Form2();
            register.Show();
            this.Hide();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string txtuser = txtUserEmail.Text.Trim();
            string txtpass = txtUserPassword.Text.Trim();

            if (txtuser != "" && txtpass != "")
            {
                if (txtuser.ToLower() == "Admin".ToLower() && txtpass.ToLower() == "12345678".ToLower())
                {
                    AdminDashboard dashboard = new AdminDashboard();
                    dashboard.Show();
                    this.Hide();

                }else
                {
                    fnloginSubmit();
                }
                
            }
            else
            {
                MessageBox.Show("Enter Corrext User email and Password for login");
            }
        }

        private void fnloginSubmit()
        {

            try
            {
                using (SqlConnection sql = new SqlConnection("Data Source=SASI-PC\\MICROSOFTSQL;Initial Catalog=db_usermanagement;Integrated Security=True"))
                {
                    sql.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_login_user", sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Email", txtUserEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtUserPassword.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Read user data if login is successful
                                reader.Read();
                                string firstName = reader["first_name"].ToString();
                                string lastName = reader["last_name"].ToString();
                                string email = reader["email"].ToString();
                                string phone = reader["phone"].ToString();
                                string address1 = reader["address_line_one"].ToString();
                                string address2 = reader["address_line_two"].ToString();

                                MessageBox.Show(firstName + " Successfully Logged In");

                                HomePage homePage = new HomePage(firstName, lastName, email, phone, address1, address2);
                                homePage.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Enter login details correctly");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while logging in: " + ex.Message);
            }




            /*try
            {
                SqlConnection sql = new SqlConnection("Data Source=SASI-PC\\MICROSOFTSQL;Initial Catalog=db_usermanagement;Integrated Security=True");
                sql.Open();
                SqlCommand cmd = new SqlCommand("sp_login_user", sql);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = new SqlParameter("@email", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txtUserEmail.Text;

                SqlParameter param2 = new SqlParameter("@password", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value = txtUserPassword.Text;
                int exe = cmd.ExecuteNonQuery();
                if (exe == 0)
                {
                    MessageBox.Show("Successfully Logged In");

                    HomePage homePage = new HomePage();
                    homePage.Show();
                    this.Hide();

                }else
                {
                    MessageBox.Show("Enter login details correctly");
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
                    MessageBox.Show("An error occurred while login the user");
                }

            }
            */
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkPassShow.Checked)
            {
                txtUserPassword.PasswordChar = '\0';
            }
            else
            {
                txtUserPassword.PasswordChar = '*';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }


        }

    }
}
