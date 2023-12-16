﻿namespace NextGenSoftware.Logging.NLogger
{
    public class Nlogger : ILogProvider
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        public void Log(string message, LogType type, bool showWorkingAnimation = false)
        {
            switch (type)
            {
                case LogType.Error:
                    _logger.Log(NLog.LogLevel.Error, message);
                    break;

                case LogType.Warning:
                    _logger.Log(NLog.LogLevel.Warn, message);
                    break;

                case LogType.Debug:
                    _logger.Log(NLog.LogLevel.Debug, message);
                    break;

                case LogType.Info:
                    _logger.Log(NLog.LogLevel.Info, message);
                    break;
            }
        }

        public void Log(string message, LogType type, ConsoleColor consoleColour, bool showWorkingAnimation = false)
        {
            //TODO: Need to add colour support to NLog later... for now if you want animated coloured console output then use the DefaultLogger (much simpler to use and config than NLog! ;-) Why I created Logging project in the 1st place! )... ;-)
            Log(message, type);
        }

        public void Shutdown()
        {
            NLog.LogManager.Shutdown(); // Flush and close down internal threads and timers
        }
    }
}