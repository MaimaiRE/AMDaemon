using System;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	public sealed class EMoneySound
	{
		public bool IsStopRequired => FilePath == null;

		public string Id { get; private set; }

		public string FilePath { get; private set; }

		internal EMoneySound(IntPtr id, IntPtr filePath)
		{
			Id = ((id == IntPtr.Zero) ? null : Marshal.PtrToStringUni(id));
			FilePath = ((filePath == IntPtr.Zero) ? null : Marshal.PtrToStringUni(filePath));
		}
	}
}
