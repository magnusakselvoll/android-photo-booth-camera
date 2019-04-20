using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Android_Photo_Booth.Properties;

namespace Android_Photo_Booth
{
    public partial class MainForm : Form
    {
        private bool _focusLoopRunning;
        private bool _downloadLoopRunning;
        private bool _downloading;

        public MainForm()
        {
            InitializeComponent();
        }

        private AdbController GetController()
        {
            return new AdbController(Settings.Default.AdbPath);
        }


        private async void OnDetectDeviceButtonClickAsync(object sender, EventArgs e)
        {
            AdbController controller = GetController();

            (bool connected, AndroidDevice device, string errorMessage) = await controller.TryConnectToDeviceAsync();

            _deviceTextBox.Text = connected ? device.ToString() : errorMessage;
        }

        private void ShowBadAdbPathDialog()
        {
            MessageBox.Show("The file adb.exe cannot be found at the given path. Please select the correct folder and try again.", "Incorrect adb path",
                MessageBoxButtons.OK);
        }


        private async void OnOpenCameraButtonClickAsync(object sender, EventArgs e)
        {
            AdbController controller = GetController();

            if (!await controller.IsInteractiveAsync())
            {
                await controller.EnableInteractiveAsync();
            }

            if (!await controller.IsInteractiveAsync())
            {
                MessageBox.Show("Unable to activate device screen", "Device not interactive", MessageBoxButtons.OK);
                return;
            }

            await Task.Delay(100);

            if (await controller.IsLockedAsync())
            {
                await controller.UnlockAsync(Settings.Default.PinCode);
            }

            if (await controller.IsLockedAsync())
            {
                MessageBox.Show("Unable to unlock device. Is the pin code correct?", "Device locked", MessageBoxButtons.OK);
                return;
            }

            await controller.OpenCameraAsync();
        }

        private void OnFocusButtonClick(object sender, EventArgs e)
        {
            if (_focusLoopRunning)
            {
                _focusTimer.Stop();
                _focusProgressBar.Value = _focusProgressBar.Minimum;
                return;
            }

            if (Settings.Default.FocusKeepaliveInterval < TimeSpan.FromSeconds(1))
            {
                MessageBox.Show("At least one second focus keepalive interval must be set", "Too short interval",
                    MessageBoxButtons.OK);
            }

            double totalInterval = Settings.Default.FocusKeepaliveInterval.TotalMilliseconds;
            int intervalStep = (int) Math.Round(totalInterval / ((double) (_focusProgressBar.Maximum - _focusProgressBar.Minimum) / _focusProgressBar.Step));

            _focusTimer.Interval = intervalStep;
            _focusTimer.Start();

            _focusLoopRunning = true;
        }

        private void OnSettingsButtonClick(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog(this);
        }

        private async void OnFocusTimerTickAsync(object sender, EventArgs e)
        {
            if (_focusProgressBar.Value >= _focusProgressBar.Maximum)
            {
                AdbController controller = GetController();
                await controller.FocusCameraAsync();

                _focusProgressBar.Value = _focusProgressBar.Minimum;

                return;
            }

            _focusProgressBar.PerformStep();
        }

        private void OnDownloadButtonClick(object sender, EventArgs e)
        {
            if (_downloadLoopRunning)
            {
                _downloadTimer.Stop();
                _downloadProgressBar.Value = _downloadProgressBar.Minimum;
                return;
            }

            if (Settings.Default.DownloadImagesInterval < TimeSpan.FromSeconds(1))
            {
                MessageBox.Show("At least one second focus keepalive interval must be set", "Too short interval",
                    MessageBoxButtons.OK);
            }

            double totalInterval = Settings.Default.DownloadImagesInterval.TotalMilliseconds;
            int intervalStep = (int)Math.Round(totalInterval / ((double)(_downloadProgressBar.Maximum - _downloadProgressBar.Minimum) / _downloadProgressBar.Step));

            _downloadTimer.Interval = intervalStep;
            _downloadTimer.Start();

            _downloadLoopRunning = true;
        }

        private async void OnDownloadTimerTickAsync(object sender, EventArgs e)
        {
            if (_downloadProgressBar.Value >= _downloadProgressBar.Maximum)
            {
                if (!_downloading)
                {
                    _downloading = true;
                    AdbController controller = GetController();
                    await controller.DownloadFilesAsync();
                    _downloading = false;
                }

                _downloadProgressBar.Value = _downloadProgressBar.Minimum;

                return;
            }

            _downloadProgressBar.PerformStep();
        }
    }
}
