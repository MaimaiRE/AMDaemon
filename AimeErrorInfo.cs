using System;

namespace AMDaemon
{
	public sealed class AimeErrorInfo : ErrorInfo
	{
		private IntPtr Pointer { get; set; }

		public AimeErrorId Id => AimeErrorId.None; // Api.Call(Pointer, Api.AimeErrorInfo_getId);

		public AimeErrorCategory Category => AimeErrorCategory.None; // Api.Call(Pointer, Api.AimeErrorInfo_getCategory);

		internal AimeErrorInfo(IntPtr pointer)
			: base(IntPtr.Zero)
		{
			Pointer = pointer;
		}
	}
}
