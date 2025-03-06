using AMDaemon.AquaDX;
using System;
using System.Runtime.InteropServices;

namespace AMDaemon.Allnet
{
	public static class Auth
	{
		public static readonly int LocationNicknamePartCount;

		public static readonly int RegionNamePartCount;

		//public static bool IsAvailable => Api.allnet_Auth_isAvailable();

		public static bool IsGood => true; // Api.allnet_Auth_isGood();

		public static DateTime AuthTime => InnerUtil.MakeDateTime(0, DateTimeKind.Local);

		public static string AuthData => "";

		//public static bool IsDevelop => Api.allnet_Auth_isDevelop();

		//public static LineType LineType => Api.allnet_Auth_getLineType();

		public static string GameServerUri { get { return Session.Instance.GetServerEndpoint(); } } // Marshal.PtrToStringUni(Api.allnet_Auth_getGameServerUri());

		public static string GameServerHost => ""; // Marshal.PtrToStringUni(Api.allnet_Auth_getGameServerHost());

		public static uint LocationId => 0; // Api.allnet_Auth_getLocationId();

		public static string LocationName => "";//;Marshal.PtrToStringUni(Api.allnet_Auth_getLocationName());

		public static LazyCollection<string> LocationNicknames { get; private set; }

		public static int RegionCode => 0; // Api.allnet_Auth_getRegionCode();

		public static LazyCollection<string> RegionNames { get; private set; }

		public static string CountryCode => "JP";

		static Auth()
		{
			LocationNicknamePartCount = 0;
			RegionNamePartCount = 0;
			LocationNicknames = new LazyCollection<string>(() => LocationNicknamePartCount, (int index) => "", false);
			RegionNames = new LazyCollection<string>(() => RegionNamePartCount, (int index) => "", false);
		}
	}
}
