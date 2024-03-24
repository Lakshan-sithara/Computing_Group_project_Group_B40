namespace Schoolmanagementsystem
{
    partial class AcademicStaffProfile
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
            button6 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            button9 = new Button();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            button8 = new Button();
            panel4 = new Panel();
            teacherDGV = new DataGridView();
            button2 = new Button();
            label9 = new Label();
            AIDTB = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teacherDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 35, 138);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 627);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 0, 0);
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(0, 543);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(215, 52);
            button6.TabIndex = 6;
            button6.Text = "LogOut";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 35, 138);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 67);
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
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 59);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(51, 12);
            label4.Name = "label4";
            label4.Size = new Size(145, 34);
            label4.TabIndex = 8;
            label4.Text = "School Management \r\nSystem";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click_1;
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
            pictureBox1.Click += pictureBox1_Click_1;
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
            panel3.TabIndex = 5;
            // 
            // button9
            // 
            button9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(594, 9);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(26, 31);
            button9.TabIndex = 7;
            button9.Text = "X";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 16);
            label3.Name = "label3";
            label3.Size = new Size(213, 22);
            label3.TabIndex = 0;
            label3.Text = "Academic Staff Profile";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.academic_1;
            pictureBox2.Location = new Point(232, 79);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 168);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // button8
            // 
            button8.BackColor = Color.MidnightBlue;
            button8.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(232, 292);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(171, 43);
            button8.TabIndex = 13;
            button8.Text = "Add Student's Marks";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(205, 243, 245);
            panel4.Controls.Add(teacherDGV);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(AIDTB);
            panel4.Location = new Point(424, 88);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(391, 507);
            panel4.TabIndex = 14;
            // 
            // teacherDGV
            // 
            teacherDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teacherDGV.Location = new Point(37, 83);
            teacherDGV.Name = "teacherDGV";
            teacherDGV.RowHeadersWidth = 51;
            teacherDGV.RowTemplate.Height = 29;
            teacherDGV.Size = new Size(320, 199);
            teacherDGV.TabIndex = 26;
            // 
            // button2
            // 
            button2.Location = new Point(243, 20);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 25;
            button2.Text = "Show";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 24);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 18;
            label9.Text = "Staff ID";
            label9.Click += label9_Click;
            // 
            // AIDTB
            // 
            AIDTB.Location = new Point(84, 20);
            AIDTB.Margin = new Padding(3, 4, 3, 4);
            AIDTB.Name = "AIDTB";
            AIDTB.Size = new Size(129, 27);
            AIDTB.TabIndex = 24;
            AIDTB.TextChanged += textBox6_TextChanged;
            // 
            // AcademicStaffProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 145, 240);
            ClientSize = new Size(842, 624);
            Controls.Add(panel4);
            Controls.Add(button8);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AcademicStaffProfile";
            Text = "AcademicStaffProfile";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teacherDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private Button button1;
        private Panel panel2;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox2;
        private Button button8;
        private Panel panel4;
        private Label label9;
        private TextBox AIDTB;
        private Button button9;
        private DataGridView teacherDGV;
        private Button button2;
    }
}