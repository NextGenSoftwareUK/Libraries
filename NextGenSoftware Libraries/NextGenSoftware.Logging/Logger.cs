﻿
using System;
using System.Collections.Generic;

namespace NextGenSoftware.Logging
{
    public class Logger
    {
        public List<ILogProvider> LogProviders { get; set; } = new List<ILogProvider>();

        //public delegate void Error(object sender, LoggingErrorEventArgs e);
        //public static event Error OnError;

        public void AddLogProvider(ILogProvider logProvider)
        {
            if (LogProviders == null)
                LogProviders = new List<ILogProvider>();

            LogProviders.Add(logProvider);
        }

        public void AddLogProviders(IEnumerable<ILogProvider> logProviders)
        {
            if (LogProviders == null)
                LogProviders = new List<ILogProvider>();

            LogProviders.AddRange(logProviders);
        }

        public void Log(string message, LogType type)
        {
            foreach (ILogProvider logger in LogProviders)
                logger.Log(message, type);
        }

        public void Log(string message, LogType type, ConsoleColor consoleColour, bool showWorkingAnimation = false)
        {
            foreach (ILogProvider logger in LogProviders)
                logger.Log(message, type, consoleColour, showWorkingAnimation);
        }

        public void Log(string message, LogType type, bool showWorkingAnimation = false)
        {
            foreach (ILogProvider logger in LogProviders)
                logger.Log(message, type, showWorkingAnimation);
        }

        //public bool ContinueLogging(LogType type)
        //{
        //    if (type == LogType.Info && !(LogConfig.LoggingMode == LoggingMode.WarningsErrorsInfoAndDebug || LogConfig.LoggingMode == LoggingMode.WarningsErrorsAndInfo))
        //        return false;

        //    if (type == LogType.Debug && LogConfig.LoggingMode != LoggingMode.WarningsErrorsInfoAndDebug)
        //        return false;

        //    if (type == LogType.Warning && !(LogConfig.LoggingMode == LoggingMode.WarningsErrorsInfoAndDebug || LogConfig.LoggingMode == LoggingMode.WarningsErrorsAndInfo || LogConfig.LoggingMode == LoggingMode.WarningsAndErrors))
        //        return false;

        //    return true;
        //}
    }
}



//using System;
//using System.Collections.Generic;

//namespace NextGenSoftware.Logging
//{
//    public static class Logger
//    {
//        public static List<ILogger> Loggers { get; set; } = new List<ILogger>();

//        //public delegate void Error(object sender, LoggingErrorEventArgs e);
//        //public static event Error OnError;

//        public static void Log(string message, LogType type)
//        {
//            foreach (ILogger logger in Loggers)
//                logger.Log(message, type);
//        }

//        public static void Log(string message, LogType type, ConsoleColor consoleColour, bool showWorkingAnimation = false)
//        {
//            foreach (ILogger logger in Loggers)
//                logger.Log(message, type, consoleColour, showWorkingAnimation);
//        }

//        public static void Log(string message, LogType type, bool showWorkingAnimation = false)
//        {
//            foreach (ILogger logger in Loggers)
//                logger.Log(message, type, showWorkingAnimation);
//        }

//        public static bool ContinueLogging(LogType type)
//        {
//            if (type == LogType.Info && !(LogConfig.LoggingMode == LoggingMode.WarningsErrorsInfoAndDebug || LogConfig.LoggingMode == LoggingMode.WarningsErrorsAndInfo))
//                return false;

//            if (type == LogType.Debug && LogConfig.LoggingMode != LoggingMode.WarningsErrorsInfoAndDebug)
//                return false;

//            if (type == LogType.Warning && !(LogConfig.LoggingMode == LoggingMode.WarningsErrorsInfoAndDebug || LogConfig.LoggingMode == LoggingMode.WarningsErrorsAndInfo || LogConfig.LoggingMode == LoggingMode.WarningsAndErrors))
//                return false;

//            return true;
//        }
//    }
//}
