using System;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	public class AimePayLocationInfo
	{
		private IntPtr Pointer { get; set; }

		//public bool IsValid => Api.Call(Pointer, Api.AimePayLocationInfo_valid);

		//public string Name => Marshal.PtrToStringUni(Api.Call(Pointer, Api.AimePayLocationInfo_getName));

		//public string CompanyName => Marshal.PtrToStringUni(Api.Call(Pointer, Api.AimePayLocationInfo_getCompanyName));

		internal AimePayLocationInfo(IntPtr pointer)
		{
			Pointer = pointer;
		}
	}
}
