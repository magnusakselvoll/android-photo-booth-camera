using System;
using System.IO;
using System.Windows.Forms;

namespace Android_Photo_Booth
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnBrowseFolderButtonClick(object sender, EventArgs e)
        {
            var result = _adbFolderPicker.ShowDialog();

            if (result == DialogResult.OK)
            {
                _adbFolderTextBox.Text = _adbFolderPicker.SelectedPath;
            }
        }

        private void OnDetectDeviceButtonClick(object sender, EventArgs e)
        {
            if (!TryGetAdbExecutablePath(out string adbExePath))
            {
                ShowBadAdbPathDialog();
                return;
            }

            var controller = new AdbController(_adbFolderTextBox.Text);

            bool connected = controller.TryConnectToDevice(out AndroidDevice device, out string errorMessage);

            if (connected)
            {
                _deviceTextBox.Text = device.ToString();
            }
            else
            {
                _deviceTextBox.Text = errorMessage;
            }
        }

        private void ShowBadAdbPathDialog()
        {
            MessageBox.Show("The file adb.exe cannot be found at the given path. Please select the correct folder and try again.", "Incorrect adb path",
                MessageBoxButtons.OK);
        }

        private bool TryGetAdbExecutablePath(out string adbExePath)
        {
            adbExePath = Path.Combine(_adbFolderTextBox.Text, "adb.exe");

            if (File.Exists(adbExePath)) return true;
            adbExePath = null;
            return false;
        }

        private void OnPhotoButtonClick(object sender, EventArgs e)
        {
            var controller = new AdbController(_adbFolderTextBox.Text);

            if (!controller.IsInteractive())
            {
                controller.EnableInteractive();
            }

            if (!controller.IsInteractive())
            {
                MessageBox.Show("Unable to activate device screen", "Device not interactive", MessageBoxButtons.OK);
                return;
            }

            if (controller.IsLocked())
            {
                controller.Unlock(_pinTextBox.Text);
            }

            if (controller.IsLocked())
            {
                MessageBox.Show("Unable to unlock device. Is the pin code correct?", "Device locked", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
