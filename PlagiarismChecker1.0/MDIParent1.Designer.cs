namespace PlagiarismChecker1._0
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uRLBasedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileBasedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileComparisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareWordFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pToolStripMenuItem,
            this.fileComparisonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uRLBasedToolStripMenuItem,
            this.fileBasedToolStripMenuItem});
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.pToolStripMenuItem.Text = "Plagiarism Check";
            // 
            // uRLBasedToolStripMenuItem
            // 
            this.uRLBasedToolStripMenuItem.Name = "uRLBasedToolStripMenuItem";
            this.uRLBasedToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.uRLBasedToolStripMenuItem.Text = "URL Based";
            this.uRLBasedToolStripMenuItem.Click += new System.EventHandler(this.URLBasedToolStripMenuItem_Click);
            // 
            // fileBasedToolStripMenuItem
            // 
            this.fileBasedToolStripMenuItem.Name = "fileBasedToolStripMenuItem";
            this.fileBasedToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fileBasedToolStripMenuItem.Text = "File Based";
            this.fileBasedToolStripMenuItem.Click += new System.EventHandler(this.FileBasedToolStripMenuItem_Click);
            // 
            // fileComparisonToolStripMenuItem
            // 
            this.fileComparisonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compareWordFilesToolStripMenuItem});
            this.fileComparisonToolStripMenuItem.Name = "fileComparisonToolStripMenuItem";
            this.fileComparisonToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.fileComparisonToolStripMenuItem.Text = "File Comparison";
            this.fileComparisonToolStripMenuItem.Click += new System.EventHandler(this.FileComparisonToolStripMenuItem_Click);
            // 
            // compareWordFilesToolStripMenuItem
            // 
            this.compareWordFilesToolStripMenuItem.Name = "compareWordFilesToolStripMenuItem";
            this.compareWordFilesToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.compareWordFilesToolStripMenuItem.Text = "Compare Word Files";
            this.compareWordFilesToolStripMenuItem.Click += new System.EventHandler(this.CompareWordFilesToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIParent1_FormClosing);
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uRLBasedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileBasedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileComparisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compareWordFilesToolStripMenuItem;
    }
}



