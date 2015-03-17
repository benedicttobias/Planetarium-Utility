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

namespace Planetarium_Utility
{
    public partial class Main : Form
    {
        /******************************************************************/
        /*       Authentication Token Function                            */
        /******************************************************************/
        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern bool LogonUser(
                string lpszUsername,
                string lpszDomain,
                string lpszPassword,
                int dwLogonType,
                int dwLogonProvider,
                out IntPtr phToken);

        [DllImport("kernel32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private unsafe static extern int FormatMessage(
                int dwFlags, 
                ref IntPtr lpSource,
                int dwMessageId, 
                int dwLanguageId, 
                ref String lpBuffer, 
                int nSize, 
                IntPtr* Arguments);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public extern static bool CloseHandle(IntPtr handle);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public extern static bool DuplicateToken(
                IntPtr ExistingTokenHandle,
                int SECURITY_IMPERSONATION_LEVEL, 
                ref IntPtr DuplicateTokenHandle);

        /******************************************************************/
        /*       Housekeeping section                                     */
        /******************************************************************/
        public settingWindow settingWindow;
        public FullDomeDist fullDomeDist;


        /******************************************************************/
        /*       Main Function                                            */
        /******************************************************************/
        public Main()
        {
            // Initial setup of Planetarium Utility
            InitializeComponent();
            initializeLogList();
            initializeProgramSize();

            // Initialize option user control
            settingWindow = new settingWindow();
            this.fullDomeDist1.ParentForm = this;

            // Impersonate remote computers
            //impersonateUser("skyvision", "ds-02", "sky");

        }

        private void impersonateUser(string userName, string domain, string password)
        {
            bool status = false; // Status of windows authentication
            string result = null; // Result of windows authentication
            int errorCode = 0; // Error code from windows

            // Token definition
            IntPtr existingToken = new IntPtr(0);
            IntPtr duplicateToken = new IntPtr(0);
            existingToken = IntPtr.Zero;
            duplicateToken = IntPtr.Zero;

            // Set domain to local if no domain passed
            if (domain.Length == 0)
                domain = Environment.MachineName;

            // Authenticate program to remote computer
            try
            {
                // Set token value
                const int LOGON32_PROVIDER_DEFAULT = 0;
                const int LOGON32_LOGON_INTERACTIVE = 2;

                // Get token
                bool impersonateResult = LogonUser(userName, domain, password, LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, out existingToken);

                // Check if impersonate fails
                if (impersonateResult == false)
                {
                    errorCode = Marshal.GetLastWin32Error();
                }

                
            }
            catch
            {

            }

        }

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
            // Show the options menu or create one if its not exist
            if (settingWindow == null || settingWindow.IsDisposed == true)
                settingWindow = new settingWindow();

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
            logListView.Items.Add(newLog);
                
            // Update the status update
            statusUpdateStatusLabel.Text = log;
        }

    }
}
