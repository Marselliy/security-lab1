namespace security_lab1_csharp
{
    partial class MainFormNew
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlSearch = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControlAnalysis = new System.Windows.Forms.TabControl();
            this.tabPageImprove = new System.Windows.Forms.TabPage();
            this.textBoxSource = new System.Windows.Forms.RichTextBox();
            this.textBoxResult = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageImprove);
            this.tabControl1.Location = new System.Drawing.Point(13, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(461, 543);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControlSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(453, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Find key";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControlSearch
            // 
            this.tabControlSearch.Location = new System.Drawing.Point(6, 6);
            this.tabControlSearch.Name = "tabControlSearch";
            this.tabControlSearch.SelectedIndex = 0;
            this.tabControlSearch.Size = new System.Drawing.Size(444, 505);
            this.tabControlSearch.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControlAnalysis);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(453, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Analysis";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControlAnalysis
            // 
            this.tabControlAnalysis.Location = new System.Drawing.Point(6, 6);
            this.tabControlAnalysis.Name = "tabControlAnalysis";
            this.tabControlAnalysis.SelectedIndex = 0;
            this.tabControlAnalysis.Size = new System.Drawing.Size(444, 505);
            this.tabControlAnalysis.TabIndex = 28;
            // 
            // tabPageImprove
            // 
            this.tabPageImprove.Location = new System.Drawing.Point(4, 22);
            this.tabPageImprove.Name = "tabPageImprove";
            this.tabPageImprove.Size = new System.Drawing.Size(453, 517);
            this.tabPageImprove.TabIndex = 2;
            this.tabPageImprove.Text = "Improve key";
            this.tabPageImprove.UseVisualStyleBackColor = true;
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(481, 50);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(444, 253);
            this.textBoxSource.TabIndex = 2;
            this.textBoxSource.Text = "";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(481, 318);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(444, 253);
            this.textBoxResult.TabIndex = 3;
            this.textBoxResult.Text = "";
            // 
            // MainFormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 583);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFormNew";
            this.Text = "Lab 1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPageImprove;
        private System.Windows.Forms.RichTextBox textBoxSource;
        private System.Windows.Forms.RichTextBox textBoxResult;
        private System.Windows.Forms.TabControl tabControlAnalysis;
        private System.Windows.Forms.TabControl tabControlSearch;
    }
}