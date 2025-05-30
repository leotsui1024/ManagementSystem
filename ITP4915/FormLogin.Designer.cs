namespace ITP4915
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 52, 110);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 400);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bowlby One SC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(23, 137);
            label6.Name = "label6";
            label6.Size = new Size(196, 60);
            label6.TabIndex = 6;
            label6.Text = "Smile and \r\nSunshine Toy Co.";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(12, 372);
            label5.Name = "label5";
            label5.Size = new Size(155, 19);
            label5.TabIndex = 6;
            label5.Text = "Management System";
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_project_80;
            pictureBox1.Location = new Point(78, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(245, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 400);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 21, 38);
            button1.FlatAppearance.BorderColor = SystemColors.Window;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(34, 252);
            button1.Name = "button1";
            button1.Size = new Size(85, 28);
            button1.TabIndex = 4;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 23);
            textBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(34, 178);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 2;
            label4.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += this.textBox1_TextChanged_2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(34, 119);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Unicode MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(15, 59);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 1;
            label2.Text = "LOGIN";
            label2.Click += this.label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 4);
            label1.Name = "label1";
            label1.Size = new Size(17, 18);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click_1;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 400);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Text = "FormLogin";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
    }
}
