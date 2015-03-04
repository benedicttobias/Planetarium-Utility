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
        OptionsMenu options;

        public Main()
        {
            // Initial setup of Planetarium Utility
            InitializeComponent();

            // Initialize option user control
            options = new OptionsMenu();

            // Initialize Form size
            this.Height = 360;
            this.Width  = 512;
            
        }

        private void optionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Show the options menu
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
            int heightCollapsed = 360;
            int heightExpanded = 486;

            // Show log list view
            if (this.Height == heightCollapsed)
            {
                // Loop until height is big enough to show Log list view
                while (this.Height < heightExpanded )
                {
                    this.Height           += 1;
                    mainTabControl.Height += 1;
                    Application.DoEvents();
                }

                // Show log list view
                logListView.Visible = true;
            }
            else
            {
                // Hide log list view
                logListView.Visible = false;

                // Loop until height is small enough to hide Log list view
                while (this.Height > heightCollapsed)
                {
                    this.Height           -= 1;
                    mainTabControl.Height -= 1;
                    Application.DoEvents();
                }
            }
        }
    }
}
