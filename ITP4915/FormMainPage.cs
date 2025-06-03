using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915
{
    public partial class FormMainPage : Form
    {
        public FormMainPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StaffNametextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StaffIDtextBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button3InventoryControl_Click(object sender, EventArgs e)
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

        private void button5SecurityControl_Click(object sender, EventArgs e)
        {
            FormSecurityControl formTarget = new FormSecurityControl();
            formTarget.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormSalesOrderManagement formTarget = new FormSalesOrderManagement();
            formTarget.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6ProductSpecificationManagement_Click(object sender, EventArgs e)
        {
            FormProductSpecifationManagement formTarget = new FormProductSpecifationManagement();
            formTarget.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1SystemMaintenance_Click_1(object sender, EventArgs e)
        {
            FormSystemMaintenance formTarget = new FormSystemMaintenance();
            formTarget.Show();
            this.Hide();
        }

        private void FormMainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
