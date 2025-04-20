using System;
using Logger = AMDaemon.Debug.Logger;
namespace AMDaemon
{
	public static class Error
	{
		public static readonly int NumberLimit;

		public static readonly int SubNumberLimit;

		public static ErrorInfo Info { get; private set; }

		public static bool IsOccurred => Info.IsOccurred;

		public static int Number => Info.Number;

		public static int SubNumber => Info.SubNumber;

		public static string Message => Info.Message;

		public static ErrorResetType ResetType => Info.ResetType;

		//public static bool CanReset => Api.Error_canReset();

		public static DateTime Time => Info.Time;

		public static ErrorLog Log { get; private set; }

		static Error()
		{
			//NumberLimit = Api.ErrorNumberLimit_get();
			//SubNumberLimit = Api.ErrorSubNumberLimit_get();
			Info = new ErrorInfo(IntPtr.Zero);
			Log = new ErrorLog(IntPtr.Zero);
		}

		public static string MakeNumberString()
		{
			return Info.MakeNumberString();
		}

		public static bool Set(int number, int subNumber)
		{
			//return Api.Call(number, subNumber, Api.Error_set);
			Logger.Trace($"{number} {subNumber}");
            return true;
		}

		public static bool Set(int number)
		{
			return Set(number, 0);
		}

		//public static bool Reset()
		//{
		//	return Api.Call(Api.Error_reset);
		//}

		//public static bool ClearLog()
		//{
		//	return Api.Call(Api.Error_clearLog);
		//}
	}
}
