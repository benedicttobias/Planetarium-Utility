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
            this.Height = 328;
            this.Width  = 504;
            
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            int heightCollapsed = 328;
            int heightExpanded  = 456;

            // Show log list view
            if (this.Height == heightCollapsed)
            {
                // Loop until height is big enough to show Log list view
                while (this.Height != heightExpanded)                
                {
                    this.Height += 1;

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
                while (this.Height != heightCollapsed)
                {
                    this.Height -= 1;

                    Application.DoEvents();
                }
            }
        }

        private void optionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Show the options menu
            options.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if any error loop
            if (Application.MessageLoop)
            {
                // Force exit
                Application.Exit();
            }
            else
            {
                // Exit appropriately
                Environment.Exit(1);
            }
        }
    }
}
