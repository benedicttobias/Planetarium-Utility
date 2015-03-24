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
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.filesGroupBox = new System.Windows.Forms.GroupBox();
            this.copyList = new System.Windows.Forms.ListView();
            this.resetButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.mirrorCheckbox = new System.Windows.Forms.CheckBox();
            this.checkBoxHolder = new System.Windows.Forms.TableLayoutPanel();
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
            this.distributeButton.Click += new System.EventHandler(this.distributeButton_Click);
            // 
            // pathGroupBox
            // 
            this.pathGroupBox.Controls.Add(this.checkBoxHolder);
            this.pathGroupBox.Controls.Add(this.mirrorCheckbox);
            this.pathGroupBox.Controls.Add(this.destinationButton);
            this.pathGroupBox.Controls.Add(this.destinationTextBox);
            this.pathGroupBox.Controls.Add(this.destinationLabel);
            this.pathGroupBox.Location = new System.Drawing.Point(4, 134);
            this.pathGroupBox.Name = "pathGroupBox";
            this.pathGroupBox.Size = new System.Drawing.Size(482, 74);
            this.pathGroupBox.TabIndex = 36;
            this.pathGroupBox.TabStop = false;
            this.pathGroupBox.Text = "Path";
            // 
            // destinationButton
            // 
            this.destinationButton.Location = new System.Drawing.Point(392, 43);
            this.destinationButton.Name = "destinationButton";
            this.destinationButton.Size = new System.Drawing.Size(26, 23);
            this.destinationButton.TabIndex = 5;
            this.destinationButton.Text = "...";
            this.destinationButton.UseVisualStyleBackColor = true;
            this.destinationButton.Click += new System.EventHandler(this.destinationButton_Click);
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Enabled = false;
            this.destinationTextBox.Location = new System.Drawing.Point(78, 46);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.ReadOnly = true;
            this.destinationTextBox.Size = new System.Drawing.Size(308, 20);
            this.destinationTextBox.TabIndex = 3;
            this.destinationTextBox.Text = "Mirror Mode";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(12, 49);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(60, 13);
            this.destinationLabel.TabIndex = 1;
            this.destinationLabel.Text = "Destination";
            // 
            // filesGroupBox
            // 
            this.filesGroupBox.Controls.Add(this.copyList);
            this.filesGroupBox.Location = new System.Drawing.Point(4, 3);
            this.filesGroupBox.Name = "filesGroupBox";
            this.filesGroupBox.Size = new System.Drawing.Size(482, 125);
            this.filesGroupBox.TabIndex = 37;
            this.filesGroupBox.TabStop = false;
            this.filesGroupBox.Text = "Total: 0 file";
            // 
            // copyList
            // 
            this.copyList.Location = new System.Drawing.Point(6, 19);
            this.copyList.Name = "copyList";
            this.copyList.Size = new System.Drawing.Size(470, 100);
            this.copyList.TabIndex = 0;
            this.copyList.UseCompatibleStateImageBehavior = false;
            this.copyList.View = System.Windows.Forms.View.Details;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(340, 210);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(90, 33);
            this.resetButton.TabIndex = 39;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(436, 209);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(44, 32);
            this.logButton.TabIndex = 40;
            this.logButton.Text = "Log";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // mirrorCheckbox
            // 
            this.mirrorCheckbox.AutoSize = true;
            this.mirrorCheckbox.Checked = true;
            this.mirrorCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mirrorCheckbox.Location = new System.Drawing.Point(424, 49);
            this.mirrorCheckbox.Name = "mirrorCheckbox";
            this.mirrorCheckbox.Size = new System.Drawing.Size(52, 17);
            this.mirrorCheckbox.TabIndex = 6;
            this.mirrorCheckbox.Text = "Mirror";
            this.mirrorCheckbox.UseVisualStyleBackColor = true;
            this.mirrorCheckbox.CheckedChanged += new System.EventHandler(this.mirrorCheckbox_CheckedChanged);
            // 
            // checkBoxHolder
            // 
            this.checkBoxHolder.ColumnCount = 1;
            this.checkBoxHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.checkBoxHolder.Location = new System.Drawing.Point(15, 11);
            this.checkBoxHolder.Name = "checkBoxHolder";
            this.checkBoxHolder.RowCount = 1;
            this.checkBoxHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.checkBoxHolder.Size = new System.Drawing.Size(461, 29);
            this.checkBoxHolder.TabIndex = 7;
            // 
            // FileDistributor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.distributeButton);
            this.Controls.Add(this.pathGroupBox);
            this.Controls.Add(this.filesGroupBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.logButton);
            this.Name = "FileDistributor";
            this.Size = new System.Drawing.Size(489, 246);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileDistributor_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileDistributor_DragEnter);
            this.pathGroupBox.ResumeLayout(false);
            this.pathGroupBox.PerformLayout();
            this.filesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button distributeButton;
        private System.Windows.Forms.GroupBox pathGroupBox;
        private System.Windows.Forms.Button destinationButton;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.GroupBox filesGroupBox;
        private System.Windows.Forms.ListView copyList;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.CheckBox mirrorCheckbox;
        private System.Windows.Forms.TableLayoutPanel checkBoxHolder;

    }
}
