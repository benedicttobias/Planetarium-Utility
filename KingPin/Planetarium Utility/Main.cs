﻿using System;
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
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void destinationLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {

        }
    }
}
