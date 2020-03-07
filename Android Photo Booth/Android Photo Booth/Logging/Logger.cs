using System;
using System.Collections.Generic;

namespace Android_Photo_Booth.Logging
{
    public static class Logger
    {
        public const int BufferLength = 200;
        private static readonly LinkedList<LogMessage> LastMessagesList = new LinkedList<LogMessage>();

        public static IReadOnlyCollection<LogMessage> LastMessages => LastMessagesList;

        public static void Log(LogMessageLevel level, string message)
        {
            Log(new LogMessage(level, message));
        }

        public static void Log(LogMessage message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            LastMessagesList.AddFirst(message);

            if (LastMessagesList.Count > BufferLength)
            {
                LastMessagesList.RemoveLast();
            }

            MessageLogged?.Invoke(null, message);
        }

        public static event EventHandler<LogMessage> MessageLogged;
    }
}
