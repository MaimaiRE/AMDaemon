using System;
using System.Runtime.InteropServices;
using AMDaemon.Allnet;

namespace AMDaemon
{
	internal static class Api
	{
		public delegate TResult RefFunc<TRef, TResult>(ref TRef arg);

		public delegate void RefAction<TRef>(ref TRef arg);

		public struct BackupRecord
		{
			public IntPtr Address;

			public IntPtr Size;

			public BackupDevice Device;
		}

		static Api()
		{
			//Core_setExceptionHook_register();
		}

		public static TResult Call<TResult>(Func<TResult> func)
		{
			try
			{
				return func();
			}
			finally
			{
				CheckException();
			}
		}

		public static TResult Call<T, TResult>(T arg, Func<T, TResult> func)
		{
			try
			{
				return func(arg);
			}
			finally
			{
				CheckException();
			}
		}

		public static TResult Call<T1, T2, TResult>(T1 arg1, T2 arg2, Func<T1, T2, TResult> func)
		{
			try
			{
				return func(arg1, arg2);
			}
			finally
			{
				CheckException();
			}
		}

		public static TResult Call<TRef, TResult>(ref TRef arg, RefFunc<TRef, TResult> func)
		{
			try
			{
				return func(ref arg);
			}
			finally
			{
				CheckException();
			}
		}

		public static void CallAction(Action action)
		{
			try
			{
				action();
			}
			finally
			{
				CheckException();
			}
		}

		public static void CallAction<T>(T arg, Action<T> action)
		{
			try
			{
				action(arg);
			}
			finally
			{
				CheckException();
			}
		}

		public static void CallAction<T1, T2>(T1 arg1, T2 arg2, Action<T1, T2> action)
		{
			try
			{
				action(arg1, arg2);
			}
			finally
			{
				CheckException();
			}
		}

		public static void CallAction<TRef>(ref TRef arg, RefAction<TRef> action)
		{
			try
			{
				action(ref arg);
			}
			finally
			{
				CheckException();
			}
		}

		private static void CheckException()
		{
			//int num = Core_setExceptionHook_count();
			//if (num <= 0)
			//{
			//	return;
			//}
			//try
			//{
			//	if (Core.ExceptionHook == null)
			//	{
			//		throw new DaemonException(Core_setExceptionHook_check());
			//	}
			//	DaemonException[] array = new DaemonException[num];
			//	for (int i = 0; i < num; i++)
			//	{
			//		array[i] = new DaemonException(Core_setExceptionHook_check());
			//		Core_setExceptionHook_done(false);
			//	}
			//	DaemonException[] array2 = array;
			//	DaemonException[] array3 = array2;
			//	foreach (DaemonException obj in array3)
			//	{
			//		Core.ExceptionHook(obj);
			//	}
			//}
			//finally
			//{
			//	Core_setExceptionHook_done(true);
			//}
		}

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Core_getLibraryVersion();

		//[DllImport("amdaemon_api")]
		//public static extern void Core_execute();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Core_isReady();

		//[DllImport("amdaemon_api")]
		//public static extern void Core_kill(NextProcess nextProcess);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Core_isExited();

		//[DllImport("amdaemon_api")]
		//public static extern int Core_getPlayerCount();

		//[DllImport("amdaemon_api")]
		//public static extern void Core_setExceptionHook_register();

		//[DllImport("amdaemon_api")]
		//public static extern int Core_setExceptionHook_count();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Core_setExceptionHook_check();

		//[DllImport("amdaemon_api")]
		//public static extern void Core_setExceptionHook_done([MarshalAs(UnmanagedType.U1)] bool all);

		//[DllImport("amdaemon_api")]
		//public static extern void Core_resetExceptionHook();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Core_getLanguage();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Core_changeLanguage([MarshalAs(UnmanagedType.LPWStr)] string language);

		//[DllImport("amdaemon_api")]
		//public static extern void Core_reboot();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Core_preloadDataSection();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool abaas_Log_isAvailable();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr abaas_Log_getRootPath();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool abaas_Log_isServerAlive();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool abaas_Log_isUploading();

		//[DllImport("amdaemon_api")]
		//public static extern int abaas_Log_getUploadingFileCount();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool abaas_Log_putErrorMessage([MarshalAs(UnmanagedType.LPWStr)] string message);

		//[DllImport("amdaemon_api")]
		//public static extern int AimeCampaignCountLimit_get();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Aime_isAvailable();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Aime_isFirmUpdating();

		//[DllImport("amdaemon_api")]
		//public static extern float Aime_getFirmUpdateProgress();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Aime_isDBAlive();

		//[DllImport("amdaemon_api")]
		//public static extern int Aime_getUnitCount();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Aime_getUnit(int unitIndex);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Aime_sendLog(uint aimeId, AimeLogStatus status, int gameCostIndex, int gameCostCount);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Aime_sendLogWithCredit(uint aimeId, AimeLogStatus status, uint credit);

		//[DllImport("amdaemon_api")]
		//public static extern int Aime_getCampaignInfoCount();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Aime_getCampaignInfo(int index);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Aime_requestCampaignProgress(uint aimeId);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Aime_requestCampaignProgress_lastResult(uint aimeId);

		//[DllImport("amdaemon_api")]
		//public static extern int Aime_getCampaignProgressCount(uint aimeId);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Aime_getCampaignProgress(uint aimeId, int index);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeUnit_canStart(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeUnit_start(IntPtr unit, AimeCommand command);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeUnit_cancel(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeUnit_isBusy(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern AimeCommand AimeUnit_getBusyCommand(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeUnit_hasConfirm(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern AimeConfirm AimeUnit_getConfirm(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeUnit_acceptConfirm(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeUnit_hasResult(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimeUnit_getResult(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeUnit_hasError(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimeUnit_getErrorInfo(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern AimeLedStatus AimeUnit_getLedStatus(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeUnit_setLedStatus(IntPtr unit, AimeLedStatus status);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeUnit_setLed(IntPtr unit, bool onR, bool onG, bool onB);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeResult_valid(IntPtr result);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeResult_isReaderDetected(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimeResult_getHardVersion(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimeResult_getFirmVersion(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern void AimeResult_getOfflineId(IntPtr result, [In][Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] dest, int destSize);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeResult_isMobile(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern void AimeResult_getAccessCode(IntPtr result, [In][Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] dest, int destSize);

		//[DllImport("amdaemon_api")]
		//public static extern uint AimeResult_getAimeId(IntPtr result);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeResult_isSegaIdRegistered(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimeResult_getSegaIdAuthKey(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern int AimeResult_getRelatedAimeIdCount(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern uint AimeResult_getRelatedAimeId(IntPtr result, int index);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimeErrorInfo_base(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern AimeErrorId AimeErrorInfo_getId(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern AimeErrorCategory AimeErrorInfo_getCategory(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern int AimeOfflineId_Size_get();

		//[DllImport("amdaemon_api")]
		//public static extern void AimeOfflineId_make_AccessCode([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] src, int srcSize, [In][Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] dest, int destSize);

		//[DllImport("amdaemon_api")]
		//public static extern void AimeOfflineId_make_FeliCaId([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] src, int srcSize, [In][Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] dest, int destSize);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeOfflineId_valid([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] src, int srcSize);

