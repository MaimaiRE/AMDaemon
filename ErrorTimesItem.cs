using System;

namespace AMDaemon
{
	public sealed class ErrorTimesItem
	{
		private IntPtr Pointer { get; set; }

		//public int Number => Api.ErrorTimesItem_number_get(Pointer);

		//public int Times => Api.ErrorTimesItem_times_get(Pointer);

		internal ErrorTimesItem(IntPtr pointer)
		{
			Pointer = pointer;
		}
	}
}
