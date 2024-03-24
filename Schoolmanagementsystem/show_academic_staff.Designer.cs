namespace Schoolmanagementsystem
{
    partial class show_academic_staff
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
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            academicDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)academicDGV).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(692, 484);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 110;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(285, 33);
            label1.Name = "label1";
            label1.Size = new Size(240, 38);
            label1.TabIndex = 109;
            label1.Text = "All Academic Staff";
            // 
            // button1
            // 
            button1.Location = new Point(692, 439);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 108;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // academicDGV
            // 
            academicDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            academicDGV.Location = new Point(38, 111);
            academicDGV.Name = "academicDGV";
            academicDGV.RowHeadersWidth = 51;
            academicDGV.RowTemplate.Height = 29;
            academicDGV.Size = new Size(623, 432);
            academicDGV.TabIndex = 107;
            // 
            // show_academic_staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 243, 245);
            ClientSize = new Size(824, 577);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(academicDGV);
            Name = "show_academic_staff";
            Text = "show_academic_staff";
            Load += show_academic_staff_Load;
            ((System.ComponentModel.ISupportInitialize)academicDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label1;
        private Button button1;
        private DataGridView academicDGV;
    }
}