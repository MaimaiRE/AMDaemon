using System;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	public class AimePayDealResult
	{
		//public static readonly int MaxErrorCodeLength = Api.MaxAimePayErrorCodeLength_get();

		//public static readonly int MaxItemIdLength = Api.MaxAimePayItemIdLength_get();

		private IntPtr Pointer { get; set; }

		//public bool IsValid => Api.Call(Pointer, Api.AimePayDealResult_valid);

		//public AimePayDealResultStatus Status => Api.Call(Pointer, Api.AimePayDealResult_getStatus);

		//public DateTime Time => InnerUtil.MakeDateTime(Api.Call(Pointer, Api.AimePayDealResult_getTime), DateTimeKind.Local);

		//public string ErrorCode => Marshal.PtrToStringUni(Api.Call(Pointer, Api.AimePayDealResult_getErrorCode));

		//public AccessCode AccessCode
		//{
		//	get
		//	{
		//		AccessCode result = AccessCode.MakeZero();
		//		byte[] values = result.Values;
		//		Api.CallAction(delegate
		//		{
		//			Api.AimePayDealResult_getAccessCode(Pointer, values, values.Length);
		//		});
		//		return result;
		//	}
		//}

		//public string ItemId => Marshal.PtrToStringUni(Api.Call(Pointer, Api.AimePayDealResult_getItemId));

		//public uint ItemCount => Api.Call(Pointer, Api.AimePayDealResult_getItemCount);

		//public int Amount => Api.Call(Pointer, Api.AimePayDealResult_getAmount);

		//public ulong ReceiptId => Api.Call(Pointer, Api.AimePayDealResult_getReceiptId);

		internal AimePayDealResult(IntPtr pointer)
		{
			Pointer = pointer;
		}
	}
}
