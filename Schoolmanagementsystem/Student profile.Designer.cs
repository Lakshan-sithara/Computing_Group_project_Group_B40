namespace Schoolmanagementsystem
{
    partial class Student_profile
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
            button1 = new Button();
            panel2 = new Panel();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel3 = new Panel();
            button9 = new Button();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            SIDTB = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            button7 = new Button();
            button8 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 35, 138);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 627);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 35, 138);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 71);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(215, 52);
            button1.TabIndex = 1;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(220, 115, 116);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 59);
            panel2.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(57, 9);
            label14.Name = "label14";
            label14.Size = new Size(145, 34);
            label14.TabIndex = 8;
            label14.Text = "School Management \r\nSystem";
            label14.TextAlign = ContentAlignment.TopCenter;
            label14.Click += label14_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TCHS_primary_crest_FC;
            pictureBox1.Location = new Point(3, 8);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 15);
            label3.Name = "label3";
            label3.Size = new Size(121, 23);
            label3.TabIndex = 0;
            label3.Text = "Student Profile";
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(157, 177, 247);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(215, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(631, 59);
            panel3.TabIndex = 2;
            // 
            // button9
            // 
            button9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(594, 8);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(26, 31);
            button9.TabIndex = 7;
            button9.Text = "X";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(205, 243, 245);
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(SIDTB);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(403, 71);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(430, 540);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(366, 221);
            dataGridView1.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(307, 25);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "Show";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SIDTB
            // 
            SIDTB.Location = new Point(133, 23);
            SIDTB.Margin = new Padding(3, 4, 3, 4);
            SIDTB.Name = "SIDTB";
            SIDTB.Size = new Size(156, 27);
            SIDTB.TabIndex = 12;
            SIDTB.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 23);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter your SID";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.student1;
            pictureBox2.Location = new Point(247, 91);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 168);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button7
            // 
            button7.BackColor = Color.MidnightBlue;
            button7.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(238, 285);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(154, 43);
            button7.TabIndex = 12;
            button7.Text = "Exam Result";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.MidnightBlue;
            button8.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(238, 340);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(154, 43);
            button8.TabIndex = 13;
            button8.Text = "Time Table";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Student_profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 145, 240);
            ClientSize = new Size(842, 624);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(pictureBox2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Student_profile";
            Text = "Student_profile";
            Load += Student_profile_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Button button7;
        private Button button8;
        private Label label2;
        private TextBox SIDTB;
        private Label label14;
        private Button button9;
        private DataGridView dataGridView1;
        private Button button2;
    }
}