		//[DllImport("amdaemon_api")]
		//public static extern AimeOfflineIdType AimeOfflineId_getType([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] src, int srcSize);

		//[DllImport("amdaemon_api")]
		//public static extern void AimeOfflineId_getData_accessCode_get([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] src, int srcSize, [In][Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] dest, int destSize);

		//[DllImport("amdaemon_api")]
		//public static extern void AimeOfflineId_getData_feliCaId_get([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] src, int srcSize, [In][Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] dest, int destSize);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimeOfflineId_toString([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] src, int srcSize);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeOfflineId_operator_equals([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] srcL, int srcLSize, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] srcR, int srcRSize);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeOfflineId_operator_less([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] srcL, int srcLSize, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] srcR, int srcRSize);

		//[DllImport("amdaemon_api")]
		//public static extern uint AimeId_makeInvalid();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeId_valid(uint id);

		//[DllImport("amdaemon_api")]
		//public static extern int AccessCode_DigitCount_get();

		//[DllImport("amdaemon_api")]
		//public static extern int AccessCode_Size_get();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AccessCode_canMake([MarshalAs(UnmanagedType.LPWStr)] string src, [MarshalAs(UnmanagedType.LPWStr)] string separator);

		//[DllImport("amdaemon_api")]
		//public static extern void AccessCode_make([MarshalAs(UnmanagedType.LPWStr)] string src, [MarshalAs(UnmanagedType.LPWStr)] string separator, [In][Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] dest, int destSize);

		//[DllImport("amdaemon_api")]
		//public static extern void AccessCode_makeInvalid([In][Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] dest, int destSize);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AccessCode_valid([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] src, int srcSize);

		//[DllImport("amdaemon_api")]
		//public static extern int AccessCode_getDigit([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] src, int srcSize, int digitIndex);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AccessCode_toString([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] src, int srcSize, [MarshalAs(UnmanagedType.LPWStr)] string separator);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AccessCode_operator_equals([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] srcL, int srcLSize, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] srcR, int srcRSize);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AccessCode_operator_less([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] srcL, int srcLSize, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] srcR, int srcRSize);

		//[DllImport("amdaemon_api")]
		//public static extern int FeliCaId_Size_get();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr FeliCaId_toString([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] src, int srcSize);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool FeliCaId_operator_equals([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] srcL, int srcLSize, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] srcR, int srcRSize);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool FeliCaId_operator_less([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] srcL, int srcLSize, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] srcR, int srcRSize);

		//[DllImport("amdaemon_api")]
		//public static extern int AimeCampaignInfo_MaxNameLength_get();

		//[DllImport("amdaemon_api")]
		//public static extern uint AimeCampaignInfo_id_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimeCampaignInfo_name_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern ulong AimeCampaignInfo_noticeTime_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern ulong AimeCampaignInfo_openTimeRange_begin_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern ulong AimeCampaignInfo_openTimeRange_end_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern ulong AimeCampaignInfo_rewardTimeRange_begin_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern ulong AimeCampaignInfo_rewardTimeRange_end_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern uint AimeCampaignProgress_id_get(IntPtr progress);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimeCampaignProgress_entry_get(IntPtr progress);

		//[DllImport("amdaemon_api")]
		//public static extern uint AimeCampaignProgress_bits_get(IntPtr progress);

		//[DllImport("amdaemon_api")]
		//public static extern AimeErrorCategory AimeErrorId_getCategory(AimeErrorId errorId);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePay_isAvailable();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePay_isActivated();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimePay_getActivatedLocationInfo();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimePay_getCurrentLocationInfo();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimePay_getOperation();

		//[DllImport("amdaemon_api")]
		//public static extern int AimePay_getDealResultCount();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimePay_getDealResult(int index);

		//[DllImport("amdaemon_api")]
		//public static extern int AimePay_getDealSummaryCount();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimePay_getDealSummary(int index);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayLocationInfo_valid(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimePayLocationInfo_getName(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimePayLocationInfo_getCompanyName(IntPtr info);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayOperation_isDealAvailable(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayOperation_canOperateDeal(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayOperation_isBusy(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayOperation_isCancellable(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayOperation_cancel(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayOperation_hasConfirm(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//public static extern AimePayConfirm AimePayOperation_getConfirm(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayOperation_acceptConfirm(IntPtr operation, [MarshalAs(UnmanagedType.LPWStr)] string param);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayOperation_isErrorOccurred(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimePayOperation_getUserSetting(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayOperation_hasDealResult(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimePayOperation_getDealResult(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayOperation_checkDisplay(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayOperation_activate(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayOperation_deactivate(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayOperation_requestUserSetting(IntPtr operation, uint aimeId);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayOperation_payToCoin(IntPtr operation, int playerIndex, uint aimeId, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] byte[] accessCode, int accessCodeSize, uint coin);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayOperation_canAddCoin(IntPtr operation, int playerIndex, uint coin);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayOperation_payAmount(IntPtr operation, uint aimeId, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] accessCode, int accessCodeSize, [MarshalAs(UnmanagedType.LPWStr)] string itemId, uint count, long optionNumber);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayUserSetting_valid(IntPtr setting);

		//[DllImport("amdaemon_api")]
		//public static extern uint AimePayUserSetting_getAimeId(IntPtr setting);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayUserSetting_isCreditCardAvailable(IntPtr setting);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayUserSetting_canSkipAimeHold(IntPtr setting);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AimePayDealResult_valid(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern AimePayDealResultStatus AimePayDealResult_getStatus(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern ulong AimePayDealResult_getTime(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimePayDealResult_getErrorCode(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern void AimePayDealResult_getAccessCode(IntPtr result, [In][Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] dest, int destSize);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AimePayDealResult_getItemId(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern uint AimePayDealResult_getItemCount(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern int AimePayDealResult_getAmount(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern ulong AimePayDealResult_getReceiptId(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern ulong AimePayDealSummary_getDate(IntPtr summary);

		//[DllImport("amdaemon_api")]
		//public static extern uint AimePayDealSummary_getAmount(IntPtr summary);

		//[DllImport("amdaemon_api")]
		//public static extern uint AimePayDealSummary_getCount(IntPtr summary);

		//[DllImport("amdaemon_api")]
		//public static extern int AimePayCheckInPinCodeLength_get();

		//[DllImport("amdaemon_api")]
		//public static extern int MaxAimePayDealResultCount_get();

		//[DllImport("amdaemon_api")]
		//public static extern int MaxAimePayDealSummaryCount_get();

		//[DllImport("amdaemon_api")]
		//public static extern int MaxAimePayErrorCodeLength_get();

		//[DllImport("amdaemon_api")]
		//public static extern int MaxAimePayItemIdLength_get();

		//[DllImport("amdaemon_api")]
		//public static extern uint MaxAimePayAmountCount_get();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_Accounting_isAvailable();

		//[DllImport("amdaemon_api")]
		//public static extern AccountingMode allnet_Accounting_getMode();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_Accounting_isPlayable();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_Accounting_isReporting();

		//[DllImport("amdaemon_api")]
		//public static extern long allnet_Accounting_getSpanUntilReport();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr allnet_Accounting_getPlayCountItem(AccountingPlayCountMonth month);

