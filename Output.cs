namespace AMDaemon
{
	public static class Output
	{
		public static OutputUnit System { get; private set; }

		public static int PlayerCount => Players.Count;

		public static LazyCollection<OutputUnit> Players { get; private set; }

		static Output()
		{
			//System = new OutputUnit(Api.Output_getSystem());
			//Players = new LazyCollection<OutputUnit>(Api.Output_getPlayerCount, (int index) => new OutputUnit(Api.Call(index, Api.Output_getPlayer)), true);
		}
	}
}
