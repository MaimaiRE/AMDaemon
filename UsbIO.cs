namespace AMDaemon
{
	public static class UsbIO
	{
		//public static bool IsAvailable => Api.UsbIO_isAvailable();

		public static int NodeCount => 0;

		public static LazyCollection<UsbIONode> Nodes { get; private set; }

		//static UsbIO()
		//{
		//	Nodes = new LazyCollection<UsbIONode>(Api.UsbIO_getNodeCount, (int index) => new UsbIONode(Api.Call(index, Api.UsbIO_getNode)), true);
		//}
	}
}
