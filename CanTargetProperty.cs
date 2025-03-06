using System;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	public sealed class CanTargetProperty
	{
		private IntPtr Pointer { get; set; }

		//public bool IsValid => Api.Call(Pointer, Api.CanTargetProperty_valid);

		//public CanTargetType Type => Api.Call(Pointer, Api.CanTargetProperty_getType);

		//public ushort Id => Api.Call(Pointer, Api.CanTargetProperty_getId);

		//public string Product => Marshal.PtrToStringUni(Api.Call(Pointer, Api.CanTargetProperty_getProduct));

		//public string CustomChip => Marshal.PtrToStringUni(Api.Call(Pointer, Api.CanTargetProperty_getCustomChip));

		//public ushort FirmRevision => Api.Call(Pointer, Api.CanTargetProperty_getFirmRevision);

		//public ushort FirmSum => Api.Call(Pointer, Api.CanTargetProperty_getFirmSum);

		internal CanTargetProperty(IntPtr pointer)
		{
			Pointer = pointer;
		}
	}
}
