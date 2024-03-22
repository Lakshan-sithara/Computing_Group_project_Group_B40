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
            AddressTB = new TextBox();
            label11 = new Label();
            label6 = new Label();
            ADDTP = new DateTimePicker();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            DOBDTB = new DateTimePicker();
            MobileTB = new TextBox();
            AIDTB = new TextBox();
            ReTB = new TextBox();
            NICTB = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            nameTB = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
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
            panel4.Controls.Add(AddressTB);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(ADDTP);
            panel4.Controls.Add(radioButton2);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(radioButton1);
            panel4.Controls.Add(DOBDTB);
            panel4.Controls.Add(MobileTB);
            panel4.Controls.Add(AIDTB);
            panel4.Controls.Add(ReTB);
            panel4.Controls.Add(NICTB);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(nameTB);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(424, 88);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(391, 507);
            panel4.TabIndex = 14;
            // 
            // AddressTB
            // 
            AddressTB.Location = new Point(130, 310);
            AddressTB.Margin = new Padding(3, 4, 3, 4);
            AddressTB.Name = "AddressTB";
            AddressTB.Size = new Size(246, 27);
            AddressTB.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 310);
            label11.Name = "label11";
            label11.Size = new Size(62, 20);
            label11.TabIndex = 33;
            label11.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 268);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 32;
            label6.Text = "Mobile No";
            // 
            // ADDTP
            // 
            ADDTP.Location = new Point(130, 222);
            ADDTP.Name = "ADDTP";
            ADDTP.Size = new Size(246, 27);
            ADDTP.TabIndex = 31;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(199, 154);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 24);
            radioButton2.TabIndex = 28;
            radioButton2.TabStop = true;
            radioButton2.Text = "female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(130, 154);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 27;
            radioButton1.TabStop = true;
            radioButton1.Text = "male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // DOBDTB
            // 
            DOBDTB.Location = new Point(130, 117);
            DOBDTB.Name = "DOBDTB";
            DOBDTB.Size = new Size(246, 27);
            DOBDTB.TabIndex = 26;
            // 
            // MobileTB
            // 
            MobileTB.Location = new Point(130, 265);
            MobileTB.Margin = new Padding(3, 4, 3, 4);
            MobileTB.Name = "MobileTB";
            MobileTB.Size = new Size(246, 27);
            MobileTB.TabIndex = 25;
            // 
            // AIDTB
            // 
            AIDTB.Location = new Point(130, 13);
            AIDTB.Margin = new Padding(3, 4, 3, 4);
            AIDTB.Name = "AIDTB";
            AIDTB.Size = new Size(246, 27);
            AIDTB.TabIndex = 24;
            AIDTB.TextChanged += textBox6_TextChanged;
            // 
            // ReTB
            // 
            ReTB.Location = new Point(130, 185);
            ReTB.Margin = new Padding(3, 4, 3, 4);
            ReTB.Name = "ReTB";
            ReTB.Size = new Size(246, 27);
            ReTB.TabIndex = 23;
            ReTB.TextChanged += textBox5_TextChanged;
            // 
            // NICTB
            // 
            NICTB.Location = new Point(130, 83);
            NICTB.Margin = new Padding(3, 4, 3, 4);
            NICTB.Name = "NICTB";
            NICTB.Size = new Size(246, 27);
            NICTB.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 227);
            label10.Name = "label10";
            label10.Size = new Size(114, 20);
            label10.TabIndex = 19;
            label10.Text = "Admission Date";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 20);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 18;
            label9.Text = "Staff ID";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 193);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 17;
            label8.Text = "Religion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 161);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 16;
            label7.Text = "Gender";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 126);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 15;
            label5.Text = "Date Of Birth";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 91);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 14;
            label2.Text = "ID Number";
            // 
            // nameTB
            // 
            nameTB.Location = new Point(130, 48);
            nameTB.Margin = new Padding(3, 4, 3, 4);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(246, 27);
            nameTB.TabIndex = 13;
            nameTB.TextChanged += nameTB_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 48);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
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
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label2;
        private TextBox nameTB;
        private Label label9;
        private Label label10;
        private TextBox ReTB;
        private TextBox NICTB;
        private TextBox MobileTB;
        private TextBox AIDTB;
        private Button button9;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker DOBDTB;
        private Label label6;
        private DateTimePicker ADDTP;
        private TextBox AddressTB;
        private Label label11;
    }
}