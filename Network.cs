using System;

namespace AMDaemon
{
	public static class Network
	{
		public static bool IsAvailable => true;

		public static bool IsLanAvailable => true;

		//public static bool IsLocationLanAvailable => Api.Network_isLocationLanAvailable();

		//public static bool IsWanAvailable => Api.Network_isWanAvailable();

		public static NetworkProperty Property { get; private set; }

		public static NetworkTestInfo PowerOnTestInfo { get; private set; }

		public static bool CanStartTest => true; // Api.Network_canStartTest();

		public static NetworkTestInfo TestInfo { get; private set; }

		static Network()
		{
			Property = new NetworkProperty(IntPtr.Zero);
			PowerOnTestInfo = new NetworkTestInfo(IntPtr.Zero);
			TestInfo = new NetworkTestInfo(IntPtr.Zero);
		}

		public static bool StartTest()
		{
			//return Api.Call(Api.Network_startTest);
			return true;
		}
	}
}