		//[DllImport("amdaemon_api")]
		//public static extern ulong allnet_Accounting_getReportTime();

		//[DllImport("amdaemon_api")]
		//public static extern ulong allnet_Accounting_getBackgroundReportTime();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_Accounting_isLogFull();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_Accounting_isNearFullEnabled();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_Accounting_setNearFullEnabled([MarshalAs(UnmanagedType.U1)] bool enabled);

		//[DllImport("amdaemon_api")]
		//public static extern int allnet_Accounting_getPlayerCount();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr allnet_Accounting_getPlayer(int playerIndex);

		//[DllImport("amdaemon_api")]
		//public static extern int allnet_AccountingUnit_getKindCodeLimit();

		//[DllImport("amdaemon_api")]
		//public static extern int allnet_AccountingUnit_getStatusCodeLimit();

		//[DllImport("amdaemon_api")]
		//public static extern int allnet_AccountingUnit_getItemCountLimit();

		//[DllImport("amdaemon_api")]
		//public static extern int allnet_AccountingUnit_getQuantityLimit();

		//[DllImport("amdaemon_api")]
		//public static extern int allnet_AccountingUnit_getMaxGeneralIdLength();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_AccountingUnit_canBeginPlay(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern uint allnet_AccountingUnit_beginPlay(IntPtr unit, int kindCode, int statusCode);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_AccountingUnit_endPlay(IntPtr unit, uint handle, int kindCode, int statusCode, int itemCount);

		//[DllImport("amdaemon_api")]
		//public static extern uint allnet_AccountingUnit_continuePlay(IntPtr unit, uint prevHandle, int prevKindCode, int prevStatusCode, int prevItemCount, int nextKindCode, int nextStatusCode);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_AccountingUnit_accountItem(IntPtr unit, int kindCode, int statusCode, int itemCount);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_AccountingUnit_putQuantity(IntPtr unit, int kindCode, int quantity);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_AccountingUnit_putGeneralId(IntPtr unit, int kindCode, [MarshalAs(UnmanagedType.LPWStr)] string generalId);

		//[DllImport("amdaemon_api")]
		//public static extern ulong allnet_AccountingPlayCountItem_month_get(IntPtr item);

		//[DllImport("amdaemon_api")]
		//public static extern int allnet_AccountingPlayCountItem_count_get(IntPtr item);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_AccountingPlayCountItem_valid(IntPtr item);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr allnet_AccountingPlayCountItem_toString(IntPtr item, int countWidth);

		//[DllImport("amdaemon_api")]
		//public static extern int allnet_Auth_getLocationNicknamePartCount();

		//[DllImport("amdaemon_api")]
		//public static extern int allnet_Auth_getRegionNamePartCount();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_Auth_isAvailable();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_Auth_isGood();

		//[DllImport("amdaemon_api")]
		//public static extern ulong allnet_Auth_getAuthTime();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_Auth_isDevelop();

		//[DllImport("amdaemon_api")]
		//public static extern LineType allnet_Auth_getLineType();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr allnet_Auth_getGameServerUri();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr allnet_Auth_getGameServerHost();

		//[DllImport("amdaemon_api")]
		//public static extern uint allnet_Auth_getLocationId();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr allnet_Auth_getLocationName();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr allnet_Auth_getLocationNickname(int partIndex);

		//[DllImport("amdaemon_api")]
		//public static extern int allnet_Auth_getRegionCode();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr allnet_Auth_getRegionName(int partIndex);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr allnet_Auth_getCountryCode();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_WiFi_isAvailable();

		//[DllImport("amdaemon_api")]
		//public static extern int allnet_WiFi_getUnitCount();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr allnet_WiFi_getUnit(int unitIndex);

		//[DllImport("amdaemon_api")]
		//public static extern void allnet_WiFi_saveUnitCache();

		//[DllImport("amdaemon_api")]
		//public static extern void allnet_WiFi_clearUnitCache();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_WiFi_isUnitCacheSaved();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_WiFiUnit_isCache(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_WiFiUnit_valid(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_WiFiUnit_isAuthGood(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr allnet_WiFiUnit_getAuthGoodText(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr allnet_WiFiUnit_getSerial(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr allnet_WiFiUnit_getFirmVersion(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool allnet_WiFiUnit_isServerAlive(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr allnet_WiFiUnit_getServerAliveText(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern int allnet_WiFiUnit_getAccessCount(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr allnet_WiFiUnit_getMasterSerial(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern int allnet_MaxWiFiUnitCount_get();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Apm_startGame(uint appVersionValue, [MarshalAs(UnmanagedType.LPWStr)] string gameId, [MarshalAs(UnmanagedType.U1)] bool withAime);

		//[DllImport("amdaemon_api")]
		//public static extern ApmGameExitReason Apm_getLastGameExitReason();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Apm_exitGame([MarshalAs(UnmanagedType.U1)] bool test);

		//[DllImport("amdaemon_api")]
		//public static extern uint AppImage_getCurrentVersion();

		//[DllImport("amdaemon_api")]
		//public static extern ulong AppImage_getCreationTime();

		//[DllImport("amdaemon_api")]
		//public static extern int AppImage_getOptionCount();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AppImage_getOptionInfo(int index);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AppImage_findOptionInfo([MarshalAs(UnmanagedType.LPWStr)] string optionName);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool AppImage_existsOption([MarshalAs(UnmanagedType.LPWStr)] string optionName);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AppImage_getOptionMountRootPath();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr AppImage_makeOptionMountPath([MarshalAs(UnmanagedType.LPWStr)] string optionName);

		//[DllImport("amdaemon_api")]
		//public static extern ulong OptionImageInfo_creationTime_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr OptionImageInfo_name_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern int Backup_getMaxRecordCount();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Backup_isAsync();

		//[DllImport("amdaemon_api")]
		//public static extern void Backup_setAsync([MarshalAs(UnmanagedType.U1)] bool async);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Backup_isBusy();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Backup_setupRecords([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] BackupRecord[] records, int count, [MarshalAs(UnmanagedType.LPWStr)] string gameId);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Backup_isSetupSucceeded();

		//[DllImport("amdaemon_api")]
		//public static extern int Backup_getRecordCount();

		//[DllImport("amdaemon_api")]
		//public static extern BackupRecordStatus Backup_getRecordStatus(int recordIndex);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Backup_saveRecord(int recordIndex);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Backup_saveAllRecords();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Backup_executeSave();

		//[DllImport("amdaemon_api")]
		//public static extern int BoardIO_DipSwitchCount_get();

		//[DllImport("amdaemon_api")]
		//public static extern int BoardIO_PushSwitchCount_get();

		//[DllImport("amdaemon_api")]
		//public static extern int BoardIO_BoardLedCount_get();

		//[DllImport("amdaemon_api")]
		//public static extern ushort BoardIO_getDipSwitchBits();

		//[DllImport("amdaemon_api")]
		//public static extern ushort BoardIO_getDipSwitchAppValue();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool BoardIO_isDipSwitchOn(int index);

		//[DllImport("amdaemon_api")]
		//public static extern ushort BoardIO_getPushSwitchBits();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool BoardIO_isPushSwitchOn(int index);

