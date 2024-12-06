using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement
{
    public partial class CustomerManagement : Form
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();

        public CustomerManagement()
        {
            InitializeComponent();
            LoadCustomerData();
            LoadProductNamesToComboBox();
        }


        private void LoadProductNamesToComboBox()
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    string query = "SELECT ProductName FROM Products";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Clear ComboBox before adding items
                    cmbPurchaseOrder.Items.Clear();

                    // Add products to ComboBox
                    while (reader.Read())
                    {
                        cmbPurchaseOrder.Items.Add(reader["ProductName"].ToString());
                    }
                    connection.Close();
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void LoadCustomerData()
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    //connection.Open();
                    string query = "SELECT * FROM Customers";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCustomerManagement.DataSource = dt;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtNumberPhone.Clear();
            cmbPurchaseOrder.Items.Clear();
            txtSearch.Clear();
            dtpDateOfPurchase.Value = DateTime.Now;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCustomerID.Text) || string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtNumberPhone.Text) || string.IsNullOrWhiteSpace(cmbPurchaseOrder.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var connection = dbConnection.GetConnection())
                {
                    //connection.Open();
                    string query = "INSERT INTO Customers (CustomerID, CustomerName, NumberPhone, PurchaseOrder, DateOfPurchase) VALUES (@CustomerID, @CustomerName, @NumberPhone, @PurchaseOrder, @DateOfPurchase)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text.Trim());
                    cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text.Trim());
                    cmd.Parameters.AddWithValue("@NumberPhone", txtNumberPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@PurchaseOrder", cmbPurchaseOrder.SelectedItem.ToString().Trim());
                    cmd.Parameters.AddWithValue("@DateOfPurchase", dtpDateOfPurchase.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadCustomerData();
                    ClearInputs();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var connection = dbConnection.GetConnection())
                    {
                        //connection.Open();
                        string query = "UPDATE Customers SET CustomerName = @CustomerName, NumberPhone = @NumberPhone, PurchaseOrder = @PurchaseOrder, DateOfPurchase = @DateOfPurchase WHERE CustomerID = @CustomerID";
                        SqlCommand cmd = new SqlCommand(query, connection);

                        cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text.Trim());
                        cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text.Trim());
                        cmd.Parameters.AddWithValue("@NumberPhone", txtNumberPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@PurchaseOrder", cmbPurchaseOrder.Text.Trim());
                        cmd.Parameters.AddWithValue("@DateOfPurchase", dtpDateOfPurchase.Value);

                        cmd.ExecuteNonQuery();
                        LoadCustomerData();
                        ClearInputs();
                        MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var connection = dbConnection.GetConnection())
                    {
                        //connection.Open();
                        string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text.Trim());

                        cmd.ExecuteNonQuery();

                        LoadCustomerData();
                        ClearInputs();
                        MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    //connection.Open();
                    string query = "SELECT * FROM Customers WHERE PurchaseOrder LIKE @SearchText";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@SearchText", $"%{txtSearch.Text.Trim()}%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCustomerManagement.DataSource = dt;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCustomerManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCustomerManagement.Rows[e.RowIndex];

                // Populate the textboxes with data from the selected row
                txtCustomerID.Text = selectedRow.Cells["CustomerID"].Value.ToString();
                txtCustomerName.Text = selectedRow.Cells["CustomerName"].Value.ToString();
                txtNumberPhone.Text = selectedRow.Cells["NumberPhone"].Value.ToString();
                cmbPurchaseOrder.Text = selectedRow.Cells["PurchaseOrder"].Value.ToString();

                // If the DateOfPurchase is not null, set the DateTimePicker's value
                if (selectedRow.Cells["DateOfPurchase"].Value != DBNull.Value)
                {
                    dtpDateOfPurchase.Value = Convert.ToDateTime(selectedRow.Cells["DateOfPurchase"].Value);
                }
            }
        }



        private void btnBackCustomer_Click_1(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Close();
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {

        }
    }
}

