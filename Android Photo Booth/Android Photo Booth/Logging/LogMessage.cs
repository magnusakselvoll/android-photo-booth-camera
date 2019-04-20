using System;

namespace Android_Photo_Booth.Logging
{
    public sealed class LogMessage
    {
        public LogMessage(LogMessageLevel level, string message)
        {
            Timestamp = DateTime.UtcNow;
            Level = level;
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }

        public DateTime Timestamp { get; }
        public DateTime TimestampLocal => TimeZone.CurrentTimeZone.ToLocalTime(Timestamp);
        public LogMessageLevel Level { get; }
        public string Message { get; }
    }
}