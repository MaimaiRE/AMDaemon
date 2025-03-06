using System;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	public sealed class EMoneyResult
	{
		//public static readonly int MaxDealNumberLength = Api.MaxEMoneyDealNumberLength_get();

		//public static readonly int MaxCardNumberLength = Api.MaxEMoneyCardNumberLength_get();

		//private IntPtr Pointer { get; set; }

		//public bool IsValid => Api.Call(Pointer, Api.EMoneyResult_valid);

		public EMoneyResultStatus Status => EMoneyResultStatus.Success;

		public DateTime Time => InnerUtil.MakeDateTime(0, DateTimeKind.Local);

		public EMoneyBrand Brand { get; private set; }

		public string DealNumber => "";// Marshal.PtrToStringUni(Api.Call(Pointer, Api.EMoneyResult_getDealNumber));

		public string CardNumber => "" ;// Marshal.PtrToStringUni(Api.Call(Pointer, Api.EMoneyResult_getCardNumber));

		public int Amount => 0;// Api.Call(Pointer, Api.EMoneyResult_getAmount);

		public int BalanceBefore => 0;// Api.Call(Pointer, Api.EMoneyResult_getBalanceBefore);

		public int BalanceAfter => 0; // Api.Call(Pointer, Api.EMoneyResult_getBalanceAfter);

		//internal EMoneyResult(IntPtr pointer)
		//{
		//	Pointer = pointer;
		//	Brand = new EMoneyBrand(Api.Call(pointer, Api.EMoneyResult_getBrand));
		//}
	}
}
