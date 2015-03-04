namespace Planetarium_Utility
{
    partial class settingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingWindow));
            this.renderersBox = new System.Windows.Forms.GroupBox();
            this.rendererNum = new System.Windows.Forms.ComboBox();
            this.rendererName = new System.Windows.Forms.TextBox();
            this.rendererNumberLabel = new System.Windows.Forms.Label();
            this.rendererNameLabel = new System.Windows.Forms.Label();
            this.authBox = new System.Windows.Forms.GroupBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.defaultsBox = new System.Windows.Forms.GroupBox();
            this.defFileTypes = new System.Windows.Forms.TextBox();
            this.fileTypesLabel = new System.Windows.Forms.Label();
            this.defDest = new System.Windows.Forms.TextBox();
            this.defSource = new System.Windows.Forms.TextBox();
            this.destLabel = new System.Windows.Forms.Label();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.renderersBox.SuspendLayout();
            this.authBox.SuspendLayout();
            this.defaultsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // renderersBox
            // 
            this.renderersBox.BackColor = System.Drawing.Color.Black;
            this.renderersBox.Controls.Add(this.rendererNum);
            this.renderersBox.Controls.Add(this.rendererName);
            this.renderersBox.Controls.Add(this.rendererNumberLabel);
            this.renderersBox.Controls.Add(this.rendererNameLabel);
            this.renderersBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renderersBox.ForeColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.renderersBox, "renderersBox");
            this.renderersBox.Name = "renderersBox";
            this.renderersBox.TabStop = false;
            // 
            // rendererNum
            // 
            this.rendererNum.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.rendererNum, "rendererNum");
            this.rendererNum.ForeColor = System.Drawing.Color.LightGray;
            this.rendererNum.FormattingEnabled = true;
            this.rendererNum.Items.AddRange(new object[] {
            resources.GetString("rendererNum.Items"),
            resources.GetString("rendererNum.Items1"),
            resources.GetString("rendererNum.Items2"),
            resources.GetString("rendererNum.Items3"),
            resources.GetString("rendererNum.Items4"),
            resources.GetString("rendererNum.Items5"),
            resources.GetString("rendererNum.Items6"),
            resources.GetString("rendererNum.Items7"),
            resources.GetString("rendererNum.Items8"),
            resources.GetString("rendererNum.Items9")});
            this.rendererNum.Name = "rendererNum";
            // 
            // rendererName
            // 
            this.rendererName.BackColor = System.Drawing.Color.Black;
            this.rendererName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rendererName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.rendererName.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.rendererName, "rendererName");
            this.rendererName.Name = "rendererName";
            // 
            // rendererNumberLabel
            // 
            resources.ApplyResources(this.rendererNumberLabel, "rendererNumberLabel");
            this.rendererNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rendererNumberLabel.ForeColor = System.Drawing.Color.LightGray;
            this.rendererNumberLabel.Name = "rendererNumberLabel";
            // 
            // rendererNameLabel
            // 
            resources.ApplyResources(this.rendererNameLabel, "rendererNameLabel");
            this.rendererNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rendererNameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.rendererNameLabel.Name = "rendererNameLabel";
            // 
            // authBox
            // 
            this.authBox.BackColor = System.Drawing.Color.Black;
            this.authBox.Controls.Add(this.password);
            this.authBox.Controls.Add(this.username);
            this.authBox.Controls.Add(this.passwordLabel);
            this.authBox.Controls.Add(this.usernameLabel);
            this.authBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authBox.ForeColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.authBox, "authBox");
            this.authBox.Name = "authBox";
            this.authBox.TabStop = false;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Black;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            this.password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Black;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.username, "username");
            this.username.Name = "username";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordLabel.ForeColor = System.Drawing.Color.LightGray;
            this.passwordLabel.Name = "passwordLabel";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.usernameLabel.Name = "usernameLabel";
            // 
            // defaultsBox
            // 
            this.defaultsBox.BackColor = System.Drawing.Color.Black;
            this.defaultsBox.Controls.Add(this.defFileTypes);
            this.defaultsBox.Controls.Add(this.fileTypesLabel);
            this.defaultsBox.Controls.Add(this.defDest);
            this.defaultsBox.Controls.Add(this.defSource);
            this.defaultsBox.Controls.Add(this.destLabel);
            this.defaultsBox.Controls.Add(this.sourceLabel);
            this.defaultsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultsBox.ForeColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.defaultsBox, "defaultsBox");
            this.defaultsBox.Name = "defaultsBox";
            this.defaultsBox.TabStop = false;
            // 
            // defFileTypes
            // 
            this.defFileTypes.BackColor = System.Drawing.Color.Black;
            this.defFileTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defFileTypes.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.defFileTypes, "defFileTypes");
            this.defFileTypes.Name = "defFileTypes";
            // 
            // fileTypesLabel
            // 
            resources.ApplyResources(this.fileTypesLabel, "fileTypesLabel");
            this.fileTypesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileTypesLabel.ForeColor = System.Drawing.Color.LightGray;
            this.fileTypesLabel.Name = "fileTypesLabel";
            // 
            // defDest
            // 
            this.defDest.BackColor = System.Drawing.Color.Black;
            this.defDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defDest.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.defDest, "defDest");
            this.defDest.Name = "defDest";
            // 
            // defSource
            // 
            this.defSource.BackColor = System.Drawing.Color.Black;
            this.defSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defSource.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.defSource, "defSource");
            this.defSource.Name = "defSource";
            // 
            // destLabel
            // 
            resources.ApplyResources(this.destLabel, "destLabel");
            this.destLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.destLabel.ForeColor = System.Drawing.Color.LightGray;
            this.destLabel.Name = "destLabel";
            // 
            // sourceLabel
            // 
            resources.ApplyResources(this.sourceLabel, "sourceLabel");
            this.sourceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sourceLabel.ForeColor = System.Drawing.Color.LightGray;
            this.sourceLabel.Name = "sourceLabel";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Black;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Black;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // settingWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.defaultsBox);
            this.Controls.Add(this.authBox);
            this.Controls.Add(this.renderersBox);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingWindow";
            this.ShowIcon = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.settingWindow_Load);
            this.renderersBox.ResumeLayout(false);
            this.renderersBox.PerformLayout();
            this.authBox.ResumeLayout(false);
            this.authBox.PerformLayout();
            this.defaultsBox.ResumeLayout(false);
            this.defaultsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox renderersBox;
        private System.Windows.Forms.TextBox rendererName;
        private System.Windows.Forms.Label rendererNumberLabel;
        private System.Windows.Forms.Label rendererNameLabel;
        private System.Windows.Forms.ComboBox rendererNum;
        private System.Windows.Forms.GroupBox authBox;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.GroupBox defaultsBox;
        private System.Windows.Forms.TextBox defDest;
        private System.Windows.Forms.TextBox defSource;
        private System.Windows.Forms.Label destLabel;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox defFileTypes;
        private System.Windows.Forms.Label fileTypesLabel;



    }
}