		//[DllImport("amdaemon_api")]
		//public static extern void BoardIO_setLedState(int index, [MarshalAs(UnmanagedType.U1)] bool on, [MarshalAs(UnmanagedType.U1)] bool forceUpdate);

		//[DllImport("amdaemon_api")]
		//public static extern ushort BoardIO_getCurrentLedStateBits();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool BoardIO_isCurrentLedStateOn(int index);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Can_isAvailable();

		//[DllImport("amdaemon_api")]
		//public static extern int Can_getPortCount();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Can_getPort(int portIndex);

		//[DllImport("amdaemon_api")]
		//public static extern int CanPort_getTargetCount(IntPtr port);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr CanPort_getTarget(IntPtr port, int targetIndex);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr CanTarget_getProperty(IntPtr target);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr CanTarget_send(IntPtr target, byte command, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] data, int dataSize, byte priority);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr CanTarget_getAck(IntPtr target, byte command);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool CanTargetProperty_valid(IntPtr property);

		//[DllImport("amdaemon_api")]
		//public static extern CanTargetType CanTargetProperty_getType(IntPtr property);

		//[DllImport("amdaemon_api")]
		//public static extern ushort CanTargetProperty_getId(IntPtr property);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr CanTargetProperty_getProduct(IntPtr property);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr CanTargetProperty_getCustomChip(IntPtr property);

		//[DllImport("amdaemon_api")]
		//public static extern ushort CanTargetProperty_getFirmRevision(IntPtr property);

		//[DllImport("amdaemon_api")]
		//public static extern ushort CanTargetProperty_getFirmSum(IntPtr property);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool CanAck_exists(IntPtr ack);

		//[DllImport("amdaemon_api")]
		//public static extern byte CanAck_getCommand(IntPtr ack);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool CanAck_isError(IntPtr ack);

		//[DllImport("amdaemon_api")]
		//public static extern CanErrorReport CanAck_getErrorReport(IntPtr ack);

		//[DllImport("amdaemon_api")]
		//public static extern int CanAck_getData(IntPtr ack, [In][Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] dest, int destSize);

		//[DllImport("amdaemon_api")]
		//public static extern int CanAck_getDataSize(IntPtr ack);

		//[DllImport("amdaemon_api")]
		//public static extern int MaxCanPacketDataSize_get();

		//[DllImport("amdaemon_api")]
		//public static extern byte MaxCanPacketPriority_get();

		//[DllImport("amdaemon_api")]
		//public static extern byte DefaultCanPacketPriority_get();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Credit_isAvailable();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Credit_isCoinInIgnored();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Credit_setCoinInIgnored([MarshalAs(UnmanagedType.U1)] bool ignored);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Credit_clearBackup();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Credit_getBookkeeping();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Credit_getConfig();

		//[DllImport("amdaemon_api")]
		//public static extern void Credit_setCoinInHook_register();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Credit_setCoinInHook_check(out CreditSound sound, out IntPtr playerIndices, out int playerCount);

		//[DllImport("amdaemon_api")]
		//public static extern void Credit_setCoinInHook_done();

		//[DllImport("amdaemon_api")]
		//public static extern void Credit_resetCoinInHook();

		//[DllImport("amdaemon_api")]
		//public static extern int Credit_getPlayerCount();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Credit_getPlayer(int playerIndex);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Credit_getSpecialDevice();

		//[DllImport("amdaemon_api")]
		//public static extern int CreditBookkeeping_CoinChuteCount_get();

		//[DllImport("amdaemon_api")]
		//public static extern uint CreditBookkeeping_coins_get(IntPtr bookkeeping, int coinChuteIndex);

		//[DllImport("amdaemon_api")]
		//public static extern uint CreditBookkeeping_totalCoin_get(IntPtr bookkeeping);

		//[DllImport("amdaemon_api")]
		//public static extern uint CreditBookkeeping_coinCredit_get(IntPtr bookkeeping);

		//[DllImport("amdaemon_api")]
		//public static extern uint CreditBookkeeping_serviceCredit_get(IntPtr bookkeeping);

		//[DllImport("amdaemon_api")]
		//public static extern uint CreditBookkeeping_eMoneyCoin_get(IntPtr bookkeeping);

		//[DllImport("amdaemon_api")]
		//public static extern uint CreditBookkeeping_eMoneyCredit_get(IntPtr bookkeeping);

		//[DllImport("amdaemon_api")]
		//public static extern uint CreditBookkeeping_totalCredit_get(IntPtr bookkeeping);

		//[DllImport("amdaemon_api")]
		//public static extern int CreditConfig_MaxCoinChuteCount_get();

		//[DllImport("amdaemon_api")]
		//public static extern int CreditConfig_MaxGameCostCount_get();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool CreditConfig_coinChuteCommon_get(IntPtr config);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool CreditConfig_serviceCommon_get(IntPtr config);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool CreditConfig_freePlay_get(IntPtr config);

		//[DllImport("amdaemon_api")]
		//public static extern uint CreditConfig_coinMultipliers_get(IntPtr config, int coinChuteIndex);

		//[DllImport("amdaemon_api")]
		//public static extern uint CreditConfig_bonusAdder_get(IntPtr config);

		//[DllImport("amdaemon_api")]
		//public static extern uint CreditConfig_coinToCredit_get(IntPtr config);

		//[DllImport("amdaemon_api")]
		//public static extern uint CreditConfig_gameCosts_get(IntPtr config, int gameCostIndex);

		//[DllImport("amdaemon_api")]
		//public static extern uint CreditConfig_coinAmount_get(IntPtr config);

		//[DllImport("amdaemon_api")]
		//public static extern uint CreditUnit_getCredit(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern uint CreditUnit_getRemain(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool CreditUnit_isZero(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern uint CreditUnit_getAddableCoin(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern uint CreditUnit_getCoinToCredit(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool CreditUnit_isFreePlay(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr CreditUnit_toString(IntPtr unit);

		//[DllImport("amdaemon_api")]
		//public static extern uint CreditUnit_getGameCost(IntPtr unit, int gameCostIndex);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool CreditUnit_isGameCostEnough(IntPtr unit, int gameCostIndex, int count);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool CreditUnit_payGameCost(IntPtr unit, int gameCostIndex, int count);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool CreditSpecialDevice_isAvailable(IntPtr device);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool CreditSpecialDevice_isLockoutOn(IntPtr device);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool CreditSpecialDevice_lockout(IntPtr device, [MarshalAs(UnmanagedType.U1)] bool on);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoney_isAvailable();

		//[DllImport("amdaemon_api")]
		//public static extern void EMoney_setSoundHook_register();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoney_setSoundHook_check(out IntPtr id, out IntPtr filePath);

		//[DllImport("amdaemon_api")]
		//public static extern void EMoney_setSoundHook_done();

		//[DllImport("amdaemon_api")]
		//public static extern void EMoney_resetSoundHook();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoney_isServiceAlive();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoney_isAuthCompleted();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr EMoney_getTerminalId();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr EMoney_getTerminalSerial();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoney_isBrandAvailable(EMoneyBrandId brandId, [MarshalAs(UnmanagedType.U1)] bool forBalance);

		//[DllImport("amdaemon_api")]
		//public static extern int EMoney_getAvailableBrandCount([MarshalAs(UnmanagedType.U1)] bool forBalance);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr EMoney_getAvailableBrand(int index, [MarshalAs(UnmanagedType.U1)] bool forBalance);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr EMoney_getOperation();

