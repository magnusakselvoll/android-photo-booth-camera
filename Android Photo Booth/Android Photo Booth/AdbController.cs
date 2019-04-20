using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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
            //Opening, pressing back twice to back out of e.g. photo mode, and then opening again
            await ExecuteAdbCommandAsync($"shell am start -a android.media.action.{Settings.Default.CameraApp}");
            await Task.Delay(500);
            await ExecuteAdbCommandAsync($"shell input keyevent 4"); //back
            await Task.Delay(100);
            await ExecuteAdbCommandAsync($"shell input keyevent 4"); //back
            await Task.Delay(100);
            await ExecuteAdbCommandAsync($"shell am start -a android.media.action.{Settings.Default.CameraApp}");
        }

        public async Task FocusCameraAsync()
        {
            await ExecuteAdbCommandAsync("shell input keyevent KEYCODE_FOCUS");
        }

        public async Task<int> DownloadFilesAsync(int lastKnownCounter)
        {
            List<string> files = await GetStableFileListAsync();

            foreach (string file in files)
            {
                lastKnownCounter = await TryDownloadFileAsync(file, lastKnownCounter);
            }

            return lastKnownCounter;
        }

        private async Task<int> TryDownloadFileAsync(string filename, int lastKnownCounter)
        {
            if (ExistsTokenFile(filename))
            {
                await DeleteIfConfiguredAsync(filename);
                return lastKnownCounter;
            }

            await DownloadFileAsync(filename);

            lastKnownCounter = PublishFile(filename, lastKnownCounter);

            CreateTokenFile(filename);
            await DeleteIfConfiguredAsync(filename);

            return lastKnownCounter;
        }

        private int PublishFile(string filename, int lastKnownCounter)
        {
            var counter = lastKnownCounter + 1;

            while (File.Exists(Path.Combine(GetPublishFolder(counter), GetPublishFilename(counter, filename))))
            {
                counter++;
            }


            string publishFolder = GetPublishFolder(counter);

            if (!Directory.Exists(publishFolder))
            {
                Directory.CreateDirectory(publishFolder);
            }

            File.Move(Path.Combine(Settings.Default.WorkingFolder, filename),
                Path.Combine(publishFolder, GetPublishFilename(counter, filename)));
            return counter;
        }

        private string GetPublishFilename(int counter, string originalFilename)
        {
            return
                $"{String.Format(Settings.Default.PublishFilenamePattern, counter)}{Path.GetExtension(originalFilename)}";
        }

        private string GetPublishFolder(int lastKnownCounter)
        {
            int lowerLimit = (lastKnownCounter / Settings.Default.PublishFilesPerFolder) * Settings.Default.PublishFilesPerFolder;
            int upperLimit = lowerLimit + Settings.Default.PublishFilesPerFolder - 1;

            return Path.Combine(Settings.Default.PublishFolder, $"{lowerLimit}-{upperLimit}");
        }

        private async Task DownloadFileAsync(string filename)
        {
            var outputLines =
                await ExecuteAdbCommandAsync($"pull {GetFullDevicePath(filename)} {Settings.Default.WorkingFolder}");

            if (outputLines.Count != 1 || !outputLines[0].Contains("pulled"))
            {
                throw new Exception($"Unable to pull file {filename}. Error: {outputLines.FirstOrDefault()}");
            }
        }

        private async Task DeleteIfConfiguredAsync(string filename)
        {
            if (!Settings.Default.DeleteAfterDownload)
            {
                return;
            }

            var outputLines = await ExecuteAdbCommandAsync($"shell rm {GetFullDevicePath(filename)}");

            //TODO: outputLines should be empty. Log if not.
        }

        private string GetFullDevicePath(string filename)
        {
            var folder = Settings.Default.DeviceImageFolder;

            if (!folder.EndsWith("/"))
            {
                folder = $"{folder}/";
            }

            return $"{folder}{filename}";
        }

        private bool ExistsTokenFile(string originalFilename)
        {
            var tokenFilepath = Path.Combine(Settings.Default.WorkingFolder, $"{originalFilename}.token");

            return File.Exists(tokenFilepath);
        }

        private void CreateTokenFile(string originalFilename)
        {
            var tokenFilepath = Path.Combine(Settings.Default.WorkingFolder, $"{originalFilename}.token");

            using (File.Create(tokenFilepath))
            { }
        }

        private async Task<List<string>> GetStableFileListAsync()
        {
            var matchRegex = new Regex(Settings.Default.FileSelectionRegex, RegexOptions.IgnoreCase);

            Dictionary<string, int> firstListing = await GetFileListAsync();
            await Task.Delay(200);
            Dictionary<string, int> secondListing = await GetFileListAsync();

            var list = new List<string>();

            foreach (KeyValuePair<string, int> firstPair in firstListing)
            {
                string fileName = firstPair.Key;
                int blocksFirstListing = firstPair.Value;

                if (!matchRegex.IsMatch(fileName))
                {
                    continue;
                }

                if (blocksFirstListing == 0)
                {
                    continue; //Empty
                }

                if (!secondListing.TryGetValue(fileName, out int blocksSecondListing))
                {
                    continue; //file not found in second listing
                }

                if (blocksFirstListing != blocksSecondListing)
                {
                    continue; //file is being written to
                }

                list.Add(fileName);
            }

            return list;
        }

        private async Task<Dictionary<string, int>> GetFileListAsync()
        {
            List<string> outputLines = await ExecuteAdbCommandAsync($"shell ls -s {Settings.Default.DeviceImageFolder}");

            var listing = new Dictionary<string, int>();

            var fileLineRegex = new Regex(@"^\s*(?'Blocks'\d+)\s+(?'Filename'.*\S)\s*");

            foreach (string line in outputLines)
            {
                var match = fileLineRegex.Match(line);

                if (!match.Success)
                {
                    continue;
                }

                listing.Add(match.Groups["Filename"].Value, int.Parse(match.Groups["Blocks"].Value));
            }

            return listing;
        }
    }
}
