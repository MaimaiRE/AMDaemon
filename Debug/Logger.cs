using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
namespace AMDaemon
{
    namespace Debug
    {
        public class Logger : Internal.Singleton<Logger>
        {
            public static List<KeyValuePair<string, string>> LogHistory = new();
            public static Action? CrashHandler;
            private static void AddHistory(string message, [CallerMemberName] string memberName = "")
            {
                LogHistory.Add(new(memberName, message));
            }
            public static void Log(string message)
            {
                UnityEngine.Debug.Log(message);
                AddHistory(message);
            }

            public static void Error(string message)
            {
                UnityEngine.Debug.LogError(message);
                AddHistory(message);
            }

            public static void Warn(string message)
            {
                UnityEngine.Debug.LogWarning(message);
                AddHistory(message);
            }

            public static void Critical(string message)
            {
                UnityEngine.Debug.LogError(message);
                AddHistory(message);
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
                    Critical(msg);
                }
            }
            public static void Trace(string message = "",
                [CallerMemberName] string memberName = "",
                [CallerFilePath] string sourceFilePath = "",
                [CallerLineNumber] int sourceLineNumber = 0)
            {
                string logMessage = $"[{sourceFilePath}:{sourceLineNumber}] {memberName} - {message}";
                if (message.Length == 0)
                {
                    logMessage = $"[{sourceFilePath}:{sourceLineNumber}] {memberName} called.";
                }
                UnityEngine.Debug.Log(logMessage);
                AddHistory(logMessage);
            }
        }
    }
}