using System;
using System.Windows.Forms;
using Android_Photo_Booth.Properties;

namespace Android_Photo_Booth
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            _settingsBindingSource.DataSource = Settings.Default;
            _cameraTypeBindingSource.DataSource = CameraType.All;
        }

        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Invalid settings - please review", "Invalid settings", MessageBoxButtons.OK);
                return;
            }

            Settings.Default.Save();
            Close();
        }

        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            Settings.Default.Reload();
            Close();
        }

        private void OnSettingsFormLoad(object sender, EventArgs e)
        {
        }

        private void OnAdbBrowseButtonClick(object sender, EventArgs e)
        {
            _folderBrowserDialog.SelectedPath = adbPathTextBox.Text;
            DialogResult result = _folderBrowserDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                adbPathTextBox.Text = _folderBrowserDialog.SelectedPath;
            }
        }

        private void OnResetButtonClick(object sender, EventArgs e)
        {
            Settings.Default.Reset();
        }

        private void OnWorkingBrowseButtonClick(object sender, EventArgs e)
        {
            _folderBrowserDialog.SelectedPath = workingFolderTextBox.Text;
            DialogResult result = _folderBrowserDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                workingFolderTextBox.Text = _folderBrowserDialog.SelectedPath;
            }
        }

        private void OnPublishBrowseButtonClick(object sender, EventArgs e)
        {
            _folderBrowserDialog.SelectedPath = publishFolderTextBox.Text;
            DialogResult result = _folderBrowserDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                publishFolderTextBox.Text = _folderBrowserDialog.SelectedPath;
            }
        }
    }
}
