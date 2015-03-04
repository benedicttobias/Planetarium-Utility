using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planetarium_Utility
{
    public partial class Main : Form
    {
        // Housekeeping section  
        settingWindow options;

        public Main()
        {
            // Initial setup of Planetarium Utility
            InitializeComponent();
            initializeFilesListView();

            // Initialize option user control
            options = new settingWindow();

            // Initialize Form size
            this.Height = 360;
            this.Width  = 512;
           
        }

        private void optionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Show the options menu or create one if its not exist
            if (options == null || options.IsDisposed == true)
                options = new settingWindow();

            options.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Force the program if there is a message loop otherwise exit appropriately
            if (Application.MessageLoop)
                Application.Exit();
            else
                Environment.Exit(1);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void logButton_Click_1(object sender, EventArgs e)
        {
            int formHeightCollapsed       = 360;
            int formHeightExpanded        = 475;
            int tabControlHeightCollapsed = 272;
            int tabControlHeightExpanded  = 393;

            // Expand the form and tab control, otherwise collaps them
            if (this.Height == formHeightCollapsed)
            {
                // Loop until form height is big enough to show Log list view
                while (this.Height != formHeightExpanded )
                    this.Height += 1;

                mainTabControl.Height = tabControlHeightExpanded;

                // Show log list view
                logListView.Visible = true;
            }
            else
            {
                // Hide log list view
                logListView.Visible = false;

                // Loop until form height is small enough to hide Log list view
                while (this.Height != formHeightCollapsed)
                    this.Height           -= 1;

                mainTabControl.Height = tabControlHeightCollapsed;

            }
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
                sendToLog("Added: " + foundFile.Name);

                // Resize list every item inserted
                //searchList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                //searchList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                fileCounter++;
            }

            // Acknowledge the user the number of files added
            sendToLog("Total file(s) added: " + fileCounter);
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
            // Create a new instance of log
            ListViewItem newLog = new ListViewItem(log);

            // Add the log to the list view
            logListView.Items.Add(newLog);
                
            // Update the status update
            statusUpdateStatusLabel.Text = log;
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
    }
}
