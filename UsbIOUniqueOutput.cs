using System;
using CardMakerRE;
namespace AMDaemon
{
	public sealed class UsbIOUniqueOutput
	{
		//public static readonly int MaxDataSize = Api.UsbIOUniqueOutput_MaxDataSize_get();

		//private readonly byte[][] currentCaches = new byte[256][];

		//private IntPtr Pointer { get; set; }

		//public RequestState LastState { get; private set; }

		//internal UsbIOUniqueOutput(IntPtr pointer)
		//{
		//	Pointer = pointer;
		//	LastState = null;
		//}

		//public bool IsSupported(byte command)
		//{
		//	return Api.Call(Pointer, command, Api.UsbIOUniqueOutput_isSupported);
		//}

		public bool Set(byte command, byte[] data, int dataSize)
		{
			Logger.Trace($"{command} {data} {dataSize}");
			return true;
		}

		public bool Set(byte command, byte[] data)
		{
			return Set(command, data, (data != null) ? data.Length : 0);
		}

		public bool Set(byte command)
		{
			return Set(command, null, 0);
		}

		//public byte[] GetCurrent(byte command)
		//{
		//	byte[] cache = currentCaches[command];
		//	if (cache == null)
		//	{
		//		cache = new byte[MaxDataSize];
		//		currentCaches[command] = cache;
		//	}
		//	Api.Call(() => Api.UsbIOUniqueOutput_getCurrent(Pointer, command, cache, cache.Length));
		//	return cache;
		//}
	}
}
