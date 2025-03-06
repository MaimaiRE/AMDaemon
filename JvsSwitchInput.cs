using System;

namespace AMDaemon
{
	public sealed class JvsSwitchInput
	{
		//public static readonly int MaxSystemBitCount = Api.JvsSwitchInput_MaxSystemBitCount_get();

		//public static readonly int MaxPlayerBitCount = Api.JvsSwitchInput_MaxPlayerBitCount_get();

		//private IntPtr Pointer { get; set; }

		//public BitSet SystemBits => new BitSet(MaxSystemBitCount, Api.Call(Pointer, Api.JvsSwitchInput_getSystemBits));

		//public int PlayerCount => PlayersBits.Count;

		//public LazyCollection<BitSet> PlayersBits { get; private set; }

		//internal JvsSwitchInput(IntPtr pointer)
		//{
		//	Pointer = pointer;
		//	PlayersBits = new LazyCollection<BitSet>(() => Api.Call(pointer, Api.JvsSwitchInput_getPlayerCount), (int index) => new BitSet(MaxPlayerBitCount, Api.Call(pointer, index, Api.JvsSwitchInput_getPlayerBits)), false);
		//}

		//public bool IsSystemOn(int bitIndex)
		//{
		//	return Api.Call(Pointer, bitIndex, Api.JvsSwitchInput_isSystemOn);
		//}

		//public byte GetSystemFlipCount(int bitIndex, bool toOn)
		//{
		//	return Api.Call(() => Api.JvsSwitchInput_getSystemFlipCount(Pointer, bitIndex, toOn));
		//}

		//public bool IsPlayerOn(int playerIndex, int bitIndex)
		//{
		//	return Api.Call(() => Api.JvsSwitchInput_isPlayerOn(Pointer, playerIndex, bitIndex));
		//}

		//public byte GetPlayerFlipCount(int playerIndex, int bitIndex, bool toOn)
		//{
		//	return Api.Call(() => Api.JvsSwitchInput_getPlayerFlipCount(Pointer, playerIndex, bitIndex, toOn));
		//}
	}
}