		//[DllImport("amdaemon_api")]
		//public static extern int EMoney_getDealResultCount();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr EMoney_getDealResult(int index);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoney_isReporting();

		//[DllImport("amdaemon_api")]
		//public static extern int EMoney_getReportCount();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr EMoney_getReport(int index);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr EMoney_getBrand(EMoneyBrandId brandId);

		//[DllImport("amdaemon_api")]
		//public static extern EMoneyBrandId EMoneyBrand_getId(IntPtr brand);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr EMoneyBrand_getName(IntPtr brand);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr EMoneyBrand_getIconFilePath(IntPtr brand);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyBrand_hasBalance(IntPtr brand);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyOperation_isDealAvailable(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyOperation_canOperateDeal(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyOperation_isBusy(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyOperation_isCancellable(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyOperation_cancel(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyOperation_isHeldOver(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyOperation_isErrorOccurred(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyOperation_hasResult(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr EMoneyOperation_getResult(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyOperation_checkDisplay(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyOperation_authTerminal(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyOperation_removeTerminal(IntPtr operation);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyOperation_requestBalance(IntPtr operation, EMoneyBrandId brandId);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyOperation_payToCoin(IntPtr operation, int playerIndex, EMoneyBrandId brandId, uint coin);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyOperation_canAddCoin(IntPtr operation, int playerIndex, uint coin);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyOperation_payAmount(IntPtr operation, EMoneyBrandId brandId, [MarshalAs(UnmanagedType.LPWStr)] string itemId, int amount, uint count, [MarshalAs(UnmanagedType.U1)] bool hooking);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyOperation_payAmount_check();

		//[DllImport("amdaemon_api")]
		//public static extern void EMoneyOperation_payAmount_done();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyResult_valid(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern EMoneyResultStatus EMoneyResult_getStatus(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern ulong EMoneyResult_getTime(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr EMoneyResult_getBrand(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr EMoneyResult_getDealNumber(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr EMoneyResult_getCardNumber(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern int EMoneyResult_getAmount(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern int EMoneyResult_getBalanceBefore(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern int EMoneyResult_getBalanceAfter(IntPtr result);

		//[DllImport("amdaemon_api")]
		//public static extern ulong EMoneyReport_getTime(IntPtr report);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool EMoneyReport_isSucceeded(IntPtr report);

		//[DllImport("amdaemon_api")]
		//public static extern int EMoneyReport_getCount(IntPtr report);

		//[DllImport("amdaemon_api")]
		//public static extern int EMoneyReport_getAmount(IntPtr report);

		//[DllImport("amdaemon_api")]
		//public static extern int EMoneyReport_getAlarmCount(IntPtr report);

		//[DllImport("amdaemon_api")]
		//public static extern int EMoneyReport_getAlarmAmount(IntPtr report);

		//[DllImport("amdaemon_api")]
		//public static extern int EMoneyBrandIdCount_get();

		//[DllImport("amdaemon_api")]
		//public static extern int MaxEMoneyDealResultCount_get();

		//[DllImport("amdaemon_api")]
		//public static extern int MaxEMoneyReportCount_get();

		//[DllImport("amdaemon_api")]
		//public static extern int MaxEMoneyBrandNameLength_get();

		//[DllImport("amdaemon_api")]
		//public static extern int MaxEMoneyDealNumberLength_get();

		//[DllImport("amdaemon_api")]
		//public static extern int MaxEMoneyCardNumberLength_get();

		//[DllImport("amdaemon_api")]
		//public static extern int MaxEMoneyTerminalIdLength_get();

		//[DllImport("amdaemon_api")]
		//public static extern int MaxEMoneyTerminalSerialLength_get();

		//[DllImport("amdaemon_api")]
		//public static extern int MaxEMoneyItemIdLength_get();

		//[DllImport("amdaemon_api")]
		//public static extern uint MaxEMoneyAmountCount_get();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Error_getInfo();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Error_canReset();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Error_set(int number, int subNumber);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Error_reset();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Error_getLog();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Error_clearLog();

		//[DllImport("amdaemon_api")]
		//public static extern int ErrorLog_getHistoryItemCount(IntPtr log);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr ErrorLog_getHistoryItem(IntPtr log, int index);

		//[DllImport("amdaemon_api")]
		//public static extern int ErrorLog_getTimesItemCount(IntPtr log);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr ErrorLog_getTimesItem(IntPtr log, int index);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr ErrorLog_findTimesItem(IntPtr log, int number);

		//[DllImport("amdaemon_api")]
		//public static extern int ErrorLog_getSystemHistoryItemCount(IntPtr log);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr ErrorLog_getSystemHistoryItem(IntPtr log, int index);

		//[DllImport("amdaemon_api")]
		//public static extern int ErrorTimesItem_number_get(IntPtr item);

		//[DllImport("amdaemon_api")]
		//public static extern int ErrorTimesItem_times_get(IntPtr item);

		//[DllImport("amdaemon_api")]
		//public static extern int ErrorNumberLimit_get();

		//[DllImport("amdaemon_api")]
		//public static extern int ErrorSubNumberLimit_get();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Input_getSystem();

		//[DllImport("amdaemon_api")]
		//public static extern int Input_getPlayerCount();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Input_getPlayer(int playerIndex);

		//[DllImport("amdaemon_api")]
		//public static extern int InputId_MaxSize_get();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool InputUnit_exists(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue);

		//[DllImport("amdaemon_api")]
		//public static extern long InputUnit_getValue(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue);

		//[DllImport("amdaemon_api")]
		//public static extern long InputUnit_getDelta(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue);

		//[DllImport("amdaemon_api")]
		//public static extern long InputUnit_getMinValue(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue);

		//[DllImport("amdaemon_api")]
		//public static extern long InputUnit_getMaxValue(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue);

		//[DllImport("amdaemon_api")]
		//public static extern long InputUnit_getDirectValue(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue);

		//[DllImport("amdaemon_api")]
		//public static extern int InputUnit_getSwitchFlipDelta(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue, [MarshalAs(UnmanagedType.U1)] bool toOn);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool SwitchInput_isOn(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool SwitchInput_isFlipNow(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool SwitchInput_isOnNow(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool SwitchInput_isOffNow(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool SwitchInput_hasFlipNow(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool SwitchInput_hasOnNow(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool SwitchInput_hasOffNow(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue);

		//[DllImport("amdaemon_api")]
		//public static extern int SwitchInput_getFlipDelta(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue, [MarshalAs(UnmanagedType.U1)] bool toOn);

		//[DllImport("amdaemon_api")]
		//public static extern double AnalogInput_getValue(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue, double minValue, double maxValue);

		//[DllImport("amdaemon_api")]
		//public static extern double AnalogInput_getDelta(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue, double minValue, double maxValue);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Jvs_isAvailable();

		//[DllImport("amdaemon_api")]
		//public static extern int Jvs_getNodeCount();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Jvs_getNode(int nodeIndex);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr JvsNode_getSwitchInput(IntPtr node);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr JvsNode_getAnalogInput(IntPtr node);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr JvsNode_getRotaryInput(IntPtr node);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr JvsNode_getGeneralOutput(IntPtr node);

