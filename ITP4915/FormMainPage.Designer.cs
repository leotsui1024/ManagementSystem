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
            label2 = new Label();
            panel1 = new Panel();
            StaffIDtextBox1 = new TextBox();
            StaffNametextBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(StaffIDtextBox1);
            panel1.Controls.Add(StaffNametextBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 450);
            panel1.TabIndex = 3;
            // 
            // StaffIDtextBox1
            // 
            StaffIDtextBox1.BackColor = Color.FromArgb(3, 52, 110);
            StaffIDtextBox1.Location = new Point(12, 70);
            StaffIDtextBox1.Name = "StaffIDtextBox1";
            StaffIDtextBox1.Size = new Size(100, 23);
            StaffIDtextBox1.TabIndex = 4;
            StaffIDtextBox1.TextChanged += StaffIDtextBox1_TextChanged;
            // 
            // StaffNametextBox1
            // 
            StaffNametextBox1.BackColor = Color.FromArgb(3, 52, 110);
            StaffNametextBox1.Location = new Point(12, 41);
            StaffNametextBox1.Name = "StaffNametextBox1";
            StaffNametextBox1.Size = new Size(100, 23);
            StaffNametextBox1.TabIndex = 4;
            StaffNametextBox1.TextChanged += StaffNametextBox1_TextChanged;
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
            // button1
            // 
            button1.Location = new Point(12, 158);
            button1.Name = "button1";
            button1.Size = new Size(210, 27);
            button1.TabIndex = 4;
            button1.Text = "Sales Order Management";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 191);
            button2.Name = "button2";
            button2.Size = new Size(210, 27);
            button2.TabIndex = 4;
            button2.Text = "Project Management";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 224);
            button3.Name = "button3";
            button3.Size = new Size(210, 27);
            button3.TabIndex = 4;
            button3.Text = "Inventory Management";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 257);
            button4.Name = "button4";
            button4.Size = new Size(210, 27);
            button4.TabIndex = 4;
            button4.Text = "Customer Management";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 290);
            button5.Name = "button5";
            button5.Size = new Size(210, 27);
            button5.TabIndex = 4;
            button5.Text = "System Maintenance";
            button5.UseVisualStyleBackColor = true;
            // 
            // FormMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMainPage";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "FormMainPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private TextBox StaffIDtextBox1;
        private TextBox StaffNametextBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}