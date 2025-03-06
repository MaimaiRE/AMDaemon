using System;
using System.Runtime.InteropServices;

namespace AMDaemon.Allnet
{
	public sealed class WiFiUnit
	{
		private IntPtr Pointer { get; set; }

		//public bool IsCache => Api.Call(Pointer, Api.allnet_WiFiUnit_isCache);

		//public bool IsValid => Api.Call(Pointer, Api.allnet_WiFiUnit_valid);

		//public bool IsAuthGood => Api.Call(Pointer, Api.allnet_WiFiUnit_isAuthGood);

		//public string AuthGoodText => Marshal.PtrToStringUni(Api.Call(Pointer, Api.allnet_WiFiUnit_getAuthGoodText));

		//public string Serial => Marshal.PtrToStringUni(Api.Call(Pointer, Api.allnet_WiFiUnit_getSerial));

		//public string FirmVersion => Marshal.PtrToStringUni(Api.Call(Pointer, Api.allnet_WiFiUnit_getFirmVersion));

		//public bool IsServerAlive => Api.Call(Pointer, Api.allnet_WiFiUnit_isServerAlive);

		//public string ServerAliveText => Marshal.PtrToStringUni(Api.Call(Pointer, Api.allnet_WiFiUnit_getServerAliveText));

		//public int AccessCount => Api.Call(Pointer, Api.allnet_WiFiUnit_getAccessCount);

		//public string MasterSerial => Marshal.PtrToStringUni(Api.Call(Pointer, Api.allnet_WiFiUnit_getMasterSerial));

		internal WiFiUnit(IntPtr pointer)
		{
			Pointer = pointer;
		}
	}
}
