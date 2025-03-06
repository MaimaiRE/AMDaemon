using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace AMDaemon
{
	public static class EMoney
	{
		//public static readonly int BrandIdCount;

		//public static readonly int MaxDealResultCount;

		//public static readonly int MaxReportCount;

		//public static readonly int MaxTerminalIdLength;

		//public static readonly int MaxTerminalSerialLength;

		private static Action<EMoneySound> soundHook;

		//private static int soundHookCheckLock;

		//private static LazyCollection<EMoneyBrand> BrandsCache;

		public static bool IsAvailable => true; // Api.EMoney_isAvailable();

		public static Action<EMoneySound> SoundHook
		{
			get
			{
				return soundHook;
			}
			set
			{
				soundHook = value;
			}
		}

		public static bool IsServiceAlive => true; // Api.EMoney_isServiceAlive();

		public static bool IsAuthCompleted => true;

		public static string TerminalId => ""; // Marshal.PtrToStringUni(Api.EMoney_getTerminalId());

		public static string TerminalSerial => ""; // Marshal.PtrToStringUni(Api.EMoney_getTerminalSerial());

		public static int AvailableBrandCount => 0; // GetAvailableBrandCount(false);

		public static LazyCollection<EMoneyBrand> AvailableBrands { get; private set; }

		//public static LazyCollection<EMoneyBrand> AvailableBrandsForBalance { get; private set; }

		public static EMoneyOperation Operation { get; private set; }

		public static int DealResultCount => DealResults.Count;

		public static LazyCollection<EMoneyResult> DealResults { get; private set; }

		public static bool IsReporting => false; // Api.EMoney_isReporting();

		//public static int ReportCount => Reports.Count;

		//public static LazyCollection<EMoneyReport> Reports { get; private set; }

		//static EMoney()
		//{
		//	BrandIdCount = Api.EMoneyBrandIdCount_get();
		//	MaxDealResultCount = Api.MaxEMoneyDealResultCount_get();
		//	MaxReportCount = Api.MaxEMoneyReportCount_get();
		//	MaxTerminalIdLength = Api.MaxEMoneyTerminalIdLength_get();
		//	MaxTerminalSerialLength = Api.MaxEMoneyTerminalSerialLength_get();
		//	soundHook = null;
		//	soundHookCheckLock = 0;
		//	BrandsCache = null;
		//	AvailableBrands = new LazyCollection<EMoneyBrand>(() => Api.EMoney_getAvailableBrandCount(false), (int index) => new EMoneyBrand(Api.Call(index, false, Api.EMoney_getAvailableBrand)), true);
		//	AvailableBrandsForBalance = new LazyCollection<EMoneyBrand>(() => Api.EMoney_getAvailableBrandCount(true), (int index) => new EMoneyBrand(Api.Call(index, true, Api.EMoney_getAvailableBrand)), true);
		//	Operation = new EMoneyOperation(Api.EMoney_getOperation());
		//	DealResults = new LazyCollection<EMoneyResult>(Api.EMoney_getDealResultCount, (int index) => new EMoneyResult(Api.Call(index, Api.EMoney_getDealResult)), true);
		//	Reports = new LazyCollection<EMoneyReport>(Api.EMoney_getReportCount, (int index) => new EMoneyReport(Api.Call(index, Api.EMoney_getReport)), true);
		//	BrandsCache = new LazyCollection<EMoneyBrand>(() => BrandIdCount, (int index) => new EMoneyBrand(Api.Call((EMoneyBrandId)index, Api.EMoney_getBrand)), true);
		//}

		//private static void CheckSoundHook()
		//{
		//	if (Interlocked.Exchange(ref soundHookCheckLock, 1) != 0)
		//	{
		//		return;
		//	}
		//	try
		//	{
		//		if (Api.EMoney_setSoundHook_check(out var id, out var filePath))
		//		{
		//			SoundHook(new EMoneySound(id, filePath));
		//			Api.EMoney_setSoundHook_done();
		//		}
		//	}
		//	finally
		//	{
		//		soundHookCheckLock = 0;
		//	}
		//}

		public static bool IsBrandAvailable(EMoneyBrandId brandId)
		{
			// return IsBrandAvailable(brandId, false);
			return false;
		}

		//public static bool IsBrandAvailable(EMoneyBrandId brandId, bool forBalance)
		//{
		//	return Api.Call(brandId, forBalance, Api.EMoney_isBrandAvailable);
		//}

		//public static int GetAvailableBrandCount(bool forBalance)
		//{
		//	return Api.EMoney_getAvailableBrandCount(forBalance);
		//}

		//public static LazyCollection<EMoneyBrand> GetAvailableBrands(bool forBalance)
		//{
		//	if (!forBalance)
		//	{
		//		return AvailableBrands;
		//	}
		//	return AvailableBrandsForBalance;
		//}

		//public static EMoneyBrand GetBrand(EMoneyBrandId brandId)
		//{
		//	return BrandsCache[(int)brandId];
		//}
	}
}
