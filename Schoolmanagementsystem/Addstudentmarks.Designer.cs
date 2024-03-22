namespace Schoolmanagementsystem
{
    partial class Addstudentmarks
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
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button6 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            button9 = new Button();
            label3 = new Label();
            SIDBox = new TextBox();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            subjectTB = new TextBox();
            MarksTB = new TextBox();
            button7 = new Button();
            addMarksDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addMarksDGV).BeginInit();
            SuspendLayout();
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
            button6.Location = new Point(0, 542);
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
            button1.Location = new Point(0, 72);
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
            panel1.TabIndex = 5;
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
            panel3.TabIndex = 6;
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
            // SIDBox
            // 
            SIDBox.Location = new Point(469, 85);
            SIDBox.Margin = new Padding(3, 4, 3, 4);
            SIDBox.Name = "SIDBox";
            SIDBox.Size = new Size(172, 27);
            SIDBox.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(246, 89);
            label7.Name = "label7";
            label7.Size = new Size(211, 18);
            label7.TabIndex = 28;
            label7.Text = "Student's Admission Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(246, 193);
            label1.Name = "label1";
            label1.Size = new Size(62, 18);
            label1.TabIndex = 30;
            label1.Text = "Subject";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(459, 185);
            label2.Name = "label2";
            label2.Size = new Size(51, 18);
            label2.TabIndex = 31;
            label2.Text = "Marks";
            // 
            // subjectTB
            // 
            subjectTB.Location = new Point(246, 221);
            subjectTB.Margin = new Padding(3, 4, 3, 4);
            subjectTB.Name = "subjectTB";
            subjectTB.Size = new Size(172, 27);
            subjectTB.TabIndex = 32;
            // 
            // MarksTB
            // 
            MarksTB.Location = new Point(459, 221);
            MarksTB.Margin = new Padding(3, 4, 3, 4);
            MarksTB.Name = "MarksTB";
            MarksTB.Size = new Size(138, 27);
            MarksTB.TabIndex = 33;
            // 
            // button7
            // 
            button7.BackColor = Color.Teal;
            button7.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(689, 214);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(115, 39);
            button7.TabIndex = 93;
            button7.Text = "ADD";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // addMarksDGV
            // 
            addMarksDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addMarksDGV.Location = new Point(273, 276);
            addMarksDGV.Name = "addMarksDGV";
            addMarksDGV.RowHeadersWidth = 51;
            addMarksDGV.RowTemplate.Height = 29;
            addMarksDGV.Size = new Size(502, 318);
            addMarksDGV.TabIndex = 94;
            // 
            // Addstudentmarks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 243, 245);
            ClientSize = new Size(842, 624);
            Controls.Add(addMarksDGV);
            Controls.Add(button7);
            Controls.Add(MarksTB);
            Controls.Add(subjectTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SIDBox);
            Controls.Add(label7);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Addstudentmarks";
            Text = "Addstudentmarks";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addMarksDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private PictureBox pictureBox1;
        private Button button6;
        private Button button1;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Button button9;
        private Label label3;
        private TextBox SIDBox;
        private Label label7;
        private Label label1;
        private Label label2;
        private TextBox subjectTB;
        private TextBox MarksTB;
        private Button button7;
        private DataGridView addMarksDGV;
    }
}