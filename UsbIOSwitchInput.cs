using System;

namespace AMDaemon
{
	public sealed class UsbIOSwitchInput
	{
		//public static readonly int MaxPlayerBitCount = Api.UsbIOSwitchInput_MaxPlayerBitCount_get();

		//private IntPtr Pointer { get; set; }

		//public bool IsTestOn => Api.Call(Pointer, Api.UsbIOSwitchInput_isTestOn);

		//public bool IsTiltOn => Api.Call(Pointer, Api.UsbIOSwitchInput_isTiltOn);

		//public int PlayerCount => PlayersBits.Count;

		//public LazyCollection<BitSet> PlayersBits { get; private set; }

		//internal UsbIOSwitchInput(IntPtr pointer)
		//{
		//	Pointer = pointer;
		//	PlayersBits = new LazyCollection<BitSet>(() => Api.Call(pointer, Api.UsbIOSwitchInput_getPlayerCount), (int index) => new BitSet(MaxPlayerBitCount, Api.Call(pointer, index, Api.UsbIOSwitchInput_getPlayerBits)), false);
		//}

		//public byte GetTestFlipCount(bool toOn)
		//{
		//	return Api.UsbIOSwitchInput_getTestFlipCount(Pointer, toOn);
		//}

		//public byte GetTiltFlipCount(bool toOn)
		//{
		//	return Api.UsbIOSwitchInput_getTiltFlipCount(Pointer, toOn);
		//}

		//public bool IsPlayerOn(int playerIndex, int bitIndex)
		//{
		//	return Api.Call(() => Api.UsbIOSwitchInput_isPlayerOn(Pointer, playerIndex, bitIndex));
		//}

		//public byte GetPlayerFlipCount(int playerIndex, int bitIndex, bool toOn)
		//{
		//	return Api.Call(() => Api.UsbIOSwitchInput_getPlayerFlipCount(Pointer, playerIndex, bitIndex, toOn));
		//}
	}
}
