namespace Planetarium_Utility
{
    partial class fileDeleter
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
            this.components = new System.ComponentModel.Container();
            this.pathGroupBox = new System.Windows.Forms.GroupBox();
            this.fileTextbox = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.filesGroupBox = new System.Windows.Forms.GroupBox();
            this.foundList = new System.Windows.Forms.ListView();
            this.resetButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.infoTextbox = new System.Windows.Forms.TextBox();
            this.backupCheckbox = new System.Windows.Forms.CheckBox();
            this.backupTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.pathGroupBox.SuspendLayout();
            this.filesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathGroupBox
            // 
            this.pathGroupBox.Controls.Add(this.fileTextbox);
            this.pathGroupBox.Controls.Add(this.destinationLabel);
            this.pathGroupBox.Location = new System.Drawing.Point(3, 3);
            this.pathGroupBox.Name = "pathGroupBox";
            this.pathGroupBox.Size = new System.Drawing.Size(482, 41);
            this.pathGroupBox.TabIndex = 41;
            this.pathGroupBox.TabStop = false;
            this.pathGroupBox.Text = "Path";
            // 
            // fileTextbox
            // 
            this.fileTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.fileTextbox.Location = new System.Drawing.Point(35, 13);
            this.fileTextbox.Name = "fileTextbox";
            this.fileTextbox.ReadOnly = true;
            this.fileTextbox.Size = new System.Drawing.Size(441, 20);
            this.fileTextbox.TabIndex = 3;
            this.fileTextbox.Text = "Drag a file here...";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(6, 16);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(23, 13);
            this.destinationLabel.TabIndex = 1;
            this.destinationLabel.Text = "File";
            // 
            // filesGroupBox
            // 
            this.filesGroupBox.Controls.Add(this.foundList);
            this.filesGroupBox.Location = new System.Drawing.Point(4, 42);
            this.filesGroupBox.Name = "filesGroupBox";
            this.filesGroupBox.Size = new System.Drawing.Size(482, 135);
            this.filesGroupBox.TabIndex = 42;
            this.filesGroupBox.TabStop = false;
            this.filesGroupBox.Text = "Occurance";
            // 
            // foundList
            // 
            this.foundList.Location = new System.Drawing.Point(6, 19);
            this.foundList.Name = "foundList";
            this.foundList.Size = new System.Drawing.Size(470, 111);
            this.foundList.TabIndex = 0;
            this.foundList.UseCompatibleStateImageBehavior = false;
            this.foundList.View = System.Windows.Forms.View.Details;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(339, 210);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(90, 33);
            this.resetButton.TabIndex = 44;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(435, 209);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(44, 32);
            this.logButton.TabIndex = 45;
            this.logButton.Text = "Log";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 210);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(321, 33);
            this.deleteButton.TabIndex = 47;
            this.deleteButton.Text = "Delete (All)";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // infoTextbox
            // 
            this.infoTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoTextbox.Location = new System.Drawing.Point(11, 183);
            this.infoTextbox.Name = "infoTextbox";
            this.infoTextbox.Size = new System.Drawing.Size(326, 13);
            this.infoTextbox.TabIndex = 48;
            this.infoTextbox.Text = "monyong";
            // 
            // backupCheckbox
            // 
            this.backupCheckbox.AutoSize = true;
            this.backupCheckbox.Checked = true;
            this.backupCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backupCheckbox.Location = new System.Drawing.Point(343, 179);
            this.backupCheckbox.Name = "backupCheckbox";
            this.backupCheckbox.Size = new System.Drawing.Size(137, 17);
            this.backupCheckbox.TabIndex = 49;
            this.backupCheckbox.Text = "Move to Backup Folder";
            this.backupTooltip.SetToolTip(this.backupCheckbox, "Move original file to backup folder before deleting");
            this.backupCheckbox.UseVisualStyleBackColor = true;
            // 
            // fileDeleter
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backupCheckbox);
            this.Controls.Add(this.infoTextbox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.filesGroupBox);
            this.Controls.Add(this.pathGroupBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.logButton);
            this.Name = "fileDeleter";
            this.Size = new System.Drawing.Size(489, 246);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileDeleter_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileDeleter_DragEnter);
            this.pathGroupBox.ResumeLayout(false);
            this.pathGroupBox.PerformLayout();
            this.filesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox pathGroupBox;
        private System.Windows.Forms.TextBox fileTextbox;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.GroupBox filesGroupBox;
        private System.Windows.Forms.ListView foundList;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox infoTextbox;
        private System.Windows.Forms.CheckBox backupCheckbox;
        private System.Windows.Forms.ToolTip backupTooltip;
    }
}
