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

        public MainForm()
        {
            InitializeComponent();
        }

        private AdbController GetController()
        {
            return new AdbController(Settings.Default.AdbPath);
        }


        private void OnDetectDeviceButtonClick(object sender, EventArgs e)
        {
            AdbController controller = GetController();

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


        private async void OnOpenCameraButtonClickAsync(object sender, EventArgs e)
        {
            AdbController controller = GetController();

            if (!controller.IsInteractive())
            {
                controller.EnableInteractive();
            }

            if (!controller.IsInteractive())
            {
                MessageBox.Show("Unable to activate device screen", "Device not interactive", MessageBoxButtons.OK);
                return;
            }

            await Task.Delay(100);

            if (controller.IsLocked())
            {
                await controller.UnlockAsync(Settings.Default.PinCode);
            }

            if (controller.IsLocked())
            {
                MessageBox.Show("Unable to unlock device. Is the pin code correct?", "Device locked", MessageBoxButtons.OK);
                return;
            }

            controller.OpenCamera();
        }

        private void OnFocusButtonClick(object sender, EventArgs e)
        {
            if (_focusLoopRunning)
            {
                _focusTimer.Stop();
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
        }

        private void OnSettingsButtonClick(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog(this);
        }

        private void OnFocusTimerTick(object sender, EventArgs e)
        {
            if (_focusProgressBar.Value >= _focusProgressBar.Maximum)
            {
                AdbController controller = GetController();
                controller.FocusCamera();

                _focusProgressBar.Value = _focusProgressBar.Minimum;

                return;
            }

            _focusProgressBar.PerformStep();
        }
    }
}
