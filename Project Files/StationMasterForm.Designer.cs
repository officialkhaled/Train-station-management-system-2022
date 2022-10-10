namespace TrainStation_MngSys
{
    partial class StationMasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationMasterForm));
            this.btnDirectExitX = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEmpData = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnHire = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxSalary = new System.Windows.Forms.TextBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.txtBoxDesignation = new System.Windows.Forms.TextBox();
            this.DirectExitXbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDirectExitX
            // 
            this.btnDirectExitX.BackgroundImage = global::TrainStation_MngSys.Properties.Resources.cancel__1_;
            this.btnDirectExitX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDirectExitX.FlatAppearance.BorderSize = 0;
            this.btnDirectExitX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectExitX.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDirectExitX.ForeColor = System.Drawing.Color.Gold;
            this.btnDirectExitX.Location = new System.Drawing.Point(934, 12);
            this.btnDirectExitX.Name = "btnDirectExitX";
            this.btnDirectExitX.Size = new System.Drawing.Size(24, 24);
            this.btnDirectExitX.TabIndex = 7;
            this.btnDirectExitX.UseVisualStyleBackColor = true;
            this.btnDirectExitX.Click += new System.EventHandler(this.btnDirectExitX_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(853, 648);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(105, 32);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "&Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEmpData
            // 
            this.btnEmpData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnEmpData.FlatAppearance.BorderSize = 0;
            this.btnEmpData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmpData.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmpData.Location = new System.Drawing.Point(407, 433);
            this.btnEmpData.Name = "btnEmpData";
            this.btnEmpData.Size = new System.Drawing.Size(219, 32);
            this.btnEmpData.TabIndex = 26;
            this.btnEmpData.Text = "View Employee\'s Data table";
            this.btnEmpData.UseVisualStyleBackColor = false;
            this.btnEmpData.Click += new System.EventHandler(this.btnEmpData_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(407, 380);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(219, 32);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update an Employee\'s info";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(407, 323);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(219, 32);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search an Employee";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnFire.FlatAppearance.BorderSize = 0;
            this.btnFire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFire.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFire.Location = new System.Drawing.Point(407, 266);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(219, 32);
            this.btnFire.TabIndex = 23;
            this.btnFire.Text = "Fire an Employee";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnHire
            // 
            this.btnHire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnHire.FlatAppearance.BorderSize = 0;
            this.btnHire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHire.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHire.Location = new System.Drawing.Point(407, 210);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(219, 32);
            this.btnHire.TabIndex = 24;
            this.btnHire.Text = "&Hire an Employee";
            this.btnHire.UseVisualStyleBackColor = false;
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogoutBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogoutBtn.Location = new System.Drawing.Point(302, 588);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(105, 32);
            this.LogoutBtn.TabIndex = 27;
            this.LogoutBtn.Text = "&Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(249, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Welcome to StationMaster Panel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 89);
            this.dataGridView1.TabIndex = 35;
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(77, 181);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.PlaceholderText = "ID";
            this.txtBoxID.Size = new System.Drawing.Size(115, 22);
            this.txtBoxID.TabIndex = 34;
            // 
            // txtBoxSalary
            // 
            this.txtBoxSalary.Location = new System.Drawing.Point(77, 295);
            this.txtBoxSalary.Name = "txtBoxSalary";
            this.txtBoxSalary.PlaceholderText = "Salary";
            this.txtBoxSalary.Size = new System.Drawing.Size(115, 22);
            this.txtBoxSalary.TabIndex = 33;
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(77, 371);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PlaceholderText = "Password";
            this.txtBoxPass.Size = new System.Drawing.Size(240, 22);
            this.txtBoxPass.TabIndex = 32;
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(77, 333);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.PlaceholderText = "Username";
            this.txtBoxUser.Size = new System.Drawing.Size(240, 22);
            this.txtBoxUser.TabIndex = 31;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(77, 257);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.PlaceholderText = "Email";
            this.txtBoxEmail.Size = new System.Drawing.Size(115, 22);
            this.txtBoxEmail.TabIndex = 30;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(77, 219);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.PlaceholderText = "Full Name";
            this.txtBoxName.Size = new System.Drawing.Size(240, 22);
            this.txtBoxName.TabIndex = 29;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(198, 181);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.PlaceholderText = "Age";
            this.txtBoxAge.Size = new System.Drawing.Size(119, 22);
            this.txtBoxAge.TabIndex = 36;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(198, 257);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.PlaceholderText = "Phone";
            this.txtBoxPhone.Size = new System.Drawing.Size(119, 22);
            this.txtBoxPhone.TabIndex = 37;
            // 
            // txtBoxDesignation
            // 
            this.txtBoxDesignation.Location = new System.Drawing.Point(198, 295);
            this.txtBoxDesignation.Name = "txtBoxDesignation";
            this.txtBoxDesignation.PlaceholderText = "Designation";
            this.txtBoxDesignation.Size = new System.Drawing.Size(119, 22);
            this.txtBoxDesignation.TabIndex = 38;
            // 
            // DirectExitXbtn
            // 
            this.DirectExitXbtn.BackgroundImage = global::TrainStation_MngSys.Properties.Resources.remove;
            this.DirectExitXbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DirectExitXbtn.FlatAppearance.BorderSize = 0;
            this.DirectExitXbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DirectExitXbtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DirectExitXbtn.ForeColor = System.Drawing.Color.Gold;
            this.DirectExitXbtn.Location = new System.Drawing.Point(674, 12);
            this.DirectExitXbtn.Name = "DirectExitXbtn";
            this.DirectExitXbtn.Size = new System.Drawing.Size(24, 24);
            this.DirectExitXbtn.TabIndex = 39;
            this.DirectExitXbtn.UseVisualStyleBackColor = true;
            this.DirectExitXbtn.Click += new System.EventHandler(this.DirectExitXbtn_Click);
            // 
            // StationMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(710, 660);
            this.Controls.Add(this.DirectExitXbtn);
            this.Controls.Add(this.txtBoxDesignation);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.txtBoxSalary);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.btnEmpData);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnHire);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDirectExitX);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StationMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StationMaster";
            this.Load += new System.EventHandler(this.StationMasterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDirectExitX;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEmpData;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnHire;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxSalary;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.TextBox txtBoxDesignation;
        private System.Windows.Forms.Button DirectExitXbtn;
    }
}