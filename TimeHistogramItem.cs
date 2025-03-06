using System;

namespace AMDaemon
{
	public sealed class TimeHistogramItem
	{
		private IntPtr Pointer { get; set; }

		//public TimeSpan TimeRangeMin => TimeSpan.FromSeconds(Api.TimeHistogramItem_timeRangeMin_get(Pointer));

		//public TimeSpan TimeRangeMax
		//{
		//	get
		//	{
		//		uint num = Api.TimeHistogramItem_timeRangeMax_get(Pointer);
		//		if (num != uint.MaxValue)
		//		{
		//			return TimeSpan.FromSeconds(num);
		//		}
		//		return TimeSpan.MaxValue;
		//	}
		//}

		//public int Count => Api.TimeHistogramItem_count_get(Pointer);

		//internal TimeHistogramItem(IntPtr pointer)
		//{
		//	Pointer = pointer;
		//}

		//public override string ToString()
		//{
		//	TimeSpan timeRangeMin = TimeRangeMin;
		//	TimeSpan timeRangeMax = TimeRangeMax;
		//	string format = ((((timeRangeMax == TimeSpan.MaxValue) ? timeRangeMin : timeRangeMax).TotalHours < 1.0) ? "{0:mm'M'ss'S'}" : "{0:hh'H'mm'M'ss'S'}");
		//	string text = string.Format(format, timeRangeMin);
		//	return ((timeRangeMax == TimeSpan.MaxValue) ? ("OVER " + text) : (text + "-" + string.Format(format, timeRangeMax))) + " : " + Count;
		//}
	}
}
