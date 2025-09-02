namespace GuessTheWord
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
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = SystemColors.MenuHighlight;
            label2.Font = new Font("Segoe UI", 50F);
            label2.Location = new Point(129, 55);
            label2.Name = "label2";
            label2.Size = new Size(338, 119);
            label2.TabIndex = 1;
            label2.Text = "B?????T";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(242, 263);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "GUESS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Highlight;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(602, 48);
            label3.Name = "label3";
            label3.Size = new Size(174, 31);
            label3.TabIndex = 4;
            label3.Text = "WRONG GUESSES";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(602, 95);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(174, 304);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private ListBox listBox1;
    }
}
