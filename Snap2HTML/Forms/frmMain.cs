﻿using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using CommandLine.Utility;
using Snap2HTMLNG.Shared.Settings;
using Snap2HTMLNG.Shared.Utils;

namespace Snap2HTMLNG
{
    public partial class frmMain : Form
    {
        private bool initDone = false;
        private bool runningAutomated = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            LoadUserSettings();

            Text = Application.ProductName + " (Press F1 for Help)";
            labelAboutVersion.Text = "version " + Application.ProductVersion.Split('.')[0] + "." + Application.ProductVersion.Split('.')[1];

#if DEBUG
            Text = $"{Text} - Preview Build";
#endif

            if (Directory.Exists(txtRoot.Text))
            {
                SetRootPath(txtRoot.Text);
            }
            else
            {
                SetRootPath("");
            }

            txtLinkRoot.Enabled = chkLinkFiles.Checked;

            // setup drag & drop handlers
            tabSnapshot.DragDrop += DragDropHandler;
            tabSnapshot.DragEnter += DragEnterHandler;
            tabSnapshot.AllowDrop = true;

            foreach (Control cnt in tabSnapshot.Controls)
            {
                cnt.DragDrop += DragDropHandler;
                cnt.DragEnter += DragEnterHandler;
                cnt.AllowDrop = true;
            }

            initDone = true;
        }

        /// <summary>
        /// Checks if the usser has used the application before and if so, populate the controls with the User Settings.
        /// </summary>
        private void LoadUserSettings()
        {
            txtRoot.Text = XmlConfigurator.Read("RootFolder");
            txtTitle.Text = XmlConfigurator.Read("Title");
            chkHidden.Checked = bool.Parse(XmlConfigurator.Read("SkipHiddenItems"));
            chkSystem.Checked = bool.Parse(XmlConfigurator.Read("SkipSystemItems"));
            chkOpenOutput.Checked = bool.Parse(XmlConfigurator.Read("OpenInBrowserAfterCapture"));
            chkLinkFiles.Checked = bool.Parse(XmlConfigurator.Read("LinkFiles"));
            txtSearchPattern.Text = XmlConfigurator.Read("SearchPattern");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker.IsBusy) e.Cancel = true;
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;    // this makes it possible to select network paths too
            folderBrowserDialog1.SelectedPath = txtRoot.Text;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRoot.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            if (SetRootPath(txtRoot.Text))
            {

                // Check if the search pattern starts with an astrix or not
                if (!txtSearchPattern.Text.StartsWith("*"))
                {
                    string tmp = txtSearchPattern.Text;
                    txtSearchPattern.Text = $"*{txtSearchPattern.Text}";
                }

                // ask for output file
                string fileName = new DirectoryInfo(txtRoot.Text + @"\").Name;
                char[] invalid = Path.GetInvalidFileNameChars();
                for (int i = 0; i < invalid.Length; i++)
                {
                    fileName = fileName.Replace(invalid[i].ToString(), "");
                }

                saveFileDialog1.DefaultExt = "html";
                if (!fileName.ToLower().EndsWith(".html")) fileName += ".html";
                saveFileDialog1.FileName = fileName;
                saveFileDialog1.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";
                saveFileDialog1.InitialDirectory = Path.GetDirectoryName(txtRoot.Text);
                saveFileDialog1.CheckPathExists = true;
                if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

                if (!saveFileDialog1.FileName.ToLower().EndsWith(".html")) saveFileDialog1.FileName += ".html";

                // Declare the user settings nodes that are available in UserSettings.xml (see Shared.UserSettings.xml)
                string[] nodes = { 
                    "RootFolder", 
                    "Title", 
                    "OutputFile", 
                    "SkipHiddenItems", 
                    "SkipSystemItems", 
                    "OpenInBrowserAfterCapture", 
                    "LinkFiles", 
                    "LinkRoot", 
                    "SearchPattern"
                };

                // Declare our actual values to be saved to the nodes
                string[] values =
                {
                    txtRoot.Text,
                    txtTitle.Text,
                    saveFileDialog1.FileName,
                    chkHidden.Checked.ToString(),
                    chkSystem.Checked.ToString(),
                    chkOpenOutput.Checked.ToString(),
                    chkLinkFiles.Checked.ToString(),
                    txtLinkRoot.Text,
                    txtSearchPattern.Text
                };

                // Write the settings to the SettingsFile // TODO: Do I need to move this so we can run from schedule multiple different times?  I think so. 
                XmlConfigurator.Write(nodes, values);

                // begin generating html
                StartProcessing();
            }
        }

