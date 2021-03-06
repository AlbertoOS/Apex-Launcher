﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apex_Launcher {
    public partial class SettingsForm : Form {
        public SettingsForm() {
            InitializeComponent();

            PathTextbox.Text = Program.GetInstallPath();
            KeepOpenCheckbox.Checked = Convert.ToBoolean(Program.GetParameter("keepLauncherOpen"));
            ForceUpdateCheckbox.Checked = Program.forceUpdate;
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e) {
            bool validated = true;
            if (!Program.HasWriteAccess(PathTextbox.Text)) {
                MessageBox.Show("You don't have permission to write to that folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validated = false;
            }

            if (validated) {
                Program.SetParameter("installpath", PathTextbox.Text);
                Program.SetParameter("keepLauncherOpen", KeepOpenCheckbox.Checked.ToString());
                //Program.SetParameter("disableGameFonts", DisableFontBox.Checked.ToString());
                Program.forceUpdate = ForceUpdateCheckbox.Checked;
                Close();
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Choose a Folder";
            fbd.ShowDialog();

            string selectedPath = fbd.SelectedPath;
            if (Program.HasWriteAccess(selectedPath)) {
                PathTextbox.Text = selectedPath;
            } else {
                MessageBox.Show("You don't have permission to write to that folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
