	
using System;
using Logger = AMDaemon.Debug.Logger;
namespace AMDaemon
{
	public sealed class CreditSpecialDevice
	{
		//private IntPtr Pointer { get; set; }

		//public bool IsAvailable => Api.Call(Pointer, Api.CreditSpecialDevice_isAvailable);

		//public bool IsLockoutOn => Api.Call(Pointer, Api.CreditSpecialDevice_isLockoutOn);

		//internal CreditSpecialDevice(IntPtr pointer)
		//{
		//	Pointer = pointer;
		//}

		public bool Lockout(bool on)
		{
			//Logger.Trace($"on={on}");
			return true;
			// return Api.Call(Pointer, on, Api.CreditSpecialDevice_lockout);
		}
	}
}