        private void StartProcessing()
        {
            // ensure source path format
            var rootFolder = Path.GetFullPath(XmlConfigurator.Read("RootFolder"));

            if (rootFolder.EndsWith(@"\")) rootFolder = rootFolder.Substring(0, rootFolder.Length - 1);
            if (Helpers.IsWildcardMatch("?:", rootFolder, false)) rootFolder += @"\"; // add backslash to path if only letter and colon eg "c:"

            // add slash or backslash to end of link (in cases where it is clear that we we can)


            bool linkFiles = bool.Parse(XmlConfigurator.Read("LinkFiles"));
            string linkRoot = XmlConfigurator.Read("LinkRoot");
            if (linkFiles)
            {
                if (!linkRoot.EndsWith(@"/"))
                {
                    if (linkRoot.ToLower().StartsWith(@"http") || linkRoot.ToLower().StartsWith(@"https"))    // web site
                    {
                        linkRoot += @"/";
                    }
                    if (Helpers.IsWildcardMatch("?:*", linkRoot, false)) // local disk
                    {
                        linkRoot += @"\";
                    }
                    if (linkRoot.StartsWith(@"\\"))    // unc path
                    {
                        linkRoot += @"\";
                    }
                }
            }

            Cursor.Current = Cursors.WaitCursor;
            Text = "Snap2HTMLNG (Working... Press Escape to Cancel)";
            tabCtrl.Enabled = false;
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripStatusLabel1.Text = e.UserState.ToString();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Cursor.Current = Cursors.Default;
            tabCtrl.Enabled = true;
            this.Text = "Snap2HTMLNG";

#if DEBUG
            Text = $"{Text} - Preview Build";
#endif

            // Quit when finished if automated via command line
            if (this.runningAutomated)
            {
                Application.Exit();
            }
        }

        private void chkLinkFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLinkFiles.Checked == true)
                txtLinkRoot.Enabled = true;
            else
                txtLinkRoot.Enabled = false;
        }

        // Link Label handlers
        #region Link Label Handlers
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://www.rlvision.com");
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://rlvision.com/exif/about.php");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://www.rlvision.com/flashren/about.php");
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", Path.GetDirectoryName(Application.ExecutablePath) + "\\template.html");
        }
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://www.rlvision.com/contact.php");
        }

        private void linkLabelLaim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/laim/Snap2HTML-NG");
        }

        private void linkLabelDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=U3E4HE8HMY9Q4&item_name=Snap2HTML&currency_code=USD&source=url");
        }
        #endregion

        // Drag & Drop handlers
        #region Drag & Drop
        private void DragEnterHandler(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void DragDropHandler(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

                if (Directory.Exists(path))
                {
                    txtRoot.Text = path;
                    toolStripStatusLabel1.Text = $"Set Root Path to {path}";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Path does not exist or is invalid.";
                }
            }
        }
        #endregion

        // Escape to cancel
        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    backgroundWorker.CancelAsync();
                }
            }
            else
            {
                if (e.KeyCode == Keys.F1)
                {
                    System.Diagnostics.Process.Start("https://github.com/Laim/Snap2HTML-NG/blob/master/HELP.md");
                }
            }
        }

        /// <summary>
        /// Does some general UI related things and checks if the Path selected exists
        /// </summary>
        /// <param name="path">The path you want to scan</param>
        /// <returns></returns>
        private bool SetRootPath(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    toolStripStatusLabel1.Text = "";

                    if (initDone)
                    {
                        txtLinkRoot.Text = txtRoot.Text;
                        txtTitle.Text = "Snapshot of " + txtRoot.Text;
                    }

                    return true;
                }
                else
                {
                    toolStripStatusLabel1.Text = "Root path is invalid!";

                    if (initDone)
                    {
                        txtLinkRoot.Text = txtRoot.Text;
                        txtTitle.Text = "";
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not select folder:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
}
