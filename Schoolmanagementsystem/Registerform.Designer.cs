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
            cmbSelect = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            P2 = new TextBox();
            rUname = new TextBox();
            P1 = new TextBox();
            IndexNo = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            panel1.Location = new Point(67, 51);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(711, 527);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PowderBlue;
            panel3.Controls.Add(cmbSelect);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(P2);
            panel3.Controls.Add(rUname);
            panel3.Controls.Add(P1);
            panel3.Controls.Add(IndexNo);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(367, 20);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(327, 485);
            panel3.TabIndex = 2;
            // 
            // cmbSelect
            // 
            cmbSelect.FormattingEnabled = true;
            cmbSelect.Location = new Point(31, 89);
            cmbSelect.Name = "cmbSelect";
            cmbSelect.Size = new Size(151, 28);
            cmbSelect.TabIndex = 5;
            cmbSelect.SelectedIndexChanged += cmbSelect_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(17, 415);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(139, 43);
            button2.TabIndex = 12;
            button2.Text = "Back to Sign In";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(175, 415);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(123, 43);
            button1.TabIndex = 11;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(29, 336);
            label7.Name = "label7";
            label7.Size = new Size(137, 22);
            label7.TabIndex = 10;
            label7.Text = "Confirm password";
            // 
            // P2
            // 
            P2.Location = new Point(31, 362);
            P2.Margin = new Padding(3, 4, 3, 4);
            P2.Name = "P2";
            P2.Size = new Size(251, 27);
            P2.TabIndex = 9;
            // 
            // rUname
            // 
            rUname.Location = new Point(31, 224);
            rUname.Margin = new Padding(3, 4, 3, 4);
            rUname.Name = "rUname";
            rUname.Size = new Size(251, 27);
            rUname.TabIndex = 8;
            // 
            // P1
            // 
            P1.Location = new Point(31, 290);
            P1.Margin = new Padding(3, 4, 3, 4);
            P1.Name = "P1";
            P1.Size = new Size(251, 27);
            P1.TabIndex = 7;
            P1.TextChanged += textBox2_TextChanged;
            // 
            // IndexNo
            // 
            IndexNo.Location = new Point(31, 157);
            IndexNo.Margin = new Padding(3, 4, 3, 4);
            IndexNo.Name = "IndexNo";
            IndexNo.Size = new Size(251, 27);
            IndexNo.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(29, 264);
            label6.Name = "label6";
            label6.Size = new Size(139, 22);
            label6.TabIndex = 5;
            label6.Text = "Create a password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(29, 198);
            label4.Name = "label4";
            label4.Size = new Size(83, 22);
            label4.TabIndex = 4;
            label4.Text = "Your name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 131);
            label3.Name = "label3";
            label3.Size = new Size(194, 22);
            label3.TabIndex = 3;
            label3.Text = "User Name (Index Number)\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 64);
            label2.Name = "label2";
            label2.Size = new Size(52, 22);
            label2.TabIndex = 2;
            label2.Text = "Select";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(121, 24);
            label1.Name = "label1";
            label1.Size = new Size(94, 24);
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
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 527);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(77, 344);
            label5.Name = "label5";
            label5.Size = new Size(228, 24);
            label5.TabIndex = 3;
            label5.Text = "THE TEURLINGS COLLAGE";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = Properties.Resources.TCHS_primary_crest_FC;
            pictureBox2.Location = new Point(78, 97);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(201, 229);
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
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(842, 37);
            panel4.TabIndex = 5;
            // 
            // button7
            // 
            button7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(813, 3);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(26, 31);
            button7.TabIndex = 7;
            button7.Text = "X";
            button7.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 8);
            label8.Name = "label8";
            label8.Size = new Size(195, 17);
            label8.TabIndex = 1;
            label8.Text = "School Management System";
            // 
            // Registerform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(842, 624);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label1;
        private Label label2;
        private TextBox rUname;
        private TextBox P1;
        private TextBox IndexNo;
        private Label label6;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label7;
        private TextBox P2;
        private Panel panel4;
        private Label label8;
        private Button button7;
        private Button button2;
        private ComboBox cmbSelect;
    }
}