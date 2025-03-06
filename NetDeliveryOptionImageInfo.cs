using System;

namespace AMDaemon
{
	public sealed class NetDeliveryOptionImageInfo
	{
		private IntPtr Pointer { get; set; }

		public NetDeliveryStatus Status => NetDeliveryStatus.Complete;// Api.NetDeliveryOptionImageInfo_status_get(Pointer);

		public NetDeliveryProgress Progress => new NetDeliveryProgress(IntPtr.Zero);

		public NetDeliveryProgress OptionalProgress => new NetDeliveryProgress(IntPtr.Zero);

        public NetDeliveryProgress TotalProgress => new NetDeliveryProgress(IntPtr.Zero);

        internal NetDeliveryOptionImageInfo(IntPtr pointer)
		{
			Pointer = pointer;
		}
	}
}
