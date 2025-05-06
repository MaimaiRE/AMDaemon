using System;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	public sealed class NetworkTestInfo
	{
		private IntPtr Pointer { get; set; }

		public bool IsRunning => false; // Api.Call(Pointer, Api.NetworkTestInfo_isRunning);

		public bool IsCompleted => true; // Api.Call(Pointer, Api.NetworkTestInfo_isCompleted);

		public int AvailableItemCount => AvailableItems.Count;

		public LazyCollection<NetworkTestItem> AvailableItems { get; private set; }

		public int Hops => 1; // Api.Call(Pointer, Api.NetworkTestInfo_getHops);

		//public ErrorInfo ErrorInfo { get; private set; }

		//public static string GetBusyStatusText(bool blink)
		//{
		//	return Marshal.PtrToStringUni(Api.NetworkTestInfo_getBusyStatusText(blink));
		//}

		//public static string GetBusyStatusText()
		//{
		//	return GetBusyStatusText(true);
		//}

		internal NetworkTestInfo(IntPtr pointer)
		{
			Pointer = pointer;
			AvailableItems = new LazyCollection<NetworkTestItem>(() => 0, (int index) => NetworkTestItem.Gateway);
		}

		//public bool IsAvailableItem(NetworkTestItem item)
		//{
		//	return Api.Call(Pointer, item, Api.NetworkTestInfo_isAvailableItem);
		//}

		//public NetworkTestState GetState(NetworkTestItem item)
		//{
		//	return Api.Call(Pointer, item, Api.NetworkTestInfo_getState);
		//}

		public bool IsBusy(NetworkTestItem item)
		{
			// return Api.Call(Pointer, item, Api.NetworkTestInfo_isBusy);
			AMDebugger.Trace($"{item}");
			return false;
		}

		public bool IsDone(NetworkTestItem item)
		{
            AMDebugger.Trace($"{item}");
            return false;
        }

		public TestResult GetResult(NetworkTestItem item)
		{
			//return Api.Call(Pointer, item, Api.NetworkTestInfo_getResult);
			AMDebugger.Trace($"{item}");
            return TestResult.Good;
        }

		//public string GetStatusText(NetworkTestItem item, bool blinkBusy)
		//{
		//	return Marshal.PtrToStringUni(Api.Call(() => Api.NetworkTestInfo_getStatusText(Pointer, item, blinkBusy)));
		//}

		//public string GetStatusText(NetworkTestItem item)
		//{
		//	return GetStatusText(item, true);
		//}
	}
}
