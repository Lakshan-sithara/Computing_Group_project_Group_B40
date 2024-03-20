namespace Schoolmanagementsystem
{
    partial class signform
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
            showPass = new CheckBox();
            RegBtn = new Button();
            signInBtn = new Button();
            label7 = new Label();
            passwordBox = new TextBox();
            userNameBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            button7 = new Button();
            label4 = new Label();
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
            panel1.Location = new Point(65, 49);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(711, 527);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PowderBlue;
            panel3.Controls.Add(showPass);
            panel3.Controls.Add(RegBtn);
            panel3.Controls.Add(signInBtn);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(passwordBox);
            panel3.Controls.Add(userNameBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(379, 49);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(298, 429);
            panel3.TabIndex = 2;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.Location = new Point(150, 235);
            showPass.Name = "showPass";
            showPass.Size = new Size(132, 24);
            showPass.TabIndex = 14;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // RegBtn
            // 
            RegBtn.BackColor = Color.MidnightBlue;
            RegBtn.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RegBtn.ForeColor = Color.White;
            RegBtn.Location = new Point(80, 349);
            RegBtn.Margin = new Padding(3, 4, 3, 4);
            RegBtn.Name = "RegBtn";
            RegBtn.Size = new Size(154, 43);
            RegBtn.TabIndex = 13;
            RegBtn.Text = "REGISTER";
            RegBtn.UseVisualStyleBackColor = false;
            // 
            // signInBtn
            // 
            signInBtn.BackColor = Color.MidnightBlue;
            signInBtn.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            signInBtn.ForeColor = Color.White;
            signInBtn.Location = new Point(80, 295);
            signInBtn.Margin = new Padding(3, 4, 3, 4);
            signInBtn.Name = "signInBtn";
            signInBtn.Size = new Size(154, 43);
            signInBtn.TabIndex = 11;
            signInBtn.Text = "SIGN IN";
            signInBtn.UseVisualStyleBackColor = false;
            signInBtn.Click += signInBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(31, 163);
            label7.Name = "label7";
            label7.Size = new Size(78, 22);
            label7.TabIndex = 10;
            label7.Text = "Password";
            label7.Click += label7_Click;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(31, 192);
            passwordBox.Margin = new Padding(3, 4, 3, 4);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(251, 27);
            passwordBox.TabIndex = 9;
            // 
            // userNameBox
            // 
            userNameBox.Location = new Point(31, 112);
            userNameBox.Margin = new Padding(3, 4, 3, 4);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(251, 27);
            userNameBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 84);
            label3.Name = "label3";
            label3.Size = new Size(194, 22);
            label3.TabIndex = 3;
            label3.Text = "User Name (Index Number)\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(115, 21);
            label1.Name = "label1";
            label1.Size = new Size(84, 29);
            label1.TabIndex = 0;
            label1.Text = "SIGN IN";
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
            panel4.Controls.Add(label4);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 8);
            label4.Name = "label4";
            label4.Size = new Size(195, 17);
            label4.TabIndex = 1;
            label4.Text = "School Management System";
            // 
            // signform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(842, 624);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "signform";
            Text = "signform";
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
        private Panel panel3;
        private Button signInBtn;
        private Label label7;
        private TextBox passwordBox;
        private TextBox userNameBox;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Label label5;
        private PictureBox pictureBox2;
        private Button RegBtn;
        private Panel panel4;
        private Label label4;
        private Button button7;
        private CheckBox showPass;
    }
}