		//[DllImport("amdaemon_api")]
		//public static extern int JvsSwitchInput_MaxSystemBitCount_get();

		//[DllImport("amdaemon_api")]
		//public static extern int JvsSwitchInput_MaxPlayerBitCount_get();

		//[DllImport("amdaemon_api")]
		//public static extern ushort JvsSwitchInput_getSystemBits(IntPtr input);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool JvsSwitchInput_isSystemOn(IntPtr input, int bitIndex);

		//[DllImport("amdaemon_api")]
		//public static extern byte JvsSwitchInput_getSystemFlipCount(IntPtr input, int bitIndex, [MarshalAs(UnmanagedType.U1)] bool toOn);

		//[DllImport("amdaemon_api")]
		//public static extern int JvsSwitchInput_getPlayerCount(IntPtr input);

		//[DllImport("amdaemon_api")]
		//public static extern ulong JvsSwitchInput_getPlayerBits(IntPtr input, int playerIndex);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool JvsSwitchInput_isPlayerOn(IntPtr input, int playerIndex, int bitIndex);

		//[DllImport("amdaemon_api")]
		//public static extern byte JvsSwitchInput_getPlayerFlipCount(IntPtr input, int playerIndex, int bitIndex, [MarshalAs(UnmanagedType.U1)] bool toOn);

		//[DllImport("amdaemon_api")]
		//public static extern int JvsAnalogInput_getChannelCount(IntPtr input);

		//[DllImport("amdaemon_api")]
		//public static extern int JvsAnalogInput_getValidBitCount(IntPtr input);

		//[DllImport("amdaemon_api")]
		//public static extern ushort JvsAnalogInput_getValue(IntPtr input, int channelIndex);

		//[DllImport("amdaemon_api")]
		//public static extern int JvsRotaryInput_getChannelCount(IntPtr input);

		//[DllImport("amdaemon_api")]
		//public static extern ushort JvsRotaryInput_getValue(IntPtr input, int channelIndex);

		//[DllImport("amdaemon_api")]
		//public static extern int JvsGeneralOutput_MaxBitCount_get();

		//[DllImport("amdaemon_api")]
		//public static extern void JvsGeneralOutput_setBits(IntPtr output, ulong bits, [MarshalAs(UnmanagedType.U1)] bool forceUpdate);

		//[DllImport("amdaemon_api")]
		//public static extern void JvsGeneralOutput_resetBits(IntPtr output, [MarshalAs(UnmanagedType.U1)] bool forceUpdate);

		//[DllImport("amdaemon_api")]
		//public static extern void JvsGeneralOutput_setBit(IntPtr output, int bitIndex, [MarshalAs(UnmanagedType.U1)] bool on, [MarshalAs(UnmanagedType.U1)] bool forceUpdate);

		//[DllImport("amdaemon_api")]
		//public static extern ulong JvsGeneralOutput_getCurrentBits(IntPtr output);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool LanInstall_isAvailable();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool LanInstall_isClient();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool LanInstall_isServer();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool LanInstall_isExitNeeded();

		//[DllImport("amdaemon_api")]
		//public static extern int LanInstall_getServerCount();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool NetDelivery_isAvailable();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool NetDelivery_isExitNeeded();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool NetDelivery_existsApp();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetDelivery_getAppTimeInfo();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetDelivery_getAppImageInfo();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool NetDelivery_existsOption();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetDelivery_getOptionTimeInfo();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetDelivery_getOptionImageInfo();

		//[DllImport("amdaemon_api")]
		//public static extern ulong NetDeliveryTimeInfo_order_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern ulong NetDeliveryTimeInfo_release_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool NetDeliveryTimeInfo_existsImage(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern NetDeliveryStatus NetDeliveryAppImageInfo_status_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetDeliveryAppImageInfo_progress_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern uint NetDeliveryAppImageInfo_version_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern ulong NetDeliveryAppImageInfo_creationTime_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern NetDeliveryStatus NetDeliveryOptionImageInfo_status_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetDeliveryOptionImageInfo_progress_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetDeliveryOptionImageInfo_optionalProgress_get(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetDeliveryOptionImageInfo_calcTotalProgress(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern int NetDeliveryProgress_total_get(IntPtr progress);

		//[DllImport("amdaemon_api")]
		//public static extern int NetDeliveryProgress_current_get(IntPtr progress);

		//[DllImport("amdaemon_api")]
		//public static extern float NetDeliveryProgress_toPercentage(IntPtr progress);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetDeliveryStatus_toString(NetDeliveryStatus status, [MarshalAs(UnmanagedType.U1)] bool japanese);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Network_isAvailable();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Network_isLanAvailable();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Network_isLocationLanAvailable();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Network_isWanAvailable();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Network_getProperty();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Network_getPowerOnTestInfo();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Network_canStartTest();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Network_startTest();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Network_getTestInfo();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool NetworkProperty_valid(IntPtr property);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool NetworkProperty_isDhcpEnabled(IntPtr property);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetworkProperty_getAddress(IntPtr property);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetworkProperty_getSubnetMask(IntPtr property);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetworkProperty_getGateway(IntPtr property);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetworkProperty_getPrimaryDns(IntPtr property);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetworkProperty_getSecondaryDns(IntPtr property);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetworkTestInfo_getBusyStatusText([MarshalAs(UnmanagedType.U1)] bool blink);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool NetworkTestInfo_isRunning(IntPtr info);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool NetworkTestInfo_isCompleted(IntPtr info);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool NetworkTestInfo_isAvailableItem(IntPtr info, NetworkTestItem item);

		//[DllImport("amdaemon_api")]
		//public static extern int NetworkTestInfo_getAvailableItemCount(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern NetworkTestItem NetworkTestInfo_getAvailableItem(IntPtr info, int index);

		//[DllImport("amdaemon_api")]
		//public static extern NetworkTestState NetworkTestInfo_getState(IntPtr info, NetworkTestItem item);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool NetworkTestInfo_isBusy(IntPtr info, NetworkTestItem item);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool NetworkTestInfo_isDone(IntPtr info, NetworkTestItem item);

		//[DllImport("amdaemon_api")]
		//public static extern TestResult NetworkTestInfo_getResult(IntPtr info, NetworkTestItem item);

		//[DllImport("amdaemon_api")]
		//public static extern int NetworkTestInfo_getHops(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetworkTestInfo_getStatusText(IntPtr info, NetworkTestItem item, [MarshalAs(UnmanagedType.U1)] bool blinkBusy);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetworkTestInfo_getErrorInfo(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr NetworkTestItem_toString(NetworkTestItem item);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Output_getSystem();

		//[DllImport("amdaemon_api")]
		//public static extern int Output_getPlayerCount();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Output_getPlayer(int playerIndex);

		//[DllImport("amdaemon_api")]
		//public static extern int OutputId_MaxSize_get();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool OutputUnit_exists(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue);

		//[DllImport("amdaemon_api")]
		//public static extern void OutputUnit_setValue(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue, long value, [MarshalAs(UnmanagedType.U1)] bool forceUpdate);

		//[DllImport("amdaemon_api")]
		//public static extern long OutputUnit_getCurrentValue(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue);

