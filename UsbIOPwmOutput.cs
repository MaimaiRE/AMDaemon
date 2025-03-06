using System;

namespace AMDaemon
{
	public sealed class UsbIOPwmOutput
	{
		//private byte[] currentDutiesCache;

		//private IntPtr Pointer { get; set; }

		//public int SlotCount => Api.Call(Pointer, Api.UsbIOPwmOutput_getSlotCount);

		//public RequestState LastState { get; private set; }

		//internal UsbIOPwmOutput(IntPtr pointer)
		//{
		//	Pointer = pointer;
		//	LastState = null;
		//}

		//public bool SetDuties(byte[] duties, int slotCount)
		//{
		//	return SetDuties(duties, slotCount, false);
		//}

		//public bool SetDuties(byte[] duties)
		//{
		//	return SetDuties(duties, false);
		//}

		//public bool SetDuties(byte[] duties, int slotCount, bool forceUpdate)
		//{
		//	IntPtr intPtr = Api.Call(() => Api.UsbIOPwmOutput_setDuties(Pointer, duties, slotCount, forceUpdate));
		//	if (intPtr == IntPtr.Zero)
		//	{
		//		return false;
		//	}
		//	LastState = RequestState.ReplaceOrCreate(LastState, intPtr);
		//	return true;
		//}

		//public bool SetDuties(byte[] duties, bool forceUpdate)
		//{
		//	return SetDuties(duties, (duties != null) ? duties.Length : 0, forceUpdate);
		//}

		//public bool ResetDuties()
		//{
		//	return ResetDuties(false);
		//}

		//public bool ResetDuties(bool forceUpdate)
		//{
		//	IntPtr intPtr = Api.Call(Pointer, forceUpdate, Api.UsbIOPwmOutput_resetDuties);
		//	if (intPtr == IntPtr.Zero)
		//	{
		//		return false;
		//	}
		//	LastState = RequestState.ReplaceOrCreate(LastState, intPtr);
		//	return true;
		//}

		//public bool SetDuty(int slotIndex, byte duty)
		//{
		//	return SetDuty(slotIndex, duty, false);
		//}

		//public bool SetDuty(int slotIndex, byte duty, bool forceUpdate)
		//{
		//	IntPtr intPtr = Api.Call(() => Api.UsbIOPwmOutput_setDuty(Pointer, slotIndex, duty, forceUpdate));
		//	if (intPtr == IntPtr.Zero)
		//	{
		//		return false;
		//	}
		//	LastState = RequestState.ReplaceOrCreate(LastState, intPtr);
		//	return true;
		//}

		//public byte[] GetCurrentDuties()
		//{
		//	byte[] duties = InnerUtil.ResizeArrayCache(ref currentDutiesCache, SlotCount);
		//	Api.Call(() => Api.UsbIOPwmOutput_getCurrentDuties(Pointer, duties, duties.Length));
		//	return duties;
		//}

		//public byte GetCurrentDuty(int slotIndex)
		//{
		//	return Api.Call(Pointer, slotIndex, Api.UsbIOPwmOutput_getCurrentDuty);
		//}
	}
}
