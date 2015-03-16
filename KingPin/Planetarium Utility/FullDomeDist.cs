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
    public partial class FullDomeDist : UserControl
    {
        // Connecting to setting form
        public settingWindow settingWindow;

        public Main ParentForm { get; set; }

        public FullDomeDist()
        {
            // Initialize option user control
            settingWindow = new settingWindow();

            // Initialization
            InitializeComponent();
            initializeFilesListView();
            initializeDefaultValue();
        }

        private void attemptListFile()
        {
            // Check directory existance
            if (Directory.Exists(projectTextBox.Text))
                listFilesInPath(projectTextBox.Text);
            else
                sendToLog("Try to load project folder, but it could not reach the address.");
        }

        private void initializeDefaultValue()
        {
            projectTextBox.Text     = settingWindow.getDefSource;
            destinationTextBox.Text = settingWindow.getDestination;
        }

        private void distributeButton_Click(object sender, EventArgs e)
        {
        
        }

        private void projectButton_Click(object sender, EventArgs e)
        {
            // preseve project textbox value in case user click 'cancel'
            String originalProjectPath = projectTextBox.Text;

            // Open browser to select project folder
            FolderBrowserDialog selectFolder = new FolderBrowserDialog();
            selectFolder.SelectedPath = projectTextBox.Text;

            // Convert to path text
            DialogResult result = selectFolder.ShowDialog();

            // Condition where user press 'Cancel'
            if (result == DialogResult.Cancel)
                projectTextBox.Text = originalProjectPath;

            // Set destination to textbox if user press 'OK' and list all the files
            if (result == DialogResult.OK)
            {
                projectTextBox.Text = selectFolder.SelectedPath;

                // List all files inside the folder path
                listFilesInPath(selectFolder.SelectedPath);
            }
        }

        private void initializeFilesListView()
        {
            // Clear the items
            filesListView.Clear();

            // Add Columns
            filesListView.Columns.Add("File Name");
            filesListView.Columns.Add("Extension");
            filesListView.Columns.Add("Channel");
            filesListView.Columns.Add("Source");
            filesListView.Columns.Add("Destination");

            // Edit properties for searched items
            filesListView.View = View.Details;
            filesListView.GridLines = true;
            filesListView.Sorting = SortOrder.Ascending;
            filesListView.CheckBoxes = true;

            // Hide source and destination
            filesListView.Columns[0].Width = 335;
            filesListView.Columns[1].Width = 60;
            filesListView.Columns[2].Width = 75;
            filesListView.Columns[3].Width = 0;
            filesListView.Columns[4].Width = 0;
        }

        private void listFilesInPath(string path)
        {
            int fileCounter = 0; // Number of files in a directory

            // Check directory existance
            if (Directory.Exists(path))
                sendToLog("Directory is accepted");
            else
                sendToLog("Directory is not exist");

            // Gather the files in an array
            DirectoryInfo directoryTarget = new DirectoryInfo(path);
            FileInfo[] filesInDir = directoryTarget.GetFiles("*", SearchOption.TopDirectoryOnly);

            foreach (FileInfo foundFile in filesInDir)
            {
                // Insert to Search list
                ListViewItem query = new ListViewItem();
                query.Text = foundFile.Name;
                query.SubItems.Add(foundFile.Extension);
                query.SubItems.Add(findChannel(foundFile.FullName));
                query.SubItems.Add(foundFile.FullName);
                query.SubItems.Add(copyTo(foundFile.FullName, foundFile.Name));

                // Insert item to file list and log it
                filesListView.Items.Add(query);

                sendToLog("Added: " + foundFile.Name);

                fileCounter++;
            }

            // Acknowledge the user the number of files added
            sendToLog("Total file(s) added: " + fileCounter);

            // Check file(s) based on default files types
            checkDefaultFileTypes();
        }

        private string copyTo(string fullName, string fileName)
        {
            string destination = "Unknown";

            if (findChannel(fullName) != "Unknown")
            {
                destination = string.Format("\\\\" + findChannel(fullName) + "\\" + destinationTextBox.Text);
            }

            return destination;
        }

        private void checkDefaultFileTypes()
        {
            int checkCounter = 0; // Count the number of files checked by default ext

            // Get default file types from setting window
            foreach (String extension in settingWindow.getDefFileTypes)
                sendToLog("Checked all " + extension + " file(s)");

            // Check if the file extension is in the default
            foreach (ListViewItem file in filesListView.Items)
            {
                // Compare each extension to a file
                foreach (string extension in settingWindow.getDefFileTypes)
                {
                    if (file.SubItems[1].Text.Contains(extension))
                    {
                        file.Checked = true;

                        checkCounter++;
                    }
                }
            }

            // Log checked items
            sendToLog(checkCounter + " file(s) checked");
        }

        private string findChannel(string fullName)
        {
            string destination = null;
            int    totalComputer;
            string computerPrefix = settingWindow.getRendererName;
            string computerStringNumber;

            // Get total computer
            if(Int32.TryParse(settingWindow.getRendererNum, out totalComputer))
            {
                ParentForm.sendToLog("Finding " + fullName + " destination");
            }
            else
                ParentForm.sendToLog("Total computer is not valid");

            for (int computerNumber = 1; computerNumber <= totalComputer; computerNumber++)
            {
                // Set the computer name (01, 02, 03...)
                computerStringNumber = string.Format("0" + computerNumber.ToString());

                // Assign to particular computer number
                if (fullName.Contains(computerStringNumber))
                    destination = string.Format(computerPrefix + '-' + computerStringNumber);
            }

            // Set destination as 'Unknown' if cant found
            if (destination == null)
            {
                destination = "Unknown";
                ParentForm.sendToLog("Can't find destination for " + fullName);
            }
            else
                ParentForm.sendToLog("Destination found for " + fullName + " (" + destination + ")");

            return destination;
        }

        private void sendToLog(string log)
        {
            //main.sendToLog(log);

            ParentForm.sendToLog(log);
        }

        private void destinationButton_Click(object sender, EventArgs e)
        {
            // preseve destination textbox value in case user click 'cancel'
            String originalDestinationPath = destinationTextBox.Text;

            // Open browser to select project folder
            FolderBrowserDialog selectFolder = new FolderBrowserDialog();

            // Convert to path text
            DialogResult result = selectFolder.ShowDialog();

            // Condition where user press 'Cancel'
            if (result == DialogResult.Cancel)
                destinationTextBox.Text = originalDestinationPath;

            // Set destination to textbox if user press 'OK'
            if (result == DialogResult.OK)
                destinationTextBox.Text = selectFolder.SelectedPath;
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            ParentForm.expandAndCollapseLog();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Initialization
            initializeFilesListView();
            initializeDefaultValue();
        }

        private void distributeButton_Click_1(object sender, EventArgs e)
        {
            // Check for empty copy
            if (filesListView.Items.Count == 0)
                ParentForm.sendToLog("Nothing to copy");

            foreach (ListViewItem item in filesListView.Items)
            {
                // Copy file from source to destination
                if (item.Checked == true)
                {
                    copyFile(item.SubItems[2].Text, item.SubItems[4].Text, item.SubItems[0].Text);
                }
            }
        }

        private void copyFile(string p1, string p2, string p3)
        {
            throw new NotImplementedException();
        }
    }
}
