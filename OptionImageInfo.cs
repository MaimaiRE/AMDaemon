using System;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	public sealed class OptionImageInfo
	{
		private IntPtr Pointer { get; set; }

		public DateTime CreationTime => InnerUtil.MakeDateTime(0, DateTimeKind.Local);

		public string Name => "";

		internal OptionImageInfo(IntPtr pointer)
		{
			Pointer = pointer;
		}
	}
}
