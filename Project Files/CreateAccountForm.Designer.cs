namespace TrainStation_MngSys
{
    partial class CreateAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountForm));
            this.btnDirectExitX = new System.Windows.Forms.Button();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnTC = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDirectExitX
            // 
            this.btnDirectExitX.BackgroundImage = global::TrainStation_MngSys.Properties.Resources.remove;
            this.btnDirectExitX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDirectExitX.FlatAppearance.BorderSize = 0;
            this.btnDirectExitX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectExitX.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDirectExitX.ForeColor = System.Drawing.Color.Gold;
            this.btnDirectExitX.Location = new System.Drawing.Point(934, 12);
            this.btnDirectExitX.Name = "btnDirectExitX";
            this.btnDirectExitX.Size = new System.Drawing.Size(24, 24);
            this.btnDirectExitX.TabIndex = 16;
            this.btnDirectExitX.UseVisualStyleBackColor = true;
            this.btnDirectExitX.Click += new System.EventHandler(this.btnDirectExitX_Click);
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkBoxShowPass.ForeColor = System.Drawing.Color.White;
            this.checkBoxShowPass.Location = new System.Drawing.Point(218, 441);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxShowPass.Size = new System.Drawing.Size(254, 18);
            this.checkBoxShowPass.TabIndex = 14;
            this.checkBoxShowPass.Text = "I agree to the Terms of Service and Privacy Policy";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(197, 402);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PlaceholderText = "Password";
            this.txtBoxPass.Size = new System.Drawing.Size(298, 22);
            this.txtBoxPass.TabIndex = 10;
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(197, 363);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.PlaceholderText = "Username";
            this.txtBoxUser.Size = new System.Drawing.Size(298, 22);
            this.txtBoxUser.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(249, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "CREATE NEW ACCOUNT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TrainStation_MngSys.Properties.Resources.createacc;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(286, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 110);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(198, 324);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.PlaceholderText = "Phone";
            this.txtBoxPhone.Size = new System.Drawing.Size(297, 22);
            this.txtBoxPhone.TabIndex = 25;
            this.txtBoxPhone.TextChanged += new System.EventHandler(this.txtBoxUsertype_TextChanged);
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(197, 286);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.PlaceholderText = "Age";
            this.txtBoxAge.Size = new System.Drawing.Size(144, 22);
            this.txtBoxAge.TabIndex = 24;
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(347, 286);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.PlaceholderText = "ID";
            this.txtBoxID.Size = new System.Drawing.Size(148, 22);
            this.txtBoxID.TabIndex = 23;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(197, 248);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.PlaceholderText = "Name";
            this.txtBoxName.Size = new System.Drawing.Size(298, 22);
            this.txtBoxName.TabIndex = 22;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnSignUp.Enabled = false;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSignUp.Location = new System.Drawing.Point(196, 515);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(299, 23);
            this.btnSignUp.TabIndex = 26;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnTC
            // 
            this.btnTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(89)))));
            this.btnTC.FlatAppearance.BorderSize = 0;
            this.btnTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTC.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnTC.Location = new System.Drawing.Point(286, 465);
            this.btnTC.Name = "btnTC";
            this.btnTC.Size = new System.Drawing.Size(129, 23);
            this.btnTC.TabIndex = 27;
            this.btnTC.Text = "Terms and Conditions";
            this.btnTC.UseVisualStyleBackColor = false;
            this.btnTC.Click += new System.EventHandler(this.btnTC_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackgroundImage = global::TrainStation_MngSys.Properties.Resources.remove;
            this.btnBackToLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackToLogin.FlatAppearance.BorderSize = 0;
            this.btnBackToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToLogin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackToLogin.ForeColor = System.Drawing.Color.Gold;
            this.btnBackToLogin.Location = new System.Drawing.Point(674, 12);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(24, 24);
            this.btnBackToLogin.TabIndex = 28;
            this.btnBackToLogin.UseVisualStyleBackColor = true;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TrainStation_MngSys.Properties.Resources.minus;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(198, 201);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 10);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TrainStation_MngSys.Properties.Resources.minus;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(448, 201);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 10);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(710, 660);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.btnTC);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDirectExitX);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccountForm";
            this.Load += new System.EventHandler(this.CreateAccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDirectExitX;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnTC;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}