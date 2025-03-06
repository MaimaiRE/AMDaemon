using System;

namespace AMDaemon
{
	public sealed class NetDeliveryTimeInfo
	{
		private IntPtr Pointer { get; set; }

		public DateTime Order => InnerUtil.MakeDateTime(0, DateTimeKind.Local);

		public DateTime Release => InnerUtil.MakeDateTime(0, DateTimeKind.Local);

		public bool IsExistsImage => true;

		internal NetDeliveryTimeInfo(IntPtr pointer)
		{
			Pointer = pointer;
		}
	}
}
