namespace AMDaemon
{
	public static class NetDelivery
	{
		//public static bool IsAvailable => Api.NetDelivery_isAvailable();

		public static bool IsExitNeeded => false;// Api.NetDelivery_isExitNeeded();

		public static bool IsExistsApp => true; // Api.NetDelivery_existsApp();

		public static NetDeliveryTimeInfo AppTimeInfo { get; private set; }

		public static NetDeliveryAppImageInfo AppImageInfo { get; private set; }

		public static bool IsExistsOption => true;// Api.NetDelivery_existsOption();

		public static NetDeliveryTimeInfo OptionTimeInfo { get; private set; }

		public static NetDeliveryOptionImageInfo OptionImageInfo { get; private set; }

		static NetDelivery()
		{
			//AppTimeInfo = new NetDeliveryTimeInfo(Api.NetDelivery_getAppTimeInfo());
			//AppImageInfo = new NetDeliveryAppImageInfo(Api.NetDelivery_getAppImageInfo());
			//OptionTimeInfo = new NetDeliveryTimeInfo(Api.NetDelivery_getOptionTimeInfo());
			//OptionImageInfo = new NetDeliveryOptionImageInfo(Api.NetDelivery_getOptionImageInfo());
		}
	}
}
