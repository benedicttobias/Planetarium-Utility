using System;
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

        // Path to document location
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



        /*=============================
         *  Event-Based Functions Def
         *============================*/

        private void settingWindow_Load(object sender, EventArgs e)
        {
            
        }


        // DEFAULT DESTINATION VALIDATION
        private void defDest_Leave(object sender, EventArgs e)
        {
            // Remove leading or trailing spaces
            defDest.Text = defDest.Text.Trim();

            // Make sure that the path is legitimate
            if (validatePath(defDest.Text))
            {
                if (defDest.Text.Contains(":"))
                    parseToNetworkPath();
            }
            else
            {
                MessageBox.Show("Enter a valid path. Path must be a network path (begins with \"\\\""); // center this to parent by creating a custom messagebox class */
                defDest.Focus();
            }
        }
        

        // DEFAULT FILE TYPES VALIDATION
        private void defFileTypes_Leave(object sender, EventArgs e)
        {
            // Make sure that text is comma separated file formats
            if (!validateFormats(defFileTypes.Text))
            {
                MessageBox.Show("File Types must be space-separated 3-letter file formats"); // center this to parent by creating a custom messagebox class */
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
            rendererNum.Text  = value[1];
            username.Text     = value[2];
            password.Text     = value[3];
            defSource.Text    = value[4];
            defDest.Text      = value[5];
            defDest.Text      = value[5];
            defFileTypes.Text = value[6];
        }


        // CHANGE LOCAL ADDRESS TO NETWORK ADDRESS
        private void parseToNetworkPath()
        {
            var sourceText = defDest.Text;
            StringBuilder newText = new StringBuilder(sourceText);

            // Find where the colon and the letter drive
            int colon = sourceText.IndexOf(':');
            int drive = colon - 1;

            // Set letter drive to lower case and remove colon
            newText = newText.Replace(sourceText[drive], sourceText[drive].ToString().ToLower().ToCharArray()[0]);
            newText = newText.Remove(colon, 1);

            // Update default destination with the modified string
            defDest.Text = ("\\" + newText.ToString());
        }


        // CHECK TO SEE IF STRING IS LEGIT PATH
        private bool validatePath(string path)
        {
            string pathRegex = @"^((([a-zA-Z]:)|(\\{1,2}\w+)|(\\{1,2}(?:(?:25[0-5]|2[0-4]\d|[01]\d\d|\d?\d)(?(?=\.?\d)\.)){4}))(\\(\w[\w ]*)))";
            /* Regex to match valid folder paths. can be local, UNC with server name, or UNC with IP address
             * Matches: c:\ds\dsfsdf | \\192.168.14.118\23423 | \\fsdf\23423
             * Non-Matches:	c:\ | \\192.168.12.114 | \\fff
             */
            Regex pathPattern = new Regex(pathRegex);
            return (pathPattern.IsMatch(path));
        }
 

        // CHECK TO SEE IF STRING IS A SET OF FILE TYPES
        private bool validateFormats(string fileTypes)
        {


            return true;
        }


    }
}
