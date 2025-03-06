using System;

namespace AMDaemon
{
	public class AimePayDealSummary
	{
		private IntPtr Pointer { get; set; }

		//public DateTime Date => InnerUtil.MakeDateTime(Api.Call(Pointer, Api.AimePayDealSummary_getDate), DateTimeKind.Local);

		//public uint Amount => Api.Call(Pointer, Api.AimePayDealSummary_getAmount);

		//public uint Count => Api.Call(Pointer, Api.AimePayDealSummary_getCount);

		internal AimePayDealSummary(IntPtr pointer)
		{
			Pointer = pointer;
		}
	}
}
