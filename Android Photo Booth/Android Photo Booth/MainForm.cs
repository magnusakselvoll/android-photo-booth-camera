using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Android_Photo_Booth.Logging;
using Android_Photo_Booth.Properties;

namespace Android_Photo_Booth
{
    public partial class MainForm : Form
    {
        private bool _downloadLoopRunning;
        private bool _focusLoopRunning;
        private int _lastKnownCounter;

        public MainForm()
        {
            InitializeComponent();

            Logger.MessageLogged += OnMessageLogged;
        }

        private void OnMessageLogged(object sender, LogMessage message)
        {
            const int maxLines = 200;
            const int reducedNumberOfLines = 150;

            var minimumLevel = LogMessageLevel.Information;

#if DEBUG
            minimumLevel = LogMessageLevel.Debug;
#endif

            if (message.Level < minimumLevel)
            {
                return;
            }

            if (_logTextBox.Lines.Length >= maxLines)
            {
                var destinationArray = new string[reducedNumberOfLines];
                Array.Copy(_logTextBox.Lines, _logTextBox.Lines.Length - reducedNumberOfLines,
                    destinationArray, 0, destinationArray.Length);

                _logTextBox.Lines = destinationArray;

            }

            _logTextBox.AppendText(GetLogMessageLine(message));
        }

        private string GetLogMessageLine(LogMessage message)
        {
            return $"[{message.TimestampLocal:s}] {message.Level} - {message.Message}{Environment.NewLine}";
        }

        private AdbController GetController()
        {
            return new AdbController(Settings.Default.AdbPath);
        }


        private async void OnDetectDeviceButtonClickAsync(object sender, EventArgs e)
        {
            var controller = GetController();

            var (connected, device, errorMessage) = await controller.TryConnectToDeviceAsync();

            _deviceTextBox.Text = connected ? device.ToString() : errorMessage;
        }

        private void ShowBadAdbPathDialog()
        {
            MessageBox.Show(
                "The file adb.exe cannot be found at the given path. Please select the correct folder and try again.",
                "Incorrect adb path",
                MessageBoxButtons.OK);
        }


        private async void OnOpenCameraButtonClickAsync(object sender, EventArgs e)
        {
            var controller = GetController();

            if (!await controller.IsInteractiveAsync())
            {
                await controller.EnableInteractiveAsync();
             
                await Task.Delay(500);

                if (!await controller.IsInteractiveAsync())
                {
                    MessageBox.Show("Unable to activate device screen", "Device not interactive", MessageBoxButtons.OK);
                    return;
                }
            }

            if (await controller.IsLockedAsync())
            {
                await controller.UnlockAsync(Settings.Default.PinCode);

                await Task.Delay(1000);
                
                if (await controller.IsLockedAsync())
                {
                    MessageBox.Show("Unable to unlock device. Is the pin code correct?", "Device locked",
                        MessageBoxButtons.OK);
                    return;
                }
            }

            await controller.OpenCameraAsync();
        }

        private void OnFocusButtonClick(object sender, EventArgs e)
        {
            if (_focusLoopRunning)
            {
                _focusTimer.Stop();
                _focusProgressBar.Value = _focusProgressBar.Minimum;
                _focusLoopRunning = false;
                return;
            }

            if (Settings.Default.FocusKeepaliveInterval < TimeSpan.FromSeconds(1))
                MessageBox.Show("At least one second focus keepalive interval must be set", "Too short interval",
                    MessageBoxButtons.OK);

            var totalInterval = Settings.Default.FocusKeepaliveInterval.TotalMilliseconds;
            var intervalStep = (int) Math.Round(totalInterval /
                                                ((double) (_focusProgressBar.Maximum - _focusProgressBar.Minimum) /
                                                 _focusProgressBar.Step));

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
                var controller = GetController();
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
                _downloadLoopRunning = false;
                return;
            }

            if (Settings.Default.DownloadImagesInterval < TimeSpan.FromSeconds(1))
                MessageBox.Show("At least one second focus keepalive interval must be set", "Too short interval",
                    MessageBoxButtons.OK);

            var totalInterval = Settings.Default.DownloadImagesInterval.TotalMilliseconds;
            var intervalStep = (int) Math.Round(totalInterval /
                                                ((double) (_downloadProgressBar.Maximum -
                                                           _downloadProgressBar.Minimum) / _downloadProgressBar.Step));

            _downloadTimer.Interval = intervalStep;
            _downloadTimer.Start();

            _downloadLoopRunning = true;
        }

        private async void OnDownloadTimerTickAsync(object sender, EventArgs e)
        {
            if (_downloadProgressBar.Value >= _downloadProgressBar.Maximum)
            {
                try
                {
                    _downloadTimer.Stop();
                    var controller = GetController();
                    _lastKnownCounter = await controller.DownloadFilesAsync(_lastKnownCounter);
                }
                finally
                {
                    _downloadProgressBar.Value = _downloadProgressBar.Minimum;
                    _downloadTimer.Start();
                }

                return;
            }

            _downloadProgressBar.PerformStep();
        }
    }
}