		//[DllImport("amdaemon_api")]
		//public static extern long OutputUnit_getMinValue(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue);

		//[DllImport("amdaemon_api")]
		//public static extern long OutputUnit_getMaxValue(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue);

		//[DllImport("amdaemon_api")]
		//public static extern void SwitchOutput_set(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue, int bitIndex, [MarshalAs(UnmanagedType.U1)] bool on, [MarshalAs(UnmanagedType.U1)] bool forceUpdate);

		//[DllImport("amdaemon_api")]
		//public static extern void SwitchOutput_reset(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue, int bitIndex, [MarshalAs(UnmanagedType.U1)] bool forceUpdate);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool SwitchOutput_isCurrentOn(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue, int bitIndex);

		//[DllImport("amdaemon_api")]
		//public static extern void AnalogOutput_setValue(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue, double minValue, double maxValue, double value, [MarshalAs(UnmanagedType.U1)] bool forceUpdate);

		//[DllImport("amdaemon_api")]
		//public static extern double AnalogOutput_getCurrentValue(IntPtr unit, [MarshalAs(UnmanagedType.LPWStr)] string idValue, double minValue, double maxValue);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Sequence_clearBackup();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Sequence_getBookkeeping();

		//[DllImport("amdaemon_api")]
		//public static extern int Sequence_getPlayerCount();

		//[DllImport("amdaemon_api")]
		//public static extern PlayAccountingTiming Sequence_getPlayAccountingTiming();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Sequence_beginPlay(int playerIndex, int gameCostIndex, int gameCostCount, [MarshalAs(UnmanagedType.U1)] bool accountingBeginValid, int accountingBeginKindCode, int accountingBeginStatusCode, [MarshalAs(UnmanagedType.U1)] bool accountingEndValid, int accountingEndKindCode, int accountingEndStatusCode, int accountingEndItemCount, uint aimeId, out PlayErrorId errorId);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Sequence_continuePlay(int playerIndex, int gameCostIndex, int gameCostCount, [MarshalAs(UnmanagedType.U1)] bool accountingBeginValid, int accountingBeginKindCode, int accountingBeginStatusCode, [MarshalAs(UnmanagedType.U1)] bool accountingEndValid, int accountingEndKindCode, int accountingEndStatusCode, int accountingEndItemCount, out PlayErrorId errorId);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Sequence_endPlay(int playerIndex, [MarshalAs(UnmanagedType.U1)] bool accountingBeginValid, int accountingBeginKindCode, int accountingBeginStatusCode, [MarshalAs(UnmanagedType.U1)] bool accountingEndValid, int accountingEndKindCode, int accountingEndStatusCode, int accountingEndItemCount, [MarshalAs(UnmanagedType.U1)] bool cancel, out PlayErrorId errorId);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Sequence_isPlaying(int playerIndex);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Sequence_isPlayingAny();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Sequence_isAccountingPlaying(int playerIndex);

		//[DllImport("amdaemon_api")]
		//public static extern uint Sequence_getPlayingAimeId(int playerIndex);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Sequence_beginTest();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Sequence_endTest();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Sequence_isTest();

		//[DllImport("amdaemon_api")]
		//public static extern int SequenceBookkeeping_MaxTimeHistogramCount_get();

		//[DllImport("amdaemon_api")]
		//public static extern uint SequenceBookkeeping_numberOfGames_get(IntPtr bookkeeping);

		//[DllImport("amdaemon_api")]
		//public static extern uint SequenceBookkeeping_totalTime_get(IntPtr bookkeeping);

		//[DllImport("amdaemon_api")]
		//public static extern uint SequenceBookkeeping_playTime_get(IntPtr bookkeeping);

		//[DllImport("amdaemon_api")]
		//public static extern uint SequenceBookkeeping_averagePlayTime_get(IntPtr bookkeeping);

		//[DllImport("amdaemon_api")]
		//public static extern uint SequenceBookkeeping_longestPlayTime_get(IntPtr bookkeeping);

		//[DllImport("amdaemon_api")]
		//public static extern uint SequenceBookkeeping_shortestPlayTime_get(IntPtr bookkeeping);

		//[DllImport("amdaemon_api")]
		//public static extern int SequenceBookkeeping_timeHistogramCount_get(IntPtr bookkeeping);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr SequenceBookkeeping_timeHistogram_get(IntPtr bookkeeping, int timeHistogramIndex);

		//[DllImport("amdaemon_api")]
		//public static extern uint TimeHistogramItem_timeRangeMin_get(IntPtr item);

		//[DllImport("amdaemon_api")]
		//public static extern uint TimeHistogramItem_timeRangeMax_get(IntPtr item);

		//[DllImport("amdaemon_api")]
		//public static extern int TimeHistogramItem_count_get(IntPtr item);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr System_getBoardId();

		//[DllImport("amdaemon_api")]
		//public static extern RegionCode System_getRegionCode();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr System_getKeychipId();

		//[DllImport("amdaemon_api")]
		//public static extern uint System_getModelType();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr System_getGameId();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool System_isDevelop();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr System_getResolution(int monitorIndex);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr System_getAppRootPath();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr SerialId_id_value(IntPtr serialId);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr SerialId_shortId_value(IntPtr serialId);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool SerialId_empty(IntPtr serialId);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr SerialId_toString(IntPtr serialId, [MarshalAs(UnmanagedType.U1)] bool useShort);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool SerialId_operator_equals(IntPtr serialIdL, IntPtr serialIdR);

		//[DllImport("amdaemon_api")]
		//public static extern int Resolution_width_get(IntPtr resolution);

		//[DllImport("amdaemon_api")]
		//public static extern int Resolution_height_get(IntPtr resolution);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool UsbDevice_startReconnect(ushort vendorId, ushort productId);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool UsbDevice_isReconnectBusy();

		//[DllImport("amdaemon_api")]
		//public static extern UsbDeviceReconnectResult UsbDevice_getLastReconnectResult();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool UsbIO_isAvailable();

		//[DllImport("amdaemon_api")]
		//public static extern int UsbIO_getNodeCount();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr UsbIO_getNode(int nodeIndex);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr UsbIONode_getSwitchInput(IntPtr node);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr UsbIONode_getAnalogInput(IntPtr node);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr UsbIONode_getRotaryInput(IntPtr node);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr UsbIONode_getUniqueInput(IntPtr node);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr UsbIONode_getGeneralOutput(IntPtr node);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr UsbIONode_getPwmOutput(IntPtr node);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr UsbIONode_getUniqueOutput(IntPtr node);

		//[DllImport("amdaemon_api")]
		//public static extern int UsbIOSwitchInput_MaxPlayerBitCount_get();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool UsbIOSwitchInput_isTestOn(IntPtr input);

		//[DllImport("amdaemon_api")]
		//public static extern byte UsbIOSwitchInput_getTestFlipCount(IntPtr input, [MarshalAs(UnmanagedType.U1)] bool toOn);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool UsbIOSwitchInput_isTiltOn(IntPtr input);

		//[DllImport("amdaemon_api")]
		//public static extern byte UsbIOSwitchInput_getTiltFlipCount(IntPtr input, [MarshalAs(UnmanagedType.U1)] bool toOn);

