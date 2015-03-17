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
        // Connecting to setting form (Options)
        public settingWindow settingWindow;

        // Connecting Main form and Usercontrol (here)
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
            // Get the settings from Options
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
            int fileCounter = 0;        // Number of files in a directory
            string channel = "Unknown"; // Initial destination for a file

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
                // Table order by index:
                // 0 : file name
                // 1 : extension
                // 2 : channel
                // 3 : full original directory (source)
                // 4 : full destination directory (destination)

                // Get the destination channel/computer
                channel = findChannel(foundFile.FullName);

                // Set the content by index
                ListViewItem query = new ListViewItem();
                query.Text = foundFile.Name;
                query.SubItems.Add(foundFile.Extension);
                query.SubItems.Add(channel);
                query.SubItems.Add(foundFile.FullName);
                query.SubItems.Add(copyTo(foundFile.FullName, foundFile.Name, channel));

                // Insert item to file list and log it
                filesListView.Items.Add(query);

                // Ackowledge the user
                sendToLog("Added: " + foundFile.Name);

                // Counting the files found
                fileCounter++;
            }

            // Acknowledge the user the number of files added
            sendToLog("Total file(s) added: " + fileCounter);

            // Check file(s) based on default files types
            checkDefaultFileTypes();
        }

        private string copyTo(string fullName, string fileName, string channel)
        {
            string destination = "Unknown"; // Initial destination location

            // Set the destination corespond to the channel if destination known
            if (channel != "Unknown")
                destination = string.Format("\\\\" + channel + "\\" + destinationTextBox.Text);

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

                        // Count how many file(s) checked
                        checkCounter++;
                    }
                }
            }

            // Let user know how many items checked
            sendToLog(checkCounter + " file(s) checked");
        }

        private string findChannel(string fullName)
        {
            string destination = "Unknown";                        // Initial file destination
            int    totalComputer;                                  // Number of renderer computers
            string computerPrefix = settingWindow.getRendererName; // Prefix of computer name
            string computerStringNumber;                           // String form of total computers

            // Get total computer
            if(Int32.TryParse(settingWindow.getRendererNum, out totalComputer))
                ParentForm.sendToLog("Finding " + fullName + " destination");
            else
                ParentForm.sendToLog("Total computer is not valid");

            // Loop through all computer number to decide which channel a file fall
            for (int computerNumber = 1; computerNumber <= totalComputer; computerNumber++)
            {
                // Set the computer name for this iteration (01, 02, 03...)
                computerStringNumber = string.Format("0" + computerNumber.ToString());

                // Assign to particular computer number
                if (fullName.Contains(computerStringNumber))
                    destination = string.Format(computerPrefix + '-' + computerStringNumber);
            }

            // Let the user know the destination
            if (destination == "Unknown")
                ParentForm.sendToLog("Can't find destination for " + fullName);
            else
                ParentForm.sendToLog("Destination found for " + fullName + " (" + destination + ")");

            return destination;
        }

        private void sendToLog(string log)
        {
            // Calling Main form to send log
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
            // Calling Main form to resize program
            ParentForm.expandAndCollapseLog();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Initialize Full Dome Distributor form 
            initializeFilesListView();
            initializeDefaultValue();
        }

        private void distributeButton_Click_1(object sender, EventArgs e)
        {
            // Check for empty copy
            if (filesListView.Items.Count == 0)
                ParentForm.sendToLog("Nothing to copy");

            // Loop through each list
            foreach (ListViewItem item in filesListView.Items)
            {
                // Copy checked file from source to destination
                if (item.Checked == true)
                {
                    // subitems 2 = source
                    // subitems 4 = destination
                    // subitems 0 = file name
                    copyFile(item.SubItems[2].Text, item.SubItems[4].Text, item.SubItems[0].Text);
                }
            }
        }

        private void copyFile(string source, string destination, string fileName)
        {
            // Exact file destination
            string fullDestination = string.Format(destination + "\\" + fileName);

            // Create a new target flder if needed
            try
            {
                // Create new folder if there is no exist directory
                if (!Directory.Exists(destination))
                {
                    ParentForm.sendToLog("Destination directory is not exist...");
                    ParentForm.sendToLog("Create " + destination + " directory");
                    Directory.CreateDirectory(destination);
                }
            }
            catch (IOException makeNewDirectoryError)
            {
                // Error in creating directory
                ParentForm.sendToLog("Creating directory failed: " + makeNewDirectoryError);
            }

            // Copy from source to destination (overwrite mode)
            try
            {
                ParentForm.sendToLog("Copying " + source + " to " + destination);
                File.Copy(source, fullDestination, true); // true mean overwrite exist file
                ParentForm.sendToLog("Copy " + source + " successfull");
            }
            catch (IOException copyError)
            {
                // Error in copy process
                ParentForm.sendToLog("Copy " + source + " failed: " + copyError);
            }

        }
    }
}
