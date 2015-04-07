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
            this.logListView = new System.Windows.Forms.ListView();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.FileDeleter = new System.Windows.Forms.TabPage();
            this.FullDomeDist = new System.Windows.Forms.TabPage();
            this.FileDist = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.copyProgressBar = new Planetarium_Utility.CustomProgressBar();
            this.fileDeleter1 = new Planetarium_Utility.fileDeleter();
            this.fullDomeDist1 = new Planetarium_Utility.FullDomeDist();
            this.fileDistributor1 = new Planetarium_Utility.FileDistributor();
            this.menuStrip1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.FileDeleter.SuspendLayout();
            this.FullDomeDist.SuspendLayout();
            this.FileDist.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 26);
            this.panel1.TabIndex = 33;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.69077F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.30924F));
            this.tableLayoutPanel1.Controls.Add(this.copyProgressBar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 26);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel.Location = new System.Drawing.Point(3, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(356, 26);
            this.statusLabel.TabIndex = 33;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // copyProgressBar
            // 
            this.copyProgressBar.CustomText = null;
            this.copyProgressBar.DisplayStyle = Planetarium_Utility.ProgressBarDisplayText.CustomText;
            this.copyProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyProgressBar.Location = new System.Drawing.Point(365, 3);
            this.copyProgressBar.Name = "copyProgressBar";
            this.copyProgressBar.Size = new System.Drawing.Size(130, 20);
            this.copyProgressBar.TabIndex = 32;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logListView);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Planetarium Utility";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.FileDeleter.ResumeLayout(false);
            this.FullDomeDist.ResumeLayout(false);
            this.FileDist.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.ListView logListView;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage FullDomeDist;
        private FullDomeDist fullDomeDist1;
        private System.Windows.Forms.TabPage FileDist;
        private FileDistributor fileDistributor1;
        private System.Windows.Forms.TabPage FileDeleter;
        private fileDeleter fileDeleter1;
        private CustomProgressBar copyProgressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label statusLabel;

    }
}

