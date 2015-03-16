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

        // Full Dome Distributor construction
        Main mainParent = null;
        public FullDomeDist(Main mainParent)
        {
            // Initialize option user control
            settingWindow = new settingWindow();

            // Initialization
            InitializeComponent();
            initializeFilesListView();
            initializeDefaultValue();

            // Set parent to Main
            this.mainParent = mainParent;

            // Attempt to populate files
            attemptListFile();
        }

        public FullDomeDist()
        {
            // Note: This initial function is not called.
            // also, in main.designer.cs, fulldomedistributor forced to call contructor
            // with argument of main form so it can call method in main form.
            // see details: https://www.daniweb.com/software-development/csharp/threads/121521/setting-parent-and-child-windows
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
            //filesListView.Columns.Add("Destination");

            // Edit properties for searched items
            filesListView.View = View.Details;
            filesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            filesListView.GridLines = true;
            filesListView.Sorting = SortOrder.Ascending;
            filesListView.CheckBoxes = true;
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
                //query.SubItems.Add(copyTo(foundFile.FullName, foundFile.Name));

                // Insert item to file list and log it
                filesListView.Items.Add(query);

                // Resize all columns as files populate
                filesListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                filesListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
                filesListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);

                sendToLog("Added: " + foundFile.Name);

                fileCounter++;
            }

            // Acknowledge the user the number of files added
            sendToLog("Total file(s) added: " + fileCounter);

            // Check file(s) based on default files types
            checkDefaultFileTypes();
        }

        private void checkDefaultFileTypes()
        {
            int checkCounter = 0; // Count the number of files checked by default ext

            // Get default file types from setting window
            foreach (String extension in settingWindow.getDefFileTypes)
                sendToLog("Adding extension: " + extension);

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
            string destination;

            /* THIS FUNCTION CONTAIN HARD CODE */

            // Find the destination based on the file name postfix
            if (fullName.Contains("01"))
                destination = "ds-01";
            else if (fullName.Contains("02"))
                destination = "ds-02";
            else if (fullName.Contains("03"))
                destination = "ds-03";
            else if (fullName.Contains("04"))
                destination = "ds-04";
            else if (fullName.Contains("05"))
                destination = "ds-05";
            else if (fullName.Contains("06"))
                destination = "ds-06";
            else if (fullName.Contains("07"))
                destination = "ds-07";
            else if (fullName.Contains("08"))
                destination = "ds-08";
            else
                destination = "Unknown";

            return destination;
        }

        private void sendToLog(string log)
        {
            mainParent.sendToLog(log);
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
            //Control parent = Parent;
            //while (!(parent is Main))
            //{
            //    parent = parent.Parent;
            //}

            //Main mainProgram = (Main)parent;

            //mainProgram.expandAndCollapseLog();

            mainParent.expandAndCollapseLog();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Initialization
            initializeFilesListView();
            initializeDefaultValue();
        }
    }
}
