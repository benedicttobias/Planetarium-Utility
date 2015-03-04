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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.copyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusUpdateStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.fullDomeDistributorTabPage = new System.Windows.Forms.TabPage();
            this.logListView = new System.Windows.Forms.ListView();
            this.resetButton = new System.Windows.Forms.Button();
            this.distributeButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.filesGroupBox = new System.Windows.Forms.GroupBox();
            this.filesListView = new System.Windows.Forms.ListView();
            this.pathGroupBox = new System.Windows.Forms.GroupBox();
            this.destinationButton = new System.Windows.Forms.Button();
            this.projectButton = new System.Windows.Forms.Button();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.projectTextBox = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.projectLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.fullDomeDistributorTabPage.SuspendLayout();
            this.filesGroupBox.SuspendLayout();
            this.pathGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyProgressBar,
            this.statusUpdateStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 299);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(496, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // copyProgressBar
            // 
            this.copyProgressBar.Margin = new System.Windows.Forms.Padding(12, 3, 1, 3);
            this.copyProgressBar.Name = "copyProgressBar";
            this.copyProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // statusUpdateStatusLabel
            // 
            this.statusUpdateStatusLabel.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.statusUpdateStatusLabel.Name = "statusUpdateStatusLabel";
            this.statusUpdateStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusUpdateStatusLabel.Size = new System.Drawing.Size(113, 17);
            this.statusUpdateStatusLabel.Text = "Please select Project";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.fullDomeDistributorTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(0, 27);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(497, 272);
            this.mainTabControl.TabIndex = 19;
            // 
            // fullDomeDistributorTabPage
            // 
            this.fullDomeDistributorTabPage.Controls.Add(this.logListView);
            this.fullDomeDistributorTabPage.Controls.Add(this.resetButton);
            this.fullDomeDistributorTabPage.Controls.Add(this.distributeButton);
            this.fullDomeDistributorTabPage.Controls.Add(this.logButton);
            this.fullDomeDistributorTabPage.Controls.Add(this.filesGroupBox);
            this.fullDomeDistributorTabPage.Controls.Add(this.pathGroupBox);
            this.fullDomeDistributorTabPage.Location = new System.Drawing.Point(4, 22);
            this.fullDomeDistributorTabPage.Name = "fullDomeDistributorTabPage";
            this.fullDomeDistributorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fullDomeDistributorTabPage.Size = new System.Drawing.Size(489, 246);
            this.fullDomeDistributorTabPage.TabIndex = 1;
            this.fullDomeDistributorTabPage.Text = "Full Dome Distributor";
            this.fullDomeDistributorTabPage.UseVisualStyleBackColor = true;
            // 
            // logListView
            // 
            this.logListView.Location = new System.Drawing.Point(6, 250);
            this.logListView.Name = "logListView";
            this.logListView.Size = new System.Drawing.Size(470, 112);
            this.logListView.TabIndex = 31;
            this.logListView.UseCompatibleStateImageBehavior = false;
            this.logListView.View = System.Windows.Forms.View.Details;
            this.logListView.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(336, 210);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(90, 33);
            this.resetButton.TabIndex = 29;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // distributeButton
            // 
            this.distributeButton.Location = new System.Drawing.Point(6, 211);
            this.distributeButton.Name = "distributeButton";
            this.distributeButton.Size = new System.Drawing.Size(324, 32);
            this.distributeButton.TabIndex = 28;
            this.distributeButton.Text = "Distribute";
            this.distributeButton.UseVisualStyleBackColor = true;
            this.distributeButton.Click += new System.EventHandler(this.distributeButton_Click);
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(432, 210);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(44, 32);
            this.logButton.TabIndex = 30;
            this.logButton.Text = "Log";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click_1);
            // 
            // filesGroupBox
            // 
            this.filesGroupBox.Controls.Add(this.filesListView);
            this.filesGroupBox.Location = new System.Drawing.Point(0, 73);
            this.filesGroupBox.Name = "filesGroupBox";
            this.filesGroupBox.Size = new System.Drawing.Size(482, 138);
            this.filesGroupBox.TabIndex = 27;
            this.filesGroupBox.TabStop = false;
            this.filesGroupBox.Text = "Files";
            // 
            // filesListView
            // 
            this.filesListView.Location = new System.Drawing.Point(6, 19);
            this.filesListView.Name = "filesListView";
            this.filesListView.Size = new System.Drawing.Size(470, 113);
            this.filesListView.TabIndex = 0;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.View = System.Windows.Forms.View.Details;
            // 
            // pathGroupBox
            // 
            this.pathGroupBox.Controls.Add(this.destinationButton);
            this.pathGroupBox.Controls.Add(this.projectButton);
            this.pathGroupBox.Controls.Add(this.destinationTextBox);
            this.pathGroupBox.Controls.Add(this.projectTextBox);
            this.pathGroupBox.Controls.Add(this.destinationLabel);
            this.pathGroupBox.Controls.Add(this.projectLabel);
            this.pathGroupBox.Location = new System.Drawing.Point(0, 6);
            this.pathGroupBox.Name = "pathGroupBox";
            this.pathGroupBox.Size = new System.Drawing.Size(482, 61);
            this.pathGroupBox.TabIndex = 26;
            this.pathGroupBox.TabStop = false;
            this.pathGroupBox.Text = "Path";
            // 
            // destinationButton
            // 
            this.destinationButton.Location = new System.Drawing.Point(450, 33);
            this.destinationButton.Name = "destinationButton";
            this.destinationButton.Size = new System.Drawing.Size(26, 23);
            this.destinationButton.TabIndex = 5;
            this.destinationButton.Text = "...";
            this.destinationButton.UseVisualStyleBackColor = true;
            this.destinationButton.Click += new System.EventHandler(this.destinationButton_Click);
            // 
            // projectButton
            // 
            this.projectButton.Location = new System.Drawing.Point(450, 10);
            this.projectButton.Name = "projectButton";
            this.projectButton.Size = new System.Drawing.Size(26, 23);
            this.projectButton.TabIndex = 4;
            this.projectButton.Text = "...";
            this.projectButton.UseVisualStyleBackColor = true;
            this.projectButton.Click += new System.EventHandler(this.projectButton_Click);
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(78, 35);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.ReadOnly = true;
            this.destinationTextBox.Size = new System.Drawing.Size(366, 20);
            this.destinationTextBox.TabIndex = 3;
            // 
            // projectTextBox
            // 
            this.projectTextBox.Location = new System.Drawing.Point(78, 13);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.ReadOnly = true;
            this.projectTextBox.Size = new System.Drawing.Size(366, 20);
            this.projectTextBox.TabIndex = 2;
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(9, 38);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(60, 13);
            this.destinationLabel.TabIndex = 1;
            this.destinationLabel.Text = "Destination";
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Location = new System.Drawing.Point(9, 16);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(40, 13);
            this.projectLabel.TabIndex = 0;
            this.projectLabel.Text = "Project";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 321);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Planetarium Utility";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.fullDomeDistributorTabPage.ResumeLayout(false);
            this.filesGroupBox.ResumeLayout(false);
            this.pathGroupBox.ResumeLayout(false);
            this.pathGroupBox.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar copyProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusUpdateStatusLabel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage fullDomeDistributorTabPage;
        private System.Windows.Forms.ListView logListView;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button distributeButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.GroupBox filesGroupBox;
        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.GroupBox pathGroupBox;
        private System.Windows.Forms.Button destinationButton;
        private System.Windows.Forms.Button projectButton;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox projectTextBox;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label projectLabel;

    }
}

