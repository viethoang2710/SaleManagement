namespace SalesManagement
{
    partial class SaleManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleManagement));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpSaleDate = new DateTimePicker();
            txtSaleID = new TextBox();
            txtCustomerIDSale = new TextBox();
            txtProductIDSale = new TextBox();
            dgvSaleManagement = new DataGridView();
            btnAddSale = new Button();
            btnEditSale = new Button();
            btnDeleteSale = new Button();
            txtSearchSale = new TextBox();
            label5 = new Label();
            btnSaleBack = new Button();
            pbLogo = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSaleManagement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 102);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Sale ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 146);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 186);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Product ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 225);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Sale Date";
            // 
            // dtpSaleDate
            // 
            dtpSaleDate.Location = new Point(172, 220);
            dtpSaleDate.Name = "dtpSaleDate";
            dtpSaleDate.Size = new Size(250, 27);
            dtpSaleDate.TabIndex = 4;
            // 
            // txtSaleID
            // 
            txtSaleID.Location = new Point(172, 95);
            txtSaleID.Name = "txtSaleID";
            txtSaleID.Size = new Size(125, 27);
            txtSaleID.TabIndex = 5;
            // 
            // txtCustomerIDSale
            // 
            txtCustomerIDSale.Location = new Point(172, 139);
            txtCustomerIDSale.Name = "txtCustomerIDSale";
            txtCustomerIDSale.Size = new Size(125, 27);
            txtCustomerIDSale.TabIndex = 6;
            // 
            // txtProductIDSale
            // 
            txtProductIDSale.Location = new Point(172, 179);
            txtProductIDSale.Name = "txtProductIDSale";
            txtProductIDSale.Size = new Size(125, 27);
            txtProductIDSale.TabIndex = 7;
            // 
            // dgvSaleManagement
            // 
            dgvSaleManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaleManagement.Location = new Point(66, 288);
            dgvSaleManagement.Name = "dgvSaleManagement";
            dgvSaleManagement.RowHeadersWidth = 51;
            dgvSaleManagement.Size = new Size(635, 188);
            dgvSaleManagement.TabIndex = 8;
            dgvSaleManagement.CellClick += dgvSaleManagement_CellClick;
            // 
            // btnAddSale
            // 
            btnAddSale.Location = new Point(598, 163);
            btnAddSale.Name = "btnAddSale";
            btnAddSale.Size = new Size(94, 29);
            btnAddSale.TabIndex = 9;
            btnAddSale.Text = "Add";
            btnAddSale.UseVisualStyleBackColor = true;
            btnAddSale.Click += btnAddSale_Click;
            // 
            // btnEditSale
            // 
            btnEditSale.Location = new Point(598, 198);
            btnEditSale.Name = "btnEditSale";
            btnEditSale.Size = new Size(94, 29);
            btnEditSale.TabIndex = 10;
            btnEditSale.Text = "Edit";
            btnEditSale.UseVisualStyleBackColor = true;
            btnEditSale.Click += btnEditSale_Click;
            // 
            // btnDeleteSale
            // 
            btnDeleteSale.Location = new Point(598, 233);
            btnDeleteSale.Name = "btnDeleteSale";
            btnDeleteSale.Size = new Size(94, 29);
            btnDeleteSale.TabIndex = 11;
            btnDeleteSale.Text = "Delete";
            btnDeleteSale.UseVisualStyleBackColor = true;
            btnDeleteSale.Click += btnDeleteSale_Click;
            // 
            // txtSearchSale
            // 
            txtSearchSale.Location = new Point(511, 95);
            txtSearchSale.Name = "txtSearchSale";
            txtSearchSale.Size = new Size(225, 27);
            txtSearchSale.TabIndex = 12;
            txtSearchSale.TextChanged += txtSearchSale_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(424, 102);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 13;
            label5.Text = "Search";
            // 
            // btnSaleBack
            // 
            btnSaleBack.Location = new Point(22, 492);
            btnSaleBack.Name = "btnSaleBack";
            btnSaleBack.Size = new Size(94, 29);
            btnSaleBack.TabIndex = 14;
            btnSaleBack.Text = "Back";
            btnSaleBack.UseVisualStyleBackColor = true;
            btnSaleBack.Click += btnSaleBack_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.InitialImage = null;
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(139, 64);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 19;
            pbLogo.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(257, 24);
            label7.Name = "label7";
            label7.Size = new Size(307, 41);
            label7.TabIndex = 20;
            label7.Text = "SALE MANAGEMENT";
            // 
            // SaleManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 536);
            Controls.Add(label7);
            Controls.Add(pbLogo);
            Controls.Add(btnSaleBack);
            Controls.Add(label5);
            Controls.Add(txtSearchSale);
            Controls.Add(btnDeleteSale);
            Controls.Add(btnEditSale);
            Controls.Add(btnAddSale);
            Controls.Add(dgvSaleManagement);
            Controls.Add(txtProductIDSale);
            Controls.Add(txtCustomerIDSale);
            Controls.Add(txtSaleID);
            Controls.Add(dtpSaleDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SaleManagement";
            Text = "SaleManagement";
            ((System.ComponentModel.ISupportInitialize)dgvSaleManagement).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpSaleDate;
        private TextBox txtSaleID;
        private TextBox txtCustomerIDSale;
        private TextBox txtProductIDSale;
        private DataGridView dgvSaleManagement;
        private Button btnAddSale;
        private Button btnEditSale;
        private Button btnDeleteSale;
        private TextBox txtSearchSale;
        private Label label5;
        private Button btnSaleBack;
        private PictureBox pbLogo;
        private Label label7;
    }
}