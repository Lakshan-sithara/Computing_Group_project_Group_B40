namespace Schoolmanagementsystem
{
    partial class Registerform
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
            panel1 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            label7 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            button7 = new Button();
            label8 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 13, 60);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(59, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 395);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PowderBlue;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(checkedListBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(321, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 364);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(84, 327);
            button1.Name = "button1";
            button1.Size = new Size(135, 32);
            button1.TabIndex = 11;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(27, 280);
            label7.Name = "label7";
            label7.Size = new Size(103, 16);
            label7.TabIndex = 10;
            label7.Text = "Confirm password";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(27, 298);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 198);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 249);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 23);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(27, 230);
            label6.Name = "label6";
            label6.Size = new Size(104, 16);
            label6.TabIndex = 5;
            label6.Text = "Create a password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 179);
            label4.Name = "label4";
            label4.Size = new Size(63, 16);
            label4.TabIndex = 4;
            label4.Text = "Your name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 130);
            label3.Name = "label3";
            label3.Size = new Size(148, 16);
            label3.TabIndex = 3;
            label3.Text = "User Name (Index Number)\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 23);
            label2.Name = "label2";
            label2.Size = new Size(40, 16);
            label2.TabIndex = 2;
            label2.Text = "Select";
            label2.Click += label2_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Student", "Academic", "Non-Academic", "Parent", "Admin" });
            checkedListBox1.Location = new Point(27, 42);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(173, 79);
            checkedListBox1.TabIndex = 1;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(115, 3);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "REGISTER";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 96, 110);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox2);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 395);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(67, 258);
            label5.Name = "label5";
            label5.Size = new Size(181, 20);
            label5.TabIndex = 3;
            label5.Text = "THE TEURLINGS COLLAGE";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = Properties.Resources.TCHS_primary_crest_FC;
            pictureBox2.Location = new Point(68, 73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 172);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(button7);
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(737, 28);
            panel4.TabIndex = 5;
            // 
            // button7
            // 
            button7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(711, 2);
            button7.Name = "button7";
            button7.Size = new Size(23, 23);
            button7.TabIndex = 7;
            button7.Text = "X";
            button7.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 6);
            label8.Name = "label8";
            label8.Size = new Size(164, 15);
            label8.TabIndex = 1;
            label8.Text = "School Management System";
            // 
            // Registerform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(737, 468);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registerform";
            Text = "signinform";
            Load += Registerform_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label5;
        private Panel panel3;
        private CheckedListBox checkedListBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label7;
        private TextBox textBox4;
        private Panel panel4;
        private Label label8;
        private Button button7;
    }
}