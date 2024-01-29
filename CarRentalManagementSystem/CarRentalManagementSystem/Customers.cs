using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem
{
    public partial class Customers : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\reald\\OneDrive\\Documents\\CarRentalManagementSystemDb.mdf;Integrated Security=True;Connect Timeout=30");

        public Customers()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!AreFieldsEmpty())
            {
                if (IsValidPhoneNumber(txtPhone.Text))
                {
                    InsertCustomerData();
                    ClearFields();
                    LoadCustomerData();
                }
                else
                {
                    MessageBox.Show("Invalid phone number format. Please enter a valid phone number. Phone number starts with 0 then 7/9 and 8 digits", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You must fill every value!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private bool IsValidPhoneNumber(string phoneNumber)
        {

            string phonePattern = @"^0[79]\d{8}$";

            return Regex.IsMatch(phoneNumber, phonePattern);
        }


        private void InsertCustomerData()
        {
            try
            {
                con.Open();


                string query = "INSERT INTO CustomerTb1 (CustName, CustAdd, CustPhone) VALUES (@CustName, @CustAdd, @CustPhone)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@CustName", txtCustName.Text);
                    cmd.Parameters.AddWithValue("@CustAdd", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@CustPhone", txtPhone.Text);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Customer data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }



        private void LoadCustomerData()
        {
            try
            {

                con.Open();


                string query = "SELECT * FROM CustomerTb1";


                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable customerDataTable = new DataTable();


                adapter.Fill(customerDataTable);


                dgvCustomer.DataSource = customerDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
            }
        }



        private void ClearFields()
        {
            txtCustName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

        private bool AreFieldsEmpty()
        {
            return string.IsNullOrWhiteSpace(txtCustName.Text) ||
                   string.IsNullOrWhiteSpace(txtAddress.Text) ||
                   string.IsNullOrWhiteSpace(txtPhone.Text);
        }




        private void Customers_Load(object sender, EventArgs e)
        {
            LoadCustomerData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedCustomer();
        }
        private void DeleteSelectedCustomer()
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvCustomer.SelectedRows[0];


                if (selectedRow.Cells["CustId"].Value != null && int.TryParse(selectedRow.Cells["CustId"].Value.ToString(), out int customerId))
                {
                    try
                    {

                        con.Open();


                        string deleteQuery = "DELETE FROM CustomerTb1 WHERE CustId = @CustomerId";


                        using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@CustomerId", customerId);


                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                con.Close();
                                LoadCustomerData();
                            }
                            else
                            {
                                MessageBox.Show("Error deleting the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void UpdateSelectedCustomer()
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                try
                {
                    con.Open();


                    string query = "UPDATE CustomerTb1 SET CustName = @CustName, CustAdd = @CustAdd, CustPhone = @CustPhone WHERE CustId = @CId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@CustName", txtCustName.Text);
                        cmd.Parameters.AddWithValue("@CustAdd", txtAddress.Text);

                        string custPhone = txtPhone.Text;
                        if (Regex.IsMatch(custPhone, @"^0[79]\d{8}$"))
                        {
                            cmd.Parameters.AddWithValue("@CustPhone", custPhone);
                        }
                        else
                        {
                            MessageBox.Show("Invalid phone number format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }


                        cmd.Parameters.AddWithValue("@CId", Convert.ToInt32(dgvCustomer.SelectedRows[0].Cells["CustId"].Value));


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Customer data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();

                        LoadCustomerData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a customer from the data grid view.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }






        private void dgvCustomer_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvCustomer.SelectedRows[0];


                txtCustName.Text = selectedRow.Cells["CustName"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["CustAdd"].Value.ToString();


                string custPhone = selectedRow.Cells["CustPhone"].Value?.ToString();
                if (!string.IsNullOrEmpty(custPhone) && Regex.IsMatch(custPhone, @"^0[79]\d{8}$"))
                {
                    txtPhone.Text = custPhone;
                }
                else
                {

                    txtPhone.Text = string.Empty;
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UpdateSelectedCustomer();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmMain car = new frmMain();
            car.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Rent rent = new Rent();
            rent.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Return return2 = new Return();
            return2.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
