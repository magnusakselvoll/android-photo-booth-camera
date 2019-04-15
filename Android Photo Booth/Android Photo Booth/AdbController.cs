using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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


        public bool TryConnectToDevice(out AndroidDevice device, out string errorMessage)
        {
            var outputLines = ExecuteAdbCommand("devices -l").ToArray();

            foreach (string line in outputLines)
            {
                if (AndroidDevice.TryParse(line, out device))
                {
                    if (!device.Authorized)
                    {
                        errorMessage =
                            $"Device {device.Id} not authorized. Please enable usb debugging and whitelist computer from the device.";
                    }

                    errorMessage = null;
                    return true;
                }
            }

            device = null;
            errorMessage = null;
            return false;
        }

        public bool IsInteractive()
        {
            var outputLines = ExecuteAdbCommand("shell service call power 12").ToArray();

            return ParseResult(outputLines);
        }

        public bool IsLocked()
        {
            var outputLines = ExecuteAdbCommand("shell service call trust 7").ToArray();

            return ParseResult(outputLines);
        }

        private static bool ParseResult(string[] outputLines)
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


        private IEnumerable<string> ExecuteAdbCommand(string arguments)
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

            string line;
            while ((line = p.StandardOutput.ReadLine()) != null)
            {
                yield return line;
            }
        }

        public void EnableInteractive()
        {
            ExecuteAdbCommand("shell input keyevent 82");
        }

        public void Unlock(string pin)
        {
            ExecuteAdbCommand($"adb shell input text {pin} && adb shell input keyevent 66");
        }
    }
}
