namespace lab_2
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
            menuStrip1 = new MenuStrip();
            selectArrayTypeToolStripMenuItem = new ToolStripMenuItem();
            oneDimArrayToolStripMenuItem = new ToolStripMenuItem();
            twoDimArrayToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { selectArrayTypeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // selectArrayTypeToolStripMenuItem
            // 
            selectArrayTypeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oneDimArrayToolStripMenuItem, twoDimArrayToolStripMenuItem });
            selectArrayTypeToolStripMenuItem.Name = "selectArrayTypeToolStripMenuItem";
            selectArrayTypeToolStripMenuItem.Size = new Size(105, 20);
            selectArrayTypeToolStripMenuItem.Text = "Select array type";
            // 
            // oneDimArrayToolStripMenuItem
            // 
            oneDimArrayToolStripMenuItem.Name = "oneDimArrayToolStripMenuItem";
            oneDimArrayToolStripMenuItem.Size = new Size(180, 22);
            oneDimArrayToolStripMenuItem.Text = "One Dim Array";
            oneDimArrayToolStripMenuItem.Click += oneDimArrayToolStripMenuItem_Click;
            // 
            // twoDimArrayToolStripMenuItem
            // 
            twoDimArrayToolStripMenuItem.Name = "twoDimArrayToolStripMenuItem";
            twoDimArrayToolStripMenuItem.Size = new Size(180, 22);
            twoDimArrayToolStripMenuItem.Text = "Two Dim Array";
            twoDimArrayToolStripMenuItem.Click += twoDimArrayToolStripMenuItem_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem selectArrayTypeToolStripMenuItem;
        private ToolStripMenuItem oneDimArrayToolStripMenuItem;
        private ToolStripMenuItem twoDimArrayToolStripMenuItem;
    }
}
