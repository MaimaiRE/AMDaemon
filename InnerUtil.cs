using System;

namespace AMDaemon
{
	internal static class InnerUtil
	{
		private static class BlankArrayCache<T>
		{
			public static readonly T[] Value = new T[0];
		}

		public static T[] ResizeArrayCache<T>(ref T[] data, int length)
		{
			if (data == null || data.Length != length)
			{
				if (length == 0)
				{
					return BlankArrayCache<T>.Value;
				}
				data = new T[length];
			}
			return data;
		}

		public static DateTime MakeDateTime(ulong microSeconds, DateTimeKind kind)
		{
			if (microSeconds <= (ulong)DateTime.MaxValue.Ticks / 10uL)
			{
				return new DateTime((long)(microSeconds * 10), kind);
			}
			return DateTime.MaxValue;
		}

		public static TimeSpan MakeTimeSpan(long microSeconds)
		{
			if (microSeconds > 922337203685477580L)
			{
				return TimeSpan.MaxValue;
			}
			if (microSeconds < -922337203685477580L)
			{
				return TimeSpan.MinValue;
			}
			return new TimeSpan(microSeconds * 10);
		}

		public static int MakeHashCode<T>(T[] values)
		{
			int num = 0;
			for (int i = 0; i < values.Length; i++)
			{
				T val = values[i];
				num ^= val.GetHashCode();
			}
			return num;
		}
	}
}
