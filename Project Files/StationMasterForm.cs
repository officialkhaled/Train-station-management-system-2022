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
    public partial class StationMasterForm : Form
    {
        public StationMasterForm()
        {
            InitializeComponent();
        }
        static string cs = @"Data Source=SHIHAB;Initial Catalog=TrainStation;Integrated Security=True";
        void BindData()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM User_Employee", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnDirectExitX_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void DirectExitXbtn_Click(object sender, EventArgs e) // Direct Exit [X] button //
        {
            this.Hide();
            new LoginWindow().Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e) // Logout button //
        {
            this.Hide();
            LoginWindow lw = new LoginWindow();
            lw.Show();
        }

        private void btnEmpData_Click(object sender, EventArgs e) // View Employee's Data button //
        {
            this.Hide();
            new DataTableEmp().Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e) // Update an employee's info button (update) //
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE User_Employee SET Emp_Name=@Name, Emp_Age=@Age, Emp_User=@Username, Emp_Pass=@Password, Emp_Phone=@Phone, Emp_Designation=@Designation, Emp_Salary=@Salary WHERE Emp_ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtBoxID.Text));
            cmd.Parameters.AddWithValue("@Name", txtBoxName.Text);
            cmd.Parameters.AddWithValue("@Age", txtBoxAge.Text);
            cmd.Parameters.AddWithValue("@Email", txtBoxEmail.Text);
            cmd.Parameters.AddWithValue("@Username", txtBoxUser.Text);
            cmd.Parameters.AddWithValue("@Password", txtBoxPass.Text);
            cmd.Parameters.AddWithValue("@Phone", txtBoxPhone.Text);
            cmd.Parameters.AddWithValue("@Salary", txtBoxSalary.Text);
            cmd.Parameters.AddWithValue("@Designation", txtBoxDesignation.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            txtBoxID.Text = "";
            txtBoxName.Text = "";
            txtBoxAge.Text = "";
            txtBoxUser.Text = "";
            txtBoxPass.Text = "";
            txtBoxPhone.Text = "";
            txtBoxEmail.Text = "";
            txtBoxSalary.Text = "";
            txtBoxDesignation.Text = "";
            MessageBox.Show("Successfully Updated!");
        }

        private void btnSearch_Click(object sender, EventArgs e) // Search an employee button (search) //
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM User_Employee WHERE Emp_ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtBoxID.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtBoxID.Text = "";
            dataGridView1.DataSource = dt;
        }

        private void btnFire_Click(object sender, EventArgs e) // Fire an employee button (delete) //
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE User_Employee WHERE Emp_ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtBoxID.Text));
            cmd.Parameters.AddWithValue("@Name", txtBoxName.Text);
            cmd.Parameters.AddWithValue("@Age", txtBoxAge.Text);
            cmd.Parameters.AddWithValue("@Email", txtBoxEmail.Text);
            cmd.Parameters.AddWithValue("@Username", txtBoxUser.Text);
            cmd.Parameters.AddWithValue("@Password", txtBoxPass.Text);
            cmd.Parameters.AddWithValue("@Phone", txtBoxPhone.Text);
            cmd.Parameters.AddWithValue("@Salary", txtBoxSalary.Text);
            cmd.Parameters.AddWithValue("@Designation", txtBoxDesignation.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            txtBoxID.Text = "";
            txtBoxName.Text = "";
            txtBoxAge.Text = "";
            txtBoxUser.Text = "";
            txtBoxPass.Text = "";
            txtBoxPhone.Text = "";
            txtBoxEmail.Text = "";
            txtBoxSalary.Text = "";
            txtBoxDesignation.Text = "";
            MessageBox.Show("Employee Fired!");
        }

        private void btnHire_Click(object sender, EventArgs e) // Hire an employee button (insert) //
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO User_Employee(Emp_ID, Emp_Name, Emp_Age, Emp_Email, Emp_User, Emp_Pass, Emp_Phone, Emp_Salary, Emp_Designation) VALUES (@ID,@Name,@Age,@Email,@Username,@Password,@Phone,@Salary,@Designation)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtBoxID.Text));
            cmd.Parameters.AddWithValue("@Name", txtBoxName.Text);
            cmd.Parameters.AddWithValue("@Age", txtBoxAge.Text);
            cmd.Parameters.AddWithValue("@Email", txtBoxEmail.Text);
            cmd.Parameters.AddWithValue("@Username", txtBoxUser.Text);
            cmd.Parameters.AddWithValue("@Password", txtBoxPass.Text);
            cmd.Parameters.AddWithValue("@Phone", txtBoxPhone.Text);
            cmd.Parameters.AddWithValue("@Salary", txtBoxSalary.Text);
            cmd.Parameters.AddWithValue("@Designation", txtBoxDesignation.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            txtBoxID.Text = "";
            txtBoxName.Text = "";
            txtBoxAge.Text = "";
            txtBoxUser.Text = "";
            txtBoxPass.Text = "";
            txtBoxPhone.Text = "";
            txtBoxEmail.Text = "";
            txtBoxSalary.Text = "";
            txtBoxDesignation.Text = "";
            MessageBox.Show("Employee Hired!");
        }

        private void StationMasterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
