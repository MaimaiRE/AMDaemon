using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;

#nullable enable
namespace AMDaemon
{
    public class LogEntry
    {
        public string Time;
        public string Value;
        public LogType Type; 
        public LogEntry(string time, string value, LogType type)
        {
            Time = time;
            Value = value;
            Type = type;
        }
    }
    public class AMDebugger : Internal.Singleton<AMDebugger>
    {
        public static LinkedList<LogEntry> LogHistory = new();
        private static Action? CrashHandler;
        public static void Install(Action crashHandler)
        {
            CrashHandler = crashHandler;            
            Application.logMessageReceivedThreaded += Application_logMessageReceived;
        }

        private static void Application_logMessageReceived(string condition, string stackTrace, LogType type)
        {
            lock (LogHistory)
            {
                AddHistory(condition, type);
            }
        }

        private static void AddHistory(string message, LogType type)
        {
            LogHistory.AddLast(new LogEntry(DateTime.Now.ToShortTimeString(), message, type));
        }
        /// <summary>
        /// Log and crash the game.
        /// </summary>
        public static void Critical(string message)
        {
            UnityEngine.Debug.LogError(message);
            AddHistory(message, LogType.Error);
            if (CrashHandler != null)
                CrashHandler();
            throw new SystemException(message);
        }

        public static void Assert(
            bool condition, string message = "",
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            if (!condition)
            {
                string msg = $"[{sourceFilePath}:{sourceLineNumber}] {memberName} - {message}";
                AddHistory(msg, LogType.Assert);
                Critical(msg);
            }
        }


        public static void Trace(
            string message = "",
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            string msg = $"[{sourceFilePath}:{sourceLineNumber}] {memberName} - {message}";
            UnityEngine.Debug.Log(msg);
        }
    }
}