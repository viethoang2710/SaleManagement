namespace SalesManagement
{
    partial class ProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagement));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAddProduct = new Button();
            btnEditProduct = new Button();
            btnDeleteProduct = new Button();
            btnBackProduct = new Button();
            dgvProductManagement = new DataGridView();
            txtProductID = new TextBox();
            txtProductName = new TextBox();
            txtSearch = new TextBox();
            txtDescription = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            label6 = new Label();
            pbLogo = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductManagement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 92);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Product ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 130);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 163);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 198);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 236);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(639, 134);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(94, 29);
            btnAddProduct.TabIndex = 5;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(639, 178);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(94, 29);
            btnEditProduct.TabIndex = 6;
            btnEditProduct.Text = "Edit";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(639, 216);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(94, 29);
            btnDeleteProduct.TabIndex = 7;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnBackProduct
            // 
            btnBackProduct.Location = new Point(18, 483);
            btnBackProduct.Name = "btnBackProduct";
            btnBackProduct.Size = new Size(94, 29);
            btnBackProduct.TabIndex = 8;
            btnBackProduct.Text = "Back";
            btnBackProduct.UseVisualStyleBackColor = true;
            btnBackProduct.Click += button4_Click;
            // 
            // dgvProductManagement
            // 
            dgvProductManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductManagement.Location = new Point(47, 280);
            dgvProductManagement.Name = "dgvProductManagement";
            dgvProductManagement.RowHeadersWidth = 51;
            dgvProductManagement.Size = new Size(710, 188);
            dgvProductManagement.TabIndex = 9;
            dgvProductManagement.CellClick += dgvProductManagement_CellClick;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(197, 85);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(125, 27);
            txtProductID.TabIndex = 10;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(197, 123);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 11;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(504, 78);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(192, 27);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(197, 227);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 12;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(197, 191);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 15;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(197, 156);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(422, 85);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 16;
            label6.Text = "Search";
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(139, 64);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 17;
            pbLogo.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(237, 22);
            label7.Name = "label7";
            label7.Size = new Size(382, 41);
            label7.TabIndex = 18;
            label7.Text = "PRODUCT MANAGEMENT";
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(788, 524);
            Controls.Add(label7);
            Controls.Add(pbLogo);
            Controls.Add(label6);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtSearch);
            Controls.Add(txtDescription);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(dgvProductManagement);
            Controls.Add(btnBackProduct);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnEditProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductManagement";
            Text = "ProductManagement";
            ((System.ComponentModel.ISupportInitialize)dgvProductManagement).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAddProduct;
        private Button btnEditProduct;
        private Button btnDeleteProduct;
        private Button btnBackProduct;
        private DataGridView dgvProductManagement;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private TextBox txtSearch;
        private TextBox txtDescription;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Label label6;
        private PictureBox pbLogo;
        private Label label7;
    }
}