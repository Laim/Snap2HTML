using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Snap2HTMLNG.Forms;
using Snap2HTMLNG.Shared.Settings;
using Snap2HTMLNG.Shared.Updater;

namespace Snap2HTMLNG
{
    public partial class frmMain : Form
    {
        private bool initDone = false;
        private bool runningAutomated = false;
        private readonly UserSettings userSettings = new UserSettings();


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            Updater updater = new Updater();
            if(updater.CheckForUpdate(Application.ProductVersion))
            {
                frmUpdateNotice frm = new frmUpdateNotice();
                frm.ShowDialog();
            }

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
                // If the root path isn't valid, just set it to the current directory
                // instead of making it null
                SetRootPath(Directory.GetCurrentDirectory());
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
            txtRoot.Text = userSettings.GetString("RootDirectory");
            txtTitle.Text = userSettings.GetString("Title");
            chkHidden.Checked = userSettings.GetBool("SkipHiddenItems");
            chkSystem.Checked = userSettings.GetBool("SkipSystemItems");
            chkOpenOutput.Checked = userSettings.GetBool("OpenInBrowserAfterCapture");
            chkLinkFiles.Checked = userSettings.GetBool("LinkFiles");
            txtLinkRoot.Text = userSettings.GetString("LinkRoot");
            txtSearchPattern.Text = userSettings.GetString("SearchPattern");
            cbCheckForUpdates.Checked = userSettings.GetBool("CheckForUpdates");
            cbDirectoriesOnly.Checked = userSettings.GetBool("DirectoriesOnly");
            dateTimePickerFileDate.Value = userSettings.GetDateTime("FileDate");
            
            if (userSettings.GetDateTime("FileDate") > dateTimePickerFileDate.MinDate)
            {
                chkFileDateEnable.Checked = true;
            }
        }

        /// <summary>
        /// If the user closes the GUI, ensure that we kill the background worker
        /// </summary>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker.IsBusy) e.Cancel = true;
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            fbdScanDirectory.RootFolder = Environment.SpecialFolder.Desktop;    // this makes it possible to select network paths too
            fbdScanDirectory.SelectedPath = txtRoot.Text;

            if (fbdScanDirectory.ShowDialog() == DialogResult.OK)
            {
                txtRoot.Text = fbdScanDirectory.SelectedPath;
            }
        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            if (SetRootPath(txtRoot.Text))
            {
                // Check if the search pattern starts with an astrix or not
                if (!txtSearchPattern.Text.StartsWith("*"))
                {
                    // We need to have an astrix at the start, so amend the pattern if it doesn't have it
                    txtSearchPattern.Text = $"*{txtSearchPattern.Text}";
                }

                // ask for output file
                string fileName = new DirectoryInfo(txtRoot.Text + @"\").Name;
                char[] invalid = Path.GetInvalidFileNameChars();
                for (int i = 0; i < invalid.Length; i++)
                {
                    fileName = fileName.Replace(invalid[i].ToString(), "");
                }

                // Ask the user where they want to save the file to.
                saveFileDialog1.DefaultExt = "html";
                if (!fileName.ToLower().EndsWith(".html")) fileName += ".html";
                saveFileDialog1.FileName = fileName;
                saveFileDialog1.Filter = "HTML files (*.html)|*.html";
                saveFileDialog1.InitialDirectory = Path.GetDirectoryName(txtRoot.Text);
                saveFileDialog1.CheckPathExists = true;
                if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

                if (!saveFileDialog1.FileName.ToLower().EndsWith(".html")) saveFileDialog1.FileName += ".html";

                // Save our settings
                userSettings.SetString("RootDirectory", txtRoot.Text);
                userSettings.SetString("Title", txtTitle.Text);
                userSettings.SetString("OutputFile", saveFileDialog1.FileName);
                userSettings.SetBool("SkipHiddenItems", chkHidden.Checked);
                userSettings.SetBool("SkipSystemItems", chkSystem.Checked);
                userSettings.SetBool("OpenInBrowserAfterCapture", chkOpenOutput.Checked);
                userSettings.SetBool("LinkFiles", chkLinkFiles.Checked);
                userSettings.SetString("LinkRoot", txtLinkRoot.Text);
                userSettings.SetString("SearchPattern", txtSearchPattern.Text);
                userSettings.SetBool("DirectoriesOnly", cbDirectoriesOnly.Checked);
                userSettings.SetBool("CheckForUpdates", cbCheckForUpdates.Checked);
                userSettings.SetDateTime("FileDate", DateTime.Parse(dateTimePickerFileDate.Text));

                // begin generating html
                StartProcessing();
            }
        }

        private void StartProcessing()
        {
            Cursor.Current = Cursors.WaitCursor;
            Text = "Snap2HTMLNG (Working... Press Escape to Cancel)";
            tabCtrl.Enabled = false;
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = e.UserState.ToString();
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
                    lblStatus.Text = $"Set Root Path to {path}";
                }
                else
                {
                    lblStatus.Text = "Path does not exist or is invalid.";
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
                    lblStatus.Text = "";

                    if (initDone)
                    {
                        txtLinkRoot.Text = txtRoot.Text;

                        if(txtTitle.Text == string.Empty || txtTitle.Text.Length == 0)
                        {
                            txtTitle.Text = "Snapshot of " + txtRoot.Text;
                        }
                    }

                    return true;
                }
                else
                {
                    lblStatus.Text = "Root path is invalid!";

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
                MessageBox.Show("Could not select folder:\n\n" + ex.Message, "Error #4", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void cbCheckForUpdates_CheckedChanged(object sender, EventArgs e)
        {
            if(cbCheckForUpdates.Checked)
            {
                userSettings.SetBool("CheckForUpdates", true);
                return;
            }

            userSettings.SetBool("CheckForUpdates", false);

        }

        private void cbDirectoriesOnly_CheckedChanged(object sender, EventArgs e)
        {
            if(cbDirectoriesOnly.Checked)
            {
                txtSearchPattern.Text = "*DirectoriesOnly";
                txtSearchPattern.Enabled = false;
            } else
            {
                txtSearchPattern.Text = "*";
                txtSearchPattern.Enabled = true;
            }
        }

        private void chkFileDateEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFileDateEnable.Checked == true)
            {
                btnFileDateConfigure.Enabled = true;
                dateTimePickerFileDate.Enabled = true;
            } else
            {
                dateTimePickerFileDate.Enabled = false;
                btnFileDateConfigure.Enabled = false;
                dateTimePickerFileDate.Value = dateTimePickerFileDate.MinDate;
            }
        
        }

        private void btnFileDateConfigure_Click(object sender, EventArgs e)
        {
            frmFileDateConfigure frmFileDateConfigure = new frmFileDateConfigure();
            frmFileDateConfigure.ShowDialog();
        }
    }
}
