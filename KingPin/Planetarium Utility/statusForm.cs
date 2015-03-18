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

        public void addProgressBar(ListViewItem item)
        {
            // Add the job to the list view
            Thread updateLog = new Thread(updateProgressBar);
            updateLog.Start(item);
        }

        private void updateProgressBar(object obj)
        {
            ListViewItem progressBar = (ListViewItem)obj; // Parsed log sentences

            // Check if invoke required because different thread
            // Most likely required because called from different threads
            if (InvokeRequired)
            {
                // Create delegate (pointer to function) and process data
                // In this case, add progress bar
                this.Invoke(new MethodInvoker(delegate
                {
                    // Insert job to status list view
                    statusListView.Items.Add(progressBar);

                    
                }));
            }
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

                    // Construt a progress bar
                    Rectangle sizeR = default(Rectangle);
                    ProgressBar jobProgressBar = new ProgressBar();

                    // Get size of progress bar
                    sizeR = statusListView.Items[statusListView.Items.Count - 1].Bounds;
                    
                    // Set size of progress bar
                    sizeR.Width = statusListView.Columns[2].Width;
                    sizeR.X = statusListView.Columns[0].Width + statusListView.Columns[1].Width;

                    // Draw progress bar to status list
                    jobProgressBar.Parent = statusListView;
                    jobProgressBar.SetBounds(sizeR.X, sizeR.Y, sizeR.Width, sizeR.Height);
                    jobProgressBar.Visible = true;

                    // Set progress bar properties
                    jobProgressBar.Minimum = 0;
                    jobProgressBar.Maximum = 100;

                    // Set name to progress bar as file name
                    jobProgressBar.Name = string.Format(item.SubItems[0].Text + "ProgressBar");
                }));
            }
        }

        private void InitializeStatusListView()
        {

            // Add Columns
            statusListView.Columns.Add("File name",     150, HorizontalAlignment.Left);
            statusListView.Columns.Add("Computer Name", 100, HorizontalAlignment.Left);
            statusListView.Columns.Add("Progress",      290, HorizontalAlignment.Left);

            // Edit properties for searched items
            statusListView.View = View.Details;
            statusListView.GridLines = true;
            statusListView.Sorting = SortOrder.Ascending;
            
        }

        private void statusListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            // Cancel the action
            e.Cancel = true;
        
            // Set to the original width
            e.NewWidth = statusListView.Columns[e.ColumnIndex].Width;
        }
            
        public ProgressBar findProgressBar(string fileName)
        {
            //foreach (Control c in this.Controls)
            //{
                
            //    //if (c.Name == string.Format(fileName + "ProgressBar"))
            //    //    return c; //found
            //}


            return (ProgressBar)this.Controls.Find(string.Format(fileName + "ProgressBar"), true).FirstOrDefault();
        }
        
        
    }
}
