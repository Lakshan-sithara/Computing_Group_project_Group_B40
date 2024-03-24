namespace Schoolmanagementsystem
{
    partial class Parent
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
            button1 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            button9 = new Button();
            label3 = new Label();
            button7 = new Button();
            panel4 = new Panel();
            parantDGV = new DataGridView();
            button2 = new Button();
            PIDTB = new TextBox();
            label6 = new Label();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)parantDGV).BeginInit();
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
            panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.parent;
            pictureBox2.Location = new Point(238, 84);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 163);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
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
            panel3.TabIndex = 8;
            // 
            // button9
            // 
            button9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(593, 11);
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
            label3.Size = new Size(136, 22);
            label3.TabIndex = 0;
            label3.Text = "Parent Profile";
            // 
            // button7
            // 
            button7.BackColor = Color.MidnightBlue;
            button7.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(226, 285);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(157, 66);
            button7.TabIndex = 13;
            button7.Text = "View Student's Results";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(205, 243, 245);
            panel4.Controls.Add(parantDGV);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(PIDTB);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(392, 84);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(440, 507);
            panel4.TabIndex = 15;
            // 
            // parantDGV
            // 
            parantDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            parantDGV.Location = new Point(39, 79);
            parantDGV.Name = "parantDGV";
            parantDGV.RowHeadersWidth = 51;
            parantDGV.RowTemplate.Height = 29;
            parantDGV.Size = new Size(372, 357);
            parantDGV.TabIndex = 29;
            // 
            // button2
            // 
            button2.Location = new Point(313, 28);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 28;
            button2.Text = "Show";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PIDTB
            // 
            PIDTB.Location = new Point(111, 28);
            PIDTB.Margin = new Padding(3, 4, 3, 4);
            PIDTB.Name = "PIDTB";
            PIDTB.Size = new Size(163, 27);
            PIDTB.TabIndex = 27;
            PIDTB.TextChanged += textBox8_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 31);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 26;
            label6.Text = "Enter PID";
            // 
            // button8
            // 
            button8.BackColor = Color.MidnightBlue;
            button8.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(226, 359);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(157, 68);
            button8.TabIndex = 16;
            button8.Text = "View Student's Timetable\r\n";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Parent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 145, 240);
            ClientSize = new Size(842, 624);
            Controls.Add(button8);
            Controls.Add(panel4);
            Controls.Add(button7);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Parent";
            Text = "Parent";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)parantDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private PictureBox pictureBox1;
        private Button button1;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label3;
        private Button button7;
        private Panel panel4;
        private Button button8;
        private Button button9;
        private TextBox PIDTB;
        private Label label6;
        private DataGridView parantDGV;
        private Button button2;
    }
}