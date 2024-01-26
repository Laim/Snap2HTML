using Snap2HTMLNG.Shared.Settings;
using System;
using System.Windows.Forms;

namespace Snap2HTMLNG.Forms
{
    public partial class frmFileDateConfigure : Form
    {
        private readonly UserSettings userSettings = new UserSettings();
        public frmFileDateConfigure()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            cbOperator.SelectedIndex = userSettings.GetInt("FileDate_Operator");
            cbBasis.SelectedIndex = userSettings.GetInt("FileDate_Basis");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(cbBasis.SelectedIndex == -1 || cbOperator.SelectedIndex == -1)
            {
                MessageBox.Show("Please configure your Basis and Operator", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            userSettings.SetInt("FileDate_Operator", cbOperator.SelectedIndex);
            userSettings.SetInt("FileDate_Basis", cbBasis.SelectedIndex);

            Close();
        }
    }
}
