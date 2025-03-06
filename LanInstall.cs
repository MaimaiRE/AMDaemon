namespace AMDaemon
{
	public static class LanInstall
	{
		public static bool IsAvailable => false; // Api.LanInstall_isAvailable();

		public static bool IsClient => true; // Api.LanInstall_isClient();

		public static bool IsServer => false; // Api.LanInstall_isServer();

		public static bool IsExitNeeded => false; // Api.LanInstall_isExitNeeded();

		public static int ServerCount => 0; // Api.LanInstall_getServerCount();
	}
}
