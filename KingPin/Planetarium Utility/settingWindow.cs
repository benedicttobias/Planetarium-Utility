using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Planetarium_Utility
{
    public partial class settingWindow : Form
    {
        /*********************************************************/
        /*  Call function to other forms                         */
        /*********************************************************/
        // Return default file types called by main program
        public String[] getDefFileTypes
        {
            get 
            { 
                String[] extensions;               

                // Split string into array of string
                extensions = defFileTypes.Text.Split(' ');

                return extensions;
            }
        }

        public string getDestination  { get { return defDest.Text;     } }
        public string getDefSource    { get { return defSource.Text;   } }
        public string getPassword     { get { return password.Text;    } }
        public string getUsername     { get { return username.Text;    } }
        public string getRendererName { get { return rendererName.Text;} }
        public string getRendererNum  { get { return rendererNum.Text; } }
        

        // VARIABLES
        string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
               // Path to document location
        string fileName = @"\PlanetariumUtilitySetting.txt";
                // File that contains setting value
        char comment = ';';
                // Comment symbol to be written in text file

        // SETUP SETTING WINDOW
        public settingWindow()
        {
            InitializeComponent();
            this.setDefaultValue();
        }

        // CLOSE WINDOW AND REVERT TO PREVIOUS SETTING
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.setDefaultValue();
            this.Hide();
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
            using (StreamWriter saveSetting = new StreamWriter(myDocPath+fileName , false))
            {
                /* !!! try and catch to handle exception !!! */

                // Write to file when it can
                await saveSetting.WriteAsync(sb.ToString());
            }

            // Close window after saving
            this.Hide();
        }

        // SET VALUES FROM SAVED TEXT FILE
        private void setDefaultValue()
        {
            string[] lines = File.ReadAllLines(myDocPath+fileName);
            string[] value = new string[7];
                    /* Order of values:
                     *  rendererName
                     *  rendererNum
                     *  username
                     *  password
                     *  defSource
                     *  defDest
                     *  defFileTypes
                     */

            // Exclude comments from the list. Store only values in a new array.
            int v = 0;
            for (int i=0; i<lines.Length; i++)
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

        //
        private void settingWindow_Load(object sender, EventArgs e)
        {
            
        }
    }
}
