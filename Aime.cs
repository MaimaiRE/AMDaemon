using System;
using System.Diagnostics;

namespace AMDaemon
{
	public static class Aime
	{
		public static readonly int CampaignCountLimit;

		private static AimeId RequestCampaignProgressAimeIdCache;

		private static RequestState RequestCampaignProgressStateCache;

		private static AimeId CampaignProgressesAimeIdCache;

		private static LazyCollection<AimeCampaignProgress> CampaignProgressesCache;

		//public static bool IsAvailable => Api.Aime_isAvailable();

		public static bool IsFirmUpdating => false; // Api.Aime_isFirmUpdating();

		public static float FirmUpdateProgress => 0.0f;// Api.Aime_getFirmUpdateProgress();

		public static bool IsDBAlive => true; // Api.Aime_isDBAlive();

		public static int UnitCount => Units.Count;

		public static LazyCollection<AimeUnit> Units { get; private set; }

		public static RequestState LastSendLogState { get; private set; }

		public static LazyCollection<AimeCampaignInfo> CampaignInfos { get; private set; }

		static Aime()
		{
			// CampaignCountLimit = Api.AimeCampaignCountLimit_get();
			RequestCampaignProgressAimeIdCache = AimeId.Invalid;
			RequestCampaignProgressStateCache = null;
			CampaignProgressesAimeIdCache = AimeId.Invalid;
			CampaignProgressesCache = null;
			Units = new LazyCollection<AimeUnit>(()=>1, (int index) => new AimeUnit(IntPtr.Zero));
            CampaignInfos = new LazyCollection<AimeCampaignInfo>(()=>0, (int index) => new AimeCampaignInfo(IntPtr.Zero));
        }

		public static bool SendLog(AimeId aimeId, AimeLogStatus status)
		{
			return SendLogWithCredit(aimeId, status, 0u);
		}

		public static bool SendLog(AimeId aimeId, AimeLogStatus status, int gameCostIndex)
		{
			return SendLog(aimeId, status, gameCostIndex, 1);
		}

		public static bool SendLog(AimeId aimeId, AimeLogStatus status, int gameCostIndex, int gameCostCount)
		{
			//IntPtr intPtr = Api.Call(() => Api.Aime_sendLog(aimeId.Value, status, gameCostIndex, gameCostCount));
			//if (intPtr == IntPtr.Zero)
			//{
			//	return false;
			//}
			//LastSendLogState = RequestState.ReplaceOrCreate(LastSendLogState, intPtr);
			AMDebugger.Trace($"SendLog: {aimeId}, {status}, {gameCostIndex}, {gameCostCount}");
            return true;
		}

		public static bool SendLogWithCredit(AimeId aimeId, AimeLogStatus status, uint credit)
		{
            //IntPtr intPtr = Api.Call(() => Api.Aime_sendLogWithCredit(aimeId.Value, status, credit));
            //if (intPtr == IntPtr.Zero)
            //{
            //	return false;
            //}
            //LastSendLogState = RequestState.ReplaceOrCreate(LastSendLogState, intPtr);
            AMDebugger.Trace($"SendLogWithCredit: {aimeId}, {status}, {credit}");
            return true;
		}

		//public static bool RequestCampaignProgress(AimeId aimeId)
		//{
		//	return Api.Call(aimeId.Value, Api.Aime_requestCampaignProgress) != IntPtr.Zero;
		//}

		//public static RequestState GetLastRequestCampaignProgressState(AimeId aimeId)
		//{
		//	IntPtr intPtr = Api.Call(aimeId.Value, Api.Aime_requestCampaignProgress_lastResult);
		//	if (intPtr == IntPtr.Zero)
		//	{
		//		return null;
		//	}
		//	if (RequestCampaignProgressAimeIdCache == aimeId)
		//	{
		//		RequestCampaignProgressStateCache = RequestState.ReplaceOrCreate(RequestCampaignProgressStateCache, intPtr);
		//	}
		//	else
		//	{
		//		RequestCampaignProgressAimeIdCache = aimeId;
		//		RequestCampaignProgressStateCache = new RequestState(intPtr);
		//	}
		//	return RequestCampaignProgressStateCache;
		//}

		//public static LazyCollection<AimeCampaignProgress> GetCampaignProgresses(AimeId aimeId)
		//{
		//	if (CampaignProgressesAimeIdCache != aimeId || CampaignProgressesCache == null)
		//	{
		//		CampaignProgressesAimeIdCache = aimeId;
		//		CampaignProgressesCache = new LazyCollection<AimeCampaignProgress>(() => Api.Call(aimeId.Value, Api.Aime_getCampaignProgressCount), (int index) => new AimeCampaignProgress(Api.Call(aimeId.Value, index, Api.Aime_getCampaignProgress)), false);
		//	}
		//	return CampaignProgressesCache;
		//}
	}
}
