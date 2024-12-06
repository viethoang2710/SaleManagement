namespace SalesManagement
{
    partial class CustomerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerManagement));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCustomerID = new TextBox();
            txtCustomerName = new TextBox();
            txtNumberPhone = new TextBox();
            dtpDateOfPurchase = new DateTimePicker();
            dgvCustomerManagement = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            label6 = new Label();
            btnBackCustomer = new Button();
            pbLogo = new PictureBox();
            label7 = new Label();
            cmbPurchaseOrder = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerManagement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 105);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 143);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 190);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Number Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 239);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 3;
            label4.Text = "Purchase Order";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 288);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 4;
            label5.Text = "Date Of Purchase";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(194, 98);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(125, 27);
            txtCustomerID.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(194, 136);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(125, 27);
            txtCustomerName.TabIndex = 6;
            // 
            // txtNumberPhone
            // 
            txtNumberPhone.Location = new Point(194, 183);
            txtNumberPhone.Name = "txtNumberPhone";
            txtNumberPhone.Size = new Size(125, 27);
            txtNumberPhone.TabIndex = 8;
            // 
            // dtpDateOfPurchase
            // 
            dtpDateOfPurchase.Location = new Point(194, 281);
            dtpDateOfPurchase.Name = "dtpDateOfPurchase";
            dtpDateOfPurchase.Size = new Size(250, 27);
            dtpDateOfPurchase.TabIndex = 10;
            // 
            // dgvCustomerManagement
            // 
            dgvCustomerManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerManagement.Location = new Point(42, 335);
            dgvCustomerManagement.Name = "dgvCustomerManagement";
            dgvCustomerManagement.RowHeadersWidth = 51;
            dgvCustomerManagement.Size = new Size(704, 215);
            dgvCustomerManagement.TabIndex = 11;
            dgvCustomerManagement.CellClick += dgvCustomerManagement_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(611, 186);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(611, 232);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(611, 279);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(518, 98);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(228, 27);
            txtSearch.TabIndex = 15;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 105);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 16;
            label6.Text = "Search";
            // 
            // btnBackCustomer
            // 
            btnBackCustomer.Location = new Point(30, 558);
            btnBackCustomer.Name = "btnBackCustomer";
            btnBackCustomer.Size = new Size(94, 29);
            btnBackCustomer.TabIndex = 17;
            btnBackCustomer.Text = "Back";
            btnBackCustomer.UseVisualStyleBackColor = true;
            btnBackCustomer.Click += btnBackCustomer_Click_1;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.InitialImage = null;
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(139, 64);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 18;
            pbLogo.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(248, 22);
            label7.Name = "label7";
            label7.Size = new Size(370, 38);
            label7.TabIndex = 19;
            label7.Text = "CUSTOMER MANAGEMENT";
            // 
            // cmbPurchaseOrder
            // 
            cmbPurchaseOrder.FormattingEnabled = true;
            cmbPurchaseOrder.Location = new Point(194, 236);
            cmbPurchaseOrder.Name = "cmbPurchaseOrder";
            cmbPurchaseOrder.Size = new Size(151, 28);
            cmbPurchaseOrder.TabIndex = 20;
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 595);
            Controls.Add(cmbPurchaseOrder);
            Controls.Add(label7);
            Controls.Add(pbLogo);
            Controls.Add(btnBackCustomer);
            Controls.Add(label6);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvCustomerManagement);
            Controls.Add(dtpDateOfPurchase);
            Controls.Add(txtNumberPhone);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerManagement";
            Text = "CustomerManagement";
            Load += CustomerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerManagement).EndInit();
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
        private TextBox txtCustomerID;
        private TextBox txtCustomerName;
        private TextBox txtNumberPhone;
        private DateTimePicker dtpDateOfPurchase;
        private DataGridView dgvCustomerManagement;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtSearch;
        private Label label6;
        private Button btnBackCustomer;
        private PictureBox pbLogo;
        private Label label7;
        private ComboBox cmbPurchaseOrder;
    }
}