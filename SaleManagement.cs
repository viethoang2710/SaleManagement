using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SalesManagement
{
    public partial class SaleManagement : Form
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();
        public SaleManagement()
        {
            InitializeComponent();
            LoadSaleData();
        }

        private void LoadSaleData()
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    string query = "SELECT * FROM Sales";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSaleManagement.DataSource = dt;
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
            txtSaleID.Clear();
            txtCustomerIDSale.Clear();
            txtProductIDSale.Clear();
            dtpSaleDate.Value = DateTime.Now;
            txtSearchSale.Clear();
        }


        private void dgvSaleManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvSaleManagement.Rows[e.RowIndex];

                txtSaleID.Text = selectedRow.Cells["SaleID"].Value.ToString();
                txtCustomerIDSale.Text = selectedRow.Cells["CustomerID"].Value.ToString();
                txtProductIDSale.Text = selectedRow.Cells["ProductID"].Value.ToString();
                dtpSaleDate.Value = Convert.ToDateTime(selectedRow.Cells["SaleDate"].Value);
            }
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCustomerIDSale.Text) || string.IsNullOrWhiteSpace(txtProductIDSale.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var connection = dbConnection.GetConnection())
                {
                    string query = "INSERT INTO Sales (CustomerID, ProductID, SaleDate) VALUES (@CustomerID, @ProductID, @SaleDate)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@CustomerID", txtCustomerIDSale.Text.Trim());
                    cmd.Parameters.AddWithValue("@ProductID", txtProductIDSale.Text.Trim());
                    cmd.Parameters.AddWithValue("@SaleDate", dtpSaleDate.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sale added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadSaleData();
                    ClearInputs();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpSaleDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpSaleDate.Value > DateTime.Now)
            {
                MessageBox.Show("Sale Date cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }


        private void btnEditSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Do you want to edit this sale?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var connection = dbConnection.GetConnection())
                    {
                        string query = "UPDATE Sales SET CustomerID = @CustomerID, ProductID = @ProductID, SaleDate = @SaleDate WHERE SaleID = @SaleID";
                        SqlCommand cmd = new SqlCommand(query, connection);

                        cmd.Parameters.AddWithValue("@SaleID", txtSaleID.Text.Trim());
                        cmd.Parameters.AddWithValue("@CustomerID", txtCustomerIDSale.Text.Trim());
                        cmd.Parameters.AddWithValue("@ProductID", txtProductIDSale.Text.Trim());
                        cmd.Parameters.AddWithValue("@SaleDate", dtpSaleDate.Value);

                        cmd.ExecuteNonQuery();
                        LoadSaleData();
                        ClearInputs();
                        MessageBox.Show("Sale updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Do you want to delete this sale?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var connection = dbConnection.GetConnection())
                    {
                        string query = "DELETE FROM Sales WHERE SaleID = @SaleID";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@SaleID", txtSaleID.Text.Trim());

                        cmd.ExecuteNonQuery();
                        LoadSaleData();
                        ClearInputs();
                        MessageBox.Show("Sale deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchSale_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    string query = "SELECT * FROM Sales WHERE ProductID LIKE @SearchText";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@SearchText", $"%{txtSearchSale.Text.Trim()}%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSaleManagement.DataSource = dt;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaleBack_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Close();
        }
    }
}



