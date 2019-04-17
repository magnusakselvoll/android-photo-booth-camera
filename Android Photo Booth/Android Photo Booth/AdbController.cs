using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Android_Photo_Booth.Properties;

namespace Android_Photo_Booth
{
    internal sealed class AdbController
    {
        public AdbController(string adbBinariesFolder)
        {
            AdbBinariesFolder = adbBinariesFolder;
        }

        public string AdbBinariesFolder { get; }
        private string AdbExePath => Path.Combine(AdbBinariesFolder, "adb.exe");


        public async Task<(bool connected, AndroidDevice device, string errorMessage)> TryConnectToDeviceAsync()
        {
            var outputLines = await ExecuteAdbCommandAsync("devices -l");

            foreach (string line in outputLines)
            {
                if (AndroidDevice.TryParse(line, out AndroidDevice device))
                {
                    if (!device.Authorized)
                    {
                        return (false, device, $"Device {device.Id} not authorized. Please enable usb debugging and whitelist computer from the device.");
                    }

                    return (true, device, null);
                }
            }

            return (false, null, "No device found");
        }

        public async Task<bool> IsInteractiveAsync()
        {
            var outputLines = await ExecuteAdbCommandAsync("shell service call power 12");

            return ParseResult(outputLines);
        }

        public async Task<bool> IsLockedAsync()
        {
            var outputLines = await ExecuteAdbCommandAsync("shell service call trust 7");

            return ParseResult(outputLines);
        }

        private static bool ParseResult(List<string> outputLines)
        {
            foreach (var line in outputLines)
            {
                if (line.StartsWith("Result", StringComparison.OrdinalIgnoreCase))
                {
                    return line.Contains("00000001");
                }
            }

            throw new Exception(($"Unable to parse result: {outputLines}"));
        }


        private async Task<List<string>> ExecuteAdbCommandAsync(string arguments)
        {
            var si = new ProcessStartInfo(AdbExePath, arguments)
            {
                CreateNoWindow = true,
                WorkingDirectory = AdbBinariesFolder,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false
            };

            // Redirect both streams so we can write/read them.
            // Start the process.
            Process p = Process.Start(si);

            var list = new List<string>();

            string line;
            while ((line = await p.StandardOutput.ReadLineAsync()) != null)
            {
                list.Add(line);
            }

            return list;
        }

        public async Task EnableInteractiveAsync()
        {
            await ExecuteAdbCommandAsync("shell input keyevent 82");
        }

        public async Task UnlockAsync(string pin)
        {
            await ExecuteAdbCommandAsync($"shell input text {pin}");
            await Task.Delay(100);
            await ExecuteAdbCommandAsync("shell input keyevent 66");
        }

        public async Task OpenCameraAsync()
        {
            await ExecuteAdbCommandAsync($"shell am start -a android.media.action.{Settings.Default.CameraApp}");
        }

        public async Task FocusCameraAsync()
        {
            await ExecuteAdbCommandAsync("shell input keyevent KEYCODE_FOCUS");
        }
    }
}
