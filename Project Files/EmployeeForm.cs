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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        static string cs = @"Data Source=SHIHAB;Initial Catalog=TrainStation;Integrated Security=True";
        void BindData()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TicketInfo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
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

        private void button2_Click(object sender, EventArgs e) // Update trip info button //
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE TicketInfo SET Location_From=@Location, Location_To=@Destination, Fare=@Fare WHERE TicketNo=@TicketNo", con);
            cmd.Parameters.AddWithValue("@TicketNo", int.Parse(txtBoxTicketNo.Text));
            cmd.Parameters.AddWithValue("@Location", txtBoxLocation.Text);
            cmd.Parameters.AddWithValue("@Destination", txtBoxDestination.Text);
            cmd.Parameters.AddWithValue("@Fare", txtBoxFare.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            txtBoxLocation.Text = "";
            txtBoxFare.Text = "";
            txtBoxDestination.Text = "";
            txtBoxTicketNo.Text = "";
            MessageBox.Show("Successfully Updated!");
        }

        private void button1_Click(object sender, EventArgs e) // Show ticket details button //
        {
            this.Hide();
            Ticket tf = new Ticket();
            tf.Show();
        }

        private void button4_Click(object sender, EventArgs e) // Search booked ticket details button //
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TicketInfo WHERE TicketNo=@TicketNo", con);
            cmd.Parameters.AddWithValue("@TicketNo", txtBoxTicketNo.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtBoxTicketNo.Text = "";
            dataGridView1.DataSource = dt;
        }

        private void btnHire_Click(object sender, EventArgs e) // Book a ticket button //
        {
            if(txtBoxDestination.Text == "" || txtBoxTicketNo.Text == "" || txtBoxFare.Text == "" || txtBoxLocation.Text == "")
            {
                MessageBox.Show("Please fill up all the details.");
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO TicketInfo(Location_From, Location_To, Fare, TicketNo) VALUES (@Location,@Destination,@Fare,@TicketNo)", con);
                cmd.Parameters.AddWithValue("@Location", txtBoxLocation.Text);
                cmd.Parameters.AddWithValue("@Destination", txtBoxDestination.Text);
                cmd.Parameters.AddWithValue("@Fare", txtBoxFare.Text);
                cmd.Parameters.AddWithValue("@TicketNo", txtBoxTicketNo.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                txtBoxLocation.Text = "";
                txtBoxFare.Text = "";
                txtBoxDestination.Text = "";
                txtBoxTicketNo.Text = "";


                MessageBox.Show("Ticket Booked!");
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTripInfo_Click(object sender, EventArgs e) // Trip info button //
        {
            this.Hide();
            TripInfo ti = new TripInfo();
            ti.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxTicketNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxDestination_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
