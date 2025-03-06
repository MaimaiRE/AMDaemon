using System;

namespace AMDaemon
{
	public sealed class UsbIOUniqueInput
	{
		//public static readonly int RawDataSize = Api.UsbIOUniqueInput_RawDataSize_get();

		//private readonly byte[][] dataCache = new byte[256][];

		//private static readonly byte[] BlankData = new byte[0];

		//private readonly byte[] rawDataCache = new byte[RawDataSize];

		//private IntPtr Pointer { get; set; }

		//internal UsbIOUniqueInput(IntPtr pointer)
		//{
		//	Pointer = pointer;
		//}

		//public bool IsSupported(byte command)
		//{
		//	return Api.Call(Pointer, command, Api.UsbIOUniqueInput_isSupported);
		//}

		//public byte[] Get(byte command)
		//{
		//	int num = Api.Call(Pointer, command, Api.UsbIOUniqueInput_get_dataSize);
		//	if (num < 0)
		//	{
		//		return null;
		//	}
		//	byte[] data = InnerUtil.ResizeArrayCache(ref dataCache[command], num);
		//	if (num > 0)
		//	{
		//		num = Api.Call(() => Api.UsbIOUniqueInput_get(Pointer, command, data, data.Length));
		//	}
		//	if (num >= 0)
		//	{
		//		return data;
		//	}
		//	return null;
		//}

		//public byte[] GetRaw()
		//{
		//	if (Api.Call(() => Api.UsbIOUniqueInput_getRaw(Pointer, rawDataCache, rawDataCache.Length)) >= 0)
		//	{
		//		return rawDataCache;
		//	}
		//	return null;
		//}
	}
}
