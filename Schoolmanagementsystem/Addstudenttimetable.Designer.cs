namespace Schoolmanagementsystem
{
    partial class Addstudenttimetable
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
            label14 = new Label();
            pictureBox1 = new PictureBox();
            button6 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            button8 = new Button();
            label4 = new Label();
            ttDTP = new DateTimePicker();
            su1TB = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button7 = new Button();
            day1 = new ComboBox();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            groupBox3 = new GroupBox();
            radioButton11 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
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
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 0, 0);
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(0, 594);
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
            button1.Location = new Point(1, 78);
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 35, 138);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 745);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(157, 177, 247);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(215, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(630, 59);
            panel3.TabIndex = 15;
            panel3.Paint += panel3_Paint;
            // 
            // button8
            // 
            button8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(593, 12);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(26, 31);
            button8.TabIndex = 13;
            button8.Text = "X";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(134, 16);
            label4.Name = "label4";
            label4.Size = new Size(229, 22);
            label4.TabIndex = 11;
            label4.Text = "Add Student's timetable";
            // 
            // ttDTP
            // 
            ttDTP.Format = DateTimePickerFormat.Time;
            ttDTP.Location = new Point(232, 277);
            ttDTP.Margin = new Padding(3, 4, 3, 4);
            ttDTP.Name = "ttDTP";
            ttDTP.Size = new Size(228, 27);
            ttDTP.TabIndex = 16;
            // 
            // su1TB
            // 
            su1TB.Location = new Point(688, 277);
            su1TB.Margin = new Padding(3, 4, 3, 4);
            su1TB.Name = "su1TB";
            su1TB.Size = new Size(131, 27);
            su1TB.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(499, 255);
            label1.Name = "label1";
            label1.Size = new Size(34, 18);
            label1.TabIndex = 19;
            label1.Text = "Day";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(232, 255);
            label5.Name = "label5";
            label5.Size = new Size(43, 18);
            label5.TabIndex = 20;
            label5.Text = "Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(688, 253);
            label6.Name = "label6";
            label6.Size = new Size(62, 18);
            label6.TabIndex = 21;
            label6.Text = "Subject";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(230, 96);
            label7.Name = "label7";
            label7.Size = new Size(52, 18);
            label7.TabIndex = 25;
            label7.Text = "Grade";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(499, 96);
            label8.Name = "label8";
            label8.Size = new Size(47, 18);
            label8.TabIndex = 26;
            label8.Text = "Class";
            // 
            // button7
            // 
            button7.BackColor = Color.Teal;
            button7.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(704, 350);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(115, 39);
            button7.TabIndex = 91;
            button7.Text = "ADD";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // day1
            // 
            day1.FormattingEnabled = true;
            day1.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saterday", "Sunday" });
            day1.Location = new Point(480, 276);
            day1.Name = "day1";
            day1.Size = new Size(151, 28);
            day1.TabIndex = 92;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Location = new Point(288, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(125, 173);
            groupBox2.TabIndex = 104;
            groupBox2.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(24, 26);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(82, 24);
            radioButton3.TabIndex = 71;
            radioButton3.TabStop = true;
            radioButton3.Text = "Grade 1";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(24, 146);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(82, 24);
            radioButton7.TabIndex = 75;
            radioButton7.TabStop = true;
            radioButton7.Text = "Grade 5";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(24, 56);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(82, 24);
            radioButton4.TabIndex = 72;
            radioButton4.TabStop = true;
            radioButton4.Text = "Grade 2";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(24, 116);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(82, 24);
            radioButton6.TabIndex = 74;
            radioButton6.TabStop = true;
            radioButton6.Text = "Grade 4";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(24, 86);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(82, 24);
            radioButton5.TabIndex = 73;
            radioButton5.TabStop = true;
            radioButton5.Text = "Grade 3";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton11);
            groupBox3.Controls.Add(radioButton10);
            groupBox3.Controls.Add(radioButton9);
            groupBox3.Controls.Add(radioButton8);
            groupBox3.Location = new Point(552, 66);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(129, 152);
            groupBox3.TabIndex = 105;
            groupBox3.TabStop = false;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(23, 114);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(41, 24);
            radioButton11.TabIndex = 79;
            radioButton11.TabStop = true;
            radioButton11.Text = "D";
            radioButton11.UseVisualStyleBackColor = true;
            radioButton11.CheckedChanged += radioButton11_CheckedChanged;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(23, 84);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(39, 24);
            radioButton10.TabIndex = 78;
            radioButton10.TabStop = true;
            radioButton10.Text = "C";
            radioButton10.UseVisualStyleBackColor = true;
            radioButton10.CheckedChanged += radioButton10_CheckedChanged;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(23, 54);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(39, 24);
            radioButton9.TabIndex = 77;
            radioButton9.TabStop = true;
            radioButton9.Text = "B";
            radioButton9.UseVisualStyleBackColor = true;
            radioButton9.CheckedChanged += radioButton9_CheckedChanged;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(23, 26);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(40, 24);
            radioButton8.TabIndex = 76;
            radioButton8.TabStop = true;
            radioButton8.Text = "A";
            radioButton8.UseVisualStyleBackColor = true;
            radioButton8.CheckedChanged += radioButton8_CheckedChanged;
            // 
            // Addstudenttimetable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 243, 245);
            ClientSize = new Size(842, 743);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(day1);
            Controls.Add(button7);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(su1TB);
            Controls.Add(ttDTP);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Addstudenttimetable";
            Text = "Addstudenttimetable";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label14;
        private PictureBox pictureBox1;
        private Button button6;
        private Button button1;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Button button8;
        private Label label4;
        private DateTimePicker ttDTP;
        private TextBox su1TB;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button7;
        private ComboBox day1;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton7;
        private RadioButton radioButton4;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private GroupBox groupBox3;
        private RadioButton radioButton11;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
    }
}