		//[DllImport("amdaemon_api")]
		//public static extern int UsbIOSwitchInput_getPlayerCount(IntPtr input);

		//[DllImport("amdaemon_api")]
		//public static extern ulong UsbIOSwitchInput_getPlayerBits(IntPtr input, int playerIndex);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool UsbIOSwitchInput_isPlayerOn(IntPtr input, int playerIndex, int bitIndex);

		//[DllImport("amdaemon_api")]
		//public static extern byte UsbIOSwitchInput_getPlayerFlipCount(IntPtr input, int playerIndex, int bitIndex, [MarshalAs(UnmanagedType.U1)] bool toOn);

		//[DllImport("amdaemon_api")]
		//public static extern int UsbIOAnalogInput_getChannelCount(IntPtr input);

		//[DllImport("amdaemon_api")]
		//public static extern int UsbIOAnalogInput_getValidBitCount(IntPtr input);

		//[DllImport("amdaemon_api")]
		//public static extern ushort UsbIOAnalogInput_getValue(IntPtr input, int channelIndex);

		//[DllImport("amdaemon_api")]
		//public static extern int UsbIORotaryInput_getChannelCount(IntPtr input);

		//[DllImport("amdaemon_api")]
		//public static extern ushort UsbIORotaryInput_getValue(IntPtr input, int channelIndex);

		//[DllImport("amdaemon_api")]
		//public static extern int UsbIOUniqueInput_RawDataSize_get();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool UsbIOUniqueInput_isSupported(IntPtr input, byte command);

		//[DllImport("amdaemon_api")]
		//public static extern int UsbIOUniqueInput_get(IntPtr input, byte command, [In][Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] dest, int destSize);

		//[DllImport("amdaemon_api")]
		//public static extern int UsbIOUniqueInput_get_dataSize(IntPtr input, byte command);

		//[DllImport("amdaemon_api")]
		//public static extern int UsbIOUniqueInput_getRaw(IntPtr input, [In][Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] dest, int destSize);

		//[DllImport("amdaemon_api")]
		//public static extern int UsbIOGeneralOutput_MaxBitCount_get();

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr UsbIOGeneralOutput_setBits(IntPtr output, ulong bits, [MarshalAs(UnmanagedType.U1)] bool forceUpdate);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr UsbIOGeneralOutput_resetBits(IntPtr output, [MarshalAs(UnmanagedType.U1)] bool forceUpdate);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr UsbIOGeneralOutput_setBit(IntPtr output, int bitIndex, [MarshalAs(UnmanagedType.U1)] bool on, [MarshalAs(UnmanagedType.U1)] bool forceUpdate);

		//[DllImport("amdaemon_api")]
		//public static extern ulong UsbIOGeneralOutput_getCurrentBits(IntPtr output);

		//[DllImport("amdaemon_api")]
		//public static extern int UsbIOPwmOutput_getSlotCount(IntPtr output);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr UsbIOPwmOutput_setDuties(IntPtr output, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] duties, int slotCount, [MarshalAs(UnmanagedType.U1)] bool forceUpdate);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr UsbIOPwmOutput_resetDuties(IntPtr output, [MarshalAs(UnmanagedType.U1)] bool forceUpdate);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr UsbIOPwmOutput_setDuty(IntPtr output, int slotIndex, byte duty, [MarshalAs(UnmanagedType.U1)] bool forceUpdate);

		//[DllImport("amdaemon_api")]
		//public static extern int UsbIOPwmOutput_getCurrentDuties(IntPtr output, [In][Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] dest, int destSize);

		//[DllImport("amdaemon_api")]
		//public static extern byte UsbIOPwmOutput_getCurrentDuty(IntPtr output, int slotIndex);

		//[DllImport("amdaemon_api")]
		//public static extern int UsbIOUniqueOutput_MaxDataSize_get();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool UsbIOUniqueOutput_isSupported(IntPtr output, byte command);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr UsbIOUniqueOutput_set(IntPtr output, byte command, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] data, int dataSize);

		//[DllImport("amdaemon_api")]
		//public static extern int UsbIOUniqueOutput_getCurrent(IntPtr output, byte command, [In][Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] dest, int destSize);

		//[DllImport("amdaemon_api")]
		//public static extern ExceptionCategory Exception_getCategory(IntPtr ex);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Exception_getFile(IntPtr ex);

		//[DllImport("amdaemon_api")]
		//public static extern int Exception_getLine(IntPtr ex);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Exception_getFunction(IntPtr ex);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Exception_getMessage(IntPtr ex);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Exception_getStackTrace(IntPtr ex);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Exception_toString(IntPtr ex, [MarshalAs(UnmanagedType.U1)] bool withoutStackTrace);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool ErrorInfo_isOccurred(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern int ErrorInfo_getNumber(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern int ErrorInfo_getSubNumber(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr ErrorInfo_makeNumberString(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr ErrorInfo_getMessage(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern ErrorResetType ErrorInfo_getResetType(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern ulong ErrorInfo_getTime(IntPtr info);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr ErrorInfo_toString(IntPtr info);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool RequestState_isSent(IntPtr state);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool RequestState_isDone(IntPtr state);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool RequestState_isSucceeded(IntPtr state);

		//[DllImport("amdaemon_api")]
		//public static extern uint Version_PatchLimit_get();

		//[DllImport("amdaemon_api")]
		//public static extern uint Version_MinorLimit_get();

		//[DllImport("amdaemon_api")]
		//public static extern uint Version_MajorLimit_get();

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Version_canMake_fromParts(uint major, uint minor, uint patch);

		//[DllImport("amdaemon_api")]
		//public static extern uint Version_make_fromParts(uint major, uint minor, uint patch);

		//[DllImport("amdaemon_api")]
		//[return: MarshalAs(UnmanagedType.U1)]
		//public static extern bool Version_canMake_fromString([MarshalAs(UnmanagedType.LPWStr)] string src);

		//[DllImport("amdaemon_api")]
		//public static extern uint Version_make_fromString([MarshalAs(UnmanagedType.LPWStr)] string src);

		//[DllImport("amdaemon_api")]
		//public static extern uint Version_major(uint value);

		//[DllImport("amdaemon_api")]
		//public static extern uint Version_minor(uint value);

		//[DllImport("amdaemon_api")]
		//public static extern uint Version_patch(uint value);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr Version_toString(uint value, [MarshalAs(UnmanagedType.U1)] bool withoutPatch);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr TestResult_toString(TestResult result);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpAll(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpProcess(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpCommon(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpAbaasLog(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpAime(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpAimePay(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpAllnetAuth(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpAllnetAccounting(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpAppImage(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpBackup(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpBoardIO(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpCan(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpCredit(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpEMoney(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpError(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpInput(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpJvs(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpLanInstall(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpNetDelivery(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpNetwork(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpOutput(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpSequence(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpSystem(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpUsbDevice(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpUsbIO(int indent);

		//[DllImport("amdaemon_api")]
		//public static extern int dump_getDumpBinarySize();

		//[DllImport("amdaemon_api")]
		//public static extern void dump_dumpBinary([In][Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] dest, int destSize);

		//[DllImport("amdaemon_api")]
		//public static extern IntPtr dump_dumpAllFromBinary([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] src, int srcSize, int indent);
	}
}
