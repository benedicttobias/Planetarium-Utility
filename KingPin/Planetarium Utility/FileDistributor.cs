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
using System.Threading;

namespace Planetarium_Utility
{
    public partial class FileDistributor : UserControl
    {
        // Connecting Main form and Usercontrol (here)
        public Main ParentForm { get; set; }

        internal class itemAndCheckbox
        {
            internal ListViewItem item { get; set; }
            internal string checkboxText { get; set; }
        }

        public FileDistributor()
        {
            InitializeComponent();

            InitializeCopyList();

            InitializeDefaultSettings();

        }

        private void InitializeDefaultSettings()
        {
            settingWindow settingWindow = new settingWindow();
            int totalComputer;                                  // Number of renderer computers
            string computerPrefix = settingWindow.getRendererName; // Prefix of computer name

            // Get total computer
            Int32.TryParse(settingWindow.getRendererNum, out totalComputer);

            // Populate checkbox for renderer
            checkBoxHolder.ColumnCount = totalComputer + 1; // One for sound
            checkBoxHolder.ColumnStyles.Clear();
            for (int checkbox = 1; checkbox <= totalComputer; checkbox++)
            {
                CheckBox check = new CheckBox();

                check.Text = "0" + checkbox;
                check.Name = computerPrefix + "-0" + checkbox + "CheckBox";
                check.Checked = true;
                check.Parent = checkBoxHolder;
                check.Visible = true;

                checkBoxHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44f));
                checkBoxHolder.Controls.Add(check, checkbox - 1, 0);
            }

