using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TrainStation_MngSys
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        static string cs = @"Data Source=SHIHAB;Initial Catalog=TrainStation;Integrated Security=True";
        private void LoginWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) // Direct Exit [X] button //
        {
            Application.Exit(); 
        }

        private void btnExit_Click(object sender, EventArgs e) // Exit button //
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e) // Login button //
        {
             
            if(txtBoxUsername.Text == "")
            {
                MessageBox.Show("Please provide your username");
                return;
            }
            else if(txtBoxPass.Text == "")
            {
                MessageBox.Show("Please provide your password");
                return;
            }
            
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from LoginInfo where Username=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", txtBoxUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtBoxPass.Text);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();

                // Switch Case //
                if (dt.Rows.Count > 0)
                {
                    switch (dt.Rows[0]["usertype"] as string)
                    {
                        case "Admin":
                            {
                                this.Hide();
                                new AdminForm().Show();
                                break;
                            }
                        case "StationMaster":
                            {
                                this.Hide();
                                new StationMasterForm().Show();
                                break;
                            }
                        case "Employee":
                            {
                                this.Hide();
                                new EmployeeForm().Show();
                                break;
                            }
                        default:
                            {
                                MessageBox.Show("Enter correct username and password");
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBoxUsername_Validating(object sender, CancelEventArgs e) // ErrorProvider 1: Username //
        {
            if (string.IsNullOrEmpty(txtBoxUsername.Text))
            {
                e.Cancel = true;
                txtBoxUsername.Focus();
                errorProvider1.SetError(txtBoxUsername, "Please enter your Username!");
            }
            else
            {
                errorProvider1.SetError(txtBoxUsername, null);
            }
        }

        private void txtBoxPass_Validating(object sender, CancelEventArgs e) // ErrorProvider 2: Password //
        {
            if (string.IsNullOrEmpty(txtBoxPass.Text))
            {
                e.Cancel = true;
                txtBoxPass.Focus();
                errorProvider2.SetError(txtBoxPass, "Please enter your Password!");
            }
            else
            {
                errorProvider2.SetError(txtBoxPass, null);
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e) // Show Password chckbox //
        {
            if (checkBoxShowPass.Checked == true)
            {
                txtBoxPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxPass.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e) // about us button //
        {
            MessageBox.Show("This project was developed by " +
                "\n\nAsmaul Hossain Akash (20-44209-3)\nKhaled Hossain Shihab (20-44256-3)" +
                "\nI S M Salim Sadman (20-44260-3)\nSumona Islam (20-43424-1)", "About Us",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e) // Create new account button //
        {
            DialogResult res = MessageBox.Show("Do you want to create a new account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                new CreateAccountForm().Show();
            }
        }
    }
}
