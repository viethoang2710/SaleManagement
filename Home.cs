using System;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void NavigateToForm(Form childForm)
        {
            childForm.Show();
            this.Hide();
            childForm.FormClosed += (s, args) => this.Show();
        }

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            NavigateToForm(new CustomerManagement());
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            NavigateToForm(new ProductManagement());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnSaleManagement_Click(object sender, EventArgs e)
        {
            NavigateToForm(new SaleManagement());
        }
    }
}
