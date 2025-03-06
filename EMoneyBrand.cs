using System;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	public sealed class EMoneyBrand
	{
		//public static readonly int MaxNameLength = Api.MaxEMoneyBrandNameLength_get();

		private IntPtr Pointer { get; set; }

		public EMoneyBrandId Id => EMoneyBrandId.Edy;// Api.Call(Pointer, Api.EMoneyBrand_getId);

		public string Name => ""; // Marshal.PtrToStringUni(Api.Call(Pointer, Api.EMoneyBrand_getName));

		//public string IconFilePath => "" Marshal.PtrToStringUni(Api.Call(Pointer, Api.EMoneyBrand_getIconFilePath));

		public bool HasBalance => true; // Api.Call(Pointer, Api.EMoneyBrand_hasBalance);

		internal EMoneyBrand(IntPtr pointer)
		{
			Pointer = pointer;
		}
	}
}
