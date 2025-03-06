namespace AMDaemon
{
	public static class Can
	{
		public static readonly int MaxPacketDataSize;

		public static readonly byte MaxPacketPriority;

		public static readonly byte DefaultPacketPriority;

		//public static bool IsAvailable => Api.Aime_isAvailable();

		//public static int PortCount => Ports.Count;

		public static LazyCollection<CanPort> Ports { get; private set; }

		static Can()
		{
			//MaxPacketDataSize = Api.MaxCanPacketDataSize_get();
			//MaxPacketPriority = Api.MaxCanPacketPriority_get();
			//DefaultPacketPriority = Api.DefaultCanPacketPriority_get();
			//Ports = new LazyCollection<CanPort>(Api.Can_getPortCount, (int index) => new CanPort(Api.Call(index, Api.Can_getPort)), true);
		}
	}
}
