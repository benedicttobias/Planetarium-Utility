using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planetarium_Utility
{
    public partial class statusForm : Form
    {
        // Receive argument to add item to status list
        public static ListViewItem iteman;

        public statusForm()
        {
            InitializeComponent();
            InitializeStatusListView();
        }

        public void addJob(ListViewItem item)
        {
            // Add the job to the list view
            Thread updateLog = new Thread(updateStatusListView);
            updateLog.Start(item);
        }

        private void updateStatusListView(object obj)
        {
            ListViewItem item = (ListViewItem)obj; // Parsed log sentences

            // Check if invoke required because different thread
            // Most likely required because called from different threads
            if (InvokeRequired)
            {
                // Create delegate (pointer to function) and process data
                // In this case, update status of jobs
                this.Invoke(new MethodInvoker(delegate
                {
                    // Insert job to status list view
                    statusListView.Items.Add(item);
                }));
            }
        }

        private void InitializeStatusListView()
        {

            // Add Columns
            statusListView.Columns.Add("File name", 100, HorizontalAlignment.Left);
            statusListView.Columns.Add("Computer Name", 100, HorizontalAlignment.Left);
            statusListView.Columns.Add("Progress", 160, HorizontalAlignment.Left);

            // Edit properties for searched items
            statusListView.View = View.Details;
            statusListView.GridLines = true;
            statusListView.Sorting = SortOrder.Ascending;
        }
    }
}
