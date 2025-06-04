using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ITP4915
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=4915M.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btnLogin
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ITP4915M.accdb;";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Staff WHERE Staff_ID = @userID and Staff_Password = @password";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", textBox1.Text);
                    command.Parameters.AddWithValue("@password", textBox2.Text);

                    OleDbDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // ✅ 讀取員工姓名與 ID
                        string userID = reader["Staff_ID"]!.ToString();
                        string userName = reader["Staff_Name"]!.ToString();

                        // ✅ 傳入 FormMainPage
                        FormMainPage formTarget = new FormMainPage();
                        formTarget.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid UserID or Password, Please Try Again!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox1.Focus();
                    }
                    reader.Close();
                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
