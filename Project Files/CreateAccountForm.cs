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
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }
        static string cs = @"Data Source=SHIHAB;Initial Catalog=TrainStation;Integrated Security=True";
        private void btnDirectExitX_Click(object sender, EventArgs e) // Direct Exit [X] button //
        {
            this.Hide();
            LoginWindow lw = new LoginWindow();
            lw.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e) // T/C accept checkbox //
        {
            btnSignUp.Enabled = checkBoxShowPass.Checked;
        }

        private void grpBoxInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnTC_Click(object sender, EventArgs e) // Terms and Conditions window button //
        {
            MessageBox.Show("This Agreement shall remain in effect until terminated by you or us. We may, in its sole discretion, at any time and for any or no reason, suspend or terminate this Agreement with or without prior notice. " +
                "\nThis Agreement will terminate immediately, without prior notice from us, " +
                "in the event that you fail to comply with any provision of this Agreement. " +
                "\nYou may also terminate this Agreement by deleting the service and all copies thereof from your computer. " +
                "\nUpon termination of this Agreement, you shall cease all use of the service and delete all copies of the service from your computer. " +
                "\nTermination of this Agreement will not limit any of our rights or remedies at law or in equity in case of breach by you (during the term of this Agreement) " +
                "of any of your obligations under the present Agreement.");
        }

        private void btnBackToLogin_Click(object sender, EventArgs e) // Back to Login Form button //
        {
            this.Hide();
            LoginWindow lw = new LoginWindow();
            lw.Show();
        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxUsertype_TextChanged(object sender, EventArgs e) 
        {
            
        }

        private void btnSignUp_Click(object sender, EventArgs e) // Sign up button //
        {
            if(txtBoxName.Text == "" || txtBoxID.Text == "" || txtBoxAge.Text == "" || txtBoxPass.Text == "" || txtBoxPhone.Text == "" || txtBoxUser.Text == "")
            {
                MessageBox.Show("Please provide all the information.");
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO User_StationMaster(Stm_ID, Stm_Name, Stm_Age, Stm_Phone, Stm_User, Stm_Pass) VALUES (@ID,@Name,@Age,@Phone,@Username,@Password)", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txtBoxID.Text));
                cmd.Parameters.AddWithValue("@Name", txtBoxName.Text);
                cmd.Parameters.AddWithValue("@Age", txtBoxAge.Text);
                cmd.Parameters.AddWithValue("@Phone", txtBoxPhone.Text);
                cmd.Parameters.AddWithValue("@Username", txtBoxUser.Text);
                cmd.Parameters.AddWithValue("@Password", txtBoxPass.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Account successfully created!");
                this.Hide();
                new LoginWindow().Show();
            }    
            
        }
    }
}
