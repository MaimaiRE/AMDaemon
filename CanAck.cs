using System;

namespace AMDaemon
{
	public sealed class CanAck
	{
		private byte[] dataCache;

		private IntPtr Pointer { get; set; }

		//public bool IsExists => Api.Call(Pointer, Api.CanAck_exists);

		//public byte Command => Api.Call(Pointer, Api.CanAck_getCommand);

		//public bool IsError => Api.Call(Pointer, Api.CanAck_isError);

		//public CanErrorReport ErrorReport => Api.Call(Pointer, Api.CanAck_getErrorReport);

		//public int DataSize => Api.Call(Pointer, Api.CanAck_getDataSize);

		internal CanAck(IntPtr pointer)
		{
			Pointer = pointer;
		}

		//public byte[] GetData()
		//{
		//	byte[] data = InnerUtil.ResizeArrayCache(ref dataCache, DataSize);
		//	if (Api.Call(() => Api.CanAck_getData(Pointer, data, data.Length)) >= 0)
		//	{
		//		return data;
		//	}
		//	return null;
		//}
	}
}
