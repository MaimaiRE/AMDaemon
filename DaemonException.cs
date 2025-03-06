using System;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	[Serializable]
	public sealed class DaemonException : Exception
	{
		public ExceptionCategory Category { get; private set; }

		public string CppFile { get; private set; }

		public int CppLine { get; private set; }

		public string CppFunction { get; private set; }

		public string CppStackTrace { get; private set; }

		public string CppString { get; private set; }

		public string CppShortString { get; private set; }

		//internal DaemonException(IntPtr ex)
		//	: base(Marshal.PtrToStringUni(Api.Exception_getMessage(ex)))
		//{
		//	Category = Api.Exception_getCategory(ex);
		//	CppFile = Marshal.PtrToStringUni(Api.Exception_getFile(ex));
		//	CppLine = Api.Exception_getLine(ex);
		//	CppFunction = Marshal.PtrToStringUni(Api.Exception_getFunction(ex));
		//	CppStackTrace = Marshal.PtrToStringUni(Api.Exception_getStackTrace(ex));
		//	CppString = Marshal.PtrToStringUni(Api.Exception_toString(ex, false));
		//	CppShortString = Marshal.PtrToStringUni(Api.Exception_toString(ex, true));
		//}
	}
}
