namespace ITP4915
{
    partial class FormMainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ProjectdataGridView1 = new DataGridView();
            label2 = new Label();
            panel1 = new Panel();
            buttonSystemMaintenance = new Button();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            button5SystemMaintenance = new Button();
            button4CustomerProfile = new Button();
            Button3InventoryControl = new Button();
            button2ProjectManagement = new Button();
            button6ProductSpecificationManagement = new Button();
            button1SalesOrderManagement = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)ProjectdataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(771, 9);
            label1.Name = "label1";
            label1.Size = new Size(17, 18);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // ProjectdataGridView1
            // 
            ProjectdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProjectdataGridView1.Location = new Point(241, 58);
            ProjectdataGridView1.Name = "ProjectdataGridView1";
            ProjectdataGridView1.Size = new Size(538, 372);
            ProjectdataGridView1.TabIndex = 4;
            ProjectdataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(88, 19);
            label2.TabIndex = 2;
            label2.Text = "Welcome!";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 52, 110);
            panel1.Controls.Add(buttonSystemMaintenance);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button5SystemMaintenance);
            panel1.Controls.Add(button4CustomerProfile);
            panel1.Controls.Add(Button3InventoryControl);
            panel1.Controls.Add(button2ProjectManagement);
            panel1.Controls.Add(button6ProductSpecificationManagement);
            panel1.Controls.Add(button1SalesOrderManagement);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 450);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // buttonSystemMaintenance
            // 
            buttonSystemMaintenance.BackColor = Color.FromArgb(110, 172, 218);
            buttonSystemMaintenance.FlatStyle = FlatStyle.Flat;
            buttonSystemMaintenance.Location = new Point(12, 379);
            buttonSystemMaintenance.Name = "buttonSystemMaintenance";
            buttonSystemMaintenance.Size = new Size(199, 27);
            buttonSystemMaintenance.TabIndex = 6;
            buttonSystemMaintenance.Text = "System Maintenance";
            buttonSystemMaintenance.UseVisualStyleBackColor = false;
            buttonSystemMaintenance.Click += button1SystemMaintenance_Click_1;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(110, 172, 218);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(70, 75);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(131, 25);
            dataGridView2.TabIndex = 5;
            dataGridView2.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(110, 172, 218);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(70, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(131, 25);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // button5SystemMaintenance
            // 
            button5SystemMaintenance.BackColor = Color.FromArgb(110, 172, 218);
            button5SystemMaintenance.FlatStyle = FlatStyle.Flat;
            button5SystemMaintenance.Location = new Point(12, 411);
            button5SystemMaintenance.Name = "button5SystemMaintenance";
            button5SystemMaintenance.Size = new Size(199, 27);
            button5SystemMaintenance.TabIndex = 4;
            button5SystemMaintenance.Text = "Security Control";
            button5SystemMaintenance.UseVisualStyleBackColor = false;
            button5SystemMaintenance.Click += button5SecurityControl_Click;
            // 
            // button4CustomerProfile
            // 
            button4CustomerProfile.BackColor = Color.FromArgb(110, 172, 218);
            button4CustomerProfile.FlatStyle = FlatStyle.Flat;
            button4CustomerProfile.Location = new Point(12, 272);
            button4CustomerProfile.Name = "button4CustomerProfile";
            button4CustomerProfile.Size = new Size(199, 27);
            button4CustomerProfile.TabIndex = 4;
            button4CustomerProfile.Text = "Customer Profile";
            button4CustomerProfile.UseVisualStyleBackColor = false;
            button4CustomerProfile.Click += button4CustomerProfile_Click;
            // 
            // Button3InventoryControl
            // 
            Button3InventoryControl.BackColor = Color.FromArgb(110, 172, 218);
            Button3InventoryControl.FlatStyle = FlatStyle.Flat;
            Button3InventoryControl.Location = new Point(12, 239);
            Button3InventoryControl.Name = "Button3InventoryControl";
            Button3InventoryControl.Size = new Size(199, 27);
            Button3InventoryControl.TabIndex = 4;
            Button3InventoryControl.Text = "Inventory Control";
            Button3InventoryControl.UseVisualStyleBackColor = false;
            Button3InventoryControl.Click += button3InventoryControl_Click;
            // 
            // button2ProjectManagement
            // 
            button2ProjectManagement.BackColor = Color.FromArgb(110, 172, 218);
            button2ProjectManagement.FlatStyle = FlatStyle.Flat;
            button2ProjectManagement.Location = new Point(12, 206);
            button2ProjectManagement.Name = "button2ProjectManagement";
            button2ProjectManagement.Size = new Size(199, 27);
            button2ProjectManagement.TabIndex = 4;
            button2ProjectManagement.Text = "Project Management";
            button2ProjectManagement.UseVisualStyleBackColor = false;
            button2ProjectManagement.Click += button2ProjectManagement_Click;
            // 
            // button6ProductSpecificationManagement
            // 
            button6ProductSpecificationManagement.BackColor = Color.FromArgb(110, 172, 218);
            button6ProductSpecificationManagement.FlatStyle = FlatStyle.Flat;
            button6ProductSpecificationManagement.Location = new Point(12, 125);
            button6ProductSpecificationManagement.Name = "button6ProductSpecificationManagement";
            button6ProductSpecificationManagement.Size = new Size(199, 43);
            button6ProductSpecificationManagement.TabIndex = 4;
            button6ProductSpecificationManagement.Text = "Product Specification Management";
            button6ProductSpecificationManagement.UseVisualStyleBackColor = false;
            button6ProductSpecificationManagement.Click += button6ProductSpecificationManagement_Click;
            // 
            // button1SalesOrderManagement
            // 
            button1SalesOrderManagement.BackColor = Color.FromArgb(110, 172, 218);
            button1SalesOrderManagement.FlatStyle = FlatStyle.Flat;
            button1SalesOrderManagement.Location = new Point(12, 173);
            button1SalesOrderManagement.Name = "button1SalesOrderManagement";
            button1SalesOrderManagement.Size = new Size(199, 27);
            button1SalesOrderManagement.TabIndex = 4;
            button1SalesOrderManagement.Text = "Sales Order Management";
            button1SalesOrderManagement.UseVisualStyleBackColor = false;
            button1SalesOrderManagement.Click += button1SalesOrderManagement_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(35, 75);
            label5.Name = "label5";
            label5.Size = new Size(29, 18);
            label5.TabIndex = 2;
            label5.Text = "ID:";
            label5.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(12, 46);
            label4.Name = "label4";
            label4.Size = new Size(52, 18);
            label4.TabIndex = 2;
            label4.Text = "Name:";
            label4.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(231, 9);
            label3.Name = "label3";
            label3.Size = new Size(94, 19);
            label3.TabIndex = 2;
            label3.Text = "Main Page";
            label3.Click += label2_Click;
            // 
            // FormMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProjectdataGridView1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMainPage";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "FormMainPage";
            Load += FormMainPage_Load;
            ((System.ComponentModel.ISupportInitialize)ProjectdataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView ProjectdataGridView1;
        private Label label2;
        private Panel panel1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Button button5SystemMaintenance;
        private Button button4CustomerProfile;
        private Button Button3InventoryControl;
        private Button button2ProjectManagement;
        private Button button6ProductSpecificationManagement;
        private Button button1SalesOrderManagement;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button buttonSystemMaintenance;
        
    }
}