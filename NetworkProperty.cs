using System;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	public sealed class NetworkProperty
	{
		private IntPtr Pointer { get; set; }

		//public bool IsValid => Api.Call(Pointer, Api.NetworkProperty_valid);

		//public bool IsDhcpEnabled => Api.Call(Pointer, Api.NetworkProperty_isDhcpEnabled);

		public string Address => "127.0.0.1"; // Marshal.PtrToStringUni(Api.Call(Pointer, Api.NetworkProperty_getAddress));

		public string SubnetMask => "255.255.255.0";// Marshal.PtrToStringUni(Api.Call(Pointer, Api.NetworkProperty_getSubnetMask));

		public string Gateway => "127.0.0.1";// Marshal.PtrToStringUni(Api.Call(Pointer, Api.NetworkProperty_getGateway));

		//public string PrimaryDns => Marshal.PtrToStringUni(Api.Call(Pointer, Api.NetworkProperty_getPrimaryDns));

		//public string SecondaryDns => Marshal.PtrToStringUni(Api.Call(Pointer, Api.NetworkProperty_getSecondaryDns));

		internal NetworkProperty(IntPtr pointer)
		{
			Pointer = pointer;
		}
	}
}
