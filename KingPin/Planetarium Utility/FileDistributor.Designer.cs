namespace Planetarium_Utility
{
    partial class FileDistributor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.distributeButton = new System.Windows.Forms.Button();
            this.pathGroupBox = new System.Windows.Forms.GroupBox();
            this.destinationButton = new System.Windows.Forms.Button();
            this.projectButton = new System.Windows.Forms.Button();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.projectTextBox = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.projectLabel = new System.Windows.Forms.Label();
            this.filesGroupBox = new System.Windows.Forms.GroupBox();
            this.filesListView = new System.Windows.Forms.ListView();
            this.resetButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.pathGroupBox.SuspendLayout();
            this.filesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // distributeButton
            // 
            this.distributeButton.Location = new System.Drawing.Point(10, 211);
            this.distributeButton.Name = "distributeButton";
            this.distributeButton.Size = new System.Drawing.Size(324, 32);
            this.distributeButton.TabIndex = 38;
            this.distributeButton.Text = "Distribute";
            this.distributeButton.UseVisualStyleBackColor = true;
            // 
            // pathGroupBox
            // 
            this.pathGroupBox.Controls.Add(this.destinationButton);
            this.pathGroupBox.Controls.Add(this.projectButton);
            this.pathGroupBox.Controls.Add(this.destinationTextBox);
            this.pathGroupBox.Controls.Add(this.projectTextBox);
            this.pathGroupBox.Controls.Add(this.destinationLabel);
            this.pathGroupBox.Controls.Add(this.projectLabel);
            this.pathGroupBox.Location = new System.Drawing.Point(4, 147);
            this.pathGroupBox.Name = "pathGroupBox";
            this.pathGroupBox.Size = new System.Drawing.Size(482, 61);
            this.pathGroupBox.TabIndex = 36;
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
            // filesGroupBox
            // 
            this.filesGroupBox.Controls.Add(this.filesListView);
            this.filesGroupBox.Location = new System.Drawing.Point(4, 3);
            this.filesGroupBox.Name = "filesGroupBox";
            this.filesGroupBox.Size = new System.Drawing.Size(482, 138);
            this.filesGroupBox.TabIndex = 37;
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
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(340, 210);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(90, 33);
            this.resetButton.TabIndex = 39;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(436, 209);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(44, 32);
            this.logButton.TabIndex = 40;
            this.logButton.Text = "Log";
            this.logButton.UseVisualStyleBackColor = true;
            // 
            // FileDistributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.distributeButton);
            this.Controls.Add(this.pathGroupBox);
            this.Controls.Add(this.filesGroupBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.logButton);
            this.Name = "FileDistributor";
            this.Size = new System.Drawing.Size(489, 246);
            this.Load += new System.EventHandler(this.FileDistributor_Load);
            this.pathGroupBox.ResumeLayout(false);
            this.pathGroupBox.PerformLayout();
            this.filesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button distributeButton;
        private System.Windows.Forms.GroupBox pathGroupBox;
        private System.Windows.Forms.Button destinationButton;
        private System.Windows.Forms.Button projectButton;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox projectTextBox;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.GroupBox filesGroupBox;
        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button logButton;

    }
}
