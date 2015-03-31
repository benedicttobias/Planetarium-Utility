using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Planetarium_Utility
{
    public partial class Main : Form
    {
        /******************************************************************/
        /*       Authentication Token Function                            */
        /******************************************************************/
        // Note: This feature should make user modify files from third computer.
        //       however, since third computer is not in the same domain, it
        //       does not work properly.
        //[DllImport("advapi32.dll", SetLastError = true)]
        //public static extern bool LogonUser(
        //        string lpszUsername,
        //        string lpszDomain,
        //        string lpszPassword,
        //        int dwLogonType,
        //        int dwLogonProvider,
        //        out IntPtr phToken);

        //[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        //public extern static bool CloseHandle(IntPtr handle);

        //[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //public extern static bool DuplicateToken(
        //        IntPtr ExistingTokenHandle,
        //        int SECURITY_IMPERSONATION_LEVEL, 
        //        ref IntPtr DuplicateTokenHandle);

        /******************************************************************/
        /*       Housekeeping section                                     */
        /******************************************************************/
        public FullDomeDist fullDomeDist;
        public statusForm statusForm;

        /******************************************************************/
        /*       Main Function                                            */
        /******************************************************************/
        public Main()
        {
            // Initial setup of Planetarium Utility
            InitializeComponent();
            initializeLogList();
            initializeProgramSize();
            initializeProgressBar();

            // Initialize other forms
            statusForm = new statusForm();

            // Set tabPage's parent
            this.fullDomeDist1.ParentForm = this;
            this.fileDistributor1.ParentForm = this;
            this.fileDeleter1.ParentForm = this;
        }

        public void initializeProgressBar()
        {
            copyProgressBar.Minimum = 0;
            copyProgressBar.Maximum = 0;
            copyProgressBar.Value = 0;
            copyProgressBar.Step = 1;
        }

        // See note above about this feature
        //private void impersonateUser(string userName, string domain, string password)
        //{
        //    //bool status = false; // Status of windows authentication
        //    //string result = null; // Result of windows authentication
        //    int errorCode = 0; // Error code from windows

        //    // Token definition
        //    IntPtr tokenHandle = new IntPtr(0);
        //    IntPtr duplicateToken = new IntPtr(0);
        //    tokenHandle = IntPtr.Zero;
        //    duplicateToken = IntPtr.Zero;

        //    // Set domain to local if no domain passed
        //    //if (domain.Length == 0)
        //    //    domain = Environment.MachineName;

        //    // Authenticate program to remote computer
        //    try
        //    {
        //        // Set token value
        //        const int LOGON32_PROVIDER_DEFAULT = 0;
        //        const int LOGON32_LOGON_INTERACTIVE = 2;

        //        // Get token
        //        bool impersonateResult = LogonUser(userName, domain, password, LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, out tokenHandle);

        //        // Check if impersonate fails
        //        if (impersonateResult == false)
        //        {
        //            // Get error code
        //            errorCode = Marshal.GetLastWin32Error();

        //            // Close connection
        //            CloseHandle(tokenHandle);
        //            sendToLog("LogonUser failed with error code: " + errorCode);
        //        }
        //        else
        //            sendToLog("Logon user succeed.");
               

        //        // Get identity before impersonation
        //        sendToLog("Before impersonation: " + WindowsIdentity.GetCurrent().Name);

        //        // Impersonate a computer
        //        WindowsIdentity remoteId = new WindowsIdentity(tokenHandle);
        //        WindowsImpersonationContext impersonatedId = remoteId.Impersonate();

        //        // Check current identity
        //        sendToLog("After impersonation: " + WindowsIdentity.GetCurrent().Name);

        //        // Stop impersonating remote
        //        impersonatedId.Undo();

        //        // Check current identity
        //        sendToLog("After undo: " + WindowsIdentity.GetCurrent().Name);

        //        // Release the token
        //        if (tokenHandle != IntPtr.Zero)
        //            CloseHandle(tokenHandle);   
        //    }
        //    catch (Exception ex)
        //    {
        //        sendToLog("Error catched! " + ex.Message);
        //    }

        //}

        public void initializeProgramSize()
        {
            // Initialize Form size
            this.Height = 358;
            this.Width = 512;
        }

        private void initializeLogList()
        {
            // Clear the items
            logListView.Clear();

            // Initialize list header
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Log";
            this.logListView.Columns.AddRange(new ColumnHeader[] { columnHeader1 });

            // Edit properties for searched items
            logListView.View = View.Details;
            logListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            logListView.LabelEdit = true;
            logListView.CheckBoxes = false;
            logListView.GridLines = true;
            logListView.Sorting = SortOrder.None;
        }

        private void optionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            settingWindow settingWindow = new settingWindow();

            settingWindow.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Force the program if there is a message loop otherwise exit appropriately
            if (Application.MessageLoop)
                Application.Exit();
            else
                Environment.Exit(1);
        }

        public void expandAndCollapseLog()
        {
            int formHeightCollapsed = 358;
            int formHeightExpanded = 475;
            int tabControlHeightCollapsed = 272;
            int tabControlHeightExpanded = 393;

            // Expand the form and tab control, otherwise collaps them
            if (this.Height == formHeightCollapsed)
            {
                // Loop until form height is big enough to show Log list view
                while (this.Height != formHeightExpanded)
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
                    this.Height -= 1;

                mainTabControl.Height = tabControlHeightCollapsed;

            }
        }

        public void sendToLog(string log)
        {
            // Create a new instance of log
            ListViewItem newLog = new ListViewItem(log);

            // Add the log to the list view
            Thread updateLog = new Thread(updateLogListView);
            updateLog.Start(log);           
        }

        private void updateLogListView(object obj)
        {
            string newLog = (string) obj; // Parsed log sentences

            // Check if invoke required because different thread
            // Most likely required because called from different threads
            if (InvokeRequired)
            {
                // Create delegate (pointer to function) and process data
                // In this case, update log list items
                this.Invoke(new MethodInvoker(delegate
                {
                    // Insert log to LogListView
                    logListView.Items.Add(newLog);

                    // Update the status update
                    statusUpdateStatusLabel.Text = newLog;
                }));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show the status form or create one if its not exist
            if (statusForm == null || statusForm.IsDisposed == true)
                statusForm = new statusForm();

            statusForm.Show();
        }

        public void addCopyProgressMax()
        {
            // Update progress bar correspond to the file name
            if (InvokeRequired)
            {
                // Create delegate (pointer to function) and process data
                // In this case, add max value for progress bar
                this.Invoke(new MethodInvoker(delegate
                {
                    // Add progress bar value
                    copyProgressBar.Maximum += 100;

                }));
            }

        }
        public void progressBarCompleted()
        {
            // Update progress bar correspond to the file name
            if (InvokeRequired)
            {
                // Create delegate (pointer to function) and process data
                this.Invoke(new MethodInvoker(delegate
                {
                    // Perform step of progress bar
                    copyProgressBar.Value += 100;
                }));
            }
            
        }

        public void deleterProgressBarMax(int max)
        {
            // Update progress bar correspond to the file name
            if (InvokeRequired)
            {
                // Create delegate (pointer to function) and process data
                this.Invoke(new MethodInvoker(delegate
                {
                    // Set max value of progress bar
                    copyProgressBar.Minimum = 0;
                    copyProgressBar.Maximum = max;
                }));
            }
        }

        public void deleterProgressBarStep(int value)
        {
            // Update progress bar correspond to the file name
            if (InvokeRequired)
            {
                // Create delegate (pointer to function) and process data
                this.Invoke(new MethodInvoker(delegate
                {
                    // Set value of progress bar
                    copyProgressBar.Value = value;
                }));
            }
        }


    }
}
