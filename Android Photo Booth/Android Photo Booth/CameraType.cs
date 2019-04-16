using System.Collections.Generic;

namespace Android_Photo_Booth
{
    public sealed class CameraType
    {
        public CameraType(string name, string action)
        {
            Name = name;
            Action = action;
        }

        public string Name { get; }
        public string Action { get; }

        public static CameraType BuiltInImageCapture { get; } = new CameraType("Built in Image Capture", "IMAGE_CAPTURE");
        public static CameraType UserSelectedCameraApp { get; } = new CameraType("User selected camera app", "STILL_IMAGE_CAMERA");

        public static IReadOnlyCollection<CameraType> All { get; } = new[] {UserSelectedCameraApp, BuiltInImageCapture };
    }
}