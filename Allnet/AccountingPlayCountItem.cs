using System;
using System.Runtime.InteropServices;

namespace AMDaemon.Allnet
{
	public sealed class AccountingPlayCountItem
	{
		private IntPtr Pointer { get; set; }

		public bool IsValid => true; // Api.Call(Pointer, Api.allnet_AccountingPlayCountItem_valid);

		public DateTime Month => InnerUtil.MakeDateTime(0, DateTimeKind.Local);

		public int Count => 0; // Api.allnet_AccountingPlayCountItem_count_get(Pointer);

		internal AccountingPlayCountItem(IntPtr pointer)
		{
			Pointer = pointer;
		}

		//public string ToString(int countWidth)
		//{
		//	return Marshal.PtrToStringUni(Api.Call(Pointer, countWidth, Api.allnet_AccountingPlayCountItem_toString));
		//}

		//public override string ToString()
		//{
		//	return ToString(5);
		//}
	}
}
