using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace TrainStation_MngSys
{
    public partial class DataTableStm : Form
    {
        public DataTableStm()
        {
            InitializeComponent();
        }
        // Connection String //
        string cs = @"Data Source=SHIHAB;Initial Catalog=TrainStation;Integrated Security=True";
        
        void BindData()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM User_StationMaster", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewStMaster.DataSource = dt;
        }
        
        private void btnExportData_Click(object sender, EventArgs e) // Export data button //
        {
            dataGridViewStMaster.SelectAll();
            DataObject copydata = dataGridViewStMaster.GetClipboardContent();
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

        private void DataTableAdmin_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnLoadData_Click(object sender, EventArgs e) // Load data button //
        {
            BindData();
        }

        private void btnBack_Click(object sender, EventArgs e) // Back button //
        {
            this.Hide();
            AdminForm af = new AdminForm();
            af.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDirectExitX_Click(object sender, EventArgs e) // Direct Exit [X] button
        {
            this.Hide();
            new AdminForm().Show();
        }
    }
}
