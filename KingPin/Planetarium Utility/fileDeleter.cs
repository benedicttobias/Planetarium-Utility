using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Planetarium_Utility
{
    public partial class fileDeleter : UserControl
    {
        // Connecting Main form and Usercontrol (here)
        public Main ParentForm { get; set; }

        ListView scriptList = new ListView();

        public fileDeleter()
        {
            InitializeComponent();
            initializeFoundList();

        }

        private void initializeFoundList()
        {
            // Destroy columns
            foundList.Items.Clear();
            foundList.Clear();

            // Add Columns
            foundList.Columns.Add("Occurance #");
            foundList.Columns.Add("Line #");
            foundList.Columns.Add("Script");
            foundList.Columns.Add("Script #");
            foundList.Columns.Add("Caption");
            foundList.Columns.Add("Tab");
            foundList.Columns.Add("Full path");

            // Edit properties for searched items
            foundList.View = View.Details;
            foundList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            foundList.LabelEdit = true;
            foundList.CheckBoxes = false;
            foundList.GridLines = true;
            foundList.Sorting = SortOrder.Ascending;

        }

        private void fileDeleter_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        public void fileDeleter_DragDrop(object sender, DragEventArgs e)
        {
            // Gather all the drag and drop item(s)
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Loop to gather all the items
            foreach (string file in files)
            {
                fileTextbox.Text = file;
                fileTextbox.Refresh();
            }

            // Run search script
            searchScript();
        }

        private void searchScript()
        {
            // Clear the table
            initializeFoundList();

            // Gather scripts
            lockScript();

            // Find file in the scripts
            findTextInScripts();
        }

        private void findTextInScripts()
        {
            // FInd file name from path
            string keyword = Path.GetFileName(fileTextbox.Text); // File name for deletion
            string line;                                         // string contain each words in each line
            int occurance;                                    // Number of keyword occurance in a file
            int lineNumber;                                   // Number of line in a file
            string lineString;                                   // Collection of line number
            string scriptName;                                   // Name of the script tab
            List<string> captions = new List<string>();          // List of caption name 
            settingWindow settingWindow = new settingWindow();
            int percentageProgress;
            int scriptPerSecond = 0;
            int previousScriptIndex = 0;
            DateTime enterFunction = DateTime.Now;
            int secondDifferent = 1; // 1 second different

            // Loop through all Buttons folder to find the keyword
            foreach (ListViewItem list in scriptList.Items)
            {
                // Initialize
                occurance  = 0;
                lineNumber = 0;
                lineString = "";
                scriptName = "";

                infoTextbox.Text = list.Text;
                infoTextbox.Refresh();

                ParentForm.deleterProgressBarStep(scriptList.Items.IndexOf(list));

                // Calculate script per second
                DateTime now = DateTime.Now;
                TimeSpan diff = now - enterFunction;
                
                if (((int) (Math.Round(diff.TotalSeconds))) == secondDifferent)
                {
                    scriptPerSecond = scriptList.Items.IndexOf(list) - previousScriptIndex;

                    // Assign script index for next second
                    previousScriptIndex = scriptList.Items.IndexOf(list);

                    // add one second diff
                    secondDifferent++;
                }
                
                // Calculate progress info by percentage
                percentageProgress = (scriptList.Items.IndexOf(list) * 100) / scriptList.Items.Count;

                // Send info about searching
                ParentForm.updateStatusLabel("Searching: " + percentageProgress.ToString() + "% | " 
                                           + "Speed: " + scriptPerSecond.ToString() + " scripts/second");

                // Open the file
                StreamReader file = new StreamReader(list.Text);

                // Read captions
                if (Path.GetFileName(list.Text) == "Captions.txt")
                    captions = readCaptions(file);

                // Loop until reach EoF
                while ((line = file.ReadLine()) != null)
                {
                    // Remember the line number
                    lineNumber++;

                    // Line #3: script title and avoid read captions file
                    if ((lineNumber == 3) && (Path.GetFileName(list.Text) != "Captions.txt"))
                    {
                        // Copy line
                        scriptName = line;

                        // Remove last character "
                        scriptName = scriptName.Remove(scriptName.Length - 1);

                        // Remove first 19 character (until " too)
                        scriptName = scriptName.Remove(0, 19);
                    }

                    if ((line.IndexOf(keyword, 0, StringComparison.CurrentCultureIgnoreCase) != -1))
                    {
                        // Track the occurance
                        occurance++;

                        // Insert log
                        ParentForm.sendToLog("Found: " + line + " in line " + lineNumber);

                        // Set the line number collection
                        if (lineString == "")
                            lineString = string.Format(lineNumber.ToString());
                        else
                            lineString = String.Format(lineString + ", " + lineNumber.ToString());
                    }
                }

                if (occurance > 0)
                {
                    // Insert to Search list
                    ListViewItem query = new ListViewItem();
                    query.Text = occurance.ToString();
                    query.SubItems.Add(lineString);
                    query.SubItems.Add(scriptName);
                    query.SubItems.Add(findScriptNumber(list.Text));
                    query.SubItems.Add(findCaption(captions, list.Text));
                    query.SubItems.Add(findTabName(list.Text));
                    query.SubItems.Add(list.Text);
                    foundList.Items.Add(query);

                    // Resize list every item inserted
                    foundList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    foundList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }

            // Reset progress bar to 0
            ParentForm.resetProgressBar();

            // Indicate the user for occurance
            if (foundList.Items.Count == 0)
            {
                ParentForm.sendToLog("No script use this file");
            }
            else
            {
                ParentForm.sendToLog("This file is being used in one or more scripts");
            }

            // If Buttons folder is not valid
            if (!System.IO.Directory.Exists(settingWindow.getButtonsFolder))
            {
                ParentForm.sendToLog("Please select valid Buttons folder");
            }
        }

        private string findTabName(string fullPath)
        {
            return Path.GetFileName(Path.GetDirectoryName(fullPath));
        }

        private string findCaption(List<string> captions, string fullPath)
        {
            int scriptNumber;
            string captionName;

            // Parse file name number
            fullPath = Path.GetFileNameWithoutExtension(fullPath);

            // Remove first character 'F'
            fullPath = fullPath.Remove(0, 1);

            // Convert to integer
            scriptNumber = Convert.ToInt32(fullPath);

            // Find in range
            if (scriptNumber >= 1 && scriptNumber <= 96)
                captionName = captions[0];
            else if (scriptNumber >= 97 && scriptNumber <= 192)
                captionName = captions[1];
            else if (scriptNumber >= 193 && scriptNumber <= 288)
                captionName = captions[2];
            else if (scriptNumber >= 289 && scriptNumber <= 384)
                captionName = captions[3];
            else if (scriptNumber >= 385 && scriptNumber <= 480)
                captionName = captions[4];
            else if (scriptNumber >= 481 && scriptNumber <= 576)
                captionName = captions[5];
            else if (scriptNumber >= 577 && scriptNumber <= 672)
                captionName = captions[6];
            else if (scriptNumber >= 673 && scriptNumber <= 768)
                captionName = captions[7];
            else if (scriptNumber >= 769 && scriptNumber <= 864)
                captionName = captions[8];
            else
                captionName = "Unknown";

            return captionName;
        }

        private string findScriptNumber(string fullPath)
        {
            return Path.GetFileNameWithoutExtension(fullPath);
        }

        private List<string> readCaptions(StreamReader file)
        {
            List<String> captions = new List<string>(); // Captions of the script
            string line;                                // One line read

            while ((line = file.ReadLine()) != null)
            {
                captions.Add(line);
            }

            return captions;
        }

        private void lockScript()
        {
            settingWindow settingWindow = new settingWindow();

            if (System.IO.Directory.Exists(settingWindow.getButtonsFolder))
            {
                generateScriptList();
            }
            else
            {
                ParentForm.sendToLog("Please select valid Buttons folder");
            }
        }

        private void generateScriptList()
        {
            settingWindow settingWindow = new settingWindow();

            // Clear the scripts list
            scriptList.Items.Clear();
            
            // Populate scripts in file
            try
            {
                foreach (string file in Directory.EnumerateFiles(settingWindow.getButtonsFolder, "*.*", SearchOption.AllDirectories))
                {
                    // Inserting new log
                    ListViewItem script = new ListViewItem();
                    script.Text = file;
                    scriptList.Items.Add(script);
                }

                ParentForm.sendToLog("Search complete using " + scriptList.Items.Count + " script(s)");

                // Send maximum value to main progress bar
                ParentForm.deleterProgressBarMax(scriptList.Items.Count);
            }
            catch (IOException error)
            {
                ParentForm.sendToLog("Generate buttons error: " + error.Message);
            }
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            // Calling Main form to resize program
            ParentForm.expandAndCollapseLog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            settingWindow settingWindow = new settingWindow();
            string backupFolder;
            string backupTarget;


            // Backup original file if backup checkbox checked and perform delete
            if (backupCheckbox.Checked == true)
            {
                // Setup backup location
                backupFolder = settingWindow.getBackupFolder;
                FileInfo fileName = new FileInfo(fileTextbox.Text);
                backupTarget = backupFolder + "\\" + fileName.Name;

                try
                {
                    ParentForm.sendToLog("Backup original file...");
                    File.Copy(fileTextbox.Text, backupTarget);
                    ParentForm.sendToLog("Backup done...");
                }
                catch (IOException error)
                {
                    ParentForm.sendToLog("Error to backup the file: " + error.Message);
                    ParentForm.sendToLog("No file deleted");
                    return;
                }
            }

            // Delete on all computers including original file
            deleteRenderer();
            deleteMaster();
        }

        private void deleteMaster()
        {
            // Delete if there is a file
            if (File.Exists(fileTextbox.Text))
            {
                try { System.IO.File.Delete(fileTextbox.Text); }
                catch (IOException deleteError) { ParentForm.sendToLog("Delete error: " + deleteError.Message); }

                // Insert log
                ParentForm.sendToLog(fileTextbox.Text + " is deleted");
            }
            else
            {
                ParentForm.sendToLog("File is not valid in this computer");
            }
        }

        private void deleteRenderer()
        {
            settingWindow settingWindow = new settingWindow();
            int totalRenderer = Int32.Parse(settingWindow.getRendererNum);
            string target = fileTextbox.Text.Replace(":", "");
            string computerStringNumber;
            string computerName;
            string deleteFullPath = null;

            // Delete if there is a file
            if (File.Exists(fileTextbox.Text))
            {
                // Loop to delete based on renderer number
                for (int computerNumber = 1; computerNumber <= totalRenderer; computerNumber++)
                {
                    // Replace Windows account name to renderer's name
                    target = target.Replace(string.Format("\\Users\\" + System.Environment.UserName),
                                            string.Format("\\Users\\" + settingWindow.getUsername));

                    // Set the computer name for this iteration (01, 02, 03...)
                    if (computerNumber < 10)
                        computerStringNumber = string.Format("0" + computerNumber.ToString());
                    else
                        computerStringNumber = string.Format(computerNumber.ToString());

                    // Construct renderer name                    
                    computerName = string.Format(settingWindow.getRendererName + '-' + computerStringNumber);

                    // Define delete path
                    deleteFullPath = String.Format("\\\\" + computerName + "\\" + target);

                    // Check file existency in the renderer
                    if (System.IO.File.Exists(deleteFullPath))
                    {
                        // Deleting log
                        ParentForm.sendToLog("Deleting " + deleteFullPath);

                        // Actual delete action
                        try { System.IO.File.Delete(deleteFullPath); }
                        catch (IOException deleteError) { ParentForm.sendToLog("Delete error: " + deleteError.Message); }

                        // Insert log
                        ParentForm.sendToLog(deleteFullPath + " is deleted");
                    }
                    else
                    {
                        ParentForm.sendToLog(deleteFullPath + " does not exist");
                    }
                }
            }
            else
            {
                ParentForm.sendToLog("File is not exist in this computer");
            }
        }

    }
}
