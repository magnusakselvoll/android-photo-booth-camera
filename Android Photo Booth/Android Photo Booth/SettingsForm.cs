using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Android_Photo_Booth.Properties;
using SharpDX.DirectInput;

namespace Android_Photo_Booth
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            _settingsBindingSource.DataSource = Settings.Default;
            _cameraTypeBindingSource.DataSource = CameraType.All;
            _joystickComboBox.DataSource = JoystickInfo.All;
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Invalid settings - please review", "Invalid settings", MessageBoxButtons.OK);
                return;
            }

            Settings.Default.Save();
            Close();
        }

        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
            Settings.Default.Reload();
            Close();
        }

        private void OnSettingsFormLoad(object sender, EventArgs e)
        {
        }

        private void OnAdbBrowseButtonClicked(object sender, EventArgs e)
        {
            _folderBrowserDialog.SelectedPath = adbPathTextBox.Text;
            var result = _folderBrowserDialog.ShowDialog(this);
            if (result == DialogResult.OK) adbPathTextBox.Text = _folderBrowserDialog.SelectedPath;
        }

        private void OnResetButtonClicked(object sender, EventArgs e)
        {
            Settings.Default.Reset();
        }

        private void OnWorkingBrowseButtonClicked(object sender, EventArgs e)
        {
            _folderBrowserDialog.SelectedPath = workingFolderTextBox.Text;
            var result = _folderBrowserDialog.ShowDialog(this);
            if (result == DialogResult.OK) workingFolderTextBox.Text = _folderBrowserDialog.SelectedPath;
        }

        private void OnPublishBrowseButtonClicked(object sender, EventArgs e)
        {
            _folderBrowserDialog.SelectedPath = publishFolderTextBox.Text;
            var result = _folderBrowserDialog.ShowDialog(this);
            if (result == DialogResult.OK) publishFolderTextBox.Text = _folderBrowserDialog.SelectedPath;
        }

        private async void OnDetectJoystickButtonClickedAsync(object sender, EventArgs e)
        {
            var joystickInfo = _joystickComboBox.SelectedItem as JoystickInfo;

            if (joystickInfo == null)
            {
                MessageBox.Show("Please select a joystick and try again", "No joystick selected", MessageBoxButtons.OK);
                return;
            }

            _detectJoystickButton.Enabled = false;
            try
            {
                using (var observer = new JoystickObserver(joystickInfo))
                {
                    observer.Start();
                    await Task.Delay(100);
                    JoystickOffset? offset = null;

                    var cancellationTokenSource = new CancellationTokenSource();

                    observer.OnJoystickUpdate += (o, update) =>
                    {
                        offset = update.Offset;
                        cancellationTokenSource.Cancel();
                    };

                    try
                    {
                        await Task.Delay(5000, cancellationTokenSource.Token);
                    }
                    catch (OperationCanceledException)
                    {
                    }

                    if (offset.HasValue)
                    {
                        _joystickButtonTextbox.Text = offset.Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Press the detect button again and press the desired joystick button", "No button deteced",  MessageBoxButtons.OK);
                    }
                }
            }
            finally
            {
                _detectJoystickButton.Enabled = true;
            }
        }
    }
}