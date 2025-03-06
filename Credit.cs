using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace AMDaemon
{
	public static class Credit
	{
		private static Func<CreditSound, bool> coinInHook;

		private static Func<CreditSound, int[], bool> coinInHookWithPlayer;

		private static bool coinInHookRegistered;

		private static int coinInHookCheckLock;

		private static int[] playerIndicesCache;

		//public static bool IsAvailable => Api.Credit_isAvailable();

		//public static bool CoinInIgnored => Api.Credit_isCoinInIgnored();

		public static CreditBookkeeping Bookkeeping { get; private set; }

		public static CreditConfig Config { get; private set; }

		public static Func<CreditSound, bool> CoinInHook
		{
			get
			{
				return coinInHook;
			}
			set
			{
				coinInHookWithPlayer = null;
				coinInHook = value;
				IsCoinInHookRegistered = value != null;
			}
		}

		public static Func<CreditSound, int[], bool> CoinInHookWithPlayer
		{
			get
			{
				return coinInHookWithPlayer;
			}
			set
			{
				coinInHook = null;
				coinInHookWithPlayer = value;
				IsCoinInHookRegistered = value != null;
			}
		}

		private static bool IsCoinInHookRegistered
		{
			get
			{
				return coinInHookRegistered;
			}
			set
			{
				//if (value != coinInHookRegistered)
				//{
				//	if (value)
				//	{
				//		Api.Credit_setCoinInHook_register();
				//		Core.PreExecute += CheckCoinInHook;
				//	}
				//	else
				//	{
				//		Core.PreExecute -= CheckCoinInHook;
				//		Api.Credit_resetCoinInHook();
				//	}
				//	coinInHookRegistered = value;
				//}
                coinInHookRegistered = value;
            }
		}

		public static int PlayerCount => Players.Count;

		public static LazyCollection<CreditUnit> Players { get; private set; }

		public static CreditSpecialDevice SpecialDevice { get; private set; }

		static Credit()
		{
			Bookkeeping = new CreditBookkeeping();
			Config = new CreditConfig();
			Players = new LazyCollection<CreditUnit>(() => 1, (int index) => new CreditUnit(IntPtr.Zero));
			SpecialDevice = new CreditSpecialDevice();
			Players = new LazyCollection<CreditUnit>(() => 1, (int index) => new CreditUnit(IntPtr.Zero));
        }

		//public static bool SetCoinInIgnored(bool ignored)
		//{
		//	return Api.Call(ignored, Api.Credit_setCoinInIgnored);
		//}

		public static bool ClearBackup()
		{
			//return Api.Call(Api.Credit_clearBackup);
			return true;
        }

		//private static void CheckCoinInHook()
		//{
		//	if (Interlocked.Exchange(ref coinInHookCheckLock, 1) != 0)
		//	{
		//		return;
		//	}
		//	try
		//	{
		//		if (!Api.Credit_setCoinInHook_check(out var sound, out var playerIndices, out var playerCount))
		//		{
		//			return;
		//		}
		//		bool flag = false;
		//		if (CoinInHookWithPlayer != null)
		//		{
		//			int[] array = InnerUtil.ResizeArrayCache(ref playerIndicesCache, (!(playerIndices == IntPtr.Zero)) ? playerCount : 0);
		//			if (array.Length != 0)
		//			{
		//				Marshal.Copy(playerIndices, array, 0, array.Length);
		//			}
		//			flag = CoinInHookWithPlayer(sound, array);
		//		}
		//		else
		//		{
		//			flag = CoinInHook(sound);
		//		}
		//		if (flag)
		//		{
		//			Api.Credit_setCoinInHook_done();
		//		}
		//	}
		//	finally
		//	{
		//		coinInHookCheckLock = 0;
		//	}
		//}
	}
}
