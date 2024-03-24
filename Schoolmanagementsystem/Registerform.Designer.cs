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
            label6 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            button7 = new Button();
            label8 = new Label();
            usernameTB = new TextBox();
            passwordTB = new TextBox();
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
            panel3.Controls.Add(passwordTB);
            panel3.Controls.Add(usernameTB);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(367, 20);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(327, 485);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(94, 291);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(123, 43);
            button1.TabIndex = 11;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(35, 200);
            label7.Name = "label7";
            label7.Size = new Size(78, 22);
            label7.TabIndex = 10;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(35, 128);
            label6.Name = "label6";
            label6.Size = new Size(79, 22);
            label6.TabIndex = 5;
            label6.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(124, 82);
            label1.Name = "label1";
            label1.Size = new Size(62, 24);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
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
            button7.Click += button7_Click;
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
            // usernameTB
            // 
            usernameTB.Location = new Point(35, 151);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(253, 27);
            usernameTB.TabIndex = 12;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(37, 229);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(253, 27);
            passwordTB.TabIndex = 13;
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
        private Label label6;
        private Button button1;
        private Label label7;
        private Panel panel4;
        private Label label8;
        private Button button7;
        private TextBox passwordTB;
        private TextBox usernameTB;
    }
}