namespace TrainStation_MngSys
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHire = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnStmData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmpData = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(302, 588);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(105, 32);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "&Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TrainStation_MngSys.Properties.Resources.remove;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(674, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnHire
            // 
            this.btnHire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnHire.FlatAppearance.BorderSize = 0;
            this.btnHire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHire.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHire.Location = new System.Drawing.Point(407, 181);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(219, 32);
            this.btnHire.TabIndex = 16;
            this.btnHire.Text = "&Hire a StationMaster";
            this.btnHire.UseVisualStyleBackColor = false;
            this.btnHire.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnFire.FlatAppearance.BorderSize = 0;
            this.btnFire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFire.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFire.Location = new System.Drawing.Point(407, 238);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(219, 32);
            this.btnFire.TabIndex = 16;
            this.btnFire.Text = "Fire a StationMaster";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(407, 295);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(219, 32);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search a StationMaster";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(407, 352);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(219, 32);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update a StationMaster\'s info";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnStmData
            // 
            this.btnStmData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnStmData.FlatAppearance.BorderSize = 0;
            this.btnStmData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStmData.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStmData.Location = new System.Drawing.Point(407, 409);
            this.btnStmData.Name = "btnStmData";
            this.btnStmData.Size = new System.Drawing.Size(219, 32);
            this.btnStmData.TabIndex = 16;
            this.btnStmData.Text = "View StationMaster\'s Data table";
            this.btnStmData.UseVisualStyleBackColor = false;
            this.btnStmData.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(260, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Welcome to Admin Panel";
            // 
            // btnEmpData
            // 
            this.btnEmpData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnEmpData.FlatAppearance.BorderSize = 0;
            this.btnEmpData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmpData.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmpData.Location = new System.Drawing.Point(407, 466);
            this.btnEmpData.Name = "btnEmpData";
            this.btnEmpData.Size = new System.Drawing.Size(219, 32);
            this.btnEmpData.TabIndex = 21;
            this.btnEmpData.Text = "View Employee\'s Data table";
            this.btnEmpData.UseVisualStyleBackColor = false;
            this.btnEmpData.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(83, 219);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.PlaceholderText = "Full Name";
            this.txtBoxName.Size = new System.Drawing.Size(240, 22);
            this.txtBoxName.TabIndex = 22;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(83, 257);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.PlaceholderText = "Age";
            this.txtBoxAge.Size = new System.Drawing.Size(240, 22);
            this.txtBoxAge.TabIndex = 23;
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(83, 333);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.PlaceholderText = "Username";
            this.txtBoxUser.Size = new System.Drawing.Size(240, 22);
            this.txtBoxUser.TabIndex = 24;
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(83, 371);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PlaceholderText = "Password";
            this.txtBoxPass.Size = new System.Drawing.Size(240, 22);
            this.txtBoxPass.TabIndex = 25;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(83, 295);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.PlaceholderText = "Phone";
            this.txtBoxPhone.Size = new System.Drawing.Size(240, 22);
            this.txtBoxPhone.TabIndex = 26;
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(83, 181);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.PlaceholderText = "ID";
            this.txtBoxID.Size = new System.Drawing.Size(240, 22);
            this.txtBoxID.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 89);
            this.dataGridView1.TabIndex = 28;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(710, 660);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnEmpData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnHire);
            this.Controls.Add(this.btnStmData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogout);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHire;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnStmData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpData;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}