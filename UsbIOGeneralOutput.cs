using System;

namespace AMDaemon
{
	public sealed class UsbIOGeneralOutput
	{
		//public static readonly int MaxBitCount = Api.UsbIOGeneralOutput_MaxBitCount_get();

		//private IntPtr Pointer { get; set; }

		//public RequestState LastState { get; private set; }

		//public BitSet CurrentBits => new BitSet(MaxBitCount, Api.Call(Pointer, Api.UsbIOGeneralOutput_getCurrentBits));

		//internal UsbIOGeneralOutput(IntPtr pointer)
		//{
		//	Pointer = pointer;
		//	LastState = null;
		//}

		//public bool SetBits(ulong bits)
		//{
		//	return SetBits(bits, false);
		//}

		//public bool SetBits(ulong bits, bool forceUpdate)
		//{
		//	IntPtr intPtr = Api.Call(() => Api.UsbIOGeneralOutput_setBits(Pointer, bits, forceUpdate));
		//	if (intPtr == IntPtr.Zero)
		//	{
		//		return false;
		//	}
		//	LastState = RequestState.ReplaceOrCreate(LastState, intPtr);
		//	return true;
		//}

		//public bool SetBits(BitSet bits)
		//{
		//	return SetBits(bits, false);
		//}

		//public bool SetBits(BitSet bits, bool forceUpdate)
		//{
		//	return SetBits(bits.Value, forceUpdate);
		//}

		//public bool ResetBits()
		//{
		//	return ResetBits(false);
		//}

		//public bool ResetBits(bool forceUpdate)
		//{
		//	IntPtr intPtr = Api.Call(Pointer, forceUpdate, Api.UsbIOGeneralOutput_resetBits);
		//	if (intPtr == IntPtr.Zero)
		//	{
		//		return false;
		//	}
		//	LastState = RequestState.ReplaceOrCreate(LastState, intPtr);
		//	return true;
		//}

		//public bool SetBit(int bitIndex, bool on)
		//{
		//	return SetBit(bitIndex, on, false);
		//}

		//public bool SetBit(int bitIndex, bool on, bool forceUpdate)
		//{
		//	IntPtr intPtr = Api.Call(() => Api.UsbIOGeneralOutput_setBit(Pointer, bitIndex, on, forceUpdate));
		//	if (intPtr == IntPtr.Zero)
		//	{
		//		return false;
		//	}
		//	LastState = RequestState.ReplaceOrCreate(LastState, intPtr);
		//	return true;
		//}
	}
}
