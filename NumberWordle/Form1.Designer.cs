namespace NumberWordle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubmit = new Button();
            lstResults = new ListBox();
            lblFeedback = new Label();
            btnRestart = new Button();
            txtDigit1 = new TextBox();
            txtDigit2 = new TextBox();
            txtDigit3 = new TextBox();
            txtDigit4 = new TextBox();
            txtDigit5 = new TextBox();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ButtonHighlight;
            btnSubmit.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(258, 12);
            btnSubmit.Name = "ButtonSubmit";
            btnSubmit.Size = new Size(179, 47);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit Guess";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += button1_Click;
            // 
            // lstResults
            // 
            lstResults.Font = new Font("Segoe UI", 12F);
            lstResults.FormattingEnabled = true;
            lstResults.ItemHeight = 28;
            lstResults.Location = new Point(443, 12);
            lstResults.Name = "ListResult";
            lstResults.Size = new Size(345, 424);
            lstResults.TabIndex = 2;
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Font = new Font("Segoe UI", 12F);
            lblFeedback.Location = new Point(187, 62);
            lblFeedback.Name = "LabelFeedback";
            lblFeedback.Size = new Size(65, 28);
            lblFeedback.TabIndex = 3;
            lblFeedback.Text = "label1";
            lblFeedback.Click += label1_Click;
            // 
            // btnRestart
            // 
            btnRestart.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestart.ForeColor = Color.Coral;
            btnRestart.Location = new Point(12, 397);
            btnRestart.Name = "ButtonRestart";
            btnRestart.Size = new Size(425, 39);
            btnRestart.TabIndex = 4;
            btnRestart.Text = "Restart Game";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += button1_Click_1;
            // 
            // txtDigit1
            // 
            txtDigit1.Font = new Font("Segoe UI", 12F);
            txtDigit1.Location = new Point(12, 18);
            txtDigit1.MaxLength = 1;
            txtDigit1.Name = "textBox1";
            txtDigit1.Size = new Size(40, 34);
            txtDigit1.TabIndex = 1;
            // 
            // txtDigit2
            // 
            txtDigit2.Font = new Font("Segoe UI", 12F);
            txtDigit2.Location = new Point(58, 18);
            txtDigit2.MaxLength = 1;
            txtDigit2.Name = "textBox2";
            txtDigit2.Size = new Size(40, 34);
            txtDigit2.TabIndex = 2;
            // 
            // txtDigit3
            // 
            txtDigit3.Font = new Font("Segoe UI", 12F);
            txtDigit3.Location = new Point(104, 18);
            txtDigit3.MaxLength = 1;
            txtDigit3.Name = "textBox3";
            txtDigit3.Size = new Size(40, 34);
            txtDigit3.TabIndex = 3;
            // 
            // txtDigit4
            // 
            txtDigit4.Font = new Font("Segoe UI", 12F);
            txtDigit4.Location = new Point(150, 18);
            txtDigit4.MaxLength = 1;
            txtDigit4.Name = "textBox4";
            txtDigit4.Size = new Size(40, 34);
            txtDigit4.TabIndex = 4;
            // 
            // txtDigit5
            // 
            txtDigit5.Font = new Font("Segoe UI", 12F);
            txtDigit5.Location = new Point(196, 18);
            txtDigit5.MaxLength = 1;
            txtDigit5.Name = "textBox5";
            txtDigit5.Size = new Size(40, 34);
            txtDigit5.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDigit5);
            Controls.Add(txtDigit4);
            Controls.Add(txtDigit3);
            Controls.Add(txtDigit2);
            Controls.Add(txtDigit1);
            Controls.Add(btnRestart);
            Controls.Add(lblFeedback);
            Controls.Add(lstResults);
            Controls.Add(btnSubmit);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSubmit;
        private ListBox lstResults;
        private Label lblFeedback;
        private Button btnRestart;
        private TextBox txtDigit1;
        private TextBox txtDigit2;
        private TextBox txtDigit3;
        private TextBox txtDigit4;
        private TextBox txtDigit5;
    }
}
