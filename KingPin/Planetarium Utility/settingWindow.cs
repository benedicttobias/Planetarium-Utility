﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Planetarium_Utility
{
    public partial class settingWindow : Form
    {
        /*========================
         *  CUSTOMIZED VARIABLES
         *=======================*/
        // Path to saved text
        string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        // File that contains setting value  
        string fileName = @"\PlanetariumUtilitySetting.txt";
        // Comment symbol to be written in text file  
        char comment = ';';



        /*========================
        *  SETUP SETTING WINDOW
        *=======================*/
        public settingWindow()
        {
            InitializeComponent();
            this.setDefaultValue();
        }



        /*================
        *  GET FUNCTIONS
        *================*/
        public string getRendererName { get { return rendererName.Text; } }
        public string getRendererNum { get { return rendererNum.Text; } }
        public string getUsername { get { return username.Text; } }
        public string getPassword { get { return password.Text; } }
        public string getDestination { get { return defDest.Text; } }
        public string getDefSource { get { return defSource.Text; } }
        public String[] getDefFileTypes
        {
            get
            {
                // Split string into array of string
                String[] extensions;
                extensions = defFileTypes.Text.Split(' ');
                return extensions;
            }
        }

        public string getBackupFolder { get { return backupTextbox.Text; } }
        public string getButtonsFolder { get { return buttonsTextbox.Text; } }




        /*=============================
         *  Event-Based Functions Def
         *============================*/

        private void settingWindow_Load(object sender, EventArgs e)
        {

        }


        // COMPUTER NAME VALIDATION
        private void rendererName_Leave(object sender, EventArgs e)
        {
            // Remove leading or trailing spaces
            rendererName.Text = rendererName.Text.Trim();

            // Make sure that the path is legitimate
            if (!validateCompName(rendererName.Text))
            {
                MessageBox.Show("Renderer name must consists of characters and be less than 16 characters. Dot is allowed, but cannot start with one."); // center this to parent by creating a custom messagebox class */
                rendererName.Focus();
            }
        }


        // RENDERER NUMBER VALIDATION
        private void rendererNum_Leave(object sender, EventArgs e)
        {
            // Does not need validation. Style changed to DropDownList which disabled text input
        }


        // USERNAME VALIDATION
        private void username_Leave(object sender, EventArgs e)
        {
            // Remove leading or trailing spaces
            username.Text = username.Text.Trim();

            // Make sure username is compliance to windows standard
            if (!validateUsername(username.Text))
            {
                MessageBox.Show("User name cannot contain \" / \\ [ ] : ; | = , + * ? < or >");
                username.Focus();
            }
        }


        // DEFAULT SOURCE VALIDATION
        private void defSource_Leave(object sender, EventArgs e)
        {
            // Remove leading or trailing spaces
            defSource.Text = defSource.Text.Trim();

            // Make sure that the path is legitimate
            if (!validateNetworkPath(defSource.Text))
            {
                MessageBox.Show("Check default Source again. Always use network address (Ex: \\\\computer-name\\drive\\folder\\subfolder)."); // center this to parent by creating a custom messagebox class */
                defSource.Focus();
            }
        }


        // DEFAULT DESTINATION VALIDATION
        private void defDest_Leave(object sender, EventArgs e)
        {
            // Remove leading or trailing spaces
            defDest.Text = defDest.Text.Trim();

            // Make sure that the path is legitimate
            if (!validateLocalPath(defDest.Text))
            {
                MessageBox.Show("Check default Destination. Destination path is where the file is going for all machines (Ex: \\localDrive\\folder\\subfolder)."); // center this to parent by creating a custom messagebox class */
                defDest.Focus();
            }
        }


        // DEFAULT FILE TYPES VALIDATION
        private void defFileTypes_Leave(object sender, EventArgs e)
        {
            // Trim trailing and leading spaces
            defFileTypes.Text = defFileTypes.Text.Trim();

            // Make sure that text is comma separated file formats
            if (!validateFormats(defFileTypes.Text) && defFileTypes.Text != "")
            {
                MessageBox.Show("File Types must be space-separated 3/4-letter file formats"); // center this to parent by creating a custom messagebox class */
                defFileTypes.Focus();
            }
        }


        // SAVE CHANGES AND CLOSE WINDOW
        private async void saveButton_Click(object sender, EventArgs e)
        {
            // Construct the text to be written on file
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(comment + "Setting for Planetarium Utility");
            sb.AppendLine(comment + "===============================");
            sb.AppendLine(rendererName.Text);
            sb.AppendLine(rendererNum.Text);
            sb.AppendLine(username.Text);
            sb.AppendLine(password.Text);
            sb.AppendLine(defSource.Text);
            sb.AppendLine(defDest.Text);
            sb.AppendLine(defFileTypes.Text);

            // Open streamwriter to a new text file named "PlanetariumUtilitySetting.txt"and write constructed string onto it.
            // "false" = Overwrite if exist
            /* !!! make text location a variable !!! */
            using (StreamWriter saveSetting = new StreamWriter(myDocPath + fileName, false))
            {
                /* !!! try and catch to handle exception !!! */

                // Write to file when it can
                await saveSetting.WriteAsync(sb.ToString());
            }

            

            // Close window after saving
            this.Hide();
        }


        // CLOSE WINDOW AND REVERT TO PREVIOUS SETTING
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.setDefaultValue();
            this.Hide();
        }



        /*=============================
         *  User Function Definitions
         *============================*/

        // SET VALUES FROM SAVED TEXT FILE
        private async void setDefaultValue()
        {
            // Attempt to read settings from saved text file
            string[] lines = new string[0];
            bool readOkay;
            try
            {
                lines = File.ReadAllLines(myDocPath + fileName);
                readOkay = true;
            }
            catch (FileNotFoundException)
            {
                readOkay = false;
            }

            // If file doesn't exist, create a new one with default values
            if (!readOkay)
            {
                // Construct the text to be written on file
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(comment + "Setting for Planetarium Utility");
                sb.AppendLine(comment + "===============================");
                sb.AppendLine("DS");
                sb.AppendLine("8");
                sb.AppendLine("skyvision");
                sb.AppendLine("sky");
                sb.AppendLine("\\\\ds-sound\\e\\svr\\output");
                sb.AppendLine("\\\\e\\digital sky\\shows\\ps");
                sb.AppendLine(".dsi .mpg");

                // Open streamwriter to a new text file named "PlanetariumUtilitySetting.txt"and write constructed string onto it.
                // "false" = Overwrite if exist
                /* !!! make text location a variable !!! */
                using (StreamWriter saveSetting = new StreamWriter(myDocPath + fileName, false))
                {
                    /* !!! try and catch to handle exception !!! */

                    // Write to file when it can
                    await saveSetting.WriteAsync(sb.ToString());
                }

                // Read the lines now that the file is created
                lines = File.ReadAllLines(myDocPath + fileName);
            }

            // Exclude comments from the list. Store only values in a new array.
            int v = 0;
            string[] value = new string[7];
            /* Order of values:
            *  rendererName, rendererNum
            *  username, password
            *  defSource, defDest, defFileTypes
            */
            for (int i = 0; i < lines.Length; i++)
            {
                if (!lines[i].Contains(comment))
                {
                    value[v] = lines[i];
                    v += 1;
                }
            }

            // Assign values to variables based on the order
            rendererName.Text = value[0];
            rendererNum.Text = value[1];
            username.Text = value[2];
            password.Text = value[3];
            defSource.Text = value[4];
            defDest.Text = value[5];
            defDest.Text = value[5];
            defFileTypes.Text = value[6];
        }


        // COMPUTER NAME MUST MEET NETBIOS REQUIREMENT
        private bool validateCompName(string name)
        {
            string nameRegex = @"^[A-Za-z\d_!@#$%^()\-'{}~]([A-Za-z\d_!@#$%^()\-'{}\.~]{1,14}$)";
            // Lookup NETBios computer name to understand regex
            Regex namePattern = new Regex(nameRegex);
            return (namePattern.IsMatch(name));
        }


        // CHECK TO SEE IF STRING IS A VALID USER NAME
        private bool validateUsername(string name)
        {
            string nameRegex = @"^([a-zA-Z0-9 \\~\\`\\!\\@\\#\\$%\\^&\\(\\)\\-_\\{\\}'\\.]+)$";
            // Validates username based on Windows requirement
            Regex namePattern = new Regex(nameRegex);
            return (namePattern.IsMatch(name));
        }

        // CHECK TO SEE IF STRING IS LEGIT PATH
        private bool validateLocalPath(string path)
        {
            string pathRegex = @"^(\\[A-Za-z0-9-_ ]+){1,}(\\?)$";
            // Regex to match valid folder paths
            Regex pathPattern = new Regex(pathRegex);
            return (pathPattern.IsMatch(path));
        }


        // CHECK TO SEE IF STRING IS LEGIT SHARED FOLDER PATH
        private bool validateNetworkPath(string path)
        {
            string pathRegex = @"^(\\)(\\[A-Za-z0-9-_ ]+){2,}(\\?)$";
            // Validates a network path on a shared location
            Regex pathPattern = new Regex(pathRegex);
            return (pathPattern.IsMatch(path));
        }


        // CHECK TO SEE IF STRING IS A SET OF FILE TYPES
        private bool validateFormats(string fileTypes)
        {
            string formatRegex = @"^(\.[a-zA-Z0-9]{1,4})(((\ ){1}\.[a-zA-Z0-9]{1,4})*)$";
            //^((\.[a-zA-Z0-9]{1,4}(\ )?)*)$
            // File types must be comma-separated sets of a dot follwed by max four letter or num.
            Regex formatPattern = new Regex(formatRegex);
            return (formatPattern.IsMatch(fileTypes));
        }
    }
}
