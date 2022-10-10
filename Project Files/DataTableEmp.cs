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
using Excel = Microsoft.Office.Interop.Excel;

namespace TrainStation_MngSys
{
    public partial class DataTableEmp : Form
    {
        public DataTableEmp()
        {
            InitializeComponent();
        }
        // Connection String //
        string cs = @"Data Source=SHIHAB;Initial Catalog=TrainStation;Integrated Security=True";

        void BindData()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM User_Employee", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewEmployee.DataSource = dt;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e) // Back button //
        {
            this.Hide();
            StationMasterForm sf = new StationMasterForm();
            sf.Show();
        }

        private void btnDirectExitX_Click(object sender, EventArgs e) // Direct Exit [X] button //
        {
            this.Hide();
            LoginWindow lw = new LoginWindow();
            lw.Show();
        }

        private void btnExportData_Click(object sender, EventArgs e) // Export button //
        {
            dataGridViewEmployee.SelectAll();
            DataObject copydata = dataGridViewEmployee.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlSheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlapp.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlapp.Cells[1, 1];
            xlr.Select();

            xlSheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, EventArgs e) // Load data button //
        {
            BindData();
        }

        private void DataTableEmp_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    
}
