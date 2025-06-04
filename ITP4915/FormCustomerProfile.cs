using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915
{
    public partial class FormCustomerProfile : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ITP4915M.accdb");
        public FormCustomerProfile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6ProductSpecificationManagement_Click(object sender, EventArgs e)
        {
            FormProductSpecifationManagement formTarget = new FormProductSpecifationManagement();
            formTarget.Show();
            this.Hide();
        }

        private void button1SalesOrderManagement_Click(object sender, EventArgs e)
        {
            FormSalesOrderManagement formTarget = new FormSalesOrderManagement();
            formTarget.Show();
            this.Hide();
        }

        private void button2ProjectManagement_Click(object sender, EventArgs e)
        {
            FormProjectManagement formTarget = new FormProjectManagement();
            formTarget.Show();
            this.Hide();
        }

        private void Button3InventoryControl_Click(object sender, EventArgs e)
        {
            FormInventoryControl formTarget = new FormInventoryControl();
            formTarget.Show();
            this.Hide();
        }

        private void button4CustomerProfile_Click(object sender, EventArgs e)
        {
            FormCustomerProfile formTarget = new FormCustomerProfile();
            formTarget.Show();
            this.Hide();
        }

        private void buttonSystemMaintenance_Click(object sender, EventArgs e)
        {
            FormSystemMaintenance formTarget = new FormSystemMaintenance();
            formTarget.Show();
            this.Hide();
        }

        private void button5SystemMaintenance_Click(object sender, EventArgs e)
        {
            FormSecurityControl formTarget = new FormSecurityControl();
            formTarget.Show();
            this.Hide();
        }
        private void FillDGV()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string query = "SELECT * FROM [Customer]";
                OleDbDataAdapter da = new OleDbDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void FormCustomerProfile_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
