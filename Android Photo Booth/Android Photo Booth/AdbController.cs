using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Android_Photo_Booth.Logging;
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

        public async Task<bool> IsInteractiveAndUnlocked()
        {
            if (Settings.Default.UseNfcScreenApi)
            {
                return await IsInteractiveAndUnlockedNfcAsync();
            }

            return await IsInteractiveAsync() && !await IsLockedAsync();
        }

        private async Task<bool> IsInteractiveAndUnlockedNfcAsync()
        {
            (bool screenOn, bool screenLocked) = await GetNfcScreenStateAsync();

            Logger.Log(LogMessageLevel.Debug, $"IsInteractive: {screenOn}");
            Logger.Log(LogMessageLevel.Debug, $"IsLocked: {screenLocked}");

            return screenOn && !screenLocked;
        }

        public async Task<bool> IsInteractiveAsync()
        {
            if (Settings.Default.UseNfcScreenApi)
            {
                return await IsInteractiveNfcAsync();
            }

            var outputLines = await ExecuteAdbCommandAsync("shell service call power 12");

            var result = ParseBinaryResult(outputLines);

            Logger.Log(LogMessageLevel.Debug, $"IsInteractive: {result}");

            return result;
        }

        private async Task<bool> IsInteractiveNfcAsync()
        {
            (bool screenOn, _) = await GetNfcScreenStateAsync();

            Logger.Log(LogMessageLevel.Debug, $"IsInteractive: {screenOn}");

            return screenOn;
        }

        private async Task<(bool screenOn, bool screenLocked)> GetNfcScreenStateAsync()
        {
            var outputLines = await ExecuteAdbCommandAsync("shell dumpsys nfc");

            foreach (string line in outputLines.Select(x => x.Trim()))
            {
                const string screenStateId = "mScreenState=";

                if (line.StartsWith(screenStateId))
                {
                    string value = line.Substring(screenStateId.Length);

                    switch (value.ToUpperInvariant())
                    {
                        case "OFF_LOCKED":
                            return (screenOn: false, screenLocked: true);
                        case "OFF_UNLOCKED":
                            return (screenOn: false, screenLocked: false);
                        case "ON_LOCKED":
                            return (screenOn: true, screenLocked: true);
                        case "ON_UNLOCKED":
                            return (screenOn: true, screenLocked: false);
                        default:
                            throw new Exception($"Unexpected screen state: {line}");
                    }
                }
            }

            throw new Exception("Unable to find NFC screen state");
        }

        public async Task<bool> IsLockedAsync()
        {
            if (Settings.Default.UseNfcScreenApi)
            {
                return await IsLockedNfcAsync();
            }

            var outputLines = await ExecuteAdbCommandAsync("shell service call trust 7");

            var result = ParseBinaryResult(outputLines);

            Logger.Log(LogMessageLevel.Debug, $"IsLocked: {result}");


            return result;
        }

        private async Task<bool> IsLockedNfcAsync()
        {
            (_, bool screenLocked) = await GetNfcScreenStateAsync();

            Logger.Log(LogMessageLevel.Debug, $"IsLocked: {screenLocked}");

            return screenLocked;
        }

        private static bool ParseBinaryResult(List<string> outputLines)
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

            if (p == null)
            {
                throw new Exception($"Unable to start process {si.FileName}");
            }

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

            Logger.Log(LogMessageLevel.Information, "Device interactive enabled");
        }

        public async Task UnlockAsync(string pin)
        {
            await ExecuteAdbCommandAsync($"shell input text {pin}");
            await Task.Delay(100);
            await ExecuteAdbCommandAsync("shell input keyevent 66");

            Logger.Log(LogMessageLevel.Information, $"Device unlocked with pin {pin}");
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

            Logger.Log(LogMessageLevel.Information, "Camera opened");
        }

        public async Task FocusCameraAsync()
        {
            await ExecuteAdbCommandAsync("shell input keyevent KEYCODE_FOCUS");

            Logger.Log(LogMessageLevel.Debug, $"Camera focused");
        }

        public async Task<int> DownloadFilesAsync(int lastKnownCounter)
        {
            List<string> files = await GetStableFileListAsync();

            Logger.Log(LogMessageLevel.Information, $"{files.Count} files ready for download");

            foreach (string file in files)
            {
                lastKnownCounter = await TryDownloadFileAsync(file, lastKnownCounter);
            }

            Logger.Log(LogMessageLevel.Debug, "All files downloaded");

            return lastKnownCounter;
        }

        private async Task<int> TryDownloadFileAsync(string filename, int lastKnownCounter)
        {
            if (ExistsTokenFile(filename))
            {
                Logger.Log(LogMessageLevel.Warning, $"File '{filename}' has already been downloaded");

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
            Logger.Log(LogMessageLevel.Debug, $"Trying to publish file '{filename}'. Last counter: {lastKnownCounter}");
            var counter = lastKnownCounter + 1;

            while (File.Exists(Path.Combine(GetPublishFolder(counter), GetPublishFilename(counter, filename))))
            {
                counter++;
            }


            string publishFolder = GetPublishFolder(counter);

            if (!Directory.Exists(publishFolder))
            {
                Directory.CreateDirectory(publishFolder);
                Logger.Log(LogMessageLevel.Information, $"Created new publish directory '{publishFolder}'");
            }

            var publishFilename = GetPublishFilename(counter, filename);

            File.Move(Path.Combine(Settings.Default.WorkingFolder, filename),
                Path.Combine(publishFolder, publishFilename));

            Logger.Log(LogMessageLevel.Information, $"Published file '{filename}' as '{publishFilename}'");

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
            var fullDevicePath = GetFullDevicePath(filename);

            Logger.Log(LogMessageLevel.Debug, $"Downloading file '{fullDevicePath}'");

            var outputLines =
                await ExecuteAdbCommandAsync($"pull {fullDevicePath} {Settings.Default.WorkingFolder}");

            if (outputLines.Count != 1 || !outputLines[0].Contains("pulled"))
            {
                throw new Exception($"Unable to pull file {filename}. Error: {outputLines.FirstOrDefault()}");
            }

            Logger.Log(LogMessageLevel.Information, $"Downloaded file '{filename}'");
        }

        private async Task DeleteIfConfiguredAsync(string filename)
        {
            var fullDevicePath = GetFullDevicePath(filename);
            Logger.Log(LogMessageLevel.Debug, $"Considering deleting file '{fullDevicePath}'");

            if (!Settings.Default.DeleteAfterDownload)
            {
                Logger.Log(LogMessageLevel.Debug, $"Deletion disabled in settings");
                return;
            }

            var outputLines = await ExecuteAdbCommandAsync($"shell rm {fullDevicePath}");
            if (outputLines.Count != 0)
            {
                throw new Exception($"Error deleting file '{fullDevicePath}': {outputLines[0]}");
            }

            Logger.Log(LogMessageLevel.Information, $"Deleted file '{filename}'");
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
            Logger.Log(LogMessageLevel.Debug, "Assembling list of stable files on device");
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
                    Logger.Log(LogMessageLevel.Debug, $"File '{fileName}' does not match pattern '{matchRegex}'");
                    continue;
                }

                if (blocksFirstListing == 0)
                {
                    Logger.Log(LogMessageLevel.Debug, $"File '{fileName}' is empty.");
                    continue; //Empty
                }

                if (!secondListing.TryGetValue(fileName, out int blocksSecondListing))
                {
                    Logger.Log(LogMessageLevel.Debug, $"File '{fileName}' was not found in second listing.");
                    continue; //file not found in second listing
                }

                if (blocksFirstListing != blocksSecondListing)
                {
                    Logger.Log(LogMessageLevel.Debug, $"File '{fileName}' has changed from {blocksFirstListing} to {blocksSecondListing} blocks and is probably being written to.");
                    continue; //file is being written to
                }

                Logger.Log(LogMessageLevel.Debug, $"File '{fileName}' is stable and will be included. Size: {blocksFirstListing} blocks.");

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

        public async Task TakeSinglePhotoAsync()
        {
            await ExecuteAdbCommandAsync("shell input keyevent KEYCODE_CAMERA");

            Logger.Log(LogMessageLevel.Debug, $"Photo taken");
        }
    }
}
