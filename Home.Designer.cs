namespace SalesManagement
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnProductManagement = new Button();
            btnCustomerManagement = new Button();
            btnLogout = new Button();
            pbLogo = new PictureBox();
            btnSaleManagement = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // btnProductManagement
            // 
            btnProductManagement.Location = new Point(507, 233);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(182, 29);
            btnProductManagement.TabIndex = 0;
            btnProductManagement.Text = "Product Management";
            btnProductManagement.UseVisualStyleBackColor = true;
            btnProductManagement.Click += btnProductManagement_Click;
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.Location = new Point(97, 233);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new Size(182, 29);
            btnCustomerManagement.TabIndex = 2;
            btnCustomerManagement.Text = "Customer Management";
            btnCustomerManagement.UseVisualStyleBackColor = true;
            btnCustomerManagement.Click += btnCustomerManagement_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(34, 392);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(139, 64);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            // 
            // btnSaleManagement
            // 
            btnSaleManagement.Location = new Point(318, 320);
            btnSaleManagement.Name = "btnSaleManagement";
            btnSaleManagement.Size = new Size(161, 29);
            btnSaleManagement.TabIndex = 5;
            btnSaleManagement.Text = "Sale Management";
            btnSaleManagement.UseVisualStyleBackColor = true;
            btnSaleManagement.Click += btnSaleManagement_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaleManagement);
            Controls.Add(pbLogo);
            Controls.Add(btnLogout);
            Controls.Add(btnCustomerManagement);
            Controls.Add(btnProductManagement);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductManagement;
        private Button btnCustomerManagement;
        private Button btnLogout;
        private PictureBox pbLogo;
        private Button btnSaleManagement;
    }
}