namespace Schoolmanagementsystem
{
    partial class AddYearschedule
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
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            yearStart = new DateTimePicker();
            label1 = new Label();
            label5 = new Label();
            yearEnd = new DateTimePicker();
            termStart = new DateTimePicker();
            termEnd = new DateTimePicker();
            button7 = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
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
            button6.Location = new Point(0, 668);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(215, 52);
            button6.TabIndex = 6;
            button6.Text = "Admin";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 35, 138);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 84);
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
            panel1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(157, 177, 247);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(215, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(722, 59);
            panel3.TabIndex = 16;
            // 
            // button8
            // 
            button8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(685, 12);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(26, 31);
            button8.TabIndex = 13;
            button8.Text = "X";
            button8.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(95, 16);
            label2.Name = "label2";
            label2.Size = new Size(19, 19);
            label2.TabIndex = 12;
            label2.Text = ">";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(130, 15);
            label4.Name = "label4";
            label4.Size = new Size(184, 22);
            label4.TabIndex = 11;
            label4.Text = "Add Year schedule";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 16);
            label3.Name = "label3";
            label3.Size = new Size(69, 22);
            label3.TabIndex = 0;
            label3.Text = "Admin";
            // 
            // yearStart
            // 
            yearStart.Format = DateTimePickerFormat.Short;
            yearStart.Location = new Point(345, 192);
            yearStart.Margin = new Padding(3, 4, 3, 4);
            yearStart.Name = "yearStart";
            yearStart.Size = new Size(218, 27);
            yearStart.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(345, 161);
            label1.Name = "label1";
            label1.Size = new Size(42, 18);
            label1.TabIndex = 28;
            label1.Text = "Start";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(583, 161);
            label5.Name = "label5";
            label5.Size = new Size(36, 18);
            label5.TabIndex = 29;
            label5.Text = "End";
            // 
            // yearEnd
            // 
            yearEnd.Format = DateTimePickerFormat.Short;
            yearEnd.Location = new Point(583, 192);
            yearEnd.Margin = new Padding(3, 4, 3, 4);
            yearEnd.Name = "yearEnd";
            yearEnd.Size = new Size(218, 27);
            yearEnd.TabIndex = 30;
            // 
            // termStart
            // 
            termStart.Format = DateTimePickerFormat.Short;
            termStart.Location = new Point(345, 340);
            termStart.Margin = new Padding(3, 4, 3, 4);
            termStart.Name = "termStart";
            termStart.Size = new Size(218, 27);
            termStart.TabIndex = 36;
            // 
            // termEnd
            // 
            termEnd.Format = DateTimePickerFormat.Short;
            termEnd.Location = new Point(583, 340);
            termEnd.Margin = new Padding(3, 4, 3, 4);
            termEnd.Name = "termEnd";
            termEnd.Size = new Size(218, 27);
            termEnd.TabIndex = 39;
            // 
            // button7
            // 
            button7.BackColor = Color.Teal;
            button7.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(790, 464);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(115, 39);
            button7.TabIndex = 92;
            button7.Text = "ADD";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(534, 112);
            label9.Name = "label9";
            label9.Size = new Size(52, 24);
            label9.TabIndex = 93;
            label9.Text = "Year";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(345, 315);
            label10.Name = "label10";
            label10.Size = new Size(42, 18);
            label10.TabIndex = 94;
            label10.Text = "Start";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(534, 289);
            label11.Name = "label11";
            label11.Size = new Size(58, 24);
            label11.TabIndex = 95;
            label11.Text = "Term";
            // 
            // AddYearschedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 243, 245);
            ClientSize = new Size(935, 743);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button7);
            Controls.Add(termEnd);
            Controls.Add(termStart);
            Controls.Add(yearEnd);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(yearStart);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddYearschedule";
            Text = "AddYearschedule";
            Load += AddYearschedule_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Label label2;
        private Label label4;
        private Label label3;
        private DateTimePicker yearStart;
        private Label label1;
        private Label label5;
        private DateTimePicker yearEnd;
        private DateTimePicker termStart;
        private DateTimePicker termEnd;
        private Button button7;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}