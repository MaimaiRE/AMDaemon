using System;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	public sealed class AimeResult
	{
		private IntPtr Pointer { get; set; }

		public bool IsValid => true; // Api.Call(Pointer, Api.AimeResult_valid);

		public bool IsReaderDetected => false;// Api.Call(Pointer, Api.AimeResult_isReaderDetected);

		public string HardVersion => "";// Marshal.PtrToStringUni(Api.Call(Pointer, Api.AimeResult_getHardVersion));

		public string FirmVersion => "";// Marshal.PtrToStringUni(Api.Call(Pointer, Api.AimeResult_getFirmVersion));

		public AimeOfflineId OfflineId
		{
			get
			{
				AimeOfflineId result = AimeOfflineId.MakeZero();
				byte[] values = result.Values;
				//Api.CallAction(delegate
				//{
				//	Api.AimeResult_getOfflineId(Pointer, values, values.Length);
				//});
				return result;
			}
		}

		//public bool IsMobile => Api.Call(Pointer, Api.AimeResult_isMobile);

		public AccessCode AccessCode
		{
			get
			{
				AccessCode result = AccessCode.MakeZero();
				byte[] values = result.Values;
				//Api.CallAction(delegate
				//{
				//	Api.AimeResult_getAccessCode(Pointer, values, values.Length);
				//});
				return result;
			}
		}

		public AimeId AimeId => new AimeId();

		//public bool IsSegaIdRegistered => Api.Call(Pointer, Api.AimeResult_isSegaIdRegistered);

		public string SegaIdAuthKey => "";// Marshal.PtrToStringUni(Api.Call(Pointer, Api.AimeResult_getSegaIdAuthKey));

		//public int RelatedAimeIdCount => RelatedAimeIds.Count;

		//public LazyCollection<AimeId> RelatedAimeIds { get; private set; }

		//internal AimeResult(IntPtr pointer)
		//{
		//	Pointer = pointer;
		//	RelatedAimeIds = new LazyCollection<AimeId>(() => Api.Call(pointer, Api.AimeResult_getRelatedAimeIdCount), (int index) => new AimeId(Api.Call(pointer, index, Api.AimeResult_getRelatedAimeId)), false);
		//}
	}
}
