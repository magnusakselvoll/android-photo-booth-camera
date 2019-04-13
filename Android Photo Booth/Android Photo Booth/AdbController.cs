using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


/*
List of devices attached
8BNX1D490              unauthorized transport_id:2


List of devices attached
8BNX1D490              device product:blueline model:Pixel_3 device:blueline transport_id:2 
     
List of devices attached
* daemon not running; starting now at tcp:5037
* daemon started successfully

List of devices attached
* daemon not running; starting now at tcp:5037
* daemon started successfully
8BNX1D490              device product:blueline model:Pixel_3 device:blueline transport_id:1 
*/
        public bool TryConnectToDevice(out AndroidDevice device, out string errorMessage)
        {
            var outputLines = ExecuteAdbCommand("devices -l");

            device = null;
            errorMessage = null;
            return false;
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

    }

    internal sealed class AndroidDevice
    {
        public string Id { get; set; }
        public bool Authorized { get; set; }
        public string Product { get; set; }
        public string Model { get; set; }
        public string Device { get; set; }

    }
}
