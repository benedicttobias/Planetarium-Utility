namespace Planetarium_Utility
{
    partial class statusForm
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
            this.statusPanel = new System.Windows.Forms.Panel();
            this.statusListView = new System.Windows.Forms.ListView();
            this.statusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.statusListView);
            this.statusPanel.Location = new System.Drawing.Point(3, 13);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(552, 380);
            this.statusPanel.TabIndex = 0;
            // 
            // statusListView
            // 
            this.statusListView.Location = new System.Drawing.Point(4, 4);
            this.statusListView.MaximumSize = new System.Drawing.Size(545, 373);
            this.statusListView.MinimumSize = new System.Drawing.Size(545, 373);
            this.statusListView.Name = "statusListView";
            this.statusListView.Size = new System.Drawing.Size(545, 373);
            this.statusListView.TabIndex = 0;
            this.statusListView.UseCompatibleStateImageBehavior = false;
            this.statusListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.statusListView_ColumnWidthChanging);
            // 
            // statusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 405);
            this.Controls.Add(this.statusPanel);
            this.MaximumSize = new System.Drawing.Size(574, 443);
            this.MinimumSize = new System.Drawing.Size(574, 443);
            this.Name = "statusForm";
            this.Text = "Batch Status";
            this.statusPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.ListView statusListView;
    }
}