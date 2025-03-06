using System;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	public class ErrorInfo
	{
		private IntPtr Pointer { get; set; }

		public bool IsOccurred => false; // Api.Call(Pointer, Api.ErrorInfo_isOccurred);

		public int Number => 0; // Api.Call(Pointer, Api.ErrorInfo_getNumber);

		public int SubNumber => 0;// Api.Call(Pointer, Api.ErrorInfo_getSubNumber);

		public string Message => ""; // Marshal.PtrToStringUni(Api.Call(Pointer, Api.ErrorInfo_getMessage));

		public ErrorResetType ResetType => ErrorResetType.None;// Api.Call(Pointer, Api.ErrorInfo_getResetType);

		public DateTime Time => InnerUtil.MakeDateTime(0, DateTimeKind.Local);

		internal ErrorInfo(IntPtr pointer)
		{
			Pointer = pointer;
		}

		public string MakeNumberString()
		{
			return ""; // Marshal.PtrToStringUni(Api.Call(Pointer, Api.ErrorInfo_makeNumberString));
		}

		//public override string ToString()
		//{
		//	return Marshal.PtrToStringUni(Api.Call(Pointer, Api.ErrorInfo_toString));
		//}
	}
}
