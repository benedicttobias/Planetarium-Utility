using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
