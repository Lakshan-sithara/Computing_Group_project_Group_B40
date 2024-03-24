namespace Schoolmanagementsystem
{
    partial class Non_academic_profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Non_academic_profile));
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button6 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            button7 = new Button();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            nonDGV = new DataGridView();
            button9 = new Button();
            label6 = new Label();
            NAIDTB = new TextBox();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nonDGV).BeginInit();
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
            pictureBox1.Location = new Point(3, 5);
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
            button6.Location = new Point(0, 460);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(215, 52);
            button6.TabIndex = 6;
            button6.Text = "LogOut";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
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
            panel3.Controls.Add(button7);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(215, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(631, 59);
            panel3.TabIndex = 6;
            // 
            // button7
            // 
            button7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(594, 8);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(26, 31);
            button7.TabIndex = 7;
            button7.Text = "X";
            button7.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 16);
            label3.Name = "label3";
            label3.Size = new Size(256, 22);
            label3.TabIndex = 0;
            label3.Text = "Non-Academic Staff Profile";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(232, 80);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(205, 243, 245);
            panel4.Controls.Add(nonDGV);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(NAIDTB);
            panel4.Location = new Point(367, 72);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(461, 391);
            panel4.TabIndex = 8;
            // 
            // nonDGV
            // 
            nonDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nonDGV.Location = new Point(33, 71);
            nonDGV.Name = "nonDGV";
            nonDGV.RowHeadersWidth = 51;
            nonDGV.RowTemplate.Height = 29;
            nonDGV.Size = new Size(410, 290);
            nonDGV.TabIndex = 30;
            // 
            // button9
            // 
            button9.Location = new Point(298, 22);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 29;
            button9.Text = "Show";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 25);
            label6.Name = "label6";
            label6.Size = new Size(157, 20);
            label6.TabIndex = 22;
            label6.Text = "Non academic staff ID";
            // 
            // NAIDTB
            // 
            NAIDTB.Location = new Point(196, 22);
            NAIDTB.Margin = new Padding(3, 4, 3, 4);
            NAIDTB.Name = "NAIDTB";
            NAIDTB.Size = new Size(96, 27);
            NAIDTB.TabIndex = 21;
            NAIDTB.TextChanged += textBox8_TextChanged;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(0, 192, 0);
            button8.Location = new Point(667, 541);
            button8.Name = "button8";
            button8.Size = new Size(143, 38);
            button8.TabIndex = 25;
            button8.Text = "Create Time Table";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_1;
            // 
            // Non_academic_profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 145, 240);
            ClientSize = new Size(842, 624);
            Controls.Add(button8);
            Controls.Add(panel4);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Non_academic_profile";
            Text = "Non_academic_profile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nonDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private PictureBox pictureBox1;
        private Button button6;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Button button7;
        private Label label6;
        private TextBox NAIDTB;
        private Button button8;
        private Button button9;
        private DataGridView nonDGV;
    }
}