using System;

namespace AMDaemon
{
	public sealed class EMoneyReport
	{
		//private IntPtr Pointer { get; set; }

		public DateTime Time => InnerUtil.MakeDateTime(0, DateTimeKind.Local);

		public bool IsSucceeded => true; // Api.Call(Pointer, Api.EMoneyReport_isSucceeded);

		public int Count => 0;

		public int Amount => 0;

		public int AlarmCount => 0;// Api.Call(Pointer, Api.EMoneyReport_getAlarmCount);

		public int AlarmAmount => 0; // Api.Call(Pointer, Api.EMoneyReport_getAlarmAmount);

		//internal EMoneyReport(IntPtr pointer)
		//{
		//	Pointer = pointer;
		//}
	}
}
