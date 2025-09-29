namespace lab_2
{
    partial class TwoDimForm
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
            listBox1 = new ListBox();
            buttonGenerate = new Button();
            buttonSum = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(299, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(271, 334);
            listBox1.TabIndex = 1;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(299, 12);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(75, 23);
            buttonGenerate.TabIndex = 2;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonSum
            // 
            buttonSum.Location = new Point(299, 41);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new Size(75, 23);
            buttonSum.TabIndex = 3;
            buttonSum.Text = "Find Sum";
            buttonSum.UseVisualStyleBackColor = true;
            buttonSum.Click += buttonSum_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 368);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "Sum: ";
            // 
            // TwoDimForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 450);
            Controls.Add(label1);
            Controls.Add(buttonSum);
            Controls.Add(buttonGenerate);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "TwoDimForm";
            Text = "TwoDimForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button buttonGenerate;
        private Button buttonSum;
        private Label label1;
    }
}