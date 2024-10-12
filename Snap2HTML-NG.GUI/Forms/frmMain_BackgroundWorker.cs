using System.ComponentModel;
using System.Windows.Forms;
using Snap2HTMLNG.Shared.Builder;
using Snap2HTMLNG.Shared.Models;
using Snap2HTMLNG.Shared.Settings;

namespace Snap2HTMLNG
{
    public partial class frmMain : Form
    {
        // This runs on a separate thread from the GUI
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            UserSettings us = new UserSettings();

            // Load the user settings from the configuration file as we're using the GUI here
            UserSettingsModel usm = new UserSettingsModel
            {
                RootDirectory = us.GetString("RootDirectory"),
                Title = us.GetString("Title"),
                OutputFile = us.GetString("OutputFile"),
                SkipHiddenItems = us.GetBool("SkipHiddenItems"),
                SkipSystemItems = us.GetBool("SkipSystemItems"),
                OpenInBrowserAfterCapture = us.GetBool("OpenInBrowserAfterCapture"),
                LinkFiles = us.GetBool("LinkFiles"),
                LinkRoot = us.GetString("LinkRoot"),
                SearchPattern = us.GetString("SearchPattern"),
                FileDate = us.GetDateTime("FileDate"),
                FileDateBasis = (FileDateBasis)us.GetInt("FileDate_Basis"),
                FileDateOperator = (FileDateOperator)us.GetInt("FileDate_Operator")
            };

            DataBuilder.Build(usm, Application.ProductName, Application.ProductVersion, backgroundWorker);
        }
        
    }
}

