namespace TrainStation_MngSys
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.DirectExitXbtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.btnBookTicket = new System.Windows.Forms.Button();
            this.btnShowTicketDetails = new System.Windows.Forms.Button();
            this.btnUpdateTrip = new System.Windows.Forms.Button();
            this.btnTripInfo = new System.Windows.Forms.Button();
            this.btnSearchTicket = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.txtBoxFare = new System.Windows.Forms.TextBox();
            this.txtBoxDestination = new System.Windows.Forms.TextBox();
            this.txtBoxTicketNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(249, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Welcome to Employee Panel";
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
            this.DirectExitXbtn.TabIndex = 41;
            this.DirectExitXbtn.UseVisualStyleBackColor = true;
            this.DirectExitXbtn.Click += new System.EventHandler(this.DirectExitXbtn_Click);
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
            this.LogoutBtn.TabIndex = 40;
            this.LogoutBtn.Text = "&Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnBookTicket.FlatAppearance.BorderSize = 0;
            this.btnBookTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookTicket.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBookTicket.Location = new System.Drawing.Point(407, 320);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(219, 32);
            this.btnBookTicket.TabIndex = 42;
            this.btnBookTicket.Text = "Book a ticket";
            this.btnBookTicket.UseVisualStyleBackColor = false;
            this.btnBookTicket.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // btnShowTicketDetails
            // 
            this.btnShowTicketDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnShowTicketDetails.FlatAppearance.BorderSize = 0;
            this.btnShowTicketDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowTicketDetails.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowTicketDetails.Location = new System.Drawing.Point(407, 430);
            this.btnShowTicketDetails.Name = "btnShowTicketDetails";
            this.btnShowTicketDetails.Size = new System.Drawing.Size(219, 32);
            this.btnShowTicketDetails.TabIndex = 43;
            this.btnShowTicketDetails.Text = "Show ticket details";
            this.btnShowTicketDetails.UseVisualStyleBackColor = false;
            this.btnShowTicketDetails.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdateTrip
            // 
            this.btnUpdateTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnUpdateTrip.FlatAppearance.BorderSize = 0;
            this.btnUpdateTrip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateTrip.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateTrip.Location = new System.Drawing.Point(407, 265);
            this.btnUpdateTrip.Name = "btnUpdateTrip";
            this.btnUpdateTrip.Size = new System.Drawing.Size(219, 32);
            this.btnUpdateTrip.TabIndex = 44;
            this.btnUpdateTrip.Text = "Update ticket info";
            this.btnUpdateTrip.UseVisualStyleBackColor = false;
            this.btnUpdateTrip.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTripInfo
            // 
            this.btnTripInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnTripInfo.FlatAppearance.BorderSize = 0;
            this.btnTripInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTripInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTripInfo.Location = new System.Drawing.Point(407, 210);
            this.btnTripInfo.Name = "btnTripInfo";
            this.btnTripInfo.Size = new System.Drawing.Size(219, 32);
            this.btnTripInfo.TabIndex = 45;
            this.btnTripInfo.Text = "Trip info";
            this.btnTripInfo.UseVisualStyleBackColor = false;
            this.btnTripInfo.Click += new System.EventHandler(this.btnTripInfo_Click);
            // 
            // btnSearchTicket
            // 
            this.btnSearchTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnSearchTicket.FlatAppearance.BorderSize = 0;
            this.btnSearchTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchTicket.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchTicket.Location = new System.Drawing.Point(407, 375);
            this.btnSearchTicket.Name = "btnSearchTicket";
            this.btnSearchTicket.Size = new System.Drawing.Size(219, 32);
            this.btnSearchTicket.TabIndex = 46;
            this.btnSearchTicket.Text = "Search booked ticket info";
            this.btnSearchTicket.UseVisualStyleBackColor = false;
            this.btnSearchTicket.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 167);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.Location = new System.Drawing.Point(77, 210);
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.PlaceholderText = "Location";
            this.txtBoxLocation.Size = new System.Drawing.Size(115, 22);
            this.txtBoxLocation.TabIndex = 49;
            this.txtBoxLocation.TextChanged += new System.EventHandler(this.txtBoxLocation_TextChanged);
            // 
            // txtBoxFare
            // 
            this.txtBoxFare.Location = new System.Drawing.Point(77, 252);
            this.txtBoxFare.Name = "txtBoxFare";
            this.txtBoxFare.PlaceholderText = "Fare";
            this.txtBoxFare.Size = new System.Drawing.Size(115, 22);
            this.txtBoxFare.TabIndex = 48;
            this.txtBoxFare.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // txtBoxDestination
            // 
            this.txtBoxDestination.Location = new System.Drawing.Point(198, 210);
            this.txtBoxDestination.Name = "txtBoxDestination";
            this.txtBoxDestination.PlaceholderText = "Destination";
            this.txtBoxDestination.Size = new System.Drawing.Size(119, 22);
            this.txtBoxDestination.TabIndex = 50;
            this.txtBoxDestination.TextChanged += new System.EventHandler(this.txtBoxDestination_TextChanged);
            // 
            // txtBoxTicketNo
            // 
            this.txtBoxTicketNo.Location = new System.Drawing.Point(198, 252);
            this.txtBoxTicketNo.Name = "txtBoxTicketNo";
            this.txtBoxTicketNo.PlaceholderText = "TicketNo";
            this.txtBoxTicketNo.Size = new System.Drawing.Size(119, 22);
            this.txtBoxTicketNo.TabIndex = 51;
            this.txtBoxTicketNo.TextChanged += new System.EventHandler(this.txtBoxTicketNo_TextChanged);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(710, 660);
            this.Controls.Add(this.txtBoxTicketNo);
            this.Controls.Add(this.txtBoxDestination);
            this.Controls.Add(this.txtBoxLocation);
            this.Controls.Add(this.txtBoxFare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearchTicket);
            this.Controls.Add(this.btnTripInfo);
            this.Controls.Add(this.btnUpdateTrip);
            this.Controls.Add(this.btnShowTicketDetails);
            this.Controls.Add(this.btnBookTicket);
            this.Controls.Add(this.DirectExitXbtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DirectExitXbtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button btnBookTicket;
        private System.Windows.Forms.Button btnShowTicketDetails;
        private System.Windows.Forms.Button btnUpdateTrip;
        private System.Windows.Forms.Button btnTripInfo;
        private System.Windows.Forms.Button btnSearchTicket;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBoxLocation;
        private System.Windows.Forms.TextBox txtBoxFare;
        private System.Windows.Forms.TextBox txtBoxDestination;
        private System.Windows.Forms.TextBox txtBoxTicketNo;
    }
}