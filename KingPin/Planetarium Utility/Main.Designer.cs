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
            this.pathGroupBox = new System.Windows.Forms.GroupBox();
            this.destinationButton = new System.Windows.Forms.Button();
            this.projectButton = new System.Windows.Forms.Button();
            this.destiantionTextBox = new System.Windows.Forms.TextBox();
            this.projectTextBox = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.projectLabel = new System.Windows.Forms.Label();
            this.filesGroupBox = new System.Windows.Forms.GroupBox();
            this.filesListView = new System.Windows.Forms.ListView();
            this.resetButton = new System.Windows.Forms.Button();
            this.distributeButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.copyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusUpdateStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.pathGroupBox.SuspendLayout();
            this.filesGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
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
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
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
            // pathGroupBox
            // 
            this.pathGroupBox.Controls.Add(this.destinationButton);
            this.pathGroupBox.Controls.Add(this.projectButton);
            this.pathGroupBox.Controls.Add(this.destiantionTextBox);
            this.pathGroupBox.Controls.Add(this.projectTextBox);
            this.pathGroupBox.Controls.Add(this.destinationLabel);
            this.pathGroupBox.Controls.Add(this.projectLabel);
            this.pathGroupBox.Location = new System.Drawing.Point(6, 27);
            this.pathGroupBox.Name = "pathGroupBox";
            this.pathGroupBox.Size = new System.Drawing.Size(482, 61);
            this.pathGroupBox.TabIndex = 13;
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
            // 
            // projectButton
            // 
            this.projectButton.Location = new System.Drawing.Point(450, 10);
            this.projectButton.Name = "projectButton";
            this.projectButton.Size = new System.Drawing.Size(26, 23);
            this.projectButton.TabIndex = 4;
            this.projectButton.Text = "...";
            this.projectButton.UseVisualStyleBackColor = true;
            // 
            // destiantionTextBox
            // 
            this.destiantionTextBox.Location = new System.Drawing.Point(78, 35);
            this.destiantionTextBox.Name = "destiantionTextBox";
            this.destiantionTextBox.Size = new System.Drawing.Size(366, 20);
            this.destiantionTextBox.TabIndex = 3;
            // 
            // projectTextBox
            // 
            this.projectTextBox.Location = new System.Drawing.Point(78, 13);
            this.projectTextBox.Name = "projectTextBox";
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
            // filesGroupBox
            // 
            this.filesGroupBox.Controls.Add(this.filesListView);
            this.filesGroupBox.Location = new System.Drawing.Point(6, 94);
            this.filesGroupBox.Name = "filesGroupBox";
            this.filesGroupBox.Size = new System.Drawing.Size(482, 138);
            this.filesGroupBox.TabIndex = 14;
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
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(342, 231);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(90, 33);
            this.resetButton.TabIndex = 16;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // distributeButton
            // 
            this.distributeButton.Location = new System.Drawing.Point(12, 232);
            this.distributeButton.Name = "distributeButton";
            this.distributeButton.Size = new System.Drawing.Size(324, 32);
            this.distributeButton.TabIndex = 15;
            this.distributeButton.Text = "Distribute";
            this.distributeButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(438, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 32);
            this.button3.TabIndex = 17;
            this.button3.Text = "Log";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyProgressBar,
            this.statusUpdateStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(492, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // copyProgressBar
            // 
            this.copyProgressBar.Name = "copyProgressBar";
            this.copyProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // statusUpdateStatusLabel
            // 
            this.statusUpdateStatusLabel.Name = "statusUpdateStatusLabel";
            this.statusUpdateStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusUpdateStatusLabel.Size = new System.Drawing.Size(113, 17);
            this.statusUpdateStatusLabel.Text = "Please select Project";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 413);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.distributeButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.filesGroupBox);
            this.Controls.Add(this.pathGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Planetarium Utility";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pathGroupBox.ResumeLayout(false);
            this.pathGroupBox.PerformLayout();
            this.filesGroupBox.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox pathGroupBox;
        private System.Windows.Forms.Button destinationButton;
        private System.Windows.Forms.Button projectButton;
        private System.Windows.Forms.TextBox destiantionTextBox;
        private System.Windows.Forms.TextBox projectTextBox;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.GroupBox filesGroupBox;
        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button distributeButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar copyProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusUpdateStatusLabel;

    }
}

