using System.Text.RegularExpressions;

namespace Android_Photo_Booth
{
    internal sealed class AndroidDevice
    {
        public string Id { get; set; }
        public bool Authorized { get; set; }
        public string Product { get; set; }
        public string Model { get; set; }
        public string Device { get; set; }
        public string Transport { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Product} - {Model}";
        }

        /*
List of devices attached
XXXXXXXXX              unauthorized transport_id:2


List of devices attached
XXXXXXXXX              device product:blueline model:Pixel_3 device:blueline transport_id:2 
     
List of devices attached
* daemon not running; starting now at tcp:5037
* daemon started successfully

List of devices attached
* daemon not running; starting now at tcp:5037
* daemon started successfully
XXXXXXXXX              device product:blueline model:Pixel_3 device:blueline transport_id:1 
*/

        public static Regex UnauthorizedRegex { get; } = new Regex(
            @"^\s*(?'Id'\S+)\s+unauthorized\s+transport_id:(?'Transport'\S+)", RegexOptions.IgnoreCase);

        public static Regex AuthorizedRegex { get; } = new Regex(
            @"^\s*(?'Id'\S+)\s+device\s+product:(?'Product'\S+)\s+model:(?'Model'\S+)\s+device:(?'Device'\S+)\s+transport_id:(?'Transport'\S+)", RegexOptions.IgnoreCase);

        public static bool TryParse(string line, out AndroidDevice device)
        {
            if (TryParseUnauthorized(line, out device))
            {
                return true;
            }

            if (TryParseAuthorized(line, out device))
            {
                return true;
            }

            return false;
        }

        private static bool TryParseAuthorized(string line, out AndroidDevice device)
        {
            var match = AuthorizedRegex.Match(line);
            if (match.Success)
            {
                device = new AndroidDevice
                {
                    Authorized = true,
                    Id = match.Groups["Id"].Value,
                    Product = match.Groups["Product"].Value,
                    Model = match.Groups["Model"].Value,
                    Device = match.Groups["Device"].Value,
                    Transport = match.Groups["Transport"].Value
                };
                return true;
            }

            device = null;
            return false;
        }

        private static bool TryParseUnauthorized(string line, out AndroidDevice device)
        {
            var match = UnauthorizedRegex.Match(line);
            if (match.Success)
            {
                device = new AndroidDevice
                {
                    Authorized = false,
                    Id = match.Groups["Id"].Value,
                    Transport = match.Groups["Transport"].Value
                };
                return true;
            }

            device = null;
            return false;
        }
    }
}