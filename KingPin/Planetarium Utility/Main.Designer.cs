namespace Planetarium_Utility
{
    partial class Main
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
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.copyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusUpdateStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.logListView = new System.Windows.Forms.ListView();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.FullDomeDist = new System.Windows.Forms.TabPage();
            this.FileDist = new System.Windows.Forms.TabPage();
            this.FileDeleter = new System.Windows.Forms.TabPage();
            this.fullDomeDist1 = new Planetarium_Utility.FullDomeDist();
            this.fileDistributor1 = new Planetarium_Utility.FileDistributor();
            this.fileDeleter1 = new Planetarium_Utility.fileDeleter();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.FullDomeDist.SuspendLayout();
            this.FileDist.SuspendLayout();
            this.FileDeleter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(498, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyProgressBar,
            this.statusUpdateStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 425);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(498, 22);
            this.statusStrip.TabIndex = 18;
            this.statusStrip.Text = "statusStrip1";
            // 
            // copyProgressBar
            // 
            this.copyProgressBar.Margin = new System.Windows.Forms.Padding(12, 3, 1, 3);
            this.copyProgressBar.Name = "copyProgressBar";
            this.copyProgressBar.Size = new System.Drawing.Size(200, 16);
            // 
            // statusUpdateStatusLabel
            // 
            this.statusUpdateStatusLabel.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.statusUpdateStatusLabel.Name = "statusUpdateStatusLabel";
            this.statusUpdateStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusUpdateStatusLabel.Size = new System.Drawing.Size(113, 17);
            this.statusUpdateStatusLabel.Text = "Please select Project";
            // 
            // logListView
            // 
            this.logListView.Location = new System.Drawing.Point(10, 301);
            this.logListView.Name = "logListView";
            this.logListView.Size = new System.Drawing.Size(470, 112);
            this.logListView.TabIndex = 31;
            this.logListView.UseCompatibleStateImageBehavior = false;
            this.logListView.View = System.Windows.Forms.View.Details;
            this.logListView.Visible = false;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.FileDeleter);
            this.mainTabControl.Controls.Add(this.FullDomeDist);
            this.mainTabControl.Controls.Add(this.FileDist);
            this.mainTabControl.Location = new System.Drawing.Point(0, 27);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(497, 272);
            this.mainTabControl.TabIndex = 19;
            // 
            // FullDomeDist
            // 
            this.FullDomeDist.Controls.Add(this.fullDomeDist1);
            this.FullDomeDist.Location = new System.Drawing.Point(4, 22);
            this.FullDomeDist.Name = "FullDomeDist";
            this.FullDomeDist.Padding = new System.Windows.Forms.Padding(3);
            this.FullDomeDist.Size = new System.Drawing.Size(489, 246);
            this.FullDomeDist.TabIndex = 0;
            this.FullDomeDist.Text = "Full Dome Distributor";
            this.FullDomeDist.UseVisualStyleBackColor = true;
            // 
            // FileDist
            // 
            this.FileDist.Controls.Add(this.fileDistributor1);
            this.FileDist.Location = new System.Drawing.Point(4, 22);
            this.FileDist.Name = "FileDist";
            this.FileDist.Padding = new System.Windows.Forms.Padding(3);
            this.FileDist.Size = new System.Drawing.Size(489, 246);
            this.FileDist.TabIndex = 1;
            this.FileDist.Text = "File Distributor (Under Construction)";
            this.FileDist.UseVisualStyleBackColor = true;
            // 
            // FileDeleter
            // 
            this.FileDeleter.Controls.Add(this.fileDeleter1);
            this.FileDeleter.Location = new System.Drawing.Point(4, 22);
            this.FileDeleter.Name = "FileDeleter";
            this.FileDeleter.Padding = new System.Windows.Forms.Padding(3);
            this.FileDeleter.Size = new System.Drawing.Size(489, 246);
            this.FileDeleter.TabIndex = 2;
            this.FileDeleter.Text = "File Deleter";
            this.FileDeleter.UseVisualStyleBackColor = true;
            // 
            // fullDomeDist1
            // 
            this.fullDomeDist1.Location = new System.Drawing.Point(-4, 0);
            this.fullDomeDist1.Name = "fullDomeDist1";
            this.fullDomeDist1.ParentForm = null;
            this.fullDomeDist1.Size = new System.Drawing.Size(489, 246);
            this.fullDomeDist1.TabIndex = 0;
            // 
            // fileDistributor1
            // 
            this.fileDistributor1.AllowDrop = true;
            this.fileDistributor1.Location = new System.Drawing.Point(0, 0);
            this.fileDistributor1.Name = "fileDistributor1";
            this.fileDistributor1.ParentForm = null;
            this.fileDistributor1.Size = new System.Drawing.Size(489, 246);
            this.fileDistributor1.TabIndex = 0;
            // 
            // fileDeleter1
            // 
            this.fileDeleter1.AllowDrop = true;
            this.fileDeleter1.Location = new System.Drawing.Point(0, 0);
            this.fileDeleter1.Name = "fileDeleter1";
            this.fileDeleter1.ParentForm = null;
            this.fileDeleter1.Size = new System.Drawing.Size(489, 246);
            this.fileDeleter1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 447);
            this.Controls.Add(this.logListView);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Planetarium Utility";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.FullDomeDist.ResumeLayout(false);
            this.FileDist.ResumeLayout(false);
            this.FileDeleter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar copyProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusUpdateStatusLabel;
        private System.Windows.Forms.ListView logListView;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage FullDomeDist;
        private FullDomeDist fullDomeDist1;
        private System.Windows.Forms.TabPage FileDist;
        private FileDistributor fileDistributor1;
        private System.Windows.Forms.TabPage FileDeleter;
        private fileDeleter fileDeleter1;

    }
}

