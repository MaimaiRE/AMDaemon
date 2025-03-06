using System;

namespace AMDaemon
{
	public sealed class JvsGeneralOutput
	{
		//public static readonly int MaxBitCount = Api.JvsGeneralOutput_MaxBitCount_get();

		private IntPtr Pointer { get; set; }

		//public BitSet CurrentBits => new BitSet(MaxBitCount, Api.Call(Pointer, Api.JvsGeneralOutput_getCurrentBits));

		internal JvsGeneralOutput(IntPtr pointer)
		{
			Pointer = pointer;
		}

		//public void SetBits(ulong bits)
		//{
		//	SetBits(bits, false);
		//}

		//public void SetBits(ulong bits, bool forceUpdate)
		//{
		//	Api.CallAction(delegate
		//	{
		//		Api.JvsGeneralOutput_setBits(Pointer, bits, forceUpdate);
		//	});
		//}

		//public void SetBits(BitSet bits)
		//{
		//	SetBits(bits, false);
		//}

		//public void SetBits(BitSet bits, bool forceUpdate)
		//{
		//	SetBits(bits.Value, forceUpdate);
		//}

		//public void ResetBits()
		//{
		//	ResetBits(false);
		//}

		//public void ResetBits(bool forceUpdate)
		//{
		//	Api.CallAction(Pointer, forceUpdate, Api.JvsGeneralOutput_resetBits);
		//}

		//public void SetBit(int bitIndex, bool on)
		//{
		//	SetBit(bitIndex, on, false);
		//}

		//public void SetBit(int bitIndex, bool on, bool forceUpdate)
		//{
		//	Api.CallAction(delegate
		//	{
		//		Api.JvsGeneralOutput_setBit(Pointer, bitIndex, on, forceUpdate);
		//	});
		//}
	}
}
