namespace Schoolmanagementsystem
{
    partial class show_parant_details
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            PDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PDGV).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(704, 435);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(319, 29);
            label1.Name = "label1";
            label1.Size = new Size(148, 38);
            label1.TabIndex = 2;
            label1.Text = "All Parents";
            // 
            // button2
            // 
            button2.Location = new Point(704, 480);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 106;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PDGV
            // 
            PDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PDGV.Location = new Point(55, 90);
            PDGV.Name = "PDGV";
            PDGV.RowHeadersWidth = 51;
            PDGV.RowTemplate.Height = 29;
            PDGV.Size = new Size(643, 447);
            PDGV.TabIndex = 107;
            // 
            // show_parant_details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 577);
            Controls.Add(PDGV);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "show_parant_details";
            Text = "show_parant_details";
            ((System.ComponentModel.ISupportInitialize)PDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Button button2;
        private DataGridView PDGV;
    }
}