using System;

namespace AMDaemon
{
	public sealed class ErrorLog
	{
		private IntPtr Pointer { get; set; }

		public LazyCollection<ErrorInfo> HistoryItems { get; private set; }

		public LazyCollection<ErrorTimesItem> TimesItems { get; private set; }

		public LazyCollection<ErrorInfo> SystemHistoryItems { get; private set; }

		internal ErrorLog(IntPtr pointer)
		{
			Pointer = pointer;
			//HistoryItems = new LazyCollection<ErrorInfo>(() => Api.Call(pointer, Api.ErrorLog_getHistoryItemCount), (int index) => new ErrorInfo(Api.Call(pointer, index, Api.ErrorLog_getHistoryItem)), true);
			//TimesItems = new LazyCollection<ErrorTimesItem>(() => Api.Call(pointer, Api.ErrorLog_getTimesItemCount), (int index) => new ErrorTimesItem(Api.Call(pointer, index, Api.ErrorLog_getTimesItem)), true);
			//SystemHistoryItems = new LazyCollection<ErrorInfo>(() => Api.Call(pointer, Api.ErrorLog_getSystemHistoryItemCount), (int index) => new ErrorInfo(Api.Call(pointer, index, Api.ErrorLog_getSystemHistoryItem)), true);
		}

		//public ErrorTimesItem FindTimesItem(int number)
		//{
		//	IntPtr intPtr = Api.Call(Pointer, number, Api.ErrorLog_findTimesItem);
		//	if (!(intPtr == IntPtr.Zero))
		//	{
		//		return new ErrorTimesItem(intPtr);
		//	}
		//	return null;
		//}
	}
}