            // Construct checkbox for sound computer
            CheckBox soundCheckbox = new CheckBox();
            soundCheckbox.Text = "Sound";
            soundCheckbox.Name = computerPrefix + "-Sound" + "CheckBox";
            soundCheckbox.Checked = false;
            soundCheckbox.Parent = checkBoxHolder;
            soundCheckbox.Visible = true;
            checkBoxHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30f));
            checkBoxHolder.Controls.Add(soundCheckbox, totalComputer, 0);
        }

        private void InitializeCopyList()
        {
            // Empty the copy list
            copyList.Clear();

            // Initialize list header
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "File name";
            this.copyList.Columns.AddRange(new ColumnHeader[] { columnHeader1 });

            // Edit properties for copy items
            copyList.View = View.Details;
            copyList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            copyList.LabelEdit = true;
            copyList.GridLines = true;
            copyList.Sorting = SortOrder.Ascending;
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            // Calling Main form to resize program
            ParentForm.expandAndCollapseLog();
        }

        private void FileDistributor_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                // Create a attribute to check folder or file
                FileAttributes path = File.GetAttributes(file);

                if ((path & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    ParentForm.sendToLog(file + " is not added because it is a folder");
                }
                else
                {
                    // Insert to Search list
                    ListViewItem items = new ListViewItem();
                    items.Text = file;
                    copyList.Items.Add(items);
                    ParentForm.sendToLog("File added: " + items.Text);
                }
            }

            // Remove duplicate
            removeListDuplicate(copyList);

            // Set total to files panel
            filesGroupBox.Text = "Total: " +
                                  copyList.Items.Count.ToString() + 
                                 (copyList.Items.Count > 1 ? " files" : " file"); 
        }

        private void FileDistributor_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void removeListDuplicate(ListView list)
        {
            // Sort ascending
            list.Sort();

            int index = 0;

            while (index < list.Items.Count - 1)
            {
                if (list.Items[index].Text == list.Items[index + 1].Text)
                {
                    // insert the remove log
                    ParentForm.sendToLog("File " + list.Items[index].Text + " is already in copy list");

                    // Remove list
                    list.Items.RemoveAt(index);
                }
                else
                    index++;
            }
        }

        private void destinationButton_Click(object sender, EventArgs e)
        {
            // Select target folder for searching
            FolderBrowserDialog selectFolder = new FolderBrowserDialog();

            // Convert to path text
            DialogResult result = selectFolder.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                mirrorCheckbox.Checked = true;
                //destinationButton.Enabled = false;
                destinationTextBox.Text = "Local destination";
            }

            // Set destination to textbox
            if (result == DialogResult.OK)
                destinationTextBox.Text = selectFolder.SelectedPath;
        }

        private void mirrorCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (mirrorCheckbox.Checked == true)
            {
                destinationTextBox.ReadOnly = true;
                destinationTextBox.Text = "Mirror Mode";
            }
            else
            {
                destinationTextBox.ReadOnly = false;
                destinationTextBox.Text = "Please select destination";
                destinationButton_Click(sender, e);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Clear copy list
            InitializeCopyList();
            ParentForm.sendToLog("Copy list cleared");

            // Set total files
            filesGroupBox.Text = "Total: 0 file";

            // Clean progress bar
            ParentForm.initializeProgressBar();
        }

        private void checkDirectory(string destination)
        {
            // Create a new target folder, if necessary.
            try
            {
                // Create new folder if there is no exist directory
                if (!System.IO.Directory.Exists(destination))
                {
                    ParentForm.sendToLog("Directory does not exist, creating " + destination);
                    System.IO.Directory.CreateDirectory(destination);
                    ParentForm.sendToLog("destination " + destination + " created");
                }
            }
            catch (IOException makeNewFolderError)
            {
                // Error in making new folder
                ParentForm.sendToLog("Could not make new folder in destination. File skipped." + makeNewFolderError.Message);
            }
        }

        private void distributeButton_Click(object sender, EventArgs e)
        {
            if (copyList.Items.Count == 0)
            {
                // Give message
                ParentForm.sendToLog("Nothing to copy");

                // Return to program
                return;
            }

            // Each files
            foreach (ListViewItem item in copyList.Items)
            {
                // Each checkboxes
                foreach (CheckBox checkbox in checkBoxHolder.Controls)
                {
                    if (checkbox.Checked)
                    {
                        // Create new object of item and checkbox
                        itemAndCheckbox itemAndCheckbox = new itemAndCheckbox() 
                            {item = item, checkboxText= checkbox.Text};

                        // Create new backgroundworker
                        BackgroundWorker copyFile = new BackgroundWorker();
                        copyFile.WorkerSupportsCancellation = true;
                        copyFile.WorkerReportsProgress = true;

                        copyFile.DoWork          += copyFile_DoWork;
                        copyFile.RunWorkerCompleted += copyFile_RunWorkerCompleted;

                        copyFile.RunWorkerAsync(itemAndCheckbox);

                        
                    }
                        
                }
            }
        }

        void copyFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Add the log to the list view
            Thread updateLog = new Thread(ParentForm.progressBarCompleted);
            updateLog.Start();      
        }

        void copyFile_DoWork(object sender, DoWorkEventArgs e)
        {
            // Parse my object
            itemAndCheckbox itemAndCheckbox = (itemAndCheckbox)e.Argument;
            ListViewItem item = itemAndCheckbox.item;
            string computerName = itemAndCheckbox.checkboxText;

            // Add progress bar max value by 100
            ParentForm.addCopyProgressMax();

            // Copy action
            copyFile(item, computerName);
        }

        private void copyFile(ListViewItem source, string computerNumber)
        {
            string destination = null;
            string fullDestination;
            settingWindow settingWindow = new settingWindow();

            // Clean the directory
            string cleanSource = source.Text.Replace(":", "");

            // Mirror mode
            if (mirrorCheckbox.Checked)
            {
                // Set the destination
                destination = source.Text;
                destination = destination.Replace(string.Format(":\\Users\\" + System.Environment.UserName),
                                                  string.Format(":\\Users\\" + settingWindow.getUsername));

                // Clean the colon sign
                destination = destination.Replace(":", "");

                // Assign the desntination
                fullDestination = string.Format("\\\\" +
                                                settingWindow.getRendererName + "-" + computerNumber +
                                                "\\" + destination);

                // Check destination folder if its exist
                checkDirectory("\\\\" + settingWindow.getRendererName + "-" + 
                                computerNumber + "\\" + Path.GetDirectoryName(destination));

            }
            else // Custom destination mode
            {
                destination = destinationTextBox.Text;

                // Set the destination
                destination = source.Text;
                destination = destination.Replace(string.Format(":\\Users\\" + System.Environment.UserName),
                                                  string.Format(":\\Users\\" + settingWindow.getUsername));

                // Clean the colon sign
                destination = destination.Replace(":", "");

                // Assign the destination path
                fullDestination = string.Format("\\\\" + computerNumber + "\\" + destination + "\\" + Path.GetFileName(cleanSource));

                checkDirectory("\\\\" + computerNumber + "\\" + destination);
            }

            // Copy from source to destination
            try
            {
                ParentForm.sendToLog("Copying " + source.Text + " to " + fullDestination);
                File.Copy(source.Text, fullDestination, true);
                ParentForm.sendToLog(settingWindow.getRendererName + '-' + 
                                     computerNumber + " Copied: " + source.Text);
            }
            catch (IOException copyError)
            {
                ParentForm.sendToLog("Could not copy {0}. " + copyError.Message + "File skipped.");
            }
        }

    }
}
