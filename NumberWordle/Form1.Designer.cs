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
            ButtonSubmit = new Button();
            ListResult = new ListBox();
            LabelFeedback = new Label();
            ButtonRestart = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.BackColor = SystemColors.ButtonHighlight;
            ButtonSubmit.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonSubmit.Location = new Point(258, 12);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(179, 47);
            ButtonSubmit.TabIndex = 1;
            ButtonSubmit.Text = "Submit Guess";
            ButtonSubmit.UseVisualStyleBackColor = false;
            ButtonSubmit.Click += button1_Click;
            // 
            // ListResult
            // 
            ListResult.Font = new Font("Segoe UI", 12F);
            ListResult.FormattingEnabled = true;
            ListResult.ItemHeight = 28;
            ListResult.Location = new Point(443, 12);
            ListResult.Name = "ListResult";
            ListResult.Size = new Size(345, 424);
            ListResult.TabIndex = 2;
            // 
            // LabelFeedback
            // 
            LabelFeedback.AutoSize = true;
            LabelFeedback.Font = new Font("Segoe UI", 12F);
            LabelFeedback.Location = new Point(187, 62);
            LabelFeedback.Name = "LabelFeedback";
            LabelFeedback.Size = new Size(65, 28);
            LabelFeedback.TabIndex = 3;
            LabelFeedback.Text = "label1";
            LabelFeedback.Click += label1_Click;
            // 
            // ButtonRestart
            // 
            ButtonRestart.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonRestart.ForeColor = Color.Coral;
            ButtonRestart.Location = new Point(12, 397);
            ButtonRestart.Name = "ButtonRestart";
            ButtonRestart.Size = new Size(425, 39);
            ButtonRestart.TabIndex = 4;
            ButtonRestart.Text = "Restart Game";
            ButtonRestart.UseVisualStyleBackColor = true;
            ButtonRestart.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(12, 18);
            textBox1.MaxLength = 1;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(40, 34);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(58, 18);
            textBox2.MaxLength = 1;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(40, 34);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(104, 18);
            textBox3.MaxLength = 1;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(40, 34);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(150, 18);
            textBox4.MaxLength = 1;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(40, 34);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.Location = new Point(196, 18);
            textBox5.MaxLength = 1;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(40, 34);
            textBox5.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(ButtonRestart);
            Controls.Add(LabelFeedback);
            Controls.Add(ListResult);
            Controls.Add(ButtonSubmit);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ButtonSubmit;
        private ListBox ListResult;
        private Label LabelFeedback;
        private Button ButtonRestart;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
