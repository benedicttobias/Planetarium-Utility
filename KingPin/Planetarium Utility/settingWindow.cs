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

        // CLOSE WINDOW WITHOUT SAVING CHANGES
        private void cancelButton_Click(object sender, EventArgs e)
        {
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
            string[] values;
                    /* Order of values:
                     */
            int      v = 0;

            // Exclude comments from the list. Store only values in a new array.
            for (int i=0; i<lines.Length; i++)
            {
                if (!lines[i].Contains(comment))
                    values[v] = lines[i];
            }

            //renderer

        }

        //
        private void settingWindow_Load(object sender, EventArgs e)
        {
            
        }
    }
}
