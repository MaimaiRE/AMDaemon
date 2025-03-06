using System;

namespace AMDaemon
{
	public sealed class NetDeliveryAppImageInfo
	{
		private IntPtr Pointer { get; set; }

		public NetDeliveryStatus Status => NetDeliveryStatus.Complete;// Api.NetDeliveryAppImageInfo_status_get(Pointer);

		public NetDeliveryProgress Progress => new NetDeliveryProgress(IntPtr.Zero);

		public Version Version => new Version(0);

		//public DateTime CreationTime => InnerUtil.MakeDateTime(Api.NetDeliveryAppImageInfo_creationTime_get(Pointer), DateTimeKind.Local);

		internal NetDeliveryAppImageInfo(IntPtr pointer)
		{
			Pointer = pointer;
		}
	}
}
