namespace SalesManagement
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            btnRegister = new Button();
            btnBacktoLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsernameRegister = new TextBox();
            txtPasswordRegister = new TextBox();
            pbLogo = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(309, 265);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBacktoLogin
            // 
            btnBacktoLogin.Location = new Point(294, 300);
            btnBacktoLogin.Name = "btnBacktoLogin";
            btnBacktoLogin.Size = new Size(120, 29);
            btnBacktoLogin.TabIndex = 1;
            btnBacktoLogin.Text = "Back to Login";
            btnBacktoLogin.UseVisualStyleBackColor = true;
            btnBacktoLogin.Click += btnBacktoLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 138);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 184);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtUsernameRegister
            // 
            txtUsernameRegister.Location = new Point(341, 131);
            txtUsernameRegister.Name = "txtUsernameRegister";
            txtUsernameRegister.Size = new Size(125, 27);
            txtUsernameRegister.TabIndex = 4;
            // 
            // txtPasswordRegister
            // 
            txtPasswordRegister.Location = new Point(341, 177);
            txtPasswordRegister.Name = "txtPasswordRegister";
            txtPasswordRegister.Size = new Size(125, 27);
            txtPasswordRegister.TabIndex = 5;
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
            label7.Location = new Point(299, 35);
            label7.Name = "label7";
            label7.Size = new Size(153, 41);
            label7.TabIndex = 20;
            label7.Text = "REGISTER";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 423);
            Controls.Add(label7);
            Controls.Add(pbLogo);
            Controls.Add(txtPasswordRegister);
            Controls.Add(txtUsernameRegister);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBacktoLogin);
            Controls.Add(btnRegister);
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Button btnBacktoLogin;
        private Label label1;
        private Label label2;
        private TextBox txtUsernameRegister;
        private TextBox txtPasswordRegister;
        private PictureBox pbLogo;
        private Label label7;
    }
}