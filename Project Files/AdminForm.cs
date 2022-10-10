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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        static string cs = @"Data Source=SHIHAB;Initial Catalog=TrainStation;Integrated Security=True";
        void BindData()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM User_StationMaster", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //dataGridViewStMaster.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e) // Direct Exit [X] button //
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e) // Logout button //
        {
            this.Hide();
            LoginWindow lw = new LoginWindow();
            lw.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e) // View StationMaster's Data button //
        {
            this.Hide();
            new DataTableStm().Show();
        }

        private void button1_Click_1(object sender, EventArgs e) // Direct Exit [X] button //
        {
            this.Hide();
            new LoginWindow().Show();
        }

        private void button6_Click(object sender, EventArgs e) // View Employee's Data button //
        {
            this.Hide();
            new DataTableEmp().Show();
        }

        private void button2_Click(object sender, EventArgs e) // Hire a StationMaster button (insert) //
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO User_StationMaster(Stm_ID, Stm_Name, Stm_Age, Stm_User, Stm_Pass, Stm_Phone) VALUES (@ID,@Name,@Age,@Username,@Password,@Phone)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtBoxID.Text));
            cmd.Parameters.AddWithValue("@Name", txtBoxName.Text);
            cmd.Parameters.AddWithValue("@Age", txtBoxAge.Text);
            cmd.Parameters.AddWithValue("@Username", txtBoxUser.Text);
            cmd.Parameters.AddWithValue("@Password", txtBoxPass.Text);
            cmd.Parameters.AddWithValue("@Phone", txtBoxPhone.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            txtBoxID.Text = "";
            txtBoxName.Text = "";
            txtBoxAge.Text = "";
            txtBoxUser.Text = "";
            txtBoxPass.Text = "";
            txtBoxPhone.Text = "";

            MessageBox.Show("StationMaster Hired!");
        }

        private void btnFire_Click(object sender, EventArgs e) // Fire a StationMaster button (delete) //
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE User_StationMaster WHERE Stm_ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtBoxID.Text));
            cmd.Parameters.AddWithValue("@Name", txtBoxName.Text);
            cmd.Parameters.AddWithValue("@Age", txtBoxAge.Text);
            cmd.Parameters.AddWithValue("@Username", txtBoxUser.Text);
            cmd.Parameters.AddWithValue("@Password", txtBoxPass.Text);
            cmd.Parameters.AddWithValue("@Phone", txtBoxPhone.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            txtBoxID.Text = "";
            txtBoxName.Text = "";
            txtBoxAge.Text = "";
            txtBoxUser.Text = "";
            txtBoxPass.Text = "";
            txtBoxPhone.Text = "";
            MessageBox.Show("StationMaster Fired!");
        }

        private void btnSearch_Click(object sender, EventArgs e) // Search a StationMaster button (search) //
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM User_StationMaster WHERE Stm_ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtBoxID.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtBoxID.Text = "";
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e) // Update a StationMaster's info button (update) //
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE User_StationMaster SET Stm_Name=@Name, Stm_Age=@Age, Stm_User=@Username, Stm_Pass=@Password, Stm_Phone=@Phone WHERE Stm_ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtBoxID.Text));
            cmd.Parameters.AddWithValue("@Name", txtBoxName.Text);
            cmd.Parameters.AddWithValue("@Age", txtBoxAge.Text);
            cmd.Parameters.AddWithValue("@Username", txtBoxUser.Text);
            cmd.Parameters.AddWithValue("@Password", txtBoxPass.Text);
            cmd.Parameters.AddWithValue("@Phone", txtBoxPhone.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            txtBoxID.Text = "";
            txtBoxName.Text = "";
            txtBoxAge.Text = "";
            txtBoxUser.Text = "";
            txtBoxPass.Text = "";
            txtBoxPhone.Text = "";
            MessageBox.Show("Successfully Updated!");
        }
    }
}
