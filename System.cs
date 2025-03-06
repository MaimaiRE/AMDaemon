using System.Runtime.InteropServices;
using System;
namespace AMDaemon
{
	public static class System
	{
		public static SerialId BoardId { get; private set; }

		public static RegionCode RegionCode => RegionCode.Japan; // Api.System_getRegionCode();

		public static SerialId KeychipId { get; private set; }

		//public static uint ModelType => Api.System_getModelType();

		public static string GameId => "MaimaiRE"; // Marshal.PtrToStringUni(Api.System_getGameId());

		public static bool IsDevelop => true; // Api.System_isDevelop();

		public static LazyCollection<Resolution> Resolutions { get; private set; }

		//public static string AppRootPath => Marshal.PtrToStringUni(Api.System_getAppRootPath());

		static System()
		{
			BoardId = new SerialId("MaimaiRE"); // new SerialId(Api.System_getBoardId());
			KeychipId = new SerialId(Utils.Config.KeychipID);
			Resolutions = new LazyCollection<Resolution>(() => 2, (int index) => new Resolution(IntPtr.Zero));
		}
	}
}
