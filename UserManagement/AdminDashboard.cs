using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserManagement
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            btnDelete.Visible = false;
            btnUpdate.Visible = false;

            this.dataFetchUser.CellFormatting += new DataGridViewCellFormattingEventHandler(dataFetchUser_CellFormatting);
            this.dataFetchUser.CellDoubleClick += new DataGridViewCellEventHandler(dataFetchUser_CellDoubleClick);
            fnClear();
            fnGetEmployeeList();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fnClear();

        }




        private void fnClear()
        {

            btnDelete.Visible = false;
            btnUpdate.Visible = false;

            textEmpID.Clear();
            textEmpName.Clear();
            textEmpSalary.Clear();
            comboBoxDepart.SelectedIndex = -1;
            comboBoxGender.SelectedIndex = -1;

            textEmpID.ReadOnly = false;
            textEmpID.BackColor = Color.White;

        }

        private void fnGetEmployeeList()
        {
            // Connection string
            string connectionString = "Data Source=SASI-PC\\MICROSOFTSQL;Initial Catalog=db_usermanagement;Integrated Security=True";

            // SQL connection
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                // SQL command
                using (SqlCommand sqlCommand = new SqlCommand("sp_get_all_employees", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // SQL data adapter
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        // Data table
                        DataTable dataTable = new DataTable();

                        // Fill the data table
                        sqlDataAdapter.Fill(dataTable);

                        // Bind the data table to the DataGridView
                        dataFetchUser.DataSource = dataTable;
                    }
                }
            }
        }

        // Handle CellFormatting event to set the default text color
        private void dataFetchUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!dataFetchUser.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.ForeColor = Color.Black; // Change to your preferred selection color
            }

        }

        // Handle CellDoubleClick event to select the row and display cell value in TextBox
        private void dataFetchUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                textEmpID.Text = dataFetchUser.SelectedRows[0].Cells[0].Value.ToString();
                textEmpName.Text = dataFetchUser.SelectedRows[0].Cells[1].Value.ToString();
                textEmpSalary.Text = dataFetchUser.SelectedRows[0].Cells[2].Value.ToString();
                comboBoxGender.Text = dataFetchUser.SelectedRows[0].Cells[3].Value.ToString();
                comboBoxDepart.Text = dataFetchUser.SelectedRows[0].Cells[4].Value.ToString();
                textEmpID.ReadOnly = true;
                textEmpID.BackColor = Color.LightGray;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
            }
        }




        private void textEmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textEmpID.Text.Trim() != "" && textEmpName.Text.Trim() != "" &&
               textEmpSalary.Text.Trim() != "" && comboBoxDepart.Text.Trim() != "" && comboBoxGender.Text.Trim() != "")
            {

                try
                {
                    SqlConnection sql = new SqlConnection("Data Source=SASI-PC\\MICROSOFTSQL;Initial Catalog=db_usermanagement;Integrated Security=True");
                    sql.Open();
                    SqlCommand cmd = new SqlCommand("sp_tbl_useradd", sql);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EMPID", textEmpID.Text.Trim());
                    cmd.Parameters.AddWithValue("@EMPNAME", textEmpName.Text.Trim());
                    cmd.Parameters.AddWithValue("@SALARY", textEmpSalary.Text.Trim());
                    cmd.Parameters.AddWithValue("@GENDER", comboBoxGender.Text.Trim());
                    cmd.Parameters.AddWithValue("@DEPARTMENT", comboBoxDepart.Text.Trim());
                    int ex = cmd.ExecuteNonQuery();
                    if (ex > 0)
                    {
                        MessageBox.Show("Employee Details Added successfully");
                        fnClear();
                        fnGetEmployeeList();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Message = " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fill all the fields");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void dataFetchUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Are you sure you want to update?", "Update Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                if (textEmpID.Text.Trim() != "" && textEmpName.Text.Trim() != "" &&
              textEmpSalary.Text.Trim() != "" && comboBoxDepart.Text.Trim() != "" && comboBoxGender.Text.Trim() != "")
                {

                    try
                    {
                        SqlConnection sql = new SqlConnection("Data Source=SASI-PC\\MICROSOFTSQL;Initial Catalog=db_usermanagement;Integrated Security=True");
                        sql.Open();
                        SqlCommand cmd = new SqlCommand("sp_update_user", sql);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EMPID", textEmpID.Text.Trim());
                        cmd.Parameters.AddWithValue("@EMPNAME", textEmpName.Text.Trim());
                        cmd.Parameters.AddWithValue("@SALARY", textEmpSalary.Text.Trim());
                        cmd.Parameters.AddWithValue("@GENDER", comboBoxGender.Text.Trim());
                        cmd.Parameters.AddWithValue("@DEPARTMENT", comboBoxDepart.Text.Trim());
                        int ex = cmd.ExecuteNonQuery();
                        if (ex > 0)
                        {
                            MessageBox.Show("Employee Details Updated successfully");
                            // fnClear();
                            fnGetEmployeeList();


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Message = " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Fill all the fields");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Delete?", "Delete Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sql = new SqlConnection("Data Source=SASI-PC\\MICROSOFTSQL;Initial Catalog=db_usermanagement;Integrated Security=True");
                    sql.Open();
                    SqlCommand cmd = new SqlCommand("sp_delete_user", sql);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EMPID", textEmpID.Text.Trim());

                    int ex = cmd.ExecuteNonQuery();
                    if (ex > 0)
                    {
                        MessageBox.Show("Employee Details Deleted successfully");
                        fnClear();
                        fnGetEmployeeList();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Message = " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (textSearch.Text.Trim().Length != 0)
            {
                try
                {
                    // Connection string
                    string connectionString = "Data Source=SASI-PC\\MICROSOFTSQL;Initial Catalog=db_usermanagement;Integrated Security=True";

                    // SQL connection
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();

                        // SQL command
                        using (SqlCommand sqlCommand = new SqlCommand("sp_tbl_search_user", sqlConnection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.Parameters.AddWithValue("@TEXTSEARCH", textSearch.Text.Trim());

                            // SQL data adapter
                            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                            {
                                // Data table
                                DataTable dataTable = new DataTable();

                                // Fill the data table
                                sqlDataAdapter.Fill(dataTable);

                                // Bind the data table to the DataGridView
                                dataFetchUser.DataSource = dataTable;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Message = " + ex.Message);
                }
            }

        }

        private void btncr_Click(object sender, EventArgs e)
        {
            if (textSearch.Text.Trim().Length != 0)
            {
                textSearch.Text = "";
                fnGetEmployeeList();
            }
        }
